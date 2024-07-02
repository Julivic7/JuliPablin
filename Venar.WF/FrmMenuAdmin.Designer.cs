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
            DgvMedics = new DataGridView();
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
            DgvMedics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMedics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedics.Location = new Point(12, 39);
            DgvMedics.MultiSelect = false;
            DgvMedics.Name = "DgvMedics";
            DgvMedics.ReadOnly = true;
            DgvMedics.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DgvMedics.RowTemplate.Height = 25;
            DgvMedics.Size = new Size(858, 257);
            DgvMedics.TabIndex = 0;
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.Location = new Point(34, 312);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(109, 22);
            btnCreateMedic.TabIndex = 1;
            btnCreateMedic.Text = "Crear Medico";
            btnCreateMedic.UseVisualStyleBackColor = true;
            btnCreateMedic.Click += btnCreateMedic_Click_1;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.Location = new Point(149, 312);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(109, 22);
            btnModifyMedic.TabIndex = 2;
            btnModifyMedic.Text = "Modificar Medico";
            btnModifyMedic.UseVisualStyleBackColor = true;
            btnModifyMedic.Click += btnModifyMedic_Click_1;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.Location = new Point(263, 311);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(109, 22);
            btnDeleatMedic.TabIndex = 3;
            btnDeleatMedic.Text = "Eliminar Medico";
            btnDeleatMedic.UseVisualStyleBackColor = true;
            btnDeleatMedic.Click += btnDeleatMedic_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(794, 311);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(75, 23);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.Location = new Point(892, 39);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(61, 22);
            btnShowMedic.TabIndex = 7;
            btnShowMedic.Text = "Refresh";
            btnShowMedic.UseVisualStyleBackColor = true;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Location = new Point(34, 13);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(0, 15);
            labelAdmin.TabIndex = 8;
            // 
            // btnCreateLocation
            // 
            btnCreateLocation.Location = new Point(378, 312);
            btnCreateLocation.Name = "btnCreateLocation";
            btnCreateLocation.Size = new Size(118, 22);
            btnCreateLocation.TabIndex = 9;
            btnCreateLocation.Text = "Cargar Localidad";
            btnCreateLocation.UseVisualStyleBackColor = true;
            btnCreateLocation.Click += btnCreateLocation_Click;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}