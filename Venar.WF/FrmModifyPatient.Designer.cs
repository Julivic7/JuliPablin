namespace Venar.WF
{
    partial class FrmModifyPatient
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
            groupBox1 = new GroupBox();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            txtName = new TextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            cmbGenders = new ComboBox();
            cmbLocations = new ComboBox();
            cmbCoverMed = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCoverMed);
            groupBox1.Controls.Add(cmbLocations);
            groupBox1.Controls.Add(cmbGenders);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(479, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(203, 165);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(257, 27);
            dateTimePicker.TabIndex = 25;
            dateTimePicker.Value = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 247);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 15;
            label1.Text = "Domicilio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 278);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "Obra Social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 211);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 11;
            label7.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 172);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 133);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "Dni";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(203, 126);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(257, 27);
            txtDni.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 94);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(203, 87);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(257, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 49);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 27);
            txtName.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(295, 372);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(86, 31);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(388, 372);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 31);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // cmbGenders
            // 
            cmbGenders.FormattingEnabled = true;
            cmbGenders.Location = new Point(203, 203);
            cmbGenders.Margin = new Padding(3, 4, 3, 4);
            cmbGenders.Name = "cmbGenders";
            cmbGenders.Size = new Size(257, 28);
            cmbGenders.TabIndex = 32;
            // 
            // cmbLocations
            // 
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(203, 239);
            cmbLocations.Margin = new Padding(3, 4, 3, 4);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(257, 28);
            cmbLocations.TabIndex = 33;
            // 
            // cmbCoverMed
            // 
            cmbCoverMed.FormattingEnabled = true;
            cmbCoverMed.Location = new Point(203, 275);
            cmbCoverMed.Margin = new Padding(3, 4, 3, 4);
            cmbCoverMed.Name = "cmbCoverMed";
            cmbCoverMed.Size = new Size(257, 28);
            cmbCoverMed.TabIndex = 34;
            // 
            // FrmModifyPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 443);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmModifyPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modicar Medico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Label label3;
        private Label label2;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtDni;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private ComboBox cmbCoverMed;
        private ComboBox cmbLocations;
        private ComboBox cmbGenders;
    }
}