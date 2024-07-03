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
            SuspendLayout();
            // 
            // btnCheckSymptoms
            // 
            btnCheckSymptoms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckSymptoms.Location = new Point(12, 205);
            btnCheckSymptoms.Name = "btnCheckSymptoms";
            btnCheckSymptoms.Size = new Size(96, 30);
            btnCheckSymptoms.TabIndex = 3;
            btnCheckSymptoms.TabStop = false;
            btnCheckSymptoms.Text = "Calcular";
            btnCheckSymptoms.UseVisualStyleBackColor = true;
            btnCheckSymptoms.Click += btnCheck_symptoms;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.Location = new Point(27, 254);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(81, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Resultados";
            lblResult.Click += lblResult_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(558, 158);
            checkedListBox1.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSend.Location = new Point(452, 291);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(97, 31);
            btnSend.TabIndex = 6;
            btnSend.TabStop = false;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // FrmSymptoms
            // 
            ClientSize = new Size(582, 364);
            Controls.Add(btnSend);
            Controls.Add(btnCheckSymptoms);
            Controls.Add(lblResult);
            Controls.Add(checkedListBox1);
            Name = "FrmSymptoms";
            Text = "Symptom Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btnSend;
    }
}