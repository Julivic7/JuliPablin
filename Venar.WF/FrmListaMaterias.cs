using Venar.DTO;
using Venar.SVC;
using Venar.WF;


namespace StudentSystem.WindowsFormsCliente
{

    public partial class FrmListaMaterias : Form
    {
        public string LoggedUserName { get; set; }
        DiagnosticSVC diagnosticSvc = new DiagnosticSVC();
        MedicSVC medicSvc = new MedicSVC();
        FrmCreateMedic frmCreateMedic;

        public FrmListaMaterias(string userName)
        {
            InitializeComponent();
            FillGridMedic();
            LoggedUserName = userName ?? "usuario";
            labelAdmin.Text = "Bienvenido " + LoggedUserName;
            //List<Materia> ListMaterias = materiaService.ObtenerMaterias();

        }

        private void FillGridMedic()
        {
            DgvMedics.DataSource = null;
            DgvMedics.DataSource = medicSvc.GetMedics();
            //DgvMedics.DataSource = materiaService.ObtenerMaterias();
        }

        //private void LlenarComboMaterias()
        //{
        //    CmbMaterias.DataSource = null;
        //    CmbMaterias.DataSource = materiaService.ObtenerMaterias();
        //    CmbMaterias.DisplayMember = "NombreMateria";
        //    CmbMaterias.ValueMember = "IdMateria";
        //}

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatMedic_Click(object sender, EventArgs e)
        {
            frmCreateMedic = new FrmCreateMedic();
            frmCreateMedic.ShowDialog();
            FillGridMedic();
        }

        private void btnShowMedic_Click(object sender, EventArgs e)
        {
            //var MateriaFound = materiaService.ObtenerMateriaPorId(1);
            List<MedicDto> medics = medicSvc.GetMedics();
            //MessageBox.Show(medics);
        }

        private void btnModifyMedic_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DgvMedics.Rows[DgvMedics.SelectedCells[0].RowIndex];
            int MedicId = int.Parse(selectedRow.Cells["ColIdMateria"].Value.ToString());

            var MedicFound = medicSvc.GetMedicForId(MedicId);

            FrmMateria frmMateria = new FrmMateria(MedicFound);
            frmMateria.ShowDialog();

            FillGridMedic();
        }

        private void btnDeleatMedic_Click(object sender, EventArgs e)
        {
            if (DgvMedics.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = DgvMedics.Rows[DgvMedics.SelectedCells[0].RowIndex];
                int IdMateria = int.Parse(selectedRow.Cells["ColIdMateria"].Value.ToString());

                if (materiaService.BajaMateria(IdMateria))
                {
                    FillGridMedic();
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja la materia");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Materia");
            }
        }
    }
}
