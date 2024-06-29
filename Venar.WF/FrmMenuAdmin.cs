using Venar.SVC;
using Venar.WF;


namespace StudentSystem.WindowsFormsCliente
{

    public partial class FrmMenuAdmin : Form
    {
        public string LoggedUserName { get; set; }
        DiagnosticSVC diagnosticSvc = new DiagnosticSVC();
        MenuAdminSVC medicSvc = new MenuAdminSVC();
        FrmCreateMedic frmCreateMedic;

        public FrmMenuAdmin(string userName)
        {
            InitializeComponent();
            FillGridMedic();
            LoggedUserName = userName ?? "usuario";
            labelAdmin.Text = "Bienvenido " + LoggedUserName;
        }
        private void FillGridMedic()
        {
            DgvMedics.Columns.Clear();
            DgvMedics.AutoGenerateColumns = true;
            DgvMedics.DataSource = medicSvc.GetMedics();
            DgvMedics.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

                var MedicFound = medicSvc.GetMedicForId(MedicId);

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

                if (medicSvc.DeleteMedic(MedicId))
                {
                    FillGridMedic();
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja al Medico");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico");
            }
        }


        private void btnCreateMedic_Click_1(object sender, EventArgs e)
        {
            frmCreateMedic = new FrmCreateMedic();
            frmCreateMedic.Show();
            FillGridMedic();
        }

        private void btnShowMedic_Click(object sender, EventArgs e)
        {
            FillGridMedic();
        }
    }
}
