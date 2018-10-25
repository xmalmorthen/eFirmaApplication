namespace eFirmaApplication.Forms
{
    partial class FrmEvidence
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
            this.mlSecuencia = new MetroFramework.Controls.MetroLabel();
            this.mlTitular = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mlValidador = new MetroFramework.Controls.MetroLabel();
            this.mlFechaFirma = new MetroFramework.Controls.MetroLabel();
            this.mlCadenaFirma = new System.Windows.Forms.TextBox();
            this.mlCadenaOriginal = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // mlSecuencia
            // 
            this.mlSecuencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlSecuencia.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlSecuencia.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlSecuencia.Location = new System.Drawing.Point(23, 85);
            this.mlSecuencia.Name = "mlSecuencia";
            this.mlSecuencia.Size = new System.Drawing.Size(232, 26);
            this.mlSecuencia.TabIndex = 67;
            this.mlSecuencia.Text = "-";
            this.mlSecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlSecuencia.WrapToLine = true;
            // 
            // mlTitular
            // 
            this.mlTitular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlTitular.AutoSize = true;
            this.mlTitular.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlTitular.Location = new System.Drawing.Point(23, 60);
            this.mlTitular.Name = "mlTitular";
            this.mlTitular.Size = new System.Drawing.Size(152, 19);
            this.mlTitular.TabIndex = 65;
            this.mlTitular.Text = "Secuencia de Validación";
            this.mlTitular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(280, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Dato validador";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Fecha de firmado";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Cadena de firma";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 274);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Cadena original";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlValidador
            // 
            this.mlValidador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlValidador.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlValidador.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlValidador.Location = new System.Drawing.Point(280, 85);
            this.mlValidador.Name = "mlValidador";
            this.mlValidador.Size = new System.Drawing.Size(232, 26);
            this.mlValidador.TabIndex = 74;
            this.mlValidador.Text = "-";
            this.mlValidador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlValidador.WrapToLine = true;
            // 
            // mlFechaFirma
            // 
            this.mlFechaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlFechaFirma.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlFechaFirma.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlFechaFirma.Location = new System.Drawing.Point(23, 140);
            this.mlFechaFirma.Name = "mlFechaFirma";
            this.mlFechaFirma.Size = new System.Drawing.Size(495, 26);
            this.mlFechaFirma.TabIndex = 75;
            this.mlFechaFirma.Text = "-";
            this.mlFechaFirma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlFechaFirma.WrapToLine = true;
            // 
            // mlCadenaFirma
            // 
            this.mlCadenaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlCadenaFirma.BackColor = System.Drawing.SystemColors.Window;
            this.mlCadenaFirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlCadenaFirma.Location = new System.Drawing.Point(25, 195);
            this.mlCadenaFirma.Multiline = true;
            this.mlCadenaFirma.Name = "mlCadenaFirma";
            this.mlCadenaFirma.ReadOnly = true;
            this.mlCadenaFirma.Size = new System.Drawing.Size(493, 74);
            this.mlCadenaFirma.TabIndex = 78;
            // 
            // mlCadenaOriginal
            // 
            this.mlCadenaOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlCadenaOriginal.BackColor = System.Drawing.SystemColors.Window;
            this.mlCadenaOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlCadenaOriginal.Location = new System.Drawing.Point(23, 299);
            this.mlCadenaOriginal.Multiline = true;
            this.mlCadenaOriginal.Name = "mlCadenaOriginal";
            this.mlCadenaOriginal.ReadOnly = true;
            this.mlCadenaOriginal.Size = new System.Drawing.Size(493, 103);
            this.mlCadenaOriginal.TabIndex = 79;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 202;
            this.lineShape1.Y1 = 19;
            this.lineShape1.Y2 = 19;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(501, 329);
            this.shapeContainer1.TabIndex = 80;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 263;
            this.lineShape2.X2 = 459;
            this.lineShape2.Y1 = 19;
            this.lineShape2.Y2 = 19;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 6;
            this.lineShape3.X2 = 329;
            this.lineShape3.Y1 = 75;
            this.lineShape3.Y2 = 75;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Gray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 7;
            this.lineShape4.X2 = 331;
            this.lineShape4.Y1 = 130;
            this.lineShape4.Y2 = 130;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Gray;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 8;
            this.lineShape5.X2 = 332;
            this.lineShape5.Y1 = 234;
            this.lineShape5.Y2 = 234;
            // 
            // FrmEvidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 409);
            this.Controls.Add(this.mlCadenaOriginal);
            this.Controls.Add(this.mlCadenaFirma);
            this.Controls.Add(this.mlFechaFirma);
            this.Controls.Add(this.mlValidador);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlSecuencia);
            this.Controls.Add(this.mlTitular);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvidence";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Evidencia de Firma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlSecuencia;
        private MetroFramework.Controls.MetroLabel mlTitular;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel mlValidador;
        private MetroFramework.Controls.MetroLabel mlFechaFirma;
        private System.Windows.Forms.TextBox mlCadenaFirma;
        private System.Windows.Forms.TextBox mlCadenaOriginal;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}