namespace Venar.WF
{
    partial class FrmConsultation
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
            txtSymptoms = new TextBox();
            lblSintomas = new Label();
            btnDiagnostic = new Button();
            btnSend = new Button();
            btnCancel = new Button();
            MedicData = new GroupBox();
            txtMedicalRegistration = new TextBox();
            label6 = new Label();
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
            boxPatientInfo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxPatientInfo.ForeColor = SystemColors.ButtonHighlight;
            boxPatientInfo.Location = new Point(23, 24);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Padding = new Padding(3, 2, 3, 2);
            boxPatientInfo.Size = new Size(914, 122);
            boxPatientInfo.TabIndex = 0;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            boxPatientInfo.Enter += boxPatientInfo_Enter;
            // 
            // txtTicket
            // 
            txtTicket.Anchor = AnchorStyles.Left;
            txtTicket.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicket.Location = new Point(559, 31);
            txtTicket.Margin = new Padding(3, 2, 3, 2);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(129, 25);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(559, 12);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(74, 15);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedicalCoverage.Location = new Point(11, 85);
            txtMedicalCoverage.Margin = new Padding(3, 2, 3, 2);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(231, 25);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(12, 65);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(77, 15);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(285, 31);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 20);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Left;
            txtGender.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGender.Location = new Point(559, 85);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(129, 25);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(559, 65);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Anchor = AnchorStyles.Left;
            txtDateOfBirth.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateOfBirth.Location = new Point(285, 85);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(231, 25);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(285, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Fecha: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Left;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(285, 65);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(93, 15);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPatientName.Location = new Point(11, 31);
            txtPatientName.Margin = new Padding(3, 2, 3, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(231, 25);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.Anchor = AnchorStyles.Left;
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(8, 12);
            lblPatienName.Name = "lblPatienName";
            lblPatienName.Size = new Size(58, 15);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(23, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(447, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiagnosis.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiagnosis.Location = new Point(11, 100);
            txtDiagnosis.Margin = new Padding(3, 2, 3, 2);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(425, 91);
            txtDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 73);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            label2.Click += label2_Click;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtReason.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtReason.Location = new Point(11, 48);
            txtReason.Margin = new Padding(3, 2, 3, 2);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(244, 25);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // txtMedicName
            // 
            txtMedicName.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedicName.Location = new Point(19, 32);
            txtMedicName.Margin = new Padding(3, 2, 3, 2);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(178, 25);
            txtMedicName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // boxCalculator
            // 
            boxCalculator.Anchor = AnchorStyles.None;
            boxCalculator.BackColor = Color.FromArgb(61, 90, 128);
            boxCalculator.Controls.Add(txtEnfermedad);
            boxCalculator.Controls.Add(label4);
            boxCalculator.Controls.Add(txtSymptoms);
            boxCalculator.Controls.Add(lblSintomas);
            boxCalculator.Controls.Add(btnDiagnostic);
            boxCalculator.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxCalculator.ForeColor = SystemColors.ButtonHighlight;
            boxCalculator.Location = new Point(491, 163);
            boxCalculator.Margin = new Padding(3, 2, 3, 2);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Padding = new Padding(3, 2, 3, 2);
            boxCalculator.Size = new Size(446, 213);
            boxCalculator.TabIndex = 13;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Diagnosticador";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnfermedad.Location = new Point(17, 105);
            txtEnfermedad.Margin = new Padding(3, 2, 3, 2);
            txtEnfermedad.Multiline = true;
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(412, 48);
            txtEnfermedad.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 88);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 16;
            label4.Text = "Posible Enfermedad:";
            // 
            // txtSymptoms
            // 
            txtSymptoms.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSymptoms.Location = new Point(17, 38);
            txtSymptoms.Margin = new Padding(3, 2, 3, 2);
            txtSymptoms.Multiline = true;
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.Size = new Size(412, 48);
            txtSymptoms.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(17, 21);
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
            btnDiagnostic.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiagnostic.Location = new Point(114, 166);
            btnDiagnostic.Margin = new Padding(3, 2, 3, 2);
            btnDiagnostic.Name = "btnDiagnostic";
            btnDiagnostic.Size = new Size(218, 34);
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
            btnSend.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            MedicData.Controls.Add(txtMedicalRegistration);
            MedicData.Controls.Add(label6);
            MedicData.Controls.Add(txtMedicLastName);
            MedicData.Controls.Add(txtMedicName);
            MedicData.Controls.Add(label5);
            MedicData.Controls.Add(label3);
            MedicData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            MedicData.ForeColor = SystemColors.ButtonHighlight;
            MedicData.Location = new Point(542, 392);
            MedicData.Name = "MedicData";
            MedicData.Size = new Size(395, 122);
            MedicData.TabIndex = 15;
            MedicData.TabStop = false;
            MedicData.Text = "Datos del médico";
            MedicData.Enter += groupBox2_Enter;
            // 
            // txtMedicalRegistration
            // 
            txtMedicalRegistration.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedicalRegistration.Location = new Point(19, 77);
            txtMedicalRegistration.Margin = new Padding(3, 2, 3, 2);
            txtMedicalRegistration.Name = "txtMedicalRegistration";
            txtMedicalRegistration.Size = new Size(178, 25);
            txtMedicalRegistration.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 58);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Matricula";
            // 
            // txtMedicLastName
            // 
            txtMedicLastName.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMedicLastName.Location = new Point(207, 33);
            txtMedicLastName.Margin = new Padding(3, 2, 3, 2);
            txtMedicLastName.Name = "txtMedicLastName";
            txtMedicLastName.Size = new Size(178, 25);
            txtMedicLastName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(207, 13);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 14;
            label5.Text = "Apellido";
            // 
            // FrmConsultation
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
            Name = "FrmConsultation";
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
        private TextBox txtSymptoms;
        private Label lblSintomas;
        private TextBox txtTicket;
        private Label lblTicket;
        private TextBox txtEnfermedad;
        private Label label4;
        private GroupBox MedicData;
        private Label label5;
        private TextBox txtMedicLastName;
        private TextBox txtMedicalRegistration;
        private Label label6;
    }
}