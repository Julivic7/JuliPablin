namespace Venar.WF
{
    partial class FrmAllpatients
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
            dtGridAllPatients = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            lblContador = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGridAllPatients).BeginInit();
            SuspendLayout();
            // 
            // dtGridAllPatients
            // 
            dtGridAllPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridAllPatients.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dtGridAllPatients.Location = new Point(12, 26);
            dtGridAllPatients.Name = "dtGridAllPatients";
            dtGridAllPatients.RowHeadersWidth = 51;
            dtGridAllPatients.RowTemplate.Height = 29;
            dtGridAllPatients.Size = new Size(1111, 396);
            dtGridAllPatients.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(488, 458);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(12, 20);
            lblContador.TabIndex = 2;
            lblContador.Text = ":";
            // 
            // Allpatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 524);
            Controls.Add(lblContador);
            Controls.Add(dtGridAllPatients);
            Name = "Allpatients";
            Text = "Allpatients";
            ((System.ComponentModel.ISupportInitialize)dtGridAllPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridAllPatients;
        private Label lblContador;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}