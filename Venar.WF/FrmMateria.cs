using Venar.DTO;
using Venar.SVC;

namespace StudentSystem.WindowsFormsCliente
{
    public partial class FrmMateria : Form
    {
        //MateriaService materiaService = new MateriaService();
        MedicSVC medicSvc = new MedicSVC();
        MedicDto medic = null;
        public FrmMateria(MedicDto medicEdit)
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
            //Validar los Datos

            //Si la validación pasos
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


            if (medic.MedicId == 0)
            {
                if (medicSvc.CreateMedic(medic))
                {
                    MessageBox.Show("Algo fallo, por favor revisar");
                }
                else
                {
                    MessageBox.Show("Se agrego la Materia");
                }
            }
            else
            {
                if (medicSvc.ed)
                {
                    MessageBox.Show("Se modifico la Materia");
                }
                else
                {
                    MessageBox.Show("Algo fallo, por favor revisar");
                }
            }
        }
    }
}
