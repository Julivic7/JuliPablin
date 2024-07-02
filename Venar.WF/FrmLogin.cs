using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmLogin : Form
    {
        private LoginSVC loginSVC;
        GetUserId getUserId = new GetUserId();

        public FrmLogin()
        {
            InitializeComponent();
            loginSVC = new LoginSVC();
        }

        //Modificado por mi

        private void txtUser_Text(object sender, EventArgs e)
        {
        }
        private void txtPassword_Text(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;

            var userType = loginSVC.VerifyLogin(userName, password);

            if (userType != null)
            {
                // El login se realizo con exito
                var type = loginSVC.RedirectUser(userType);
                switch (type)
                {
                    case "admin":
                        var adminId = getUserId.GetAdminId(userType.UserId);
                        FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(userName, adminId);
                        frmMenuAdmin.Show();
                        this.Hide();
                        break;
                    case "medic":
                        var medicId = getUserId.GetMedicId(userType.UserId);
                        FrmMenuMedic frmMenuMedic = new FrmMenuMedic(userName, medicId);
                        frmMenuMedic.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario desconocido");
                        ResetLoginFields();
                        break;
                }

            }
            else
            {
                // Mostrar los errores de validación
                MessageBox.Show("Error de validación");
            }

        }

        private void ResetLoginFields()
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUser.Focus(); // Opcional: para poner el foco en el campo del usuario
        }


        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmForgetPassword frmForgetPassword = new FrmForgetPassword();
            frmForgetPassword.Show();
            this.Hide();

        }

        private void groupInicio_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
