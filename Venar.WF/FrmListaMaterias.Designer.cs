﻿namespace StudentSystem.WindowsFormsCliente
{
    partial class FrmListaMaterias
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
            components = new System.ComponentModel.Container();
            DgvMedics = new DataGridView();
            ColIdMateria = new DataGridViewTextBoxColumn();
            ColCod = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColMinimo = new DataGridViewTextBoxColumn();
            ColAnio = new DataGridViewTextBoxColumn();
            ColCuat = new DataGridViewTextBoxColumn();
            medicSVCBindingSource = new BindingSource(components);
            btnCreateMedic = new Button();
            btnModifyMedic = new Button();
            btnDeleatMedic = new Button();
            BtnCerrar = new Button();
            btnShowMedic = new Button();
            labelAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvMedics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicSVCBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DgvMedics
            // 
            DgvMedics.AllowUserToAddRows = false;
            DgvMedics.AllowUserToDeleteRows = false;
            DgvMedics.BackgroundColor = Color.FromArgb(230, 242, 255);
            DgvMedics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMedics.Columns.AddRange(new DataGridViewColumn[] { ColIdMateria, ColCod, ColNombre, ColMinimo, ColAnio, ColCuat });
            DgvMedics.GridColor = Color.FromArgb(51, 153, 255);
            DgvMedics.Location = new Point(12, 39);
            DgvMedics.Name = "DgvMedics";
            DgvMedics.ReadOnly = true;
            DgvMedics.RightToLeft = RightToLeft.No;
            DgvMedics.RowHeadersWidth = 51;
            DgvMedics.RowTemplate.Height = 25;
            DgvMedics.Size = new Size(665, 257);
            DgvMedics.TabIndex = 0;
            DgvMedics.CellContentClick += DgvMedics_CellContentClick;
            // 
            // ColIdMateria
            // 
            ColIdMateria.DataPropertyName = "IdMateria";
            ColIdMateria.HeaderText = "Id";
            ColIdMateria.MinimumWidth = 6;
            ColIdMateria.Name = "ColIdMateria";
            ColIdMateria.ReadOnly = true;
            ColIdMateria.Width = 50;
            // 
            // ColCod
            // 
            ColCod.DataPropertyName = "CodMateria";
            ColCod.HeaderText = "Código";
            ColCod.MinimumWidth = 6;
            ColCod.Name = "ColCod";
            ColCod.ReadOnly = true;
            ColCod.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "NombreMateria";
            ColNombre.HeaderText = "Materia";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 300;
            // 
            // ColMinimo
            // 
            ColMinimo.DataPropertyName = "ContenidosMinimos";
            ColMinimo.HeaderText = "Contenidos minimos";
            ColMinimo.MinimumWidth = 6;
            ColMinimo.Name = "ColMinimo";
            ColMinimo.ReadOnly = true;
            ColMinimo.Width = 700;
            // 
            // ColAnio
            // 
            ColAnio.DataPropertyName = "Anio";
            ColAnio.HeaderText = "Año";
            ColAnio.MinimumWidth = 6;
            ColAnio.Name = "ColAnio";
            ColAnio.ReadOnly = true;
            ColAnio.Width = 125;
            // 
            // ColCuat
            // 
            ColCuat.DataPropertyName = "Cuatrimestre";
            ColCuat.HeaderText = "Cuatrimestre";
            ColCuat.MinimumWidth = 6;
            ColCuat.Name = "ColCuat";
            ColCuat.ReadOnly = true;
            ColCuat.Width = 125;
            // 
            // medicSVCBindingSource
            // 
            medicSVCBindingSource.DataSource = typeof(Venar.SVC.MedicSVC);
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.Location = new Point(34, 312);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(109, 22);
            btnCreateMedic.TabIndex = 1;
            btnCreateMedic.Text = "Crear Medico";
            btnCreateMedic.UseVisualStyleBackColor = true;
            btnCreateMedic.Click += btnCreatMedic_Click;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.Location = new Point(263, 312);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(109, 22);
            btnModifyMedic.TabIndex = 2;
            btnModifyMedic.Text = "Modificar Medico";
            btnModifyMedic.UseVisualStyleBackColor = true;
            btnModifyMedic.Click += btnModifyMedic_Click_1;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.Location = new Point(386, 312);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(109, 22);
            btnDeleatMedic.TabIndex = 3;
            btnDeleatMedic.Text = "Eliminar Medico";
            btnDeleatMedic.UseVisualStyleBackColor = true;
            btnDeleatMedic.Click += btnDeleatMedic_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(603, 311);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(75, 23);
            BtnCerrar.TabIndex = 4;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.Location = new Point(149, 312);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(109, 22);
            btnShowMedic.TabIndex = 7;
            btnShowMedic.Text = "Ver Medico";
            btnShowMedic.UseVisualStyleBackColor = true;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Location = new Point(34, 13);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(0, 15);
            labelAdmin.TabIndex = 8;
            // 
            // FrmListaMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 179, 255);
            ClientSize = new Size(689, 348);
            Controls.Add(labelAdmin);
            Controls.Add(btnShowMedic);
            Controls.Add(BtnCerrar);
            Controls.Add(btnDeleatMedic);
            Controls.Add(btnModifyMedic);
            Controls.Add(btnCreateMedic);
            Controls.Add(DgvMedics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaMaterias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Administrador";
            ((System.ComponentModel.ISupportInitialize)DgvMedics).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicSVCBindingSource).EndInit();
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
        private DataGridViewTextBoxColumn ColIdMateria;
        private DataGridViewTextBoxColumn ColCod;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColMinimo;
        private DataGridViewTextBoxColumn ColAnio;
        private DataGridViewTextBoxColumn ColCuat;
        private Label labelAdmin;
        private BindingSource medicSVCBindingSource;
    }
}