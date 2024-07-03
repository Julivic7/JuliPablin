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
            label3 = new Label();
            boxCalculator = new GroupBox();
            txtIllenese = new TextBox();
            lblSintomas = new Label();
            btnDiagnostic = new Button();
            btnSend = new Button();
            btnCancel = new Button();
            txtMedicName = new TextBox();
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
            boxPatientInfo.Location = new Point(25, 10);
            boxPatientInfo.Margin = new Padding(3, 2, 3, 2);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Padding = new Padding(3, 2, 3, 2);
            boxPatientInfo.Size = new Size(914, 122);
            boxPatientInfo.TabIndex = 0;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Datos del Paciente";
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(774, 28);
            txtTicket.Margin = new Padding(3, 2, 3, 2);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(129, 23);
            txtTicket.TabIndex = 12;
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicket.Location = new Point(669, 30);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(90, 20);
            lblTicket.TabIndex = 11;
            lblTicket.Text = "Nº Consulta:";
            // 
            // txtMedicalCoverage
            // 
            txtMedicalCoverage.Location = new Point(104, 83);
            txtMedicalCoverage.Margin = new Padding(3, 2, 3, 2);
            txtMedicalCoverage.Name = "txtMedicalCoverage";
            txtMedicalCoverage.Size = new Size(200, 23);
            txtMedicalCoverage.TabIndex = 10;
            // 
            // lblMCoverage
            // 
            lblMCoverage.AutoSize = true;
            lblMCoverage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMCoverage.Location = new Point(5, 83);
            lblMCoverage.Name = "lblMCoverage";
            lblMCoverage.Size = new Size(93, 20);
            lblMCoverage.TabIndex = 9;
            lblMCoverage.Text = "Obra Social: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(438, 30);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(774, 83);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(129, 23);
            txtGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(704, 86);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Genero:";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(438, 84);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(231, 23);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(371, 30);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(54, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "Fecha: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(309, 86);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(111, 20);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "F.Naciemiento: ";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(104, 30);
            txtPatientName.Margin = new Padding(3, 2, 3, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(200, 23);
            txtPatientName.TabIndex = 1;
            // 
            // lblPatienName
            // 
            lblPatienName.AutoSize = true;
            lblPatienName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatienName.Location = new Point(5, 30);
            lblPatienName.Name = "lblPatienName";
            lblPatienName.Size = new Size(71, 20);
            lblPatienName.TabIndex = 0;
            lblPatienName.Text = "Nombre: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiagnosis);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 149);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(914, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hisotria Clinca";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(200, 88);
            txtDiagnosis.Margin = new Padding(3, 2, 3, 2);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(685, 23);
            txtDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 86);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 12;
            label2.Text = "Diagnositico:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(200, 42);
            txtReason.Margin = new Padding(3, 2, 3, 2);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(685, 23);
            txtReason.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 40);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 11;
            label1.Text = "Motivo de Consulta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(575, 431);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 11;
            label3.Text = "Medico: ";
            // 
            // boxCalculator
            // 
            boxCalculator.Controls.Add(txtIllenese);
            boxCalculator.Controls.Add(lblSintomas);
            boxCalculator.Controls.Add(btnDiagnostic);
            boxCalculator.Location = new Point(25, 377);
            boxCalculator.Margin = new Padding(3, 2, 3, 2);
            boxCalculator.Name = "boxCalculator";
            boxCalculator.Padding = new Padding(3, 2, 3, 2);
            boxCalculator.Size = new Size(394, 166);
            boxCalculator.TabIndex = 13;
            boxCalculator.TabStop = false;
            boxCalculator.Text = "Diagnosticador";
            // 
            // txtIllenese
            // 
            txtIllenese.Location = new Point(164, 107);
            txtIllenese.Margin = new Padding(3, 2, 3, 2);
            txtIllenese.Name = "txtIllenese";
            txtIllenese.Size = new Size(203, 23);
            txtIllenese.TabIndex = 14;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSintomas.Location = new Point(32, 110);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(115, 15);
            lblSintomas.TabIndex = 14;
            lblSintomas.Text = "Posible Enfermedad:";
            // 
            // btnDiagnostic
            // 
            btnDiagnostic.Location = new Point(32, 39);
            btnDiagnostic.Margin = new Padding(3, 2, 3, 2);
            btnDiagnostic.Name = "btnDiagnostic";
            btnDiagnostic.Size = new Size(218, 25);
            btnDiagnostic.TabIndex = 0;
            btnDiagnostic.Text = "Analizar Sintomas";
            btnDiagnostic.UseVisualStyleBackColor = true;
            btnDiagnostic.Click += btnDiagnostic_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DodgerBlue;
            btnSend.Location = new Point(799, 477);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(111, 25);
            btnSend.TabIndex = 1;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(665, 477);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 25);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMedicName
            // 
            txtMedicName.Location = new Point(665, 434);
            txtMedicName.Margin = new Padding(3, 2, 3, 2);
            txtMedicName.Name = "txtMedicName";
            txtMedicName.Size = new Size(245, 23);
            txtMedicName.TabIndex = 13;
            // 
            // FrmMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 580);
            Controls.Add(txtMedicName);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(boxCalculator);
            Controls.Add(label3);
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
        private Label label3;
        private GroupBox boxCalculator;
        private Button btnDiagnostic;
        private Button btnSend;
        private Button btnCancel;
        private TextBox txtIllenese;
        private Label lblSintomas;
        private TextBox txtTicket;
        private Label lblTicket;
        private TextBox txtMedicName;
    }
}