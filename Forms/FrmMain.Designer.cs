namespace eFirmaApplication
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.oFDCer = new System.Windows.Forms.OpenFileDialog();
            this.oFDKey = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtKey = new MetroFramework.Controls.MetroTextBox();
            this.txtPwd = new MetroFramework.Controls.MetroTextBox();
            this.txtCer = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.mpInfo = new MetroFramework.Controls.MetroPanel();
            this.mlEstatusSAT = new MetroFramework.Controls.MetroLabel();
            this.mlVigencia = new MetroFramework.Controls.MetroLabel();
            this.mlCurpRFC = new MetroFramework.Controls.MetroLabel();
            this.mlTitular = new MetroFramework.Controls.MetroLabel();
            this.mpControls = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tlpProc = new System.Windows.Forms.FlowLayoutPanel();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.mlProccInfo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bkgndValidate = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKey = new MetroFramework.Controls.MetroButton();
            this.btnCer = new MetroFramework.Controls.MetroButton();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bkgndSign = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.mpInfo.SuspendLayout();
            this.mpControls.SuspendLayout();
            this.tlpProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Red;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // oFDCer
            // 
            this.oFDCer.Filter = "Certificado Público|*.cer";
            this.oFDCer.Title = "Certificado público";
            // 
            // oFDKey
            // 
            this.oFDKey.Filter = "Llave privada|*.key";
            this.oFDKey.Title = "Llave privada";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtKey.CustomButton.Image = null;
            this.txtKey.CustomButton.Location = new System.Drawing.Point(629, 2);
            this.txtKey.CustomButton.Name = "";
            this.txtKey.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKey.CustomButton.TabIndex = 1;
            this.txtKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKey.CustomButton.UseSelectable = true;
            this.txtKey.CustomButton.Visible = false;
            this.txtKey.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtKey, 5);
            this.txtKey.Lines = new string[0];
            this.txtKey.Location = new System.Drawing.Point(2, 79);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.ReadOnly = true;
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.ShortcutsEnabled = true;
            this.txtKey.Size = new System.Drawing.Size(657, 30);
            this.txtKey.Style = MetroFramework.MetroColorStyle.Black;
            this.txtKey.TabIndex = 2;
            this.txtKey.TabStop = false;
            this.txtKey.UseSelectable = true;
            this.txtKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPwd.CustomButton.Image = null;
            this.txtPwd.CustomButton.Location = new System.Drawing.Point(540, 2);
            this.txtPwd.CustomButton.Name = "";
            this.txtPwd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPwd.CustomButton.TabIndex = 1;
            this.txtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPwd.CustomButton.UseSelectable = true;
            this.txtPwd.CustomButton.Visible = false;
            this.txtPwd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtPwd, 5);
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(2, 132);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '?';
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.SelectedText = "";
            this.txtPwd.SelectionLength = 0;
            this.txtPwd.SelectionStart = 0;
            this.txtPwd.ShortcutsEnabled = true;
            this.txtPwd.Size = new System.Drawing.Size(568, 30);
            this.txtPwd.Style = MetroFramework.MetroColorStyle.Black;
            this.txtPwd.TabIndex = 4;
            this.txtPwd.UseSelectable = true;
            this.txtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCer
            // 
            this.txtCer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCer.CustomButton.Image = null;
            this.txtCer.CustomButton.Location = new System.Drawing.Point(628, 2);
            this.txtCer.CustomButton.Name = "";
            this.txtCer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCer.CustomButton.TabIndex = 1;
            this.txtCer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCer.CustomButton.UseSelectable = true;
            this.txtCer.CustomButton.Visible = false;
            this.txtCer.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.errorProvider.SetIconPadding(this.txtCer, 5);
            this.txtCer.Lines = new string[0];
            this.txtCer.Location = new System.Drawing.Point(2, 23);
            this.txtCer.MaxLength = 32767;
            this.txtCer.Name = "txtCer";
            this.txtCer.PasswordChar = '\0';
            this.txtCer.ReadOnly = true;
            this.txtCer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCer.SelectedText = "";
            this.txtCer.SelectionLength = 0;
            this.txtCer.SelectionStart = 0;
            this.txtCer.ShortcutsEnabled = true;
            this.txtCer.Size = new System.Drawing.Size(656, 30);
            this.txtCer.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCer.TabIndex = 0;
            this.txtCer.TabStop = false;
            this.txtCer.UseSelectable = true;
            this.txtCer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCer.TextChanged += new System.EventHandler(this.txtCer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "e.Firma";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(10, 30);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(722, 440);
            this.shapeContainer1.TabIndex = 44;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 3;
            this.lineShape1.X2 = 415;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // mpInfo
            // 
            this.mpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpInfo.Controls.Add(this.mlEstatusSAT);
            this.mpInfo.Controls.Add(this.mlVigencia);
            this.mpInfo.Controls.Add(this.mlCurpRFC);
            this.mpInfo.Controls.Add(this.mlTitular);
            this.mpInfo.HorizontalScrollbarBarColor = true;
            this.mpInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpInfo.HorizontalScrollbarSize = 10;
            this.mpInfo.Location = new System.Drawing.Point(13, 121);
            this.mpInfo.Name = "mpInfo";
            this.mpInfo.Size = new System.Drawing.Size(714, 95);
            this.mpInfo.TabIndex = 51;
            this.mpInfo.VerticalScrollbarBarColor = true;
            this.mpInfo.VerticalScrollbarHighlightOnWheel = false;
            this.mpInfo.VerticalScrollbarSize = 10;
            this.mpInfo.Visible = false;
            // 
            // mlEstatusSAT
            // 
            this.mlEstatusSAT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlEstatusSAT.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlEstatusSAT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlEstatusSAT.Location = new System.Drawing.Point(4, 69);
            this.mlEstatusSAT.Name = "mlEstatusSAT";
            this.mlEstatusSAT.Size = new System.Drawing.Size(707, 23);
            this.mlEstatusSAT.TabIndex = 64;
            this.mlEstatusSAT.Text = "Estatus ante el SAT []";
            this.mlEstatusSAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlVigencia
            // 
            this.mlVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlVigencia.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlVigencia.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlVigencia.Location = new System.Drawing.Point(4, 46);
            this.mlVigencia.Name = "mlVigencia";
            this.mlVigencia.Size = new System.Drawing.Size(707, 23);
            this.mlVigencia.TabIndex = 63;
            this.mlVigencia.Text = "Válido desde [] - Válido hasta []";
            this.mlVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlCurpRFC
            // 
            this.mlCurpRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlCurpRFC.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlCurpRFC.Location = new System.Drawing.Point(4, 23);
            this.mlCurpRFC.Name = "mlCurpRFC";
            this.mlCurpRFC.Size = new System.Drawing.Size(707, 23);
            this.mlCurpRFC.TabIndex = 62;
            this.mlCurpRFC.Text = "CURP - RFC";
            this.mlCurpRFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlTitular
            // 
            this.mlTitular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlTitular.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlTitular.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlTitular.Location = new System.Drawing.Point(4, 0);
            this.mlTitular.Name = "mlTitular";
            this.mlTitular.Size = new System.Drawing.Size(707, 23);
            this.mlTitular.TabIndex = 2;
            this.mlTitular.Text = "Titular";
            this.mlTitular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpControls
            // 
            this.mpControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpControls.Controls.Add(this.btnKey);
            this.mpControls.Controls.Add(this.btnCer);
            this.mpControls.Controls.Add(this.metroLabel4);
            this.mpControls.Controls.Add(this.txtKey);
            this.mpControls.Controls.Add(this.metroLabel1);
            this.mpControls.Controls.Add(this.txtPwd);
            this.mpControls.Controls.Add(this.metroLabel2);
            this.mpControls.Controls.Add(this.txtCer);
            this.mpControls.Controls.Add(this.btnAccept);
            this.mpControls.Controls.Add(this.tlpProc);
            this.mpControls.HorizontalScrollbarBarColor = true;
            this.mpControls.HorizontalScrollbarHighlightOnWheel = false;
            this.mpControls.HorizontalScrollbarSize = 10;
            this.mpControls.Location = new System.Drawing.Point(13, 226);
            this.mpControls.Name = "mpControls";
            this.mpControls.Size = new System.Drawing.Size(714, 239);
            this.mpControls.TabIndex = 0;
            this.mpControls.TabStop = true;
            this.mpControls.VerticalScrollbarBarColor = true;
            this.mpControls.VerticalScrollbarHighlightOnWheel = false;
            this.mpControls.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(-1, 59);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(150, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "Llave privada [ .key ]";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(0, 112);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "Contraseña";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(0, 3);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(184, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Certificado público [ .cer ]";
            // 
            // tlpProc
            // 
            this.tlpProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpProc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpProc.Controls.Add(this.metroProgressSpinner3);
            this.tlpProc.Controls.Add(this.mlProccInfo);
            this.tlpProc.Location = new System.Drawing.Point(2, 169);
            this.tlpProc.Name = "tlpProc";
            this.tlpProc.Size = new System.Drawing.Size(598, 70);
            this.tlpProc.TabIndex = 57;
            this.tlpProc.Visible = false;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(3, 3);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(65, 65);
            this.metroProgressSpinner3.Speed = 2F;
            this.metroProgressSpinner3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroProgressSpinner3.TabIndex = 27;
            this.metroProgressSpinner3.TabStop = false;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 50;
            // 
            // mlProccInfo
            // 
            this.tlpProc.SetFlowBreak(this.mlProccInfo, true);
            this.mlProccInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlProccInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlProccInfo.Location = new System.Drawing.Point(74, 7);
            this.mlProccInfo.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.mlProccInfo.Name = "mlProccInfo";
            this.mlProccInfo.Size = new System.Drawing.Size(339, 61);
            this.mlProccInfo.Style = MetroFramework.MetroColorStyle.Black;
            this.mlProccInfo.TabIndex = 28;
            this.mlProccInfo.Text = "Generando firma, favor de esperar...";
            this.mlProccInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlProccInfo.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(44, 94);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(260, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 61;
            this.metroLabel6.Text = "Información del titular del certificado";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 3;
            this.lineShape2.X2 = 598;
            this.lineShape2.Y1 = 84;
            this.lineShape2.Y2 = 84;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 64;
            this.lineShape3.X2 = 659;
            this.lineShape3.Y1 = 188;
            this.lineShape3.Y2 = 188;
            // 
            // bkgndValidate
            // 
            this.bkgndValidate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgndValidate_DoWork);
            this.bkgndValidate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgndValidate_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackgroundImage = global::eFirmaApplication.Properties.Resources._1474935786_multiply;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(705, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 6;
            this.metroToolTip.SetToolTip(this.btnCancel, "Cerrar");
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.AutoSize = true;
            this.metroButton1.BackgroundImage = global::eFirmaApplication.Properties.Resources._1474935786_multiply;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(462, 51);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(30, 30);
            this.metroButton1.TabIndex = 63;
            this.metroToolTip.SetToolTip(this.metroButton1, "Cerrar");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eFirmaApplication.Properties.Resources._1473814142_certificate_fw;
            this.pictureBox1.Location = new System.Drawing.Point(13, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btnKey
            // 
            this.btnKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKey.AutoSize = true;
            this.btnKey.BackgroundImage = global::eFirmaApplication.Properties.Resources.if_ic_folder_48px_352374;
            this.btnKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKey.Location = new System.Drawing.Point(683, 79);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(30, 30);
            this.btnKey.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.btnKey, "Seleccionar llave privada");
            this.btnKey.UseSelectable = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnCer
            // 
            this.btnCer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCer.AutoSize = true;
            this.btnCer.BackgroundImage = global::eFirmaApplication.Properties.Resources.if_ic_folder_48px_352374;
            this.btnCer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCer.Location = new System.Drawing.Point(683, 23);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(30, 30);
            this.btnCer.TabIndex = 1;
            this.metroToolTip.SetToolTip(this.btnCer, "Seleccionar certificado público");
            this.btnCer.UseSelectable = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackgroundImage = global::eFirmaApplication.Properties.Resources._1475261875_autograf;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Location = new System.Drawing.Point(601, 132);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 105);
            this.btnAccept.TabIndex = 5;
            this.metroToolTip.SetToolTip(this.btnAccept, "Firmar");
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eFirmaApplication.Properties.Resources._1475013989_approval;
            this.pictureBox2.Location = new System.Drawing.Point(13, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // bkgndSign
            // 
            this.bkgndSign.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgndSign_DoWork);
            this.bkgndSign.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgndSign_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomRight;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(742, 480);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mpControls);
            this.Controls.Add(this.mpInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.shapeContainer1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(742, 474);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.mpInfo.ResumeLayout(false);
            this.mpControls.ResumeLayout(false);
            this.mpControls.PerformLayout();
            this.tlpProc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.OpenFileDialog oFDCer;
        private System.Windows.Forms.OpenFileDialog oFDKey;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroPanel mpControls;
        private MetroFramework.Controls.MetroButton btnKey;
        private MetroFramework.Controls.MetroButton btnCer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtKey;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPwd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCer;
        private MetroFramework.Controls.MetroButton btnAccept;
        private System.Windows.Forms.FlowLayoutPanel tlpProc;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroLabel mlProccInfo;
        private MetroFramework.Controls.MetroPanel mpInfo;
        private MetroFramework.Controls.MetroLabel mlTitular;
        private MetroFramework.Controls.MetroLabel mlVigencia;
        private MetroFramework.Controls.MetroLabel mlCurpRFC;
        private MetroFramework.Controls.MetroLabel mlEstatusSAT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.ComponentModel.BackgroundWorker bkgndValidate;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.ComponentModel.BackgroundWorker bkgndSign;
    }
}

