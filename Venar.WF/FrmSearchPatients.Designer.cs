namespace Venar.WF
{
    partial class FrmViewPatients
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
            txtBxDniSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNameSearch = new TextBox();
            txtBxLastNameSearch = new TextBox();
            label4 = new Label();
            txtBoxCoverSearch = new TextBox();
            btnModifyPatient = new Button();
            label5 = new Label();
            btnDeleatPatient = new Button();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            button2 = new Button();
            datagridPatients = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            MedicalCoverage = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagridPatients).BeginInit();
            SuspendLayout();
            // 
            // txtBxDniSearch
            // 
            txtBxDniSearch.Location = new Point(329, 38);
            txtBxDniSearch.Margin = new Padding(3, 2, 3, 2);
            txtBxDniSearch.Name = "txtBxDniSearch";
            txtBxDniSearch.Size = new Size(197, 23);
            txtBxDniSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Dni Patients:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 113);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Name Patients:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 113);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 4;
            label3.Text = "LastName  Patients:";
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(71, 130);
            txtNameSearch.Margin = new Padding(3, 2, 3, 2);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(197, 23);
            txtNameSearch.TabIndex = 5;
            // 
            // txtBxLastNameSearch
            // 
            txtBxLastNameSearch.Location = new Point(289, 130);
            txtBxLastNameSearch.Margin = new Padding(3, 2, 3, 2);
            txtBxLastNameSearch.Name = "txtBxLastNameSearch";
            txtBxLastNameSearch.Size = new Size(197, 23);
            txtBxLastNameSearch.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 113);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Cover Patients:";
            // 
            // txtBoxCoverSearch
            // 
            txtBoxCoverSearch.Location = new Point(502, 130);
            txtBoxCoverSearch.Margin = new Padding(3, 2, 3, 2);
            txtBoxCoverSearch.Name = "txtBoxCoverSearch";
            txtBoxCoverSearch.Size = new Size(197, 23);
            txtBoxCoverSearch.TabIndex = 8;
            // 
            // btnModifyPatient
            // 
            btnModifyPatient.BackColor = SystemColors.HotTrack;
            btnModifyPatient.BackgroundImage = Properties.Resources.edicion_de_usuario;
            btnModifyPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifyPatient.Cursor = Cursors.Hand;
            btnModifyPatient.FlatAppearance.BorderSize = 0;
            btnModifyPatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnModifyPatient.FlatStyle = FlatStyle.Flat;
            btnModifyPatient.Location = new Point(120, 298);
            btnModifyPatient.Name = "btnModifyPatient";
            btnModifyPatient.Size = new Size(131, 30);
            btnModifyPatient.TabIndex = 13;
            btnModifyPatient.UseVisualStyleBackColor = false;
            btnModifyPatient.Click += btnModifyPatient_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(95, 280);
            label5.Name = "label5";
            label5.Size = new Size(160, 17);
            label5.TabIndex = 18;
            label5.Text = "Modificar Pacientes";
            // 
            // btnDeleatPatient
            // 
            btnDeleatPatient.BackColor = SystemColors.HotTrack;
            btnDeleatPatient.BackgroundImage = Properties.Resources.eliminarPaciente;
            btnDeleatPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleatPatient.Cursor = Cursors.Hand;
            btnDeleatPatient.FlatAppearance.BorderSize = 0;
            btnDeleatPatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnDeleatPatient.FlatStyle = FlatStyle.Flat;
            btnDeleatPatient.Location = new Point(328, 298);
            btnDeleatPatient.Name = "btnDeleatPatient";
            btnDeleatPatient.Size = new Size(141, 30);
            btnDeleatPatient.TabIndex = 19;
            btnDeleatPatient.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(328, 280);
            label6.Name = "label6";
            label6.Size = new Size(144, 17);
            label6.TabIndex = 20;
            label6.Text = "Eliminar Paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(576, 280);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 21;
            label7.Text = "Ver HC";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(534, 298);
            button1.Name = "button1";
            button1.Size = new Size(141, 30);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 7);
            label8.Name = "label8";
            label8.Size = new Size(209, 15);
            label8.TabIndex = 23;
            label8.Text = "INGRESE DNI PARA BUSCAR PACIENTE";
            // 
            // button2
            // 
            button2.Location = new Point(317, 62);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(136, 25);
            button2.TabIndex = 24;
            button2.Text = "SEARCH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // datagridPatients
            // 
            datagridPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridPatients.Columns.AddRange(new DataGridViewColumn[] { name, LastName, Gender, Location, MedicalCoverage, DateOfBirth });
            datagridPatients.Location = new Point(34, 158);
            datagridPatients.Margin = new Padding(3, 2, 3, 2);
            datagridPatients.Name = "datagridPatients";
            datagridPatients.RowHeadersWidth = 51;
            datagridPatients.RowTemplate.Height = 29;
            datagridPatients.Size = new Size(702, 120);
            datagridPatients.TabIndex = 25;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // Location
            // 
            Location.DataPropertyName = "location";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.Width = 125;
            // 
            // MedicalCoverage
            // 
            MedicalCoverage.DataPropertyName = "MedicalCoverage";
            MedicalCoverage.HeaderText = "MedicalCoverage";
            MedicalCoverage.MinimumWidth = 6;
            MedicalCoverage.Name = "MedicalCoverage";
            MedicalCoverage.Width = 125;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 125;
            // 
            // FrmViewPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 166, 233);
            ClientSize = new Size(770, 338);
            Controls.Add(datagridPatients);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnDeleatPatient);
            Controls.Add(label5);
            Controls.Add(btnModifyPatient);
            Controls.Add(txtBoxCoverSearch);
            Controls.Add(label4);
            Controls.Add(txtBxLastNameSearch);
            Controls.Add(txtNameSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBxDniSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmViewPatients";
            Text = "viewPatients";
            ((System.ComponentModel.ISupportInitialize)datagridPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBxDniSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNameSearch;
        private TextBox txtBxLastNameSearch;
        private Label label4;
        private TextBox txtBoxCoverSearch;
        private Button btnModifyPatient;
        private Label label5;
        private Button btnDeleatPatient;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Button button2;
        private DataGridView datagridPatients;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn MedicalCoverage;
        private DataGridViewTextBoxColumn DateOfBirth;
    }
}