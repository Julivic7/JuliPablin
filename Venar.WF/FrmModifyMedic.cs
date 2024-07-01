using Venar.DTO;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmModifyMedic : Form
    {
        
        MenuAdminSVC menuAdminSvc = new MenuAdminSVC();
        MedicDto medic = null;
        public FrmModifyMedic(MedicDto medicEdit)
        {
            InitializeComponent();
            if (medicEdit != null)
            {
                this.medic = medicEdit;
                LlenarDatosMedic();
            }
        }

        private void LlenarDatosMedic()
        {
            txtUsername.Text = medic.UserName;
            txtName.Text = medic.Name;
            txtLastName.Text = medic.LastName;
            txtDni.Text = medic.Dni.ToString();
            txtMail.Text = medic.Mail;
            txtSpecialty.Text = medic.Specialty;
            txtMedicalRegistration.Text = medic.MedicalRegistration;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if (medic == null)
            {
                medic = new MedicDto();
            }
             medic.UserName = txtUsername.Text;
             medic.Name = txtName.Text;
             medic.LastName = txtLastName.Text;
             medic.Dni = txtDni.Text;
             medic.Mail = txtMail.Text;
             medic.Specialty = txtSpecialty.Text;
             medic.MedicalRegistration = txtMedicalRegistration.Text;


            try
            {
                if (medic.MedicId == 0)
                {
                    menuAdminSvc.CreateMedic(medic);
                    MessageBox.Show("Se agregó el Medico");
                }
                else
                {
                    if (menuAdminSvc.UpdateMedic(medic))
                    {
                        MessageBox.Show("Se modificó el Medico: " + medic.LastName);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo falló, por favor revisar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El nombre de Usuario ya se encunetra en Uso");
            }
        }
    }
}
