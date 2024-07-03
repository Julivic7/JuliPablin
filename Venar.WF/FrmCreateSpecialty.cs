using Venar.Entities;
using Venar.SVC; 

namespace Venar.WF
{
    public partial class FrmCreateSpecialty : Form
    {
        SpecialtySVC specialtySvc = new SpecialtySVC();

        public FrmCreateSpecialty()
        {
            InitializeComponent();
            specialtySvc = new SpecialtySVC();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Specialty newSpecialty = new Specialty
            {
                SpecialtyName = txtSpecialtyName.Text,
                Description = txtDescription.Text
            };


            try
            {
                specialtySvc.InsertSpecialty(newSpecialty);
                MessageBox.Show("Especialidad insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar especialidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

