using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eFirma.Models;
using MetroFramework.Forms;

namespace eFirmaApplication.Forms
{
    public partial class FrmEvidence : MetroForm
    {
        private evidence Evidence { get; set; }
        public FrmEvidence(evidence Evidence)
        {
            InitializeComponent();
            this.Evidence = Evidence;
            this.init();
        }

        private void init()
        {
            mlSecuencia.Text = Evidence.Sign.secuencia;
            mlValidador.Text = Evidence.Sign.validador;
            mlFechaFirma.Text = Evidence.Sign.fechaFirma;
            mlCadenaFirma.Text = Evidence.Sign.firma;
            mlCadenaOriginal.Text = Evidence.Sign.cadenaOriginal;            
        }
    }
}
