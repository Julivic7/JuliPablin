using Venar.SVC;
using Venar.Entities;
using Venar.DTO;

namespace Venar.WF
{
    public partial class FrmLogin : Form
    {
        LoginSVC loginSVC;
        GetUserId getUserId = new GetUserId();

        public FrmLogin()
        {
            InitializeComponent();
            loginSVC = new LoginSVC();
            this.FormClosing += FrmLogin_FormClosing;
        }
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
                        Admin admin = getUserId.GetAdminId(userType.UserId);
                        FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin(admin);
                        frmMenuAdmin.Show();
                        this.Hide();
                        break;
                    case "medic":
                        MedicDto medic = getUserId.GetMedicId(userType.UserId);
                        FrmMenuMedic frmMenuMedic = new FrmMenuMedic(medic);
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
        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
