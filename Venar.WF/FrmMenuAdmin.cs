using StudentSystem.WindowsFormsCliente;
using Venar.DTO;
using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmMenuAdmin : Form
    {
        public string LoggedUserName { get; set; }
        DiagnosticSVC diagnosticSvc = new DiagnosticSVC();
        MedicSVC medicSvc = new MedicSVC();

        // Constructor that accepts a username parameter
        public FrmMenuAdmin(string userName)
        {
            InitializeComponent();
            LoggedUserName = userName ?? "usuario";
            labelAdmin.Text = "Bienvenido " + LoggedUserName;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void openFormPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnCreateMedic_Click(object sender, EventArgs e)
        {
            openFormPanel(new FrmCreateMedic());

        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {
            openFormPanel(new FrmCreatePatient());
        }

        private void btnShowMedic_Click(object sender, EventArgs e)
        {
            openFormPanel(new FrmListaMaterias(LoggedUserName));
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
