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
            ((System.ComponentModel.ISupportInitialize)DgvPatients).BeginInit();
            SuspendLayout();
            // 
            // DgvPatients
            // 
            DgvPatients.AllowUserToAddRows = false;
            DgvPatients.AllowUserToDeleteRows = false;
            DgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPatients.Columns.AddRange(new DataGridViewColumn[] { colPatientId, colName, colLastname, colDni, colDateOfBirth, colGender, colMedicalCoverage, colLocation });
            DgvPatients.Location = new Point(12, 78);
            DgvPatients.Margin = new Padding(3, 4, 3, 4);
            DgvPatients.Name = "DgvPatients";
            DgvPatients.ReadOnly = true;
            DgvPatients.RowHeadersWidth = 51;
            DgvPatients.RowTemplate.Height = 25;
            DgvPatients.Size = new Size(986, 343);
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
            colPatientId.Width = 80;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nombre";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // colLastname
            // 
            colLastname.DataPropertyName = "LastName";
            colLastname.HeaderText = "Apellido";
            colLastname.MinimumWidth = 6;
            colLastname.Name = "colLastname";
            colLastname.ReadOnly = true;
            colLastname.Width = 125;
            // 
            // colDni
            // 
            colDni.DataPropertyName = "Dni";
            colDni.HeaderText = "Dni";
            colDni.MinimumWidth = 6;
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            colDni.Width = 120;
            // 
            // colDateOfBirth
            // 
            colDateOfBirth.DataPropertyName = "Fecha Nacimiento";
            colDateOfBirth.HeaderText = "Fecha Naciemiento";
            colDateOfBirth.MinimumWidth = 6;
            colDateOfBirth.Name = "colDateOfBirth";
            colDateOfBirth.ReadOnly = true;
            colDateOfBirth.Width = 130;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Genero";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 125;
            // 
            // colMedicalCoverage
            // 
            colMedicalCoverage.DataPropertyName = "Obra Social";
            colMedicalCoverage.HeaderText = "Obra Social";
            colMedicalCoverage.MinimumWidth = 6;
            colMedicalCoverage.Name = "colMedicalCoverage";
            colMedicalCoverage.ReadOnly = true;
            colMedicalCoverage.Width = 125;
            // 
            // colLocation
            // 
            colLocation.DataPropertyName = "Direccion";
            colLocation.HeaderText = "Direccion";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            colLocation.Width = 125;
            // 
            // btnFinishSession
            // 
            btnFinishSession.Location = new Point(912, 459);
            btnFinishSession.Margin = new Padding(3, 4, 3, 4);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(86, 31);
            btnFinishSession.TabIndex = 13;
            btnFinishSession.Text = "Cerrar";
            btnFinishSession.UseVisualStyleBackColor = true;
            btnFinishSession.Click += btnFinishSession_Click_1;
            // 
            // btnDeleatPatient
            // 
            btnDeleatPatient.Location = new Point(274, 458);
            btnDeleatPatient.Margin = new Padding(3, 4, 3, 4);
            btnDeleatPatient.Name = "btnDeleatPatient";
            btnDeleatPatient.Size = new Size(125, 30);
            btnDeleatPatient.TabIndex = 12;
            btnDeleatPatient.Text = "Eliminar Paciente";
            btnDeleatPatient.UseVisualStyleBackColor = true;
            btnDeleatPatient.Click += btnDeleatPatient_Click;
            // 
            // btnModifyPatient
            // 
            btnModifyPatient.Location = new Point(143, 459);
            btnModifyPatient.Margin = new Padding(3, 4, 3, 4);
            btnModifyPatient.Name = "btnModifyPatient";
            btnModifyPatient.Size = new Size(125, 30);
            btnModifyPatient.TabIndex = 11;
            btnModifyPatient.Text = "Modificar Paciente";
            btnModifyPatient.UseVisualStyleBackColor = true;
            btnModifyPatient.Click += btnModifyPatient_Click_1;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.Location = new Point(12, 459);
            btnCreatePatient.Margin = new Padding(3, 4, 3, 4);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(125, 30);
            btnCreatePatient.TabIndex = 10;
            btnCreatePatient.Text = "Crear Paciente";
            btnCreatePatient.UseVisualStyleBackColor = true;
            btnCreatePatient.Click += btnCreatePatient_Click_1;
            // 
            // btnShowPatient
            // 
            btnShowPatient.Location = new Point(1014, 78);
            btnShowPatient.Margin = new Padding(3, 4, 3, 4);
            btnShowPatient.Name = "btnShowPatient";
            btnShowPatient.Size = new Size(70, 30);
            btnShowPatient.TabIndex = 15;
            btnShowPatient.Text = "Refresh";
            btnShowPatient.UseVisualStyleBackColor = true;
            btnShowPatient.Click += btnShowPatient_Click;
            // 
            // btnClinicalHistory
            // 
            btnClinicalHistory.Location = new Point(405, 458);
            btnClinicalHistory.Margin = new Padding(3, 4, 3, 4);
            btnClinicalHistory.Name = "btnClinicalHistory";
            btnClinicalHistory.Size = new Size(160, 30);
            btnClinicalHistory.TabIndex = 16;
            btnClinicalHistory.Text = "Crear Historia Clinica";
            btnClinicalHistory.UseVisualStyleBackColor = true;
            btnClinicalHistory.Click += btnClinicalHistory_Click;
            // 
            // FrmMenuMedic
            // 
            ClientSize = new Size(1096, 547);
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
    }
}