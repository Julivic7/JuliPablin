using Venar.Entities;
using Venar.SVC;
using Venar.DTO;

namespace Venar.WF
{
    public partial class FrmModifyPatient : Form
    {
        PatientsSVC patientsSvc = new PatientsSVC();
        Patient patient = null;
        Gender gender = new Gender();
        Location location;
        MedicalCoverage medicalCoverage;
        MedicDto medic;
        ValidCreatePatient validPatient = new ValidCreatePatient();

        public FrmModifyPatient(Patient patientEdit, MedicDto medic)
        {
            InitializeComponent();
            if (patientEdit != null)
            {
                this.patient = patientEdit;
                this.medic = medic;
                LlenarDatosPatient();
                cmbLocation();
                cmbGender();
                cmbCoverMedical();
            }
        }
        private void LlenarDatosPatient()
        {
            txtName.Text = patient.Name;
            txtLastName.Text = patient.LastName;
            txtDni.Text = patient.Dni.ToString();
            dateTimePicker.Value = patient.DateOfBirth;
            cmbGenders.SelectedValue = patient.Gender.NameGender;
            cmbLocations.SelectedValue = patient.Location.LocationName;
            cmbCoverMed.SelectedValue = patient.MedicalCoverage.NameCover;
        }
        private void cmbLocation()
        {
            cmbLocations.DataSource = patientsSvc.GetLocation();
            cmbLocations.DisplayMember = "LocationName";
            cmbLocations.ValueMember = "IdLocation";
        }
        private void cmbGender()
        {
            cmbGenders.DataSource = patientsSvc.GetGender();
            cmbGenders.DisplayMember = "NameGender";
            cmbGenders.ValueMember = "IdGender";
        }
        private void cmbCoverMedical()
        {
            cmbCoverMed.DataSource = patientsSvc.GetCover();
            cmbCoverMed.DisplayMember = "NameCover";
            cmbCoverMed.ValueMember = "IdCover";
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {             
            if (patient == null)
            {
                patient = new Patient();
            }

            patient.Name = txtName.Text;
            patient.LastName = txtLastName.Text;
            patient.Dni = Convert.ToInt32(txtDni.Text);
            patient.DateOfBirth = dateTimePicker.Value;
            patient.Gender = new Gender { IdGender = (int)cmbGenders.SelectedValue };
            patient.Location = new Location { IdLocation = (int)cmbLocations.SelectedValue };
            patient.MedicalCoverage = new MedicalCoverage { IdCover = (int)cmbCoverMed.SelectedValue };

            var validatePatient = validPatient.ValidPatient(patient);

            if (validatePatient)
            {
                try
                {
                    if (patient.PatientId == 0)
                    {
                        patientsSvc.CreatePatient(patient, medic);
                        MessageBox.Show("Se agregó el Paciente");
                    }
                    else
                    {
                        if (patientsSvc.UpdatePatient(patient))
                        {
                            MessageBox.Show("Se modificó el Paciente: " + patient.LastName);
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
                    MessageBox.Show($"Algo falló, por favor revisar. Error: {ex.Message}");
                }
            }
            
        }
    }
}
