using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmMenuMedic : Form
    {
        PatientsSVC patientsService;
        FrmModifyPatient frmModifyPatient;
        FrmCreatePatient frmCreatePatient;
        ValidCreatePatient validCreatedPatient;
        MedicalRecordSVC medicalRecordSVC = new MedicalRecordSVC();
        private int medicId;
        private string userName;

        public FrmMenuMedic(string userName, int medicId)
        {
            InitializeComponent();
            patientsService = new PatientsSVC();
            this.medicId = medicId;
            this.userName = userName;
            FillGridPatients();
        }
        private void FillGridPatients()
        {
            DgvPatients.DataSource = null;
            DgvPatients.AutoGenerateColumns = true;
            DgvPatients.Columns.Clear();

            var patients = patientsService.GetPatients(medicId);

            if (patients != null)
            {
                DgvPatients.DataSource = patients;
                DgvPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }
        private void DgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnCreatePatient_Click_1(object sender, EventArgs e)
        {
            FrmCreatePatient frmCreatePatient = new FrmCreatePatient(medicId);
            frmCreatePatient.Show();
        }
        private void btnModifyPatient_Click_1(object sender, EventArgs e)
        {
            int dni = GetSelectedPatientDni();
            if (dni > 0)
            {
                var patientFound = patientsService.SearchPat(dni);
                FrmModifyPatient frmModifyPatient = new FrmModifyPatient(patientFound, medicId);
                frmModifyPatient.Show();
                FillGridPatients();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }
        }
        private void btnDeleatPatient_Click(object sender, EventArgs e)
        {
            int dni = GetSelectedPatientDni();
            if (dni > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool deletSuccesful = patientsService.DeletePatient(dni, medicId);
                    if (deletSuccesful)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGridPatients();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar al paciente.", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFinishSession_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            FillGridPatients();
        }
        private void btnClinicalHistory_Click(object sender, EventArgs e)
        {
            int dni = GetSelectedPatientDni();
            if (dni > 0)
            {
                var patientFound = patientsService.SearchPat(dni);
                FrmMedicalRecord frmMedicalRecord = new FrmMedicalRecord(patientFound, medicId, userName);
                frmMedicalRecord.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }
        }
        private int GetSelectedPatientDni()
        {
            if (DgvPatients.SelectedCells.Count > 0)
            {
                int columnIndex = -1;
                foreach (DataGridViewColumn column in DgvPatients.Columns)
                {
                    if (column.Name.Equals("Dni", StringComparison.OrdinalIgnoreCase))
                    {
                        columnIndex = column.Index;
                        break;
                    }
                }

                if (columnIndex != -1)
                {
                    DataGridViewRow selectedRow = DgvPatients.Rows[DgvPatients.SelectedCells[0].RowIndex];
                    return int.Parse(selectedRow.Cells[columnIndex].Value.ToString());
                }
                else
                {
                    throw new Exception("Column 'Dni' not found.");
                }
            }
            return 0;
        }


    }
}
