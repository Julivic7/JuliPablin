using Venar.Data;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmResetPassword : Form
    {
        DataServices dataServices = new DataServices();
        ResetPasswordSVC resetPasswordSVC = new ResetPasswordSVC();
        ResetPassword resetPassword;
        FrmLogin frmLogin = new FrmLogin();

        private string temporalPass;
        private string setMail;
        private string LoggedUserMail;
        public FrmResetPassword(string mail, string temporalPass)
        {
            InitializeComponent();
            this.temporalPass = temporalPass;
            this.setMail = mail;

            LoggedUserMail = mail ?? "usuario";
            label7.Text = LoggedUserMail;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            resetPassword = new ResetPassword()
            {
                Temporal = temporalPass,
                Password = txtMailPass.Text,
                NewPassword = txtNewPass.Text,
                NewPasswordConfirm = txtNewPassConfirm.Text,
                SetMail = setMail
            };
            string success = resetPasswordSVC.ResetPass(resetPassword);
            MessageBox.Show(success);
            this.Close();
            frmLogin.Show();
        }

    }

}

