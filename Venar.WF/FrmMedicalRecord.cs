using Venar.Entities;
using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmMedicalRecord : Form
    {
        Patient patient;
        Consultation consultation;
        PatientsSVC patientsSvc = new PatientsSVC();
        MedicalRecordSVC medicalRecordSvc = new MedicalRecordSVC();
        
        public FrmMedicalRecord(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            FillInfoPatients();
            FillConsultationsGrid();
        }

        private void FillInfoPatients()
        {
            Patient patientNew = patientsSvc.SearchPat(patient.Dni);
            txtPatientName.Text = patientNew.Name +" "+ patientNew.LastName;
            txtDni.Text = patientNew.Dni.ToString();
            txtMedicalCoverage.Text = patientNew.MedicalCoverage.NameCover.ToString();

        }
        private void FillConsultationsGrid()
        {
            DgvConsultation.AutoGenerateColumns = false;
            DgvConsultation.DataSource = medicalRecordSvc.GetConsultationsForPatient(patient.PatientId);
        }
    }
}
