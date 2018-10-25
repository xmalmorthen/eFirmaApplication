using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eFirmaApplication.Classes
{
    class frm
    {
        public DialogResult dlgRes = DialogResult.No;
        public DialogResult DlgRes { get { return dlgRes; } set { dlgRes = value; } }

        public enum FrmState
        {
            Normal,
            Ready,
            Proccesing,
            Generating,
            Proccesed
        }

    }
}
