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
            btnShowHistory = new Button();
            btnPrintConsulta = new Button();
            boxPatientInfo = new GroupBox();
            txtDni = new TextBox();
            lblTicket = new Label();
            txtMedicalCoverage = new TextBox();
            lblMCoverage = new Label();
            txtPatientName = new TextBox();
            label2 = new Label();
            DgvConsultation = new DataGridView();
            colPatientId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colLastname = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colDateOfBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colMedicalCoverage = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            boxPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvConsultation).BeginInit();
            SuspendLayout();
            // 
            // btnShowHistory
            // 
            btnShowHistory.Anchor = AnchorStyles.None;
            btnShowHistory.BackColor = Color.FromArgb(77, 100, 141);
            btnShowHistory.FlatAppearance.BorderSize = 0;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowHistory.ForeColor = SystemColors.ButtonHighlight;
            btnShowHistory.Location = new Point(792, 398);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(160, 22);
            btnShowHistory.TabIndex = 21;
            btnShowHistory.Text = "Ver";
            btnShowHistory.UseVisualStyleBackColor = false;
            btnShowHistory.Click += btnViewMedicalHistory_Click;
            // 
            // btnPrintConsulta
            // 
            btnPrintConsulta.Anchor = AnchorStyles.None;
            btnPrintConsulta.BackColor = Color.FromArgb(77, 100, 141);
            btnPrintConsulta.FlatAppearance.BorderSize = 0;
            btnPrintConsulta.FlatStyle = FlatStyle.Flat;
            btnPrintConsulta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintConsulta.ForeColor = SystemColors.ButtonHighlight;
            btnPrintConsulta.Location = new Point(657, 398);
            btnPrintConsulta.Name = "btnPrintConsulta";
            btnPrintConsulta.Size = new Size(122, 22);
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
            boxPatientInfo.Location = new Point(27, 19);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Padding = new Padding(3, 2, 3, 2);
            boxPatientInfo.Size = new Size(689, 94);
            boxPatientInfo.TabIndex = 25;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Left;
            txtDni.Location = new Point(251, 41);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(129, 20);
            txtDni.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(251, 22);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(29, 15);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Dni:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Location = new Point(397, 42);
            txtMedicalCoverage.Margin = new Padding(3, 2, 3, 2);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(231, 20);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(398, 22);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(77, 15);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Location = new Point(7, 41);
            txtPatientName.Margin = new Padding(3, 2, 3, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(231, 20);
            txtPatientName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 22);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre y Apellido: ";
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
            DgvConsultation.Columns.AddRange(new DataGridViewColumn[] { colPatientId, colName, colLastname, colDni, colDateOfBirth, colGender, colMedicalCoverage, colLocation });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(206, 232, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvConsultation.DefaultCellStyle = dataGridViewCellStyle6;
            DgvConsultation.EnableHeadersVisualStyles = false;
            DgvConsultation.Location = new Point(27, 126);
            DgvConsultation.Margin = new Padding(3, 4, 3, 4);
            DgvConsultation.Name = "DgvConsultation";
            DgvConsultation.ReadOnly = true;
            DgvConsultation.RowHeadersWidth = 51;
            DgvConsultation.RowTemplate.Height = 25;
            DgvConsultation.Size = new Size(925, 265);
            DgvConsultation.TabIndex = 13;
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
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(988, 437);
            Controls.Add(DgvConsultation);
            Controls.Add(boxPatientInfo);
            Controls.Add(btnShowHistory);
            Controls.Add(btnPrintConsulta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMedicalRecord";
            Text = "MedicalRecord";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvConsultation).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnShowHistory;
        private Button btnPrintConsulta;
        private GroupBox boxPatientInfo;
        private TextBox txtDni;
        private Label lblTicket;
        private TextBox txtMedicalCoverage;
        private Label lblMCoverage;
        private TextBox txtPatientName;
        private Label label2;
        private DataGridView DgvConsultation;
        private DataGridViewTextBoxColumn colPatientId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLastname;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colDateOfBirth;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colMedicalCoverage;
        private DataGridViewTextBoxColumn colLocation;
    }
}