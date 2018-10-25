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
using eFirmaApplication.Actions;
using eFirmaApplication.Classes;
using eFirmaApplication.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace eFirmaApplication
{
    public partial class FrmMain : MetroForm
    {
    #region Privte Members
        private void init()
        {
            visualStyles.apply(this, msmMain);

            frmState = frm.FrmState.Normal;
        }

        private frm Frm = new frm();
        private frm.FrmState _frmState;
        private frm.FrmState frmState
        {
            get { return _frmState; }
            set
            {
                _frmState = value;

                this.tlpProc.Visible = value != frm.FrmState.Normal;
                this.btnAccept.Enabled = value == frm.FrmState.Normal;
                //this.Enabled = value == frm.FrmState.Normal;
            }
        }

        private Boolean FrmError = false;

        private Boolean validaForm()
        {
            Boolean returnResponse = true;
            
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtCer.Text.Trim()))
            {
                setErrorIcon(txtCer, "Falta seleccionar el certificado público");
                returnResponse = false;
            }

            if (string.IsNullOrEmpty(txtKey.Text.Trim()))
            {
                setErrorIcon(txtKey, "Falta seleccionar la llave privada");
                returnResponse = false;
            }

            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                setErrorIcon(txtPwd, "Falta indicar la contraseña de la llave privada");
                returnResponse = false;
            }

            if (!returnResponse || this.FrmError)
                MetroMessageBox.Show(this, "No es posible firmar." + Environment.NewLine + "Faltan datos requeridos o los datos no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return returnResponse;
        }
    #endregion

        private void setErrorIcon(Control control, string msg)
        {
            errorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            errorProvider.SetIconPadding(control, 5);
            errorProvider.SetError(control, msg);
        }

        public FrmMain()
        {
            InitializeComponent();
            frmState = frm.FrmState.Normal;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validaForm()) {
                    this.mlProccInfo.Text = "Generando firma";   
                    frmState = frm.FrmState.Proccesing;
                    originalStringToSignModel modelToSign = new originalStringToSignModel()
                    {
                        Validator = "Test",
                        ToSign = new toSign()
                        {
                            Data = "|Miguel Angel Rueda Aguilar|3.2|test|cadena|original|Prueba|",
                            MIMEType = "text/plain",
                            Charset = "ISO-8859-1",
                            Base64Encode = false
                        }
                    };
                    bkgndSign.RunWorkerAsync(modelToSign);
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }        

        private void btnCer_Click(object sender, EventArgs e)
        {
            if (oFDCer.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                txtCer.Text = pathFolders.shortPathFolder(oFDCer.FileName);
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            if (oFDKey.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                txtKey.Text = pathFolders.shortPathFolder(oFDKey.FileName);
        }

        private void txtCer_TextChanged(object sender, EventArgs e)
        {
            this.mlProccInfo.Text = "Validando certificado";            
            this.btnCer.Enabled = false;
            frmState = frm.FrmState.Proccesing;
            this.Refresh(); //Refrescado de pantalla para que se sigan visualizando las lineas, BUG
            this.bkgndValidate.RunWorkerAsync();            
        }

        private void bkgndValidate_DoWork(object sender, DoWorkEventArgs e)
        {
            pubCert pubCertInfo = signAction.ValidateCert(this.txtCer.Text);
            e.Result = pubCertInfo;                        
        }

        private void bkgndValidate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {                
                if (e.Error != null) 
                    throw e.Error;

                pubCert pubCertInfo = (pubCert)e.Result;

                mlTitular.Text = pubCertInfo.getCNTitular;
                mlCurpRFC.Text = string.Format("{0} - {1}", pubCertInfo.getSerialNumberTitular, pubCertInfo.getCNRFC);
                mlVigencia.Text = string.Format("Válido desde [ {0} ] - Válido hasta [ {1} ]", pubCertInfo.certificateData.ValidoDesde, pubCertInfo.certificateData.ValidoHasta);
                mlEstatusSAT.Text = string.Format("Estatus ante el SAT [ {0} ]", pubCertInfo.OCSPStatus.ToString().ToUpper());
                mpInfo.Visible = true;
                this.FrmError = false;
            }
            catch (Exception ex)
            {
                mpInfo.Visible = false;
                string msg = "Ocurrió un error al intentar validar el certificado" + Environment.NewLine;
                msg += ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MetroMessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setErrorIcon(txtCer, msg);
                this.FrmError = true;
            }
            this.btnCer.Enabled = true;
            frmState = frm.FrmState.Normal;
            this.Refresh(); //Refrescado de pantalla para que se sigan visualizando las lineas, BUG
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.txtCer.Text = @"E:\CertsStore\productivo\FIEL_RUAM8111232S9_20180829104552\ruam8111232s9.cer";
            this.txtKey.Text = @"E:\CertsStore\productivo\FIEL_RUAM8111232S9_20180829104552\Claveprivada_FIEL_RUAM8111232S9_20180829_104552.key";
        }

        private void bkgndSign_DoWork(object sender, DoWorkEventArgs e)
        {
            originalStringToSignModel modelToSign = (originalStringToSignModel)e.Argument;
            evidence Evidence = signAction.Sign(txtCer.Text, txtKey.Text, txtPwd.Text, modelToSign);
            e.Result = Evidence;
        }

        private void bkgndSign_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                    throw e.Error;

                evidence Evidence = (evidence)e.Result;

                frmState = frm.FrmState.Normal;

                FrmEvidence frmEvidence = new FrmEvidence(Evidence);
                frmEvidence.ShowDialog(this);
            }
            catch (Exception ex)
            {
                string msg = "Ocurrió un error al generar la firma" + Environment.NewLine;
                msg += ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MetroMessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmState = frm.FrmState.Normal;
            this.Refresh(); //Refrescado de pantalla para que se sigan visualizando las lineas, BUG
        }
        
    }
}
