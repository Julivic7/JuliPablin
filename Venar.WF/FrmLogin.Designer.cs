namespace Venar.WF
{
    partial class FrmLogin
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
            groupInicio = new GroupBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            linkForgetPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            labelWelcome = new Label();
            groupInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupInicio
            // 
            groupInicio.AutoSize = true;
            groupInicio.BackColor = Color.MediumAquamarine;
            groupInicio.BackgroundImageLayout = ImageLayout.Center;
            groupInicio.Controls.Add(pictureBox1);
            groupInicio.Controls.Add(btnLogin);
            groupInicio.Controls.Add(linkForgetPassword);
            groupInicio.Controls.Add(txtPassword);
            groupInicio.Controls.Add(txtUser);
            groupInicio.Controls.Add(labelPassword);
            groupInicio.Controls.Add(labelUser);
            groupInicio.Controls.Add(labelWelcome);
            groupInicio.Dock = DockStyle.Fill;
            groupInicio.ImeMode = ImeMode.NoControl;
            groupInicio.Location = new Point(0, 0);
            groupInicio.Name = "groupInicio";
            groupInicio.Size = new Size(900, 465);
            groupInicio.TabIndex = 0;
            groupInicio.TabStop = false;
            groupInicio.Text = "Ingreso";
            groupInicio.Enter += groupInicio_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(362, 70);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 81);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.BackgroundImage = Properties.Resources.acceso;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(454, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(110, 40);
            btnLogin.TabIndex = 8;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.BackColor = Color.Transparent;
            linkForgetPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkForgetPassword.LinkColor = Color.Black;
            linkForgetPassword.Location = new Point(202, 358);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(159, 20);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Olvido su contraseña?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(331, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.LightCyan;
            txtUser.Location = new Point(331, 232);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(234, 23);
            txtUser.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.ButtonFace;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(202, 279);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(92, 21);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.LightCyan;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ActiveCaptionText;
            labelUser.Location = new Point(202, 229);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(67, 21);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario:";
            labelUser.Click += labelUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Location = new Point(370, 170);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(130, 30);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Bienvenidos";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(900, 465);
            Controls.Add(groupInicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            groupInicio.ResumeLayout(false);
            groupInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupInicio;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkForgetPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelWelcome;
        private PictureBox pictureBox1;
    }
}