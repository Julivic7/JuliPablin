namespace Venar.WF  
{
    partial class FrmMenuAdmin
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
            DgvMedics = new DataGridView();
            colMedicId = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colLastname = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colSpecialty = new DataGridViewTextBoxColumn();
            colMedicalRegistration = new DataGridViewTextBoxColumn();
            btnCreateMedic = new Button();
            btnModifyMedic = new Button();
            btnDeleatMedic = new Button();
            BtnCerrar = new Button();
            btnShowMedic = new Button();
            labelAdmin = new Label();
            btnCreateLocation = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvMedics).BeginInit();
            SuspendLayout();
            // 
            // DgvMedics
            // 
            DgvMedics.AllowUserToAddRows = false;
            DgvMedics.AllowUserToDeleteRows = false;
            DgvMedics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedics.Columns.AddRange(new DataGridViewColumn[] { colMedicId, colUserName, colName, colLastname, colDni, colMail, colSpecialty, colMedicalRegistration });
            DgvMedics.Location = new Point(14, 52);
            DgvMedics.Margin = new Padding(3, 4, 3, 4);
            DgvMedics.Name = "DgvMedics";
            DgvMedics.ReadOnly = true;
            DgvMedics.RowHeadersWidth = 51;
            DgvMedics.RowTemplate.Height = 25;
            DgvMedics.Size = new Size(980, 343);
            DgvMedics.TabIndex = 0;
            // 
            // colMedicId
            // 
            colMedicId.DataPropertyName = "colMedicId";
            colMedicId.HeaderText = "Id";
            colMedicId.MinimumWidth = 6;
            colMedicId.Name = "colMedicId";
            colMedicId.ReadOnly = true;
            colMedicId.Width = 50;
            // 
            // colUserName
            // 
            colUserName.DataPropertyName = "colUserName";
            colUserName.HeaderText = "Usuario";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            colUserName.Width = 125;
            // 
            // colName
            // 
            colName.DataPropertyName = "MedicName";
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
            colDni.Width = 125;
            // 
            // colMail
            // 
            colMail.DataPropertyName = "Mial";
            colMail.HeaderText = "Mail";
            colMail.MinimumWidth = 6;
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            colMail.Width = 125;
            // 
            // colSpecialty
            // 
            colSpecialty.DataPropertyName = "Especialidad";
            colSpecialty.HeaderText = "Especialidad";
            colSpecialty.MinimumWidth = 6;
            colSpecialty.Name = "colSpecialty";
            colSpecialty.ReadOnly = true;
            colSpecialty.Width = 125;
            // 
            // colMedicalRegistration
            // 
            colMedicalRegistration.DataPropertyName = "Matricula";
            colMedicalRegistration.HeaderText = "Matricula";
            colMedicalRegistration.MinimumWidth = 6;
            colMedicalRegistration.Name = "colMedicalRegistration";
            colMedicalRegistration.ReadOnly = true;
            colMedicalRegistration.Width = 125;
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.Location = new Point(39, 416);
            btnCreateMedic.Margin = new Padding(3, 4, 3, 4);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(125, 30);
            btnCreateMedic.TabIndex = 1;
            btnCreateMedic.Text = "Crear Medico";
            btnCreateMedic.UseVisualStyleBackColor = true;
            btnCreateMedic.Click += btnCreateMedic_Click_1;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.Location = new Point(170, 416);
            btnModifyMedic.Margin = new Padding(3, 4, 3, 4);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(125, 30);
            btnModifyMedic.TabIndex = 2;
            btnModifyMedic.Text = "Modificar Medico";
            btnModifyMedic.UseVisualStyleBackColor = true;
            btnModifyMedic.Click += btnModifyMedic_Click_1;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.Location = new Point(301, 415);
            btnDeleatMedic.Margin = new Padding(3, 4, 3, 4);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(125, 30);
            btnDeleatMedic.TabIndex = 3;
            btnDeleatMedic.Text = "Eliminar Medico";
            btnDeleatMedic.UseVisualStyleBackColor = true;
            btnDeleatMedic.Click += btnDeleatMedic_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(908, 415);
            BtnCerrar.Margin = new Padding(3, 4, 3, 4);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(86, 31);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.Location = new Point(1020, 52);
            btnShowMedic.Margin = new Padding(3, 4, 3, 4);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(70, 30);
            btnShowMedic.TabIndex = 7;
            btnShowMedic.Text = "Refresh";
            btnShowMedic.UseVisualStyleBackColor = true;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Location = new Point(39, 17);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(0, 20);
            labelAdmin.TabIndex = 8;
            // 
            // btnCreateLocation
            // 
            btnCreateLocation.Location = new Point(432, 416);
            btnCreateLocation.Margin = new Padding(3, 4, 3, 4);
            btnCreateLocation.Name = "btnCreateLocation";
            btnCreateLocation.Size = new Size(135, 30);
            btnCreateLocation.TabIndex = 9;
            btnCreateLocation.Text = "Cargar Localidad";
            btnCreateLocation.UseVisualStyleBackColor = true;
            btnCreateLocation.Click += btnCreateLocation_Click;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 464);
            Controls.Add(btnCreateLocation);
            Controls.Add(labelAdmin);
            Controls.Add(btnShowMedic);
            Controls.Add(BtnCerrar);
            Controls.Add(btnDeleatMedic);
            Controls.Add(btnModifyMedic);
            Controls.Add(btnCreateMedic);
            Controls.Add(DgvMedics);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Administrador";
            ((System.ComponentModel.ISupportInitialize)DgvMedics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvMedics;
        private Button btnCreateMedic;
        private Button btnModifyMedic;
        private Button btnDeleatMedic;
        private Button BtnCerrar;
        private Button btnShowMedic;
        private Label labelAdmin;
        private DataGridViewTextBoxColumn colMedicId;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLastname;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colSpecialty;
        private DataGridViewTextBoxColumn colMedicalRegistration;
        private Button btnCreateLocation;
    }
}