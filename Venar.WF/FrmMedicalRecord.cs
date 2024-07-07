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
            //ConfigureDataGridView();
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
            DgvConsultation.DataSource = medicalRecordSvc.GetConsultationsForPatient(patient.PatientId);
        }


        private void ConfigureDataGridView()
        {
            // Deshabilitar la generación automática de columnas
            DgvConsultation.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.DataPropertyName = "Date"; // Nombre de la propiedad en Consultation
            colDate.HeaderText = "Fecha";
            DgvConsultation.Columns.Add(colDate);

            DataGridViewTextBoxColumn colReason = new DataGridViewTextBoxColumn();
            colReason.DataPropertyName = "Reason"; // Nombre de la propiedad en Consultation
            colReason.HeaderText = "Motivo";
            DgvConsultation.Columns.Add(colReason);

            DataGridViewTextBoxColumn colDiagnosis = new DataGridViewTextBoxColumn();
            colDiagnosis.DataPropertyName = "Diagnosis"; // Nombre de la propiedad en Consultation
            colDiagnosis.HeaderText = "Diagnóstico";
            DgvConsultation.Columns.Add(colDiagnosis);

            DataGridViewTextBoxColumn colAttended = new DataGridViewTextBoxColumn();
            colDiagnosis.DataPropertyName = "MedicId"; // Nombre de la propiedad en Consultation
            colDiagnosis.HeaderText = "Atendido por Doctor";
            DgvConsultation.Columns.Add(colAttended);

            // Opcional: Ajusta el modo de redimensionamiento de columnas según sea necesario
            DgvConsultation.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    }
}
