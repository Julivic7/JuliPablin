﻿using Venar.DTO;
using Venar.SVC;

namespace StudentSystem.WindowsFormsCliente
{
    public partial class FrmModifyMedic : Form
    {
        //MateriaService materiaService = new MateriaService();
        MenuAdminSVC medicSvc = new MenuAdminSVC();
        MedicDto medic = null;
        public FrmModifyMedic(MedicDto medicEdit)
        {
            InitializeComponent();
            if (medicEdit != null)
            {
                this.medic = medicEdit;
                LlenarDatosMedic();
            }
        }

        private void LlenarDatosMedic()
        {
            txtUsername.Text = medic.UserName;
            txtName.Text = medic.Name;
            txtLastName.Text = medic.LastName;
            txtDni.Text = medic.Dni.ToString();
            txtMail.Text = medic.Mail;
            txtSpecialty.Text = medic.Specialty;
            txtMedicalRegistration.Text = medic.MedicalRegistration;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Validar los Datos

            //Si la validación pasos
            if (medic == null)
            {
                medic = new MedicDto();
            }
             medic.UserName = txtUsername.Text;
             medic.Name = txtName.Text;
             medic.LastName = txtLastName.Text;
             medic.Dni = txtDni.Text;
             medic.Mail = txtMail.Text;
             medic.Specialty = txtSpecialty.Text;
             medic.MedicalRegistration = txtMedicalRegistration.Text;


            try
            {
                if (medic.MedicId == 0)
                {
                    medicSvc.CreateMedic(medic);
                    MessageBox.Show("Se agregó el Medico");
                }
                else
                {
                    if (medicSvc.EditMedic(medic))
                    {
                        MessageBox.Show("Se modificó el Medico: " , medic.LastName);
                    }
                    else
                    {
                        MessageBox.Show("Algo falló, por favor revisar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo falló, por favor revisar. Error: {ex.Message}");
            }
        }
    }
}