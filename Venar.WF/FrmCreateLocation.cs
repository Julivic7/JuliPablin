using Venar.Entities;
using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmCreateLocation : Form
    {
        private LocationSVC locationSvc;

        public FrmCreateLocation()
        {
            InitializeComponent();
            locationSvc = new LocationSVC();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Location newLocation = new Location
            {
                LocationName = txtLocationName.Text,
                Province = txtProvince.Text,
                PostalCode = txtPostalCode.Text
            };

            try
            {
                locationSvc.InsertLocation(newLocation);
                MessageBox.Show("Ubicación insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar ubicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
