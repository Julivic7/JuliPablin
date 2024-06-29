using System.Xml.Linq;
using Venar.DTO;
using Venar.Entities;
using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmCreatePatient : Form
    {
        ValidCreatePatient validCreatePatient = new ValidCreatePatient();
        PatientSVC createPatientSVC = new PatientSVC();
        PatientDto patientDto = new PatientDto();

        public FrmCreatePatient()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            patientDto = new PatientDto
            {
                name = txtNamePat.Text.Trim(),
                lastName = txtLastNamePat.Text.Trim(),
                dni = txtDniPat.Text.Trim(),
                MedicalCoverage = cmbCoverage.SelectedItem.ToString(),
                DateOfBirth = DateOfBirth.Value,
                gender = cmbGender.SelectedItem.ToString(),
                location = cmbLocation.SelectedItem.ToString()
            };

            if (validCreatePatient.ValidatePatient(patientDto))
            {
                MessageBox.Show("Paciente registrado");
                try
                {
                    createPatientSVC.CreatePatient(patientDto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Algo falló, por favor revisar. Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Error al registrar paciente");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCreatePatient_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}



