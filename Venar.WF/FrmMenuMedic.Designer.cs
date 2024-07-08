namespace Venar.WF
{
    partial class FrmMenuMedic
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgvPatients = new DataGridView();
            colPatientId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colLastname = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colDateOfBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colMedicalCoverage = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            btnFinishSession = new Button();
            btnDeleatPatient = new Button();
            btnModifyPatient = new Button();
            btnCreatePatient = new Button();
            btnShowPatient = new Button();
            btnClinicalHistory = new Button();
            labelMedicName = new Label();
            btnShowHistory = new Button();
            labelMedicalRegistration = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvPatients).BeginInit();
            SuspendLayout();
            // 
            // DgvPatients
            // 
            DgvPatients.AllowUserToAddRows = false;
            DgvPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPatients.Anchor = AnchorStyles.None;
            DgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPatients.BackgroundColor = Color.White;
            DgvPatients.BorderStyle = BorderStyle.None;
            DgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(61, 90, 128);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPatients.Columns.AddRange(new DataGridViewColumn[] { colPatientId, colName, colLastname, colDni, colDateOfBirth, colGender, colMedicalCoverage, colLocation });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(206, 232, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            DgvPatients.EnableHeadersVisualStyles = false;
            DgvPatients.Location = new Point(12, 39);
            DgvPatients.Margin = new Padding(3, 4, 3, 4);
            DgvPatients.Name = "DgvPatients";
            DgvPatients.ReadOnly = true;
            DgvPatients.RowHeadersWidth = 51;
            DgvPatients.RowTemplate.Height = 25;
            DgvPatients.Size = new Size(986, 318);
            DgvPatients.TabIndex = 1;
            DgvPatients.CellContentClick += DgvPatients_CellContentClick;
            // 
            // colPatientId
            // 
            colPatientId.DataPropertyName = "colPatientId";
            colPatientId.HeaderText = "Id Paciente";
            colPatientId.MinimumWidth = 6;
            colPatientId.Name = "colPatientId";
            colPatientId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nombre";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colLastname
            // 
            colLastname.DataPropertyName = "LastName";
            colLastname.HeaderText = "Apellido";
            colLastname.MinimumWidth = 6;
            colLastname.Name = "colLastname";
            colLastname.ReadOnly = true;
            // 
            // colDni
            // 
            colDni.DataPropertyName = "Dni";
            colDni.HeaderText = "Dni";
            colDni.MinimumWidth = 6;
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colDateOfBirth
            // 
            colDateOfBirth.DataPropertyName = "Fecha Nacimiento";
            colDateOfBirth.HeaderText = "Fecha Naciemiento";
            colDateOfBirth.MinimumWidth = 6;
            colDateOfBirth.Name = "colDateOfBirth";
            colDateOfBirth.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Genero";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colMedicalCoverage
            // 
            colMedicalCoverage.DataPropertyName = "Obra Social";
            colMedicalCoverage.HeaderText = "Obra Social";
            colMedicalCoverage.MinimumWidth = 6;
            colMedicalCoverage.Name = "colMedicalCoverage";
            colMedicalCoverage.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.DataPropertyName = "Direccion";
            colLocation.HeaderText = "Direccion";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // btnFinishSession
            // 
            btnFinishSession.Anchor = AnchorStyles.None;
            btnFinishSession.BackColor = Color.FromArgb(77, 100, 141);
            btnFinishSession.FlatAppearance.BorderSize = 0;
            btnFinishSession.FlatStyle = FlatStyle.Flat;
            btnFinishSession.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishSession.ForeColor = SystemColors.ButtonHighlight;
            btnFinishSession.Location = new Point(915, 366);
            btnFinishSession.Margin = new Padding(3, 4, 3, 4);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(83, 31);
            btnFinishSession.TabIndex = 13;
            btnFinishSession.Text = "Cerrar";
            btnFinishSession.UseVisualStyleBackColor = false;
            btnFinishSession.Click += btnFinishSession_Click_1;
            // 
            // btnDeleatPatient
            // 
            btnDeleatPatient.Anchor = AnchorStyles.None;
            btnDeleatPatient.BackColor = Color.FromArgb(77, 100, 141);
            btnDeleatPatient.FlatAppearance.BorderSize = 0;
            btnDeleatPatient.FlatStyle = FlatStyle.Flat;
            btnDeleatPatient.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleatPatient.ForeColor = SystemColors.ButtonHighlight;
            btnDeleatPatient.Location = new Point(316, 366);
            btnDeleatPatient.Margin = new Padding(3, 4, 3, 4);
            btnDeleatPatient.Name = "btnDeleatPatient";
            btnDeleatPatient.Size = new Size(150, 30);
            btnDeleatPatient.TabIndex = 12;
            btnDeleatPatient.Text = "Eliminar Paciente";
            btnDeleatPatient.UseVisualStyleBackColor = false;
            btnDeleatPatient.Click += btnDeleatPatient_Click;
            // 
            // btnModifyPatient
            // 
            btnModifyPatient.Anchor = AnchorStyles.None;
            btnModifyPatient.BackColor = Color.FromArgb(77, 100, 141);
            btnModifyPatient.FlatAppearance.BorderSize = 0;
            btnModifyPatient.FlatStyle = FlatStyle.Flat;
            btnModifyPatient.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifyPatient.ForeColor = SystemColors.ButtonHighlight;
            btnModifyPatient.Location = new Point(148, 367);
            btnModifyPatient.Margin = new Padding(3, 4, 3, 4);
            btnModifyPatient.Name = "btnModifyPatient";
            btnModifyPatient.Size = new Size(162, 30);
            btnModifyPatient.TabIndex = 11;
            btnModifyPatient.Text = "Modificar Paciente";
            btnModifyPatient.UseVisualStyleBackColor = false;
            btnModifyPatient.Click += btnModifyPatient_Click_1;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.Anchor = AnchorStyles.None;
            btnCreatePatient.BackColor = Color.FromArgb(77, 100, 141);
            btnCreatePatient.FlatAppearance.BorderSize = 0;
            btnCreatePatient.FlatStyle = FlatStyle.Flat;
            btnCreatePatient.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatePatient.ForeColor = SystemColors.ButtonHighlight;
            btnCreatePatient.Location = new Point(12, 367);
            btnCreatePatient.Margin = new Padding(3, 4, 3, 4);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(130, 30);
            btnCreatePatient.TabIndex = 10;
            btnCreatePatient.Text = "Crear Paciente";
            btnCreatePatient.UseVisualStyleBackColor = false;
            btnCreatePatient.Click += btnCreatePatient_Click_1;
            // 
            // btnShowPatient
            // 
            btnShowPatient.Anchor = AnchorStyles.None;
            btnShowPatient.BackColor = Color.FromArgb(77, 100, 141);
            btnShowPatient.FlatAppearance.BorderSize = 0;
            btnShowPatient.FlatStyle = FlatStyle.Flat;
            btnShowPatient.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowPatient.ForeColor = SystemColors.ButtonHighlight;
            btnShowPatient.Location = new Point(1004, 39);
            btnShowPatient.Margin = new Padding(3, 4, 3, 4);
            btnShowPatient.Name = "btnShowPatient";
            btnShowPatient.Size = new Size(83, 31);
            btnShowPatient.TabIndex = 15;
            btnShowPatient.Text = "Refresh";
            btnShowPatient.UseVisualStyleBackColor = false;
            btnShowPatient.Click += btnShowPatient_Click;
            // 
            // btnClinicalHistory
            // 
            btnClinicalHistory.Anchor = AnchorStyles.None;
            btnClinicalHistory.BackColor = Color.FromArgb(77, 100, 141);
            btnClinicalHistory.FlatAppearance.BorderSize = 0;
            btnClinicalHistory.FlatStyle = FlatStyle.Flat;
            btnClinicalHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClinicalHistory.ForeColor = SystemColors.ButtonHighlight;
            btnClinicalHistory.Location = new Point(472, 365);
            btnClinicalHistory.Margin = new Padding(3, 4, 3, 4);
            btnClinicalHistory.Name = "btnClinicalHistory";
            btnClinicalHistory.Size = new Size(140, 30);
            btnClinicalHistory.TabIndex = 16;
            btnClinicalHistory.Text = "Cargar Consulta";
            btnClinicalHistory.UseVisualStyleBackColor = false;
            btnClinicalHistory.Click += btnClinicalHistory_Click;
            // 
            // labelMedicName
            // 
            labelMedicName.AutoSize = true;
            labelMedicName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicName.ForeColor = SystemColors.ButtonHighlight;
            labelMedicName.Location = new Point(12, 9);
            labelMedicName.Name = "labelMedicName";
            labelMedicName.Size = new Size(60, 18);
            labelMedicName.TabIndex = 18;
            labelMedicName.Text = "Doctor";
            // 
            // btnShowHistory
            // 
            btnShowHistory.Anchor = AnchorStyles.None;
            btnShowHistory.BackColor = Color.FromArgb(77, 100, 141);
            btnShowHistory.FlatAppearance.BorderSize = 0;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowHistory.ForeColor = SystemColors.ButtonHighlight;
            btnShowHistory.Location = new Point(618, 365);
            btnShowHistory.Margin = new Padding(3, 4, 3, 4);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(183, 30);
            btnShowHistory.TabIndex = 19;
            btnShowHistory.Text = "Historial de Consultas";
            btnShowHistory.UseVisualStyleBackColor = false;
            btnShowHistory.Click += btnShowHistory_Click;
            // 
            // labelMedicalRegistration
            // 
            labelMedicalRegistration.AutoSize = true;
            labelMedicalRegistration.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicalRegistration.ForeColor = SystemColors.ButtonHighlight;
            labelMedicalRegistration.Location = new Point(234, 9);
            labelMedicalRegistration.Name = "labelMedicalRegistration";
            labelMedicalRegistration.Size = new Size(77, 18);
            labelMedicalRegistration.TabIndex = 20;
            labelMedicalRegistration.Text = "Matricula";
            // 
            // FrmMenuMedic
            // 
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(1096, 410);
            Controls.Add(labelMedicalRegistration);
            Controls.Add(btnShowHistory);
            Controls.Add(labelMedicName);
            Controls.Add(btnClinicalHistory);
            Controls.Add(btnShowPatient);
            Controls.Add(btnFinishSession);
            Controls.Add(btnDeleatPatient);
            Controls.Add(btnModifyPatient);
            Controls.Add(btnCreatePatient);
            Controls.Add(DgvPatients);
            Name = "FrmMenuMedic";
            ((System.ComponentModel.ISupportInitialize)DgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView DgvPatients;
        private Button btnFinishSession;
        private Button btnDeleatPatient;
        private Button btnModifyPatient;
        private Button btnCreatePatient;
        private Button btnShowPatient;
        private DataGridViewTextBoxColumn colPatientId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLastname;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colDateOfBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colMedicalCoverage;
        private DataGridViewTextBoxColumn colLocation;
        private Button btnClinicalHistory;
        private Label lblMedicName;
        private Label labelMedicName;
        private Button btnShowHistory;
        private Label labelMedicalRegistration;
    }
}