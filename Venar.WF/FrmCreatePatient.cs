using Venar.Entities;
using Venar.SVC;
using Venar.DTO;


namespace Venar.WF
{
    public partial class FrmCreatePatient : Form
    {
        ValidCreatePatient validPatient = new ValidCreatePatient();
        PatientsSVC patientsSVC;
        MedicDto medic;

        public FrmCreatePatient(MedicDto medic)
        {
            InitializeComponent();
            patientsSVC = new PatientsSVC();
            this.medic = medic;
            cmbLocation();
            cmbGender();
            cmbCoverMedical();
        }
        private void cmbLocation()
        {
            cmbLocations.DataSource = patientsSVC.GetLocation();
            cmbLocations.DisplayMember = "LocationName";
            cmbLocations.ValueMember = "IdLocation";
        }
        private void cmbGender()
        {
            cmbGenders.DataSource = patientsSVC.GetGender();
            cmbGenders.DisplayMember = "NameGender";
            cmbGenders.ValueMember = "IdGender";
        }
        private void cmbCoverMedical()
        {
            cmbCoverMed.DataSource = patientsSVC.GetCover();
            cmbCoverMed.DisplayMember = "NameCover";
            cmbCoverMed.ValueMember = "IdCover";
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
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                Name = txtNamePat.Text,
                LastName = txtLastNamePat.Text,
                Dni = Convert.ToInt32(txtDniPat.Text),
                DateOfBirth = dateTimePicker1.Value,
                Gender = new Gender { IdGender = (int)cmbGenders.SelectedValue },
                Location = (Location)cmbLocations.SelectedItem,
                MedicalCoverage = new MedicalCoverage { IdCover = (int)cmbCoverMed.SelectedValue }
            };

            ValidCreatePatient validCreatePatient = new ValidCreatePatient();

            if (validCreatePatient.ValidPatient(patient))
            {
                int patientId = patientsSVC.CreatePatient(patient, medic);
                MessageBox.Show("Paciente registrado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Paciente no registrado");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
