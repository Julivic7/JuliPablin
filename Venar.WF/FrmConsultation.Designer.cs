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
            txtSymtoms = new TextBox();
            lblSintomas = new Label();
            btnDiagnostic = new Button();
            btnSend = new Button();
            btnCancel = new Button();
            MedicData = new GroupBox();
            txtMedicLastName = new TextBox();
            label5 = new Label();
            txtMedicalRegistration = new TextBox();
            label6 = new Label();
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
            boxPatientInfo.Location = new Point(26, 32);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Size = new Size(1045, 163);
            boxPatientInfo.TabIndex = 0;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            boxPatientInfo.Enter += boxPatientInfo_Enter;
            // 
            // txtTicket
            // 
            txtTicket.Anchor = AnchorStyles.Left;
            txtTicket.Location = new Point(634, 43);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(147, 23);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(634, 17);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(91, 18);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Location = new Point(8, 115);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(263, 23);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(9, 88);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(94, 18);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(321, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Left;
            txtGender.Location = new Point(634, 115);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(147, 23);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(634, 88);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 18);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Anchor = AnchorStyles.Left;
            txtDateOfBirth.Location = new Point(321, 115);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(263, 23);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(321, 17);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 18);
            lblDate.TabIndex = 3;
            lblDate.Text = "Fecha: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Left;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(321, 88);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(112, 18);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Location = new Point(8, 43);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(263, 23);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.Anchor = AnchorStyles.Left;
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(5, 17);
            lblPatienName.Name = "lblPatienName";
            lblPatienName.Size = new Size(70, 18);
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
            groupBox1.Location = new Point(26, 217);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1045, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiagnosis.Location = new Point(7, 133);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(1030, 120);
            txtDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 97);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            label2.Click += label2_Click;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Bottom;
            txtReason.Location = new Point(7, 64);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(278, 23);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // txtMedicName
            // 
            txtMedicName.Location = new Point(22, 43);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(203, 23);
            txtMedicName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 17);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
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
            boxCalculator.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxCalculator.ForeColor = SystemColors.ButtonHighlight;
            boxCalculator.Location = new Point(26, 521);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Size = new Size(450, 221);
            boxCalculator.TabIndex = 13;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Diagnosticador";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Location = new Point(185, 152);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(231, 23);
            txtEnfermedad.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 155);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 16;
            label4.Text = "Posible Enfermedad:";
            // 
            // txtSymtoms
            // 
            txtSymtoms.Location = new Point(185, 100);
            txtSymtoms.Name = "txtSymtoms";
            txtSymtoms.Size = new Size(231, 23);
            txtSymtoms.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(34, 103);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(73, 20);
            lblSintomas.TabIndex = 14;
            lblSintomas.Text = "Sintomas:";
            // 
            // btnDiagnostic
            // 
            btnDiagnostic.BackColor = Color.FromArgb(15, 28, 46);
            btnDiagnostic.Cursor = Cursors.Hand;
            btnDiagnostic.FlatStyle = FlatStyle.Flat;
            btnDiagnostic.Location = new Point(34, 39);
            btnDiagnostic.Name = "btnDiagnostic";
            btnDiagnostic.Size = new Size(249, 33);
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
            btnSend.Location = new Point(944, 692);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(127, 51);
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
            btnCancel.Location = new Point(785, 692);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 51);
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
            MedicData.Location = new Point(605, 521);
            MedicData.Margin = new Padding(3, 4, 3, 4);
            MedicData.Name = "MedicData";
            MedicData.Padding = new Padding(3, 4, 3, 4);
            MedicData.Size = new Size(458, 163);
            MedicData.TabIndex = 15;
            MedicData.TabStop = false;
            MedicData.Text = "Datos del médico";
            MedicData.Enter += groupBox2_Enter;
            // 
            // txtMedicLastName
            // 
            txtMedicLastName.Location = new Point(237, 44);
            txtMedicLastName.Name = "txtMedicLastName";
            txtMedicLastName.Size = new Size(203, 23);
            txtMedicLastName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(237, 17);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 14;
            label5.Text = "Apellido";
            // 
            // txtMedicalRegistration
            // 
            txtMedicalRegistration.Location = new Point(22, 103);
            txtMedicalRegistration.Name = "txtMedicalRegistration";
            txtMedicalRegistration.Size = new Size(203, 23);
            txtMedicalRegistration.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 77);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 15;
            label6.Text = "Matricula";
            // 
            // FrmConsultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(1097, 773);
            Controls.Add(MedicData);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(boxCalculator);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
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
        private TextBox txtSymtoms;
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