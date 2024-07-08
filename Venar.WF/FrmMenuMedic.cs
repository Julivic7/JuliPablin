﻿using Venar.DTO;
using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmMenuMedic : Form
    {
        public string LoggedUserName { get; set; }
        public string LoggedMedicalRegistration { get; set; }
        PatientsSVC patientsService;
        FrmModifyPatient frmModifyPatient;
        FrmCreatePatient frmCreatePatient;
        ValidCreatePatient validCreatedPatient;
        ConsultationSVC medicalRecordSVC = new ConsultationSVC();
        MedicDto medic;
        private string userName;

        public FrmMenuMedic(MedicDto medic)
        {
            InitializeComponent();
            patientsService = new PatientsSVC();
            this.medic = medic;
            LoggedUserName = medic.LastName ?? "usuario";
            LoggedMedicalRegistration = medic.MedicalRegistration ?? "Matricula";
            labelMedicName.Text = "Doctor: " + LoggedUserName;
            labelMedicalRegistration.Text = "Matricula: " + LoggedMedicalRegistration;
            FillGridPatients();
        }
        private void FillGridPatients()
        {
            DgvPatients.DataSource = null;
            DgvPatients.AutoGenerateColumns = true;
            DgvPatients.Columns.Clear();

            var patients = patientsService.GetPatients(medic.MedicId);

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
            FrmCreatePatient frmCreatePatient = new FrmCreatePatient(medic);
            frmCreatePatient.Show();
        }
        private void btnModifyPatient_Click_1(object sender, EventArgs e)
        {
            int dni = GetSelectedPatientDni();
            if (dni > 0)
            {
                var patientFound = patientsService.SearchPat(dni);
                FrmModifyPatient frmModifyPatient = new FrmModifyPatient(patientFound, medic);
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
                    bool deletSuccesful = patientsService.DeletePatient(dni, medic);
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
                FrmConsultation frmMedicalRecord = new FrmConsultation(patientFound, medic);
                frmMedicalRecord.Show();
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
        private void btnShowHistory_Click(object sender, EventArgs e) // modificar para ver hitorial de consultas
        {
            int dni = GetSelectedPatientDni();
            if (dni > 0)
            {
                var patientFound = patientsService.SearchPat(dni);
                FrmMedicalRecord frmMedicalRecord = new FrmMedicalRecord(patientFound, medic);
                frmMedicalRecord.Show();
                FillGridPatients();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }
        }
    }
}
