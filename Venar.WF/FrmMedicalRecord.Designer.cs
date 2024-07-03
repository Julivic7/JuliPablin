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
            txtSymtoms = new TextBox();
            lblSintomas = new Label();
            btnDiagnostic = new Button();
            btnSend = new Button();
            btnCancel = new Button();
            boxPatientInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            boxCalculator.SuspendLayout();
            SuspendLayout();
            // 
            // boxPatientInfo
            // 
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
            boxPatientInfo.Location = new Point(29, 14);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Size = new Size(1044, 163);
            boxPatientInfo.TabIndex = 0;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(884, 38);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(147, 27);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(765, 40);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(117, 25);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Location = new Point(119, 111);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(228, 27);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(6, 111);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(118, 25);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(500, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(884, 111);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(147, 27);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(804, 114);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(78, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(500, 112);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(263, 27);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(424, 40);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Fecha: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(353, 114);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(141, 25);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(119, 40);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(228, 27);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(6, 40);
            lblPatienName.Name = "lblPatienName";
            lblPatienName.Size = new Size(90, 25);
            lblPatienName.TabIndex = 0;
            lblPatienName.Text = "Nombre: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiagnosis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1044, 278);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(229, 117);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(782, 27);
            txtDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 114);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(229, 56);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(782, 27);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // txtMedicName
            // 
            txtMedicName.Location = new Point(760, 575);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(280, 27);
            txtMedicName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(657, 575);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 11;
            label3.Text = "Medico: ";
            // 
            // boxCalculator
            // 
            boxCalculator.Controls.Add(txtSymtoms);
            boxCalculator.Controls.Add(lblSintomas);
            boxCalculator.Controls.Add(btnDiagnostic);
            boxCalculator.Location = new Point(29, 503);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Size = new Size(450, 222);
            boxCalculator.TabIndex = 13;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Diagnosticador";
            // 
            // txtSymtoms
            // 
            txtSymtoms.Location = new Point(187, 143);
            txtSymtoms.Name = "txtSymtoms";
            txtSymtoms.Size = new Size(231, 27);
            txtSymtoms.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(37, 146);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(144, 20);
            lblSintomas.TabIndex = 14;
            lblSintomas.Text = "Posible Enfermedad:";
            // 
            // btnDiagnostic
            // 
            btnDiagnostic.Location = new Point(37, 52);
            btnDiagnostic.Name = "btnDiagnostic";
            btnDiagnostic.Size = new Size(249, 33);
            btnDiagnostic.TabIndex = 0;
            btnDiagnostic.Text = "Analizar Sintomas";
            btnDiagnostic.UseVisualStyleBackColor = true;
            btnDiagnostic.Click += btnDiagnostic_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DodgerBlue;
            btnSend.Location = new Point(913, 636);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(127, 33);
            btnSend.TabIndex = 1;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(760, 636);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 33);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 773);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(boxCalculator);
            Controls.Add(txtMedicName);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
            Name = "FrmMedicalRecord";
            Text = "MedicalRecord";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            boxCalculator.ResumeLayout(false);
            boxCalculator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}