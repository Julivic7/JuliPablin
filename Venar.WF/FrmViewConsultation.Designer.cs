namespace Venar.WF
{
    partial class FrmViewConsultation
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
            label3 = new Label();
            label2 = new Label();
            txtReason = new TextBox();
            label1 = new Label();
            boxCalculator = new GroupBox();
            txtEnfermedad = new TextBox();
            label4 = new Label();
            txtSymtoms = new TextBox();
            lblSintomas = new Label();
            MedicData = new GroupBox();
            txtMedicalRegistration = new TextBox();
            label6 = new Label();
            txtMedicLastName = new TextBox();
            txtMedicName = new TextBox();
            label5 = new Label();
            label7 = new Label();
            btnCancel = new Button();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            boxPatientInfo.Location = new Point(57, 42);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Size = new Size(1032, 163);
            boxPatientInfo.TabIndex = 1;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            // 
            // txtTicket
            // 
            txtTicket.Anchor = AnchorStyles.Left;
            txtTicket.Location = new Point(644, 55);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(147, 23);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Left;
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(644, 29);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(91, 18);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Anchor = AnchorStyles.Left;
            txtMedicalCoverage.Location = new Point(18, 127);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(263, 23);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.Anchor = AnchorStyles.Left;
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(19, 100);
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
            dateTimePicker1.Location = new Point(331, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Left;
            txtGender.Location = new Point(644, 127);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(147, 23);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(644, 100);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 18);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Anchor = AnchorStyles.Left;
            txtDateOfBirth.Location = new Point(331, 127);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(263, 23);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(331, 29);
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
            lblDateOfBirth.Location = new Point(331, 100);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(112, 18);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.Left;
            txtPatientName.Location = new Point(18, 55);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(263, 23);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.Anchor = AnchorStyles.Left;
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(15, 29);
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(57, 232);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 295);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiagnosis.Location = new Point(16, 148);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(1005, 120);
            txtDiagnosis.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 112);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 14;
            label3.Text = "Diagnositico:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(423, 292);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Bottom;
            txtReason.Location = new Point(9, 77);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(278, 23);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 41);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // boxCalculator
            // 
            boxCalculator.Anchor = AnchorStyles.None;
            boxCalculator.BackColor = Color.FromArgb(61, 90, 128);
            boxCalculator.Controls.Add(txtEnfermedad);
            boxCalculator.Controls.Add(label4);
            boxCalculator.Controls.Add(txtSymtoms);
            boxCalculator.Controls.Add(lblSintomas);
            boxCalculator.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxCalculator.ForeColor = SystemColors.ButtonHighlight;
            boxCalculator.Location = new Point(57, 550);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Size = new Size(436, 163);
            boxCalculator.TabIndex = 14;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Sintomas";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Location = new Point(172, 118);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(231, 23);
            txtEnfermedad.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 121);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 16;
            label4.Text = "Posible Enfermedad:";
            // 
            // txtSymtoms
            // 
            txtSymtoms.Location = new Point(172, 66);
            txtSymtoms.Name = "txtSymtoms";
            txtSymtoms.Size = new Size(231, 23);
            txtSymtoms.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(21, 69);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(73, 20);
            lblSintomas.TabIndex = 14;
            lblSintomas.Text = "Sintomas:";
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
            MedicData.Controls.Add(label7);
            MedicData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            MedicData.ForeColor = SystemColors.ButtonHighlight;
            MedicData.Location = new Point(644, 550);
            MedicData.Margin = new Padding(3, 4, 3, 4);
            MedicData.Name = "MedicData";
            MedicData.Padding = new Padding(3, 4, 3, 4);
            MedicData.Size = new Size(445, 163);
            MedicData.TabIndex = 16;
            MedicData.TabStop = false;
            MedicData.Text = "Datos del médico";
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
            label6.Location = new Point(22, 78);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 15;
            label6.Text = "Matricula";
            // 
            // txtMedicLastName
            // 
            txtMedicLastName.Location = new Point(237, 44);
            txtMedicLastName.Name = "txtMedicLastName";
            txtMedicLastName.Size = new Size(203, 23);
            txtMedicLastName.TabIndex = 13;
            // 
            // txtMedicName
            // 
            txtMedicName.Location = new Point(22, 43);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(203, 23);
            txtMedicName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(237, 18);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 14;
            label5.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 18);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 11;
            label7.Text = "Nombre";
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
            btnCancel.Location = new Point(962, 746);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 39);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.None;
            btnPrint.BackColor = Color.FromArgb(61, 90, 128);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(1105, 42);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 34);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // FrmViewConsultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(1243, 860);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(MedicData);
            Controls.Add(boxCalculator);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
            Name = "FrmViewConsultation";
            Text = "  ";
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
        private TextBox txtTicket;
        private Label lblTicket;
        private TextBox txtMedicalCoverage;
        private Label lblMCoverage;
        private DateTimePicker dateTimePicker1;
        private TextBox txtGender;
        private Label lblGender;
        private TextBox txtDateOfBirth;
        private Label lblDate;
        private Label lblDateOfBirth;
        private TextBox txtPatientName;
        private Label lblPatienName;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtReason;
        private Label label1;
        private TextBox txtDiagnosis;
        private Label label3;
        private GroupBox boxCalculator;
        private TextBox txtEnfermedad;
        private Label label4;
        private TextBox txtSymtoms;
        private Label lblSintomas;
        private GroupBox MedicData;
        private TextBox txtMedicalRegistration;
        private Label label6;
        private TextBox txtMedicLastName;
        private TextBox txtMedicName;
        private Label label5;
        private Label label7;
        private Button btnCancel;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}