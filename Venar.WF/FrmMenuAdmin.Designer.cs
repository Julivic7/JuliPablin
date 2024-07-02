namespace Venar.WF  
{
    partial class FrmMenuAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DgvMedics = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnCreateMedic = new Button();
            btnModifyMedic = new Button();
            btnDeleatMedic = new Button();
            BtnCerrar = new Button();
            btnShowMedic = new Button();
            labelAdmin = new Label();
            btnCreateLocation = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvMedics).BeginInit();
            SuspendLayout();
            // 
            // DgvMedics
            // 
            DgvMedics.AllowUserToAddRows = false;
            DgvMedics.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DgvMedics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvMedics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvMedics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMedics.BackgroundColor = Color.FromArgb(230, 242, 255);
            DgvMedics.BorderStyle = BorderStyle.None;
            DgvMedics.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 133, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvMedics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvMedics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedics.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvMedics.DefaultCellStyle = dataGridViewCellStyle3;
            DgvMedics.EnableHeadersVisualStyles = false;
            DgvMedics.Location = new Point(12, 35);
            DgvMedics.MultiSelect = false;
            DgvMedics.Name = "DgvMedics";
            DgvMedics.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvMedics.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvMedics.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DgvMedics.RowTemplate.Height = 25;
            DgvMedics.Size = new Size(858, 271);
            DgvMedics.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateMedic.BackColor = Color.FromArgb(51, 133, 255);
            btnCreateMedic.Cursor = Cursors.Hand;
            btnCreateMedic.FlatAppearance.BorderSize = 0;
            btnCreateMedic.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            btnCreateMedic.FlatStyle = FlatStyle.Flat;
            btnCreateMedic.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateMedic.ForeColor = SystemColors.ButtonHighlight;
            btnCreateMedic.Location = new Point(11, 312);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(109, 31);
            btnCreateMedic.TabIndex = 1;
            btnCreateMedic.Text = "Crear Medico";
            btnCreateMedic.UseVisualStyleBackColor = false;
            btnCreateMedic.Click += btnCreateMedic_Click_1;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModifyMedic.BackColor = Color.FromArgb(51, 133, 255);
            btnModifyMedic.Cursor = Cursors.Hand;
            btnModifyMedic.FlatAppearance.BorderSize = 0;
            btnModifyMedic.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            btnModifyMedic.FlatStyle = FlatStyle.Flat;
            btnModifyMedic.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifyMedic.ForeColor = SystemColors.ButtonHighlight;
            btnModifyMedic.Location = new Point(126, 312);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(109, 31);
            btnModifyMedic.TabIndex = 2;
            btnModifyMedic.Text = "Modificar Medico";
            btnModifyMedic.UseVisualStyleBackColor = false;
            btnModifyMedic.Click += btnModifyMedic_Click_1;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleatMedic.BackColor = Color.FromArgb(51, 133, 255);
            btnDeleatMedic.Cursor = Cursors.Hand;
            btnDeleatMedic.FlatAppearance.BorderSize = 0;
            btnDeleatMedic.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            btnDeleatMedic.FlatStyle = FlatStyle.Flat;
            btnDeleatMedic.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleatMedic.ForeColor = SystemColors.ButtonHighlight;
            btnDeleatMedic.Location = new Point(240, 312);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(109, 31);
            btnDeleatMedic.TabIndex = 3;
            btnDeleatMedic.Text = "Eliminar Medico";
            btnDeleatMedic.UseVisualStyleBackColor = false;
            btnDeleatMedic.Click += btnDeleatMedic_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCerrar.BackColor = Color.FromArgb(51, 133, 255);
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCerrar.ForeColor = SystemColors.ButtonHighlight;
            BtnCerrar.Location = new Point(755, 313);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(115, 30);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowMedic.BackColor = Color.FromArgb(51, 133, 255);
            btnShowMedic.FlatAppearance.BorderSize = 0;
            btnShowMedic.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            btnShowMedic.FlatStyle = FlatStyle.Flat;
            btnShowMedic.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowMedic.ForeColor = SystemColors.ButtonHighlight;
            btnShowMedic.Location = new Point(875, 35);
            btnShowMedic.Margin = new Padding(0);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(83, 31);
            btnShowMedic.TabIndex = 7;
            btnShowMedic.Text = "Refresh";
            btnShowMedic.UseVisualStyleBackColor = false;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdmin.ForeColor = SystemColors.ButtonHighlight;
            labelAdmin.Location = new Point(12, 9);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(90, 23);
            labelAdmin.TabIndex = 8;
            labelAdmin.Text = "Bienvenido";
            labelAdmin.Click += labelAdmin_Click;
            // 
            // btnCreateLocation
            // 
            btnCreateLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateLocation.BackColor = Color.FromArgb(51, 133, 255);
            btnCreateLocation.Cursor = Cursors.Hand;
            btnCreateLocation.FlatAppearance.BorderSize = 0;
            btnCreateLocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 150, 224);
            btnCreateLocation.FlatStyle = FlatStyle.Flat;
            btnCreateLocation.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateLocation.ForeColor = SystemColors.ButtonHighlight;
            btnCreateLocation.Location = new Point(355, 312);
            btnCreateLocation.Name = "btnCreateLocation";
            btnCreateLocation.Size = new Size(118, 31);
            btnCreateLocation.TabIndex = 9;
            btnCreateLocation.Text = "Cargar Localidad";
            btnCreateLocation.UseVisualStyleBackColor = false;
            btnCreateLocation.Click += btnCreateLocation_Click;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 179, 255);
            ClientSize = new Size(964, 348);
            Controls.Add(btnCreateLocation);
            Controls.Add(labelAdmin);
            Controls.Add(btnShowMedic);
            Controls.Add(BtnCerrar);
            Controls.Add(btnDeleatMedic);
            Controls.Add(btnModifyMedic);
            Controls.Add(btnCreateMedic);
            Controls.Add(DgvMedics);
            Name = "FrmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Administrador";
            ((System.ComponentModel.ISupportInitialize)DgvMedics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvMedics;
        private Button btnCreateMedic;
        private Button btnModifyMedic;
        private Button btnDeleatMedic;
        private Button BtnCerrar;
        private Button btnShowMedic;
        private Label labelAdmin;
        private Button btnCreateLocation;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}