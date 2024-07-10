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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnShowHistory = new Button();
            btnClose = new Button();
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
            printDialog1 = new PrintDialog();
            button1 = new Button();
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
            btnShowHistory.Location = new Point(31, 531);
            btnShowHistory.Margin = new Padding(3, 4, 3, 4);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(139, 29);
            btnShowHistory.TabIndex = 21;
            btnShowHistory.Text = "Ver";
            btnShowHistory.UseVisualStyleBackColor = false;
            btnShowHistory.Click += btnViewMedicalHistory_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.FromArgb(77, 100, 141);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(949, 541);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 29);
            btnClose.TabIndex = 20;
            btnClose.Text = "Atras";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            // DgvConsultation
            // 
            DgvConsultation.AllowUserToAddRows = false;
            DgvConsultation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            DgvConsultation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DgvConsultation.Anchor = AnchorStyles.None;
            DgvConsultation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsultation.BackgroundColor = Color.White;
            DgvConsultation.BorderStyle = BorderStyle.None;
            DgvConsultation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(61, 90, 128);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DgvConsultation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DgvConsultation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsultation.Columns.AddRange(new DataGridViewColumn[] { colPatientId, colName, colLastname, colDni, colDateOfBirth, colGender, colMedicalCoverage, colLocation });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(206, 232, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DgvConsultation.DefaultCellStyle = dataGridViewCellStyle9;
            DgvConsultation.EnableHeadersVisualStyles = false;
            DgvConsultation.Location = new Point(31, 168);
            DgvConsultation.Margin = new Padding(3, 5, 3, 5);
            DgvConsultation.Name = "DgvConsultation";
            DgvConsultation.ReadOnly = true;
            DgvConsultation.RowHeadersWidth = 51;
            DgvConsultation.RowTemplate.Height = 25;
            DgvConsultation.Size = new Size(1057, 353);
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
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(77, 100, 141);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(176, 530);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 26;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(1129, 583);
            Controls.Add(button1);
            Controls.Add(DgvConsultation);
            Controls.Add(boxPatientInfo);
            Controls.Add(btnShowHistory);
            Controls.Add(btnClose);
            Name = "FrmMedicalRecord";
            Text = "MedicalRecord";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvConsultation).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnShowHistory;
        private Button btnClose;
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
        private PrintDialog printDialog1;
        private Button button1;
    }
}