using System.Diagnostics;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmMedicalRecord : Form
    {
        private int medicId;
        private string userName;
        private Patient patient;
        MedicalRecordSVC medicalRecordSVC = new MedicalRecordSVC();
        MedicalHistory medicalHistory;
        PatientsSVC patientsService;

        public FrmMedicalRecord(Patient patient, int medicId, string userName)
        {
            InitializeComponent();
            this.medicId = medicId;
            this.patient = patient;
            this.userName = userName;
            FillGridPatients();
        }
        private void FillGridPatients()
        {
            // Ensure patient is not null before accessing its properties
            if (patient != null)
            {
                txtPatientName.Text = $"{patient.Name} {patient.LastName}";
                txtMedicalCoverage.Text = patient.MedicalCoverage != null ? patient.MedicalCoverage.NameCover : "No especificada";
                txtDateOfBirth.Text = patient.DateOfBirth.ToShortDateString(); // Formato de fecha corta
                txtGender.Text = patient.Gender != null ? patient.Gender.NameGender : "No especificado";
                txtReason.Text = patient.MedicalHistory.Reason.Trim();
                txtDiagnosis.Text = patient.MedicalHistory.Diagnosis.Trim();
            }

            try
            {
                // Ensure medicId is valid before using it
                if (medicId > 0)
                {
                    Medic medic = medicalRecordSVC.GetInfoMedic(medicId);

                    if (medic != null)
                    {
                        txtMedicName.Text = medic.Name.Trim();
                        txtMedicLastName.Text = medic.LastName.Trim();
                    }
                    else
                    {
                        // Handle the case where no medic is found (should not happen with the current GetInfoMedic implementation)
                        txtMedicName.Text = "No especificado";
                        txtMedicLastName.Text = "No especificado";
                    }
                }
                else
                {
                    // Handle invalid medicId
                    txtMedicName.Text = "No especificado";
                    txtMedicLastName.Text = "No especificado";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error: {ex.Message}");
                txtMedicName.Text = "Error al obtener nombre del médico";
                txtMedicLastName.Text = "Error al obtener apellido del médico";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (patient.MedicalHistoryId == 0)
            {

                medicalHistory = new MedicalHistory()
                {
                    IdMedic = medicId,
                    IdPatient = patient.PatientId,
                    Date = dateTimePicker1.Value,
                    Reason = txtReason.Text,
                    Diagnosis = txtDiagnosis.Text,
                    ResultSymtoms = txtSymtoms.Text
                };

                int medicalHistoryId = medicalRecordSVC.CreateMedicalHistory(medicalHistory);

                if (medicalHistoryId > 0)
                {
                    MessageBox.Show("Historia clínica creada y asociada al paciente correctamente.");
                    FillGridPatients();
                }
                else
                {
                    MessageBox.Show("No se pudo crear o asociar la historia clínica al paciente.");
                }
            }
            else
            {
                //TERMINAR LOGICA DE EDICION DE HISTORIAL MEDICO
                Debug.WriteLine("Patient does not have existing medical history.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMenuMedic frmMenuMedic = new FrmMenuMedic(userName, medicId);
            frmMenuMedic.Show();
            this.Close();
        }
        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            FrmSymptoms frmSymptoms = new FrmSymptoms();
            frmSymptoms.SymptomsSelected += FrmSymptoms_SymptomsSelected;
            frmSymptoms.Show();
        }
        private void FrmSymptoms_SymptomsSelected(object sender, List<string> selectedSymptoms)
        {
            // Actualizar el cuadro de texto txtSymptoms con los síntomas seleccionados
            txtSymtoms.Text = string.Join(", ", selectedSymptoms);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boxPatientInfo_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
