using Venar.SVC;

namespace Venar.WF
{
    public partial class FrmAllpatients : Form
    {
        Patient patient;
        MenuAdminSVC patientsSvc = new MenuAdminSVC();
        public FrmAllpatients()
        {
            InitializeComponent();
            GridPatatients();
            this.Load += new EventHandler(MainForm_Load); // Suscribirse al evento Load

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            int patientCount = patientsSvc.CountPatients();
            lblContador.Text = $"Total Patients: {patientCount}";
        }
        private void GridPatatients()
        {
            dtGridAllPatients.DataSource = null;
            dtGridAllPatients.AutoGenerateColumns = true;
            dtGridAllPatients.Columns.Clear();

            var patients = patientsSvc.GetPatient();
            if (patients != null)
            {
                dtGridAllPatients.DataSource = patients;
                dtGridAllPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

    }



}
