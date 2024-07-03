namespace Venar.WF
{
    partial class FrmCreateSpecialty
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
            lblNambe = new Label();
            txtDescription = new TextBox();
            txtSpecialtyName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(398, 307);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 31);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(305, 307);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(86, 31);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblNambe);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtSpecialtyName);
            groupBox1.Location = new Point(42, 43);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(506, 230);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 81);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Descripcion:";
            // 
            // lblNambe
            // 
            lblNambe.AutoSize = true;
            lblNambe.Location = new Point(24, 45);
            lblNambe.Name = "lblNambe";
            lblNambe.Size = new Size(155, 20);
            lblNambe.TabIndex = 3;
            lblNambe.Text = "Nombre Especialidad:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 81);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(257, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtSpecialtyName
            // 
            txtSpecialtyName.Location = new Point(185, 42);
            txtSpecialtyName.Margin = new Padding(3, 4, 3, 4);
            txtSpecialtyName.Name = "txtSpecialtyName";
            txtSpecialtyName.Size = new Size(257, 27);
            txtSpecialtyName.TabIndex = 0;
            // 
            // FrmCreateSpecialty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 380);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(groupBox1);
            Name = "FrmCreateSpecialty";
            Text = "FrmCreateSpecialty";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label lblNambe;
        private TextBox txtPostalCode;
        private TextBox txtDescription;
        private TextBox txtSpecialtyName;
    }
}