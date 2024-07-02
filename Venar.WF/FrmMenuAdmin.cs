using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmMenuAdmin : Form
    {
        public string LoggedUserName { get; set; }
        DiagnosticSVC diagnosticSvc = new DiagnosticSVC();
        MenuAdminSVC menuAdminSvc = new MenuAdminSVC();
        FrmCreateMedic frmCreateMedic;
        private int adminId;

        public FrmMenuAdmin(string userName , int adminId)
        {
            InitializeComponent();
            FillGridMedic();
            LoggedUserName = userName ?? "usuario";
            labelAdmin.Text = "Bienvenido " + LoggedUserName;
            this.adminId = adminId;
        }
        private void FillGridMedic()
        {
            DgvMedics.DataSource = null; 
            DgvMedics.AutoGenerateColumns = false; 
            DgvMedics.Columns.Clear(); 

            var medics = menuAdminSvc.GetMedics();

            if (medics != null)
            {
                DgvMedics.DataSource = medics;
                DgvMedics.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Close();
            frmLogin.ShowDialog();

        }
        private void btnModifyMedic_Click_1(object sender, EventArgs e)
        {
            if (DgvMedics.SelectedCells.Count > 0)
            {
                int columnIndex = 0; // Suponiendo que MedicId está en la primera columna (índice 0)
                DataGridViewRow selectedRow = DgvMedics.Rows[DgvMedics.SelectedCells[0].RowIndex];
                int MedicId = int.Parse(selectedRow.Cells[columnIndex].Value.ToString());

                var MedicFound = menuAdminSvc.GetMedicForId(MedicId);

                FrmModifyMedic frmModifyMedic = new FrmModifyMedic(MedicFound);
                frmModifyMedic.Show();

                FillGridMedic();
            }
            else
            {
                MessageBox.Show("Seleccione un médico");
            }
        }
        private void btnDeleatMedic_Click(object sender, EventArgs e)
        {
            if (DgvMedics.SelectedCells.Count > 0)
            {
                int columnIndex = 0; // Suponiendo que MedicId está en la primera columna (índice 0)
                DataGridViewRow selectedRow = DgvMedics.Rows[DgvMedics.SelectedCells[0].RowIndex];
                int MedicId = int.Parse(selectedRow.Cells[columnIndex].Value.ToString());

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este médico?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    if (menuAdminSvc.DeleteMedic(MedicId))
                    {
                        FillGridMedic();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo dar de baja al Medico");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico");
            }
        }
        private void btnCreateMedic_Click_1(object sender, EventArgs e)
        {
            frmCreateMedic = new FrmCreateMedic(adminId);
            frmCreateMedic.Show();
            FillGridMedic();
        }
        private void btnShowMedic_Click(object sender, EventArgs e)
        {
            FillGridMedic();
        }
        private void btnCreateLocation_Click(object sender, EventArgs e)
        {
            //string nombre = txtNombreLocalidad.Text;
            //int codigoPostal = int.Parse(txtCodigoPostal.Text);

            //bool resultado = locationService.AddLocation(nombre, codigoPostal);

            //if (resultado)
            //{
            //    MessageBox.Show("Localidad agregada correctamente.");
            //    // Lógica adicional después de agregar la localidad
            //}
            //else
            //{
            //    MessageBox.Show("Error al agregar la localidad.");
            //}
        }
    }
}
