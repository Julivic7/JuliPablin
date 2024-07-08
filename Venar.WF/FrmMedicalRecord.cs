using System.Diagnostics;
using Venar.DTO;
using Venar.Entities;
using Venar.SVC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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

        public FrmMedicalRecord(Patient patient, MedicDto medic)
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
                // Assuming medicalRecordSvc returns a list of Consultation objects
                var consultations = medicalRecordSvc.GetConsultationsForPatient(patient.PatientId);

                // Bind the data to DataGridView
                DgvConsultation.DataSource = consultations;

                // Optionally, you can refresh the DataGridView to reflect changes
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
            // Clear existing columns to avoid duplication
            DgvConsultation.Columns.Clear();

            // Disable automatic column generation
            DgvConsultation.AutoGenerateColumns = false;

            // Configure Date column
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.DataPropertyName = "Date"; // Property name in the Consultation class
            colDate.HeaderText = "Fecha";

            DgvConsultation.Columns.Add(colDate);

            // Configure Reason column
            DataGridViewTextBoxColumn colReason = new DataGridViewTextBoxColumn();
            colReason.DataPropertyName = "Reason"; // Property name in the Consultation class
            colReason.HeaderText = "Motivo";

            DgvConsultation.Columns.Add(colReason);

            // Configure Diagnosis column
            DataGridViewTextBoxColumn colDiagnosis = new DataGridViewTextBoxColumn();
            colDiagnosis.DataPropertyName = "Diagnosis"; // Property name in the Consultation class
            colDiagnosis.HeaderText = "Diagnóstico";

            DgvConsultation.Columns.Add(colDiagnosis);

            // Configure Attended by Doctor column (assuming MedicId refers to a doctor's ID)
            DataGridViewTextBoxColumn colAttended = new DataGridViewTextBoxColumn();
            colAttended.DataPropertyName = "MedicName"; // Property name in the Consultation class
            colAttended.HeaderText = "Atendido por Doctor";

            DgvConsultation.Columns.Add(colAttended);

            DataGridViewTextBoxColumn colReportNumber = new DataGridViewTextBoxColumn();
            colReportNumber.DataPropertyName = "ReportNumber"; // Property name in the Consultation class
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
                FrmConsultation frmConsultation = new(patientReport, medic);
                frmConsultation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }
        }


        private int GetSelectRecordByNumber()
        {
            // Initialize reportNumber
            int reportNumber = 0;

            // Check if any cell is selected in the DataGridView
            if (DgvConsultation.SelectedCells.Count > 0)
            {
                // Get the index of the column named "Consulta" (HeaderText)
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
                    // Get the selected cell
                    DataGridViewCell selectedCell = DgvConsultation.SelectedCells[0];

                    // Get the DataGridViewRow that contains the selected cell
                    DataGridViewRow selectedRow = selectedCell.OwningRow;

                    // Retrieve the value of "Consulta" cell in the selected row and convert to int
                    if (selectedRow.Cells[columnIndex].Value != null &&
                        int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out reportNumber))
                    {
                        // reportNumber now holds the integer value of "Consulta" cell
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





    }
}
