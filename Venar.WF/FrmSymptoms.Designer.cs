namespace Venar.WF
{
    partial class FrmSymptoms
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
        private System.Windows.Forms.Button btnCheckSymptoms;

        private void InitializeComponent()
        {
            btnCheckSymptoms = new Button();
            checkedListBox1 = new CheckedListBox();
            btnSend = new Button();
            btnCancel = new Button();
            boxPatientInfo = new GroupBox();
            txtResults = new TextBox();
            groupBox1 = new GroupBox();
            txtMatchPercentage = new TextBox();
            groupBox3 = new GroupBox();
            boxPatientInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckSymptoms
            // 
            btnCheckSymptoms.Anchor = AnchorStyles.Bottom;
            btnCheckSymptoms.BackColor = Color.FromArgb(31, 58, 95);
            btnCheckSymptoms.FlatAppearance.BorderSize = 0;
            btnCheckSymptoms.FlatStyle = FlatStyle.Flat;
            btnCheckSymptoms.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckSymptoms.Location = new Point(53, 403);
            btnCheckSymptoms.Name = "btnCheckSymptoms";
            btnCheckSymptoms.Size = new Size(168, 46);
            btnCheckSymptoms.TabIndex = 3;
            btnCheckSymptoms.TabStop = false;
            btnCheckSymptoms.Text = "Analizar Sintomas";
            btnCheckSymptoms.UseVisualStyleBackColor = false;
            btnCheckSymptoms.Click += btnCheck_symptoms;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 17);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(263, 364);
            checkedListBox1.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top;
            btnSend.BackColor = Color.FromArgb(61, 90, 128);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(626, 435);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(101, 42);
            btnSend.TabIndex = 6;
            btnSend.TabStop = false;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(519, 435);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 42);
            btnCancel.TabIndex = 8;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // boxPatientInfo
            // 
            boxPatientInfo.Anchor = AnchorStyles.None;
            boxPatientInfo.BackColor = Color.FromArgb(61, 90, 128);
            boxPatientInfo.BackgroundImageLayout = ImageLayout.None;
            boxPatientInfo.Controls.Add(txtResults);
            boxPatientInfo.FlatStyle = FlatStyle.Flat;
            boxPatientInfo.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxPatientInfo.ForeColor = SystemColors.ButtonHighlight;
            boxPatientInfo.Location = new Point(300, 14);
            boxPatientInfo.Margin = new Padding(0);
            boxPatientInfo.Name = "boxPatientInfo";
            boxPatientInfo.Size = new Size(427, 272);
            boxPatientInfo.TabIndex = 26;
            boxPatientInfo.TabStop = false;
            boxPatientInfo.Text = "Resultados Obtenidos";
            // 
            // txtResults
            // 
            txtResults.Anchor = AnchorStyles.Left;
            txtResults.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtResults.Location = new Point(6, 17);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(415, 249);
            txtResults.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.BackColor = Color.FromArgb(61, 90, 128);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txtMatchPercentage);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(300, 299);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 123);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Probable Enfermedad";
            // 
            // txtMatchPercentage
            // 
            txtMatchPercentage.Anchor = AnchorStyles.Left;
            txtMatchPercentage.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatchPercentage.Location = new Point(6, 14);
            txtMatchPercentage.Multiline = true;
            txtMatchPercentage.Name = "txtMatchPercentage";
            txtMatchPercentage.Size = new Size(415, 103);
            txtMatchPercentage.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.FromArgb(61, 90, 128);
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(checkedListBox1);
            groupBox3.Controls.Add(btnCheckSymptoms);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(10, 14);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 463);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sintomas presentados";
            // 
            // FrmSymptoms
            // 
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(736, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Name = "FrmSymptoms";
            Text = "Symptom Checker";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btnSend;
        private Button btnCancel;
        private GroupBox boxPatientInfo;
        private TextBox txtResults;
        private GroupBox groupBox1;
        private TextBox txtMatchPercentage;
        private GroupBox groupBox3;
    }
}