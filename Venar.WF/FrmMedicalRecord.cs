using Venar.DTO;
using Venar.Entities;
using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmMedicalRecord : Form
    {
        private Patient patient;
        private MedicDto medic;
        Consultation consultation;
        PatientsSVC patientsSvc = new PatientsSVC();
        MenuAdminSVC menuAdminSVC = new MenuAdminSVC();
        MedicalRecordSVC medicalRecordSvc = new MedicalRecordSVC();

        public FrmMedicalRecord(Patient patient, MedicDto medic, DiagnosticResult diagnostic)
        {
            InitializeComponent();
            this.patient = patient;
            this.medic = medic;
            FillInfoPatients();
            FillConsultationsGrid();
            ConfigureDataGridView();
        }
        private void FillConsultationsGrid()
        {
            try
            {
                var consultations = medicalRecordSvc.GetConsultationsForPatient(patient.PatientId);
                DgvConsultation.DataSource = consultations;
                DgvConsultation.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las consultas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInfoPatients()
        {
            try
            {
                Patient patientNew = patientsSvc.SearchPat(patient.Dni);
                txtPatientName.Text = $"{patientNew.Name} {patientNew.LastName}";
                txtDni.Text = patientNew.Dni.ToString();
                txtMedicalCoverage.Text = patientNew.MedicalCoverage.NameCover.ToString();
                //var MedicalNumber = patientNew.MedicalHistory.ReportNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la información del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView()
        {
            DgvConsultation.Columns.Clear();
            DgvConsultation.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.DataPropertyName = "Date";
            colDate.HeaderText = "Fecha de Consulta";
            DgvConsultation.Columns.Add(colDate);

            DataGridViewTextBoxColumn colReason = new DataGridViewTextBoxColumn();
            colReason.DataPropertyName = "Reason";
            colReason.HeaderText = "Motivo";
            DgvConsultation.Columns.Add(colReason);

            DataGridViewTextBoxColumn colDiagnosis = new DataGridViewTextBoxColumn();
            colDiagnosis.DataPropertyName = "Diagnosis";
            colDiagnosis.HeaderText = "Diagnóstico";
            DgvConsultation.Columns.Add(colDiagnosis);

            DataGridViewTextBoxColumn colAttended = new DataGridViewTextBoxColumn();
            colAttended.DataPropertyName = "MedicName";
            colAttended.HeaderText = "Atendido por Doctor";
            DgvConsultation.Columns.Add(colAttended);

            DataGridViewTextBoxColumn colSpecialty = new DataGridViewTextBoxColumn();
            colSpecialty.DataPropertyName = "MedicSpecialty";
            colSpecialty.HeaderText = "Especialidad";
            DgvConsultation.Columns.Add(colSpecialty);

            DataGridViewTextBoxColumn colMedicalRegistration = new DataGridViewTextBoxColumn();
            colMedicalRegistration.DataPropertyName = "MedicRegistration";
            colMedicalRegistration.HeaderText = "Matricula";
            DgvConsultation.Columns.Add(colMedicalRegistration);

            DataGridViewTextBoxColumn colReportNumber = new DataGridViewTextBoxColumn();
            colReportNumber.DataPropertyName = "ReportNumber";
            colReportNumber.HeaderText = "# Consulta";
            DgvConsultation.Columns.Add(colReportNumber);
        }
        private void btnViewMedicalRecord_Click()
        {

        }
        private void btnViewMedicalHistory_Click(object sender, EventArgs e)
        {
            int reportNumber = GetSelectRecordByNumber();

            if (reportNumber != null)
            {
                Patient patientReport = patientsSvc.SearchByReportNumber(reportNumber, patient.PatientId);
                FrmViewConsultation frmViewConsultation = new FrmViewConsultation(patientReport, medic);
                frmViewConsultation.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }
        }
        private int GetSelectRecordByNumber()
        {
            int reportNumber = 0;

            if (DgvConsultation.SelectedCells.Count > 0)
            {
                int columnIndex = -1;
                foreach (DataGridViewColumn column in DgvConsultation.Columns)
                {
                    if (column.HeaderText.Equals("# Consulta", StringComparison.OrdinalIgnoreCase))
                    {
                        columnIndex = column.Index;
                        break;
                    }
                }

                if (columnIndex != -1)
                {
                    DataGridViewCell selectedCell = DgvConsultation.SelectedCells[0];
                    DataGridViewRow selectedRow = selectedCell.OwningRow;
                    if (selectedRow.Cells[columnIndex].Value != null &&
                        int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out reportNumber))
                    {
                        return reportNumber;
                    }
                    else
                    {
                        throw new Exception("Invalid value in 'Consulta' cell or cannot convert to integer.");
                    }
                }
                else
                {
                    throw new Exception("Column 'Consulta' not found.");
                }
            }
            else
            {
                throw new Exception("No cells are selected in the DataGridView.");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
