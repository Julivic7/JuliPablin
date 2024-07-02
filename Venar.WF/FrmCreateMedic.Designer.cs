namespace Venar.WF
{
    partial class FrmCreateMedic
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
            txtMedicalRegistration = new TextBox();
            taMatricula = new Label();
            label6 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtMail = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtDni = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            boxSpecialty = new ComboBox();
            SuspendLayout();
            // 
            // txtMedicalRegistration
            // 
            txtMedicalRegistration.Location = new Point(415, 144);
            txtMedicalRegistration.Name = "txtMedicalRegistration";
            txtMedicalRegistration.Size = new Size(266, 23);
            txtMedicalRegistration.TabIndex = 23;
            // 
            // taMatricula
            // 
            taMatricula.AutoSize = true;
            taMatricula.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            taMatricula.ForeColor = SystemColors.ButtonHighlight;
            taMatricula.Location = new Point(415, 118);
            taMatricula.Name = "taMatricula";
            taMatricula.Size = new Size(146, 23);
            taMatricula.TabIndex = 21;
            taMatricula.Text = "Matricula Medica :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(415, 58);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 20;
            label6.Text = "Especialidad :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(415, 204);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 23);
            txtUserName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(415, 178);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 18;
            label1.Text = "Nombre de Usuario:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.MenuHighlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(547, 321);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 32);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(415, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 23);
            txtPassword.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(92, 262);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(266, 23);
            txtMail.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 23);
            txtName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(92, 144);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(266, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(92, 202);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(266, 23);
            txtDni.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(92, 58);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 7;
            label8.Text = "Nombre :";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(415, 238);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 6;
            label7.Text = "Contraseña :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(92, 236);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 3;
            label4.Text = "Correo Electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(92, 178);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 2;
            label3.Text = "DNI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(92, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "Apellido :";
            // 
            // boxSpecialty
            // 
            boxSpecialty.FormattingEnabled = true;
            boxSpecialty.Location = new Point(415, 84);
            boxSpecialty.Name = "boxSpecialty";
            boxSpecialty.Size = new Size(266, 23);
            boxSpecialty.TabIndex = 24;
            // 
            // FrmCreateMedic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 133, 255);
            ClientSize = new Size(772, 410);
            Controls.Add(boxSpecialty);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtUserName);
            Controls.Add(txtMedicalRegistration);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(taMatricula);
            Controls.Add(label8);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCreateMedic";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnRegister;
        private TextBox txtUserName;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private Label taMatricula;
        private TextBox txtMedicalRegistration;
        private ComboBox boxSpecialty;
    }
}