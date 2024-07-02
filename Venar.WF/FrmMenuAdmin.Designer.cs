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
            DgvMedics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvMedics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMedics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedics.Location = new Point(12, 12);
            DgvMedics.MultiSelect = false;
            DgvMedics.Name = "DgvMedics";
            DgvMedics.ReadOnly = true;
            DgvMedics.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DgvMedics.RowTemplate.Height = 25;
            DgvMedics.Size = new Size(858, 294);
            DgvMedics.TabIndex = 0;
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateMedic.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateMedic.Location = new Point(11, 312);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(109, 31);
            btnCreateMedic.TabIndex = 1;
            btnCreateMedic.Text = "Crear Medico";
            btnCreateMedic.UseVisualStyleBackColor = true;
            btnCreateMedic.Click += btnCreateMedic_Click_1;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModifyMedic.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifyMedic.Location = new Point(126, 312);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(109, 31);
            btnModifyMedic.TabIndex = 2;
            btnModifyMedic.Text = "Modificar Medico";
            btnModifyMedic.UseVisualStyleBackColor = true;
            btnModifyMedic.Click += btnModifyMedic_Click_1;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleatMedic.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleatMedic.Location = new Point(240, 312);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(109, 31);
            btnDeleatMedic.TabIndex = 3;
            btnDeleatMedic.Text = "Eliminar Medico";
            btnDeleatMedic.UseVisualStyleBackColor = true;
            btnDeleatMedic.Click += btnDeleatMedic_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCerrar.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrar.Location = new Point(755, 313);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(115, 30);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowMedic.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowMedic.Location = new Point(876, 12);
            btnShowMedic.Margin = new Padding(0);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(83, 31);
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
            btnCreateLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateLocation.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateLocation.Location = new Point(355, 312);
            btnCreateLocation.Name = "btnCreateLocation";
            btnCreateLocation.Size = new Size(118, 31);
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