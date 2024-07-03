﻿using Venar.DTO;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmCreateMedic : Form
    {
        MenuAdminSVC createMedicSVC = new MenuAdminSVC();
        ValidCreateMedic validCreateMedicSVC = new ValidCreateMedic();
        MedicDto medicDto = new MedicDto();
        private int admin;

        public FrmCreateMedic(int adminId)
        {
            InitializeComponent();
            cmbSpecialty();
            this.admin = adminId;
        }

        private void cmbSpecialty()
        {
            boxSpecialty.DataSource = createMedicSVC.GetSpecialty();
            boxSpecialty.DisplayMember = "SpecialtyName";
            boxSpecialty.ValueMember = "SpecialtyId";
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            MedicDto medicDto = new MedicDto
            {
                UserName = txtUserName.Text,
                Name = txtName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Mail = txtMail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                SpecialtyId = (int)boxSpecialty.SelectedValue,
                MedicalRegistration = txtMedicalRegistration.Text.Trim()
            };

            ValidCreateMedic validCreateMedicSVC = new ValidCreateMedic();
            bool isValidMail = validCreateMedicSVC.IsValidEmail(txtMail.Text.Trim());

            if (isValidMail)
            {
                ResultDto result = validCreateMedicSVC.CreateReallyUser(medicDto);
                if (result.IsSuccess)
                {
                    MessageBox.Show(result.Message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string errorMessage = string.Join("\n", result.Errors);
                    MessageBox.Show(errorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void boxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSpecialty();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
