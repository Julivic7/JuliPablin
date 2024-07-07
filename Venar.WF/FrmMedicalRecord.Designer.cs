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
            boxPatientInfo = new GroupBox();
            txtTicket = new TextBox();
            lblTicket = new Label();
            txtMedicalCoverage = new TextBox();
            lblMCoverage = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtGender = new TextBox();
            lblGender = new Label();
            txtDateOfBirth = new TextBox();
            lblDate = new Label();
            lblDateOfBirth = new Label();
            txtPatientName = new TextBox();
            lblPatienName = new Label();
            groupBox1 = new GroupBox();
            txtDiagnosis = new TextBox();
            label2 = new Label();
            txtReason = new TextBox();
            label1 = new Label();
            txtMedicName = new TextBox();
            label3 = new Label();
            boxCalculator = new GroupBox();
            txtEnfermedad = new TextBox();
            label4 = new Label();
            txtSymtoms = new TextBox();
            lblSintomas = new Label();
            btnDiagnostic = new Button();
            btnSend = new Button();
            btnCancel = new Button();
            MedicData = new GroupBox();
            txtMedicLastName = new TextBox();
            label5 = new Label();
            boxPatientInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            boxCalculator.SuspendLayout();
            MedicData.SuspendLayout();
            SuspendLayout();
            // 
            // boxPatientInfo
            // 
            boxPatientInfo.Anchor = AnchorStyles.None;
            boxPatientInfo.BackColor = Color.FromArgb(61, 90, 128);
            boxPatientInfo.BackgroundImageLayout = ImageLayout.None;
            boxPatientInfo.Controls.Add(txtTicket);
            boxPatientInfo.Controls.Add(lblTicket);
            boxPatientInfo.Controls.Add(txtMedicalCoverage);
            boxPatientInfo.Controls.Add(lblMCoverage);
            boxPatientInfo.Controls.Add(dateTimePicker1);
            boxPatientInfo.Controls.Add(txtGender);
            boxPatientInfo.Controls.Add(lblGender);
            boxPatientInfo.Controls.Add(txtDateOfBirth);
            boxPatientInfo.Controls.Add(lblDate);
            boxPatientInfo.Controls.Add(lblDateOfBirth);
            boxPatientInfo.Controls.Add(txtPatientName);
            boxPatientInfo.Controls.Add(lblPatienName);
            boxPatientInfo.FlatStyle = FlatStyle.Flat;
            boxPatientInfo.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxPatientInfo.ForeColor = SystemColors.ButtonHighlight;
            boxPatientInfo.Location = new Point(23, 24);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Padding = new Padding(3, 2, 3, 2);
            boxPatientInfo.Size = new Size(689, 122);
            boxPatientInfo.TabIndex = 0;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            boxPatientInfo.Enter += boxPatientInfo_Enter;
            // 
            // txtTicket
            // 
            txtTicket.Anchor = AnchorStyles.Left;
            txtTicket.Location = new Point(555, 32);
            txtTicket.Margin = new Padding(3, 2, 3, 2);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(129, 24);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(555, 13);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(83, 22);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Location = new Point(7, 86);
            txtMedicalCoverage.Margin = new Padding(3, 2, 3, 2);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(231, 24);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(8, 66);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(84, 22);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.CalendarFont = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(281, 32);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 24);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Left;
            txtGender.Location = new Point(555, 86);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(129, 24);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(555, 66);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(56, 22);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Anchor = AnchorStyles.Left;
            txtDateOfBirth.Location = new Point(281, 86);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(231, 24);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(281, 13);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 22);
            lblDate.TabIndex = 3;
            lblDate.Text = "Fecha: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Left;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(281, 66);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(100, 22);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Location = new Point(7, 32);
            txtPatientName.Margin = new Padding(3, 2, 3, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(231, 24);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.Anchor = AnchorStyles.Left;
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(4, 13);
            lblPatienName.Name = "lblPatienName";
            lblPatienName.Size = new Size(63, 22);
            lblPatienName.TabIndex = 0;
            lblPatienName.Text = "Nombre: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(61, 90, 128);
            groupBox1.Controls.Add(txtDiagnosis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(23, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(914, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiagnosis.Location = new Point(6, 100);
            txtDiagnosis.Margin = new Padding(3, 2, 3, 2);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(902, 91);
            txtDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            label2.Click += label2_Click;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Bottom;
            txtReason.Location = new Point(6, 48);
            txtReason.Margin = new Padding(3, 2, 3, 2);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(244, 24);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // txtMedicName
            // 
            txtMedicName.Location = new Point(19, 32);
            txtMedicName.Margin = new Padding(3, 2, 3, 2);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(178, 24);
            txtMedicName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // boxCalculator
            // 
            boxCalculator.Anchor = AnchorStyles.None;
            boxCalculator.BackColor = Color.FromArgb(61, 90, 128);
            boxCalculator.Controls.Add(txtEnfermedad);
            boxCalculator.Controls.Add(label4);
            boxCalculator.Controls.Add(txtSymtoms);
            boxCalculator.Controls.Add(lblSintomas);
            boxCalculator.Controls.Add(btnDiagnostic);
            boxCalculator.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxCalculator.ForeColor = SystemColors.ButtonHighlight;
            boxCalculator.Location = new Point(23, 391);
            boxCalculator.Margin = new Padding(3, 2, 3, 2);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Padding = new Padding(3, 2, 3, 2);
            boxCalculator.Size = new Size(394, 166);
            boxCalculator.TabIndex = 13;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Diagnosticador";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Location = new Point(162, 114);
            txtEnfermedad.Margin = new Padding(3, 2, 3, 2);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(203, 24);
            txtEnfermedad.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 116);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 16;
            label4.Text = "Posible Enfermedad:";
            // 
            // txtSymtoms
            // 
            txtSymtoms.Location = new Point(162, 75);
            txtSymtoms.Margin = new Padding(3, 2, 3, 2);
            txtSymtoms.Name = "txtSymtoms";
            txtSymtoms.Size = new Size(203, 24);
            txtSymtoms.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(30, 77);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(59, 15);
            lblSintomas.TabIndex = 14;
            lblSintomas.Text = "Sintomas:";
            // 
            // btnDiagnostic
            // 
            btnDiagnostic.BackColor = Color.FromArgb(15, 28, 46);
            btnDiagnostic.Cursor = Cursors.Hand;
            btnDiagnostic.FlatStyle = FlatStyle.Flat;
            btnDiagnostic.Location = new Point(30, 29);
            btnDiagnostic.Margin = new Padding(3, 2, 3, 2);
            btnDiagnostic.Name = "btnDiagnostic";
            btnDiagnostic.Size = new Size(218, 25);
            btnDiagnostic.TabIndex = 0;
            btnDiagnostic.Text = "Analizar Sintomas";
            btnDiagnostic.UseVisualStyleBackColor = false;
            btnDiagnostic.Click += btnDiagnostic_Click;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.BackColor = Color.FromArgb(61, 90, 128);
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(826, 519);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(111, 38);
            btnSend.TabIndex = 1;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(15, 28, 46);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(687, 519);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 38);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // MedicData
            // 
            MedicData.Anchor = AnchorStyles.None;
            MedicData.BackColor = Color.FromArgb(61, 90, 128);
            MedicData.Controls.Add(txtMedicLastName);
            MedicData.Controls.Add(txtMedicName);
            MedicData.Controls.Add(label5);
            MedicData.Controls.Add(label3);
            MedicData.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            MedicData.ForeColor = SystemColors.ButtonHighlight;
            MedicData.Location = new Point(721, 24);
            MedicData.Name = "MedicData";
            MedicData.Size = new Size(216, 122);
            MedicData.TabIndex = 15;
            MedicData.TabStop = false;
            MedicData.Text = "Datos del médico";
            MedicData.Enter += groupBox2_Enter;
            // 
            // txtMedicLastName
            // 
            txtMedicLastName.Location = new Point(19, 86);
            txtMedicLastName.Margin = new Padding(3, 2, 3, 2);
            txtMedicLastName.Name = "txtMedicLastName";
            txtMedicLastName.Size = new Size(178, 24);
            txtMedicLastName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 66);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 14;
            label5.Text = "Apellido";
            // 
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(960, 580);
            Controls.Add(MedicData);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(boxCalculator);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMedicalRecord";
            Text = "MedicalRecord";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            boxCalculator.ResumeLayout(false);
            boxCalculator.PerformLayout();
            MedicData.ResumeLayout(false);
            MedicData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxPatientInfo;
        private Label lblPatienName;
        private Label lblDate;
        private Label lblDateOfBirth;
        private TextBox txtPatientName;
        private Label lblGender;
        private TextBox txtDateOfBirth;
        private TextBox txtMedicalCoverage;
        private Label lblMCoverage;
        private DateTimePicker dateTimePicker1;
        private TextBox txtGender;
        private GroupBox groupBox1;
        private TextBox txtReason;
        private Label label1;
        private TextBox txtDiagnosis;
        private Label label2;
        private TextBox txtMedicName;
        private Label label3;
        private GroupBox boxCalculator;
        private Button btnDiagnostic;
        private Button btnSend;
        private Button btnCancel;
        private TextBox txtSymtoms;
        private Label lblSintomas;
        private TextBox txtTicket;
        private Label lblTicket;
        private TextBox txtEnfermedad;
        private Label label4;
        private GroupBox MedicData;
        private Label label5;
        private TextBox txtMedicLastName;
    }
}