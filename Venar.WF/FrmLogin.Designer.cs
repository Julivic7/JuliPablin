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
            labelWelcome = new Label();
            labelUser = new Label();
            labelPassword = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            linkForgetPassword = new LinkLabel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Location = new Point(393, 116);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(130, 30);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Bienvenidos";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ButtonHighlight;
            labelUser.Location = new Point(307, 205);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(73, 21);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario:";
            labelUser.Click += labelUser_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(280, 255);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 21);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña:";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Window;
            txtUser.Location = new Point(386, 205);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(234, 23);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(386, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 5;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.BackColor = Color.Transparent;
            linkForgetPassword.DisabledLinkColor = Color.SlateGray;
            linkForgetPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkForgetPassword.ForeColor = SystemColors.ButtonHighlight;
            linkForgetPassword.LinkColor = SystemColors.ButtonHighlight;
            linkForgetPassword.Location = new Point(280, 347);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(159, 20);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Olvido su contraseña?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.BackgroundImage = Properties.Resources.acceso;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(522, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(110, 40);
            btnLogin.TabIndex = 8;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.acceso;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(375, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 81);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 166, 233);
            ClientSize = new Size(900, 465);
            Controls.Add(btnLogin);
            Controls.Add(linkForgetPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(labelWelcome);
            Controls.Add(txtUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelUser;
        private Label labelPassword;
        private TextBox txtUser;
        private TextBox txtPassword;
        private LinkLabel linkForgetPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}