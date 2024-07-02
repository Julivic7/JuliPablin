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
            btnLogin = new Button();
            linkForgetPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            labelPassword = new Label();
            labelUser = new Label();
            labelWelcome = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "Login";
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(522, 358);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(110, 33);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.Anchor = AnchorStyles.None;
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.BackColor = Color.Transparent;
            linkForgetPassword.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkForgetPassword.ForeColor = SystemColors.ButtonHighlight;
            linkForgetPassword.LinkColor = SystemColors.ButtonHighlight;
            linkForgetPassword.Location = new Point(269, 365);
            linkForgetPassword.Margin = new Padding(0);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(202, 26);
            linkForgetPassword.TabIndex = 7;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Olvido su contraseña?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(230, 242, 255);
            txtPassword.Location = new Point(398, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.BackColor = Color.FromArgb(230, 242, 255);
            txtUser.Location = new Point(398, 240);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(234, 23);
            txtUser.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(269, 287);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(116, 26);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña:";
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.None;
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ButtonHighlight;
            labelUser.Location = new Point(269, 237);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(81, 26);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario:";
            labelUser.Click += labelUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.Anchor = AnchorStyles.None;
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Location = new Point(385, 159);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(130, 30);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Bienvenidos";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed_removebg_preview;
            pictureBox1.Location = new Point(324, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 133, 255);
            ClientSize = new Size(900, 465);
            Controls.Add(pictureBox1);
            Controls.Add(txtUser);
            Controls.Add(btnLogin);
            Controls.Add(labelWelcome);
            Controls.Add(linkForgetPassword);
            Controls.Add(labelUser);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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