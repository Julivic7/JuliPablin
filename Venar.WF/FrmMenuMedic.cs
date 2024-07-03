using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmMenuMedic : Form
    {
        PatientsSVC patientsService;
        FrmModifyPatient frmModifyPatient;
        FrmCreatePatient frmCreatePatient;
        ValidCreatePatient validCreatedPatient;
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
            DgvPatients.Columns.Clear();
            DgvPatients.AutoGenerateColumns = false;
            //Projection para poder imprimir en el datagrid los valores de l paciente
            DataGridViewTextBoxColumn colDni = new DataGridViewTextBoxColumn();
            colDni.DataPropertyName = "Dni";
            colDni.HeaderText = "DNI";
            DgvPatients.Columns.Add(colDni);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nombre";
            DgvPatients.Columns.Add(colName);

            DataGridViewTextBoxColumn colLastName = new DataGridViewTextBoxColumn();
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Apellido";
            DgvPatients.Columns.Add(colLastName);

            DataGridViewTextBoxColumn colDateOfBirth = new DataGridViewTextBoxColumn();
            colDateOfBirth.DataPropertyName = "DateOfBirth";
            colDateOfBirth.HeaderText = "Fecha de Nacimiento";
            DgvPatients.Columns.Add(colDateOfBirth);

            DataGridViewTextBoxColumn colGenderName = new DataGridViewTextBoxColumn();
            colGenderName.DataPropertyName = "GenderName";
            colGenderName.HeaderText = "Género";
            DgvPatients.Columns.Add(colGenderName);

            DataGridViewTextBoxColumn colLocationName = new DataGridViewTextBoxColumn();
            colLocationName.DataPropertyName = "LocationName";
            colLocationName.HeaderText = "Dirección";
            DgvPatients.Columns.Add(colLocationName);

            DataGridViewTextBoxColumn colMedicalCoverageName = new DataGridViewTextBoxColumn();
            colMedicalCoverageName.DataPropertyName = "MedicalCoverageName";
            colMedicalCoverageName.HeaderText = "Cobertura Médica";
            DgvPatients.Columns.Add(colMedicalCoverageName);

            // Obtener datos y establecer DataSource
            var pacientesDataSource = patientsService.GetPatients(medicId).Select(p => new
            {
                p.Dni,
                p.Name,
                p.LastName,
                DateOfBirth = p.DateOfBirth.ToShortDateString(),
                GenderName = p.Gender != null ? p.Gender.NameGender : "",
                LocationName = p.Location != null ? p.Location.LocationName : "",
                MedicalCoverageName = p.MedicalCoverage != null ? p.MedicalCoverage.NameCover : "",
            }).ToList();

            DgvPatients.DataSource = pacientesDataSource;
            DgvPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                int columnIndex = 0; // Suponiendo que la columna 3 contiene el DNI
                DataGridViewRow selectedRow = DgvPatients.Rows[DgvPatients.SelectedCells[0].RowIndex];
                return int.Parse(selectedRow.Cells[columnIndex].Value.ToString());
            }
            return 0; 
        }

    }
}
