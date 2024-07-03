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
            txtPatientName.Text = $"{patient.Name} {patient.LastName}";
            txtMedicalCoverage.Text = patient.MedicalCoverage != null ? patient.MedicalCoverage.NameCover : "No especificada";
            txtDateOfBirth.Text = patient.DateOfBirth.ToShortDateString(); // Formato de fecha corta
            txtGender.Text = patient.Gender != null ? patient.Gender.NameGender : "No especificado";
        
            string medicName = medicalRecordSVC.GetInfoMedic(medicId);
            txtMedicName.Text = medicName.Trim();
            txtTicket.Text = null;
        }
        private void btnSend_Click(object sender, EventArgs e)
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
                // Actualizar el DataGridView u otra lógica de actualización necesaria
                FillGridPatients();
            }
            else
            {
                MessageBox.Show("No se pudo crear o asociar la historia clínica al paciente.");
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
            frmSymptoms.Show();
        }
    }
}
