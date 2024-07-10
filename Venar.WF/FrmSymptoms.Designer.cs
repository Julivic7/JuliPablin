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
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            btnCheckSymptoms = new Button();
            lblResult = new Label();
            checkedListBox1 = new CheckedListBox();
            btnSend = new Button();
            btnCancel = new Button();
            boxPatientInfo = new GroupBox();
            txtResults = new TextBox();
            groupBox1 = new GroupBox();
            txtMatchPercentage = new TextBox();
            label1 = new Label();
            boxPatientInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckSymptoms
            // 
            btnCheckSymptoms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckSymptoms.Location = new Point(304, 12);
            btnCheckSymptoms.Name = "btnCheckSymptoms";
            btnCheckSymptoms.Size = new Size(168, 46);
            btnCheckSymptoms.TabIndex = 3;
            btnCheckSymptoms.TabStop = false;
            btnCheckSymptoms.Text = "Analizar Sintomas";
            btnCheckSymptoms.UseVisualStyleBackColor = true;
            btnCheckSymptoms.Click += btnCheck_symptoms;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.ForeColor = SystemColors.ControlLight;
            lblResult.Location = new Point(15, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 17);
            lblResult.TabIndex = 4;
            lblResult.Text = "Resultados:";
            lblResult.Click += lblResult_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(267, 576);
            checkedListBox1.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.Location = new Point(634, 557);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(97, 31);
            btnSend.TabIndex = 6;
            btnSend.TabStop = false;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(531, 557);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 31);
            btnCancel.TabIndex = 8;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // boxPatientInfo
            // 
            boxPatientInfo.Anchor = AnchorStyles.None;
            boxPatientInfo.BackColor = Color.FromArgb(61, 90, 128);
            boxPatientInfo.BackgroundImageLayout = ImageLayout.None;
            boxPatientInfo.Controls.Add(txtResults);
            boxPatientInfo.Controls.Add(lblResult);
            boxPatientInfo.FlatStyle = FlatStyle.Flat;
            boxPatientInfo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            boxPatientInfo.ForeColor = SystemColors.ButtonHighlight;
            boxPatientInfo.Location = new Point(304, 80);
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
            txtResults.Location = new Point(128, 40);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(282, 201);
            txtResults.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(61, 90, 128);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txtMatchPercentage);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(304, 365);
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
            txtMatchPercentage.Location = new Point(169, 45);
            txtMatchPercentage.Multiline = true;
            txtMatchPercentage.Name = "txtMatchPercentage";
            txtMatchPercentage.Size = new Size(241, 56);
            txtMatchPercentage.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 4;
            label1.Text = "Mayor Probabilidad:";
            // 
            // FrmSymptoms
            // 
            BackColor = Color.FromArgb(31, 58, 95);
            ClientSize = new Size(751, 629);
            Controls.Add(groupBox1);
            Controls.Add(boxPatientInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(btnCheckSymptoms);
            Controls.Add(checkedListBox1);
            Name = "FrmSymptoms";
            Text = "Symptom Checker";
            boxPatientInfo.ResumeLayout(false);
            boxPatientInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label1;
    }
}