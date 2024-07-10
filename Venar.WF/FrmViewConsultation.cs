using Venar.DTO;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmViewConsultation : Form
    {
        private MedicDto medic;
        private string userName;
        private Patient patient;
        ConsultationSVC consultationSvc = new ConsultationSVC();
        Consultation medicalHistory;
        PatientsSVC patientsService;
        public FrmViewConsultation(Patient patient, MedicDto medic)
        {
            InitializeComponent();            
            this.patient = patient;
            this.medic = medic;
            FillConsultationPatients();
        }
        private void FillConsultationPatients()
        {
            if (patient != null)
            {
                txtPatientName.Text = $"{patient.Name} {patient.LastName}";
                txtMedicalCoverage.Text = patient.MedicalCoverage != null ? patient.MedicalCoverage.NameCover : "No especificada";
                txtDateOfBirth.Text = patient.DateOfBirth.ToString("yyyy-mm-dd");
                txtGender.Text = patient.Gender != null ? patient.Gender.NameGender : "No especificado";
                txtReason.Text = patient.MedicalHistory.Reason;
                txtDiagnosis.Text = patient.MedicalHistory.Diagnosis;
                txtTicket.Text = patient.MedicalHistory.ReportNumber.ToString();
                txtMedicalRegistration.Text = medic.MedicalRegistration;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
