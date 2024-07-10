using System.Windows.Forms;
using Venar.DTO;
using Venar.Entities;
using Venar.SVC;


namespace Venar.WF
{
    public partial class FrmSymptoms : Form
    {
        public event EventHandler<List<string>> SymptomsSelected;
        private SymptomsServices symptomsServices;
        DiagnosticSVC diagnosticSVC = new DiagnosticSVC();
        Patient patient;
        MedicDto medic;
        DiagnosticResult diagnostic;
        public FrmSymptoms(Patient patient, MedicDto medic)
        {
            InitializeComponent();
            symptomsServices = new SymptomsServices();
            this.patient = patient;
            this.medic = medic;
            LoadSymptoms();
        }
        private void LoadSymptoms()
        {
            List<string> symptoms = symptomsServices.GetSymptoms();

            foreach (string symptom in symptoms)
            {
                checkedListBox1.Items.Add((symptom));
            }

        }
        private void btnCheck_symptoms(object sender, EventArgs e)
        {
            txtResults.Text = "";
            txtMatchPercentage.Text = "";

            List<int> selectedSymptomIds = new List<int>();

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                string symptom = checkedListBox1.Items[index].ToString().Trim();
                int symptomId = symptomsServices.GetSymptomIdByName(symptom);

                if (symptomId != 0)
                {
                    selectedSymptomIds.Add(symptomId);
                }

                if (!string.IsNullOrEmpty(txtResults.Text))
                {
                    txtResults.Text += ", ";
                }
                txtResults.Text += symptom;
            }

            List<DiagnosticResult> diagnosticResults = diagnosticSVC.GetDiagnostic(selectedSymptomIds);

            if (diagnosticResults.Count > 0)
            {
                // Mostrar los resultados de diagnóstico en labels
                int labelIndex = 0;
                foreach (DiagnosticResult result in diagnosticResults)
                {
                    Label lblDiagnostic = this.Controls.Find($"lblDiagnostic{labelIndex}", true).FirstOrDefault() as Label;
                    if (lblDiagnostic != null)
                    {
                        lblDiagnostic.Text = result.ToString();
                    }
                    labelIndex++;
                }

                DiagnosticResult maxPercentageResult = diagnosticResults.OrderByDescending(r => r.MatchPercentage).First();
                txtMatchPercentage.Text = maxPercentageResult.ToString();
            }
            else
            {
                txtResults.Text = "No se encontraron enfermedades coincidentes.";
                txtMatchPercentage.Text = "";
            }
        }
        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            diagnostic = new DiagnosticResult()
            {
                Results = txtResults.Text,
                MatchPercentage = txtMatchPercentage.Text
            };
            FrmConsultation frm = new FrmConsultation(patient, medic, diagnostic);

            frm.Show();
            //List<string> selectedSymptoms = new List<string>();

            //foreach (int index in checkedListBox1.CheckedIndices)
            //{
            //    selectedSymptoms.Add(checkedListBox1.Items[index].ToString().Trim());
            //}

            //SymptomsSelected?.Invoke(this, selectedSymptoms);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmConsultation frmConsultation = new FrmConsultation(patient, medic, null);
            frmConsultation.Show();
            this.Close();
        }
    }
}
