namespace Venar.WF
{
    partial class FrmCreateLocation
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
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            lblNambe = new Label();
            txtPostalCode = new TextBox();
            txtProvince = new TextBox();
            txtLocationName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(381, 293);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 31);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(288, 293);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(86, 31);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblNambe);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(txtProvince);
            groupBox1.Controls.Add(txtLocationName);
            groupBox1.Location = new Point(44, 29);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(441, 230);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 80);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 6;
            label5.Text = "Provincia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 118);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "CoodigoPostal";
            // 
            // lblNambe
            // 
            lblNambe.AutoSize = true;
            lblNambe.Location = new Point(24, 44);
            lblNambe.Name = "lblNambe";
            lblNambe.Size = new Size(136, 20);
            lblNambe.TabIndex = 3;
            lblNambe.Text = "Nombre Localidad:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(166, 118);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(257, 27);
            txtPostalCode.TabIndex = 2;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(166, 80);
            txtProvince.Margin = new Padding(3, 4, 3, 4);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(257, 27);
            txtProvince.TabIndex = 1;
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(166, 41);
            txtLocationName.Margin = new Padding(3, 4, 3, 4);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(257, 27);
            txtLocationName.TabIndex = 0;
            // 
            // FrmCreateLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 445);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(groupBox1);
            Name = "FrmCreateLocation";
            Text = "FrmCreateLocation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtDni;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPostalCode;
        private TextBox txtProvince;
        private TextBox txtLocationName;
        private Label lblNambe;
        private Label label5;
    }
}