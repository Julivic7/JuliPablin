namespace Venar.WF
{
    partial class FrmMedicalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DgvConsultation = new DataGridView();
            colDateOfConsultation = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colDiagnosis = new DataGridViewTextBoxColumn();
            colMedicName = new DataGridViewTextBoxColumn();
            colMedicalRegistration = new DataGridViewTextBoxColumn();
            btnShowHistory = new Button();
            btnPrintConsulta = new Button();
            boxPatientInfo = new GroupBox();
            txtDni = new TextBox();
            lblTicket = new Label();
            txtMedicalCoverage = new TextBox();
            lblMCoverage = new Label();
            txtPatientName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvConsultation).BeginInit();
            boxPatientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // DgvConsultation
            // 
            DgvConsultation.AllowUserToAddRows = false;
            DgvConsultation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DgvConsultation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvConsultation.Anchor = AnchorStyles.None;
            DgvConsultation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsultation.BackgroundColor = Color.White;
            DgvConsultation.BorderStyle = BorderStyle.None;
            DgvConsultation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(61, 90, 128);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvConsultation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvConsultation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsultation.Columns.AddRange(new DataGridViewColumn[] { colDateOfConsultation, colReason, colDiagnosis, colMedicName, colMedicalRegistration });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(206, 232, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvConsultation.DefaultCellStyle = dataGridViewCellStyle6;
            DgvConsultation.EnableHeadersVisualStyles = false;
            DgvConsultation.Location = new Point(31, 179);
            DgvConsultation.Margin = new Padding(3, 4, 3, 4);
            DgvConsultation.Name = "DgvConsultation";
            DgvConsultation.ReadOnly = true;
            DgvConsultation.RowHeadersWidth = 51;
            DgvConsultation.RowTemplate.Height = 25;
            DgvConsultation.Size = new Size(1057, 318);
            DgvConsultation.TabIndex = 2;
            // 
            // colDateOfConsultation
            // 
            colDateOfConsultation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDateOfConsultation.DataPropertyName = "Fecha Consulta";
            colDateOfConsultation.HeaderText = "Fecha Consulta";
            colDateOfConsultation.MinimumWidth = 6;
            colDateOfConsultation.Name = "colDateOfConsultation";
            colDateOfConsultation.ReadOnly = true;
            colDateOfConsultation.Width = 125;
            // 
            // colReason
            // 
            colReason.DataPropertyName = "Motivo de Consulta";
            colReason.HeaderText = "Motivo de Consulta";
            colReason.MinimumWidth = 6;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colDiagnosis
            // 
            colDiagnosis.DataPropertyName = "Diagnostico";
            colDiagnosis.HeaderText = "Diagnostico";
            colDiagnosis.MinimumWidth = 6;
            colDiagnosis.Name = "colDiagnosis";
            colDiagnosis.ReadOnly = true;
            // 
            // colMedicName
            // 
            colMedicName.HeaderText = "Atendido por";
            colMedicName.MinimumWidth = 6;
            colMedicName.Name = "colMedicName";
            colMedicName.ReadOnly = true;
            // 
            // colMedicalRegistration
            // 
            colMedicalRegistration.HeaderText = "Matricula";
            colMedicalRegistration.MinimumWidth = 6;
            colMedicalRegistration.Name = "colMedicalRegistration";
            colMedicalRegistration.ReadOnly = true;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Anchor = AnchorStyles.None;
            btnShowHistory.BackColor = Color.FromArgb(77, 100, 141);
            btnShowHistory.FlatAppearance.BorderSize = 0;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowHistory.ForeColor = SystemColors.ButtonHighlight;
            btnShowHistory.Location = new Point(905, 531);
            btnShowHistory.Margin = new Padding(3, 4, 3, 4);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(183, 30);
            btnShowHistory.TabIndex = 21;
            btnShowHistory.Text = "Ver";
            btnShowHistory.UseVisualStyleBackColor = false;
            // 
            // btnPrintConsulta
            // 
            btnPrintConsulta.Anchor = AnchorStyles.None;
            btnPrintConsulta.BackColor = Color.FromArgb(77, 100, 141);
            btnPrintConsulta.FlatAppearance.BorderSize = 0;
            btnPrintConsulta.FlatStyle = FlatStyle.Flat;
            btnPrintConsulta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintConsulta.ForeColor = SystemColors.ButtonHighlight;
            btnPrintConsulta.Location = new Point(751, 531);
            btnPrintConsulta.Margin = new Padding(3, 4, 3, 4);
            btnPrintConsulta.Name = "btnPrintConsulta";
            btnPrintConsulta.Size = new Size(140, 30);
            btnPrintConsulta.TabIndex = 20;
            btnPrintConsulta.Text = "Imprimir";
            btnPrintConsulta.UseVisualStyleBackColor = false;
            // 
            // boxPatientInfo
            // 
            boxPatientInfo.Anchor = AnchorStyles.None;
            boxPatientInfo.BackColor = Color.FromArgb(61, 90, 128);
            boxPatientInfo.BackgroundImageLayout = ImageLayout.None;
            boxPatientInfo.Controls.Add(txtDni);
            boxPatientInfo.Controls.Add(lblTicket);
            boxPatientInfo.Controls.Add(txtMedicalCoverage);
            boxPatientInfo.Controls.Add(lblMCoverage);
            boxPatientInfo.Controls.Add(txtPatientName);
            boxPatientInfo.Controls.Add(label2);
            boxPatientInfo.FlatStyle = FlatStyle.Flat;
            boxPatientInfo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxPatientInfo.ForeColor = SystemColors.ButtonHighlight;
            boxPatientInfo.Location = new Point(31, 25);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Size = new Size(787, 125);
            boxPatientInfo.TabIndex = 25;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Left;
            txtDni.Location = new Point(287, 55);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(147, 23);
            txtDni.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(287, 29);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(34, 18);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Dni:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Location = new Point(454, 56);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(263, 23);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(455, 29);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(94, 18);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Location = new Point(8, 55);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(263, 23);
            txtPatientName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 29);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 0;
            label2.Text = "Nombre y Apellido: ";
            // 
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(1129, 583);
            Controls.Add(boxPatientInfo);
            Controls.Add(btnShowHistory);
            Controls.Add(btnPrintConsulta);
            Controls.Add(DgvConsultation);
            Name = "FrmMedicalRecord";
            Text = "MedicalRecord";
            ((System.ComponentModel.ISupportInitialize)DgvConsultation).EndInit();
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvConsultation;
        private Button btnShowHistory;
        private Button btnPrintConsulta;
        private GroupBox boxPatientInfo;
        private TextBox txtDni;
        private Label lblTicket;
        private TextBox txtMedicalCoverage;
        private Label lblMCoverage;
        private TextBox txtPatientName;
        private Label label2;
        private DataGridViewTextBoxColumn colDateOfConsultation;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colDiagnosis;
        private DataGridViewTextBoxColumn colMedicName;
        private DataGridViewTextBoxColumn colMedicalRegistration;
    }
}