using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace eFirmaApplication.Classes
{
    public static class visualStyles
    {
        private static void iterControls(Control control, MetroStyleManager msmMain)
        {
            foreach (Control item in control.Controls)
            {
                iterControls(item, msmMain);
                if (item is IMetroControl)
                    ((IMetroControl)item).StyleManager = msmMain;
            }
        }

        public static void apply(Control frm, MetroStyleManager msmMain)
        {
            msmMain = Properties.Settings.Default.mainStyle;
            //msmMain.Owner = (ContainerControl)frm;            
            try
            {
                ((MetroForm)frm).StyleManager = msmMain;
            }
            catch (Exception)
            {
                try
                {
                    ((MetroUserControl)frm).StyleManager = msmMain;
                }
                catch (Exception)
                { }
            }
            visualStyles.iterControls(frm, msmMain);
        }

    }
}
