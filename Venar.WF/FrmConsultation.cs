using System.Diagnostics;
using Venar.Entities;
using Venar.SVC;
using Venar.DTO;

namespace Venar.WF
{
    public partial class FrmConsultation : Form
    {
        private MedicDto medic;
        private string userName;
        private Patient patient;
        private DiagnosticResult diagnostic;
        ConsultationSVC consultationSvc = new ConsultationSVC();
        Consultation medicalHistory;
        PatientsSVC patientsService;

        public FrmConsultation(Patient patient, MedicDto medic, DiagnosticResult diagnostic)
        {
            InitializeComponent();
            this.medic = medic;
            this.patient = patient;
            this.diagnostic = diagnostic;
            FillGridPatients();
        }
        private void FillGridPatients()
        {
            if (patient != null)
            {
                txtPatientName.Text = $"{patient.Name} {patient.LastName}";
                txtMedicalCoverage.Text = patient.MedicalCoverage != null ? patient.MedicalCoverage.NameCover : "No especificada";
                txtDateOfBirth.Text = patient.DateOfBirth.ToShortDateString();
                txtGender.Text = patient.Gender != null ? patient.Gender.NameGender : "No especificado";
                txtMedicalRegistration.Text = medic.MedicalRegistration;
                txtSymptoms.Text = diagnostic != null ? diagnostic.Results : string.Empty;
                txtEnfermedad.Text = diagnostic != null ? diagnostic.MatchPercentage : string.Empty;
            }
            try
            {
                if (medic.MedicId > 0)
                {
                    var medico = consultationSvc.GetInfoMedic(medic.MedicId);

                    if (medico != null)
                    {
                        txtMedicName.Text = medic.Name.Trim();
                        txtMedicLastName.Text = medic.LastName.Trim();
                    }
                    else
                    {
                        txtMedicName.Text = "No especificado";
                        txtMedicLastName.Text = "No especificado";
                    }
                }
                else
                {
                    txtMedicName.Text = "No especificado";
                    txtMedicLastName.Text = "No especificado";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                txtMedicName.Text = "Error al obtener nombre del médico";
                txtMedicLastName.Text = "Error al obtener apellido del médico";
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (patient.MedicalHistoryId == 0)
            {

                medicalHistory = new Consultation()
                {
                    IdMedic = medic.MedicId,
                    IdPatient = patient.PatientId,
                    Date = dateTimePicker1.Value,
                    Reason = txtReason.Text,
                    Diagnosis = txtDiagnosis.Text,
                    ResultSymtoms = txtSymptoms.Text
                };

                bool medicalHistorySuccess = consultationSvc.CreateConsultation(medicalHistory);

                if (medicalHistorySuccess)
                {
                    MessageBox.Show("Consulta creada y asociada al paciente correctamente.");
                    FillGridPatients();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear o asociar la consulta clínica al paciente.");
                }
            }
            else
            {
                Debug.WriteLine("Patient does not have existing medical history.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            FrmSymptoms frmSymptoms = new FrmSymptoms(patient, medic);
            frmSymptoms.SymptomsSelected += FrmSymptoms_SymptomsSelected;
            frmSymptoms.Show();
            this.Close();
        }
        private void FrmSymptoms_SymptomsSelected(object sender, List<string> selectedSymptoms)
        {
            txtSymptoms.Text = string.Join(", ", selectedSymptoms);
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