namespace Venar.WF
{
    partial class FrmCreatePatient
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label8 = new Label();
            btnRegistar = new Button();
            txtDniPat = new TextBox();
            txtLastNamePat = new TextBox();
            txtNamePat = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            cmbLocations = new ComboBox();
            cmbCoverMed = new ComboBox();
            cmbGenders = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(152, 235);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2024, 5, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(225, 34);
            label1.TabIndex = 6;
            label1.Text = "REGISTRAR PACIENTE";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(460, 197);
            label8.Name = "label8";
            label8.Size = new Size(100, 22);
            label8.TabIndex = 21;
            label8.Text = "OBRA SOCIAL:";
            // 
            // btnRegistar
            // 
            btnRegistar.Anchor = AnchorStyles.None;
            btnRegistar.BackColor = SystemColors.HotTrack;
            btnRegistar.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistar.Location = new Point(335, 342);
            btnRegistar.Margin = new Padding(3, 2, 3, 2);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(178, 42);
            btnRegistar.TabIndex = 20;
            btnRegistar.Text = "REGISTRAR";
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtDniPat
            // 
            txtDniPat.Anchor = AnchorStyles.None;
            txtDniPat.BackColor = Color.WhiteSmoke;
            txtDniPat.Location = new Point(123, 198);
            txtDniPat.Margin = new Padding(3, 2, 3, 2);
            txtDniPat.Name = "txtDniPat";
            txtDniPat.Size = new Size(309, 23);
            txtDniPat.TabIndex = 16;
            // 
            // txtLastNamePat
            // 
            txtLastNamePat.Anchor = AnchorStyles.None;
            txtLastNamePat.BackColor = Color.WhiteSmoke;
            txtLastNamePat.Location = new Point(123, 161);
            txtLastNamePat.Margin = new Padding(3, 2, 3, 2);
            txtLastNamePat.Name = "txtLastNamePat";
            txtLastNamePat.Size = new Size(309, 23);
            txtLastNamePat.TabIndex = 15;
            // 
            // txtNamePat
            // 
            txtNamePat.Anchor = AnchorStyles.None;
            txtNamePat.BackColor = Color.WhiteSmoke;
            txtNamePat.Location = new Point(123, 126);
            txtNamePat.Margin = new Padding(3, 2, 3, 2);
            txtNamePat.Name = "txtNamePat";
            txtNamePat.Size = new Size(309, 23);
            txtNamePat.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(474, 161);
            label7.Name = "label7";
            label7.Size = new Size(86, 22);
            label7.TabIndex = 13;
            label7.Text = "LOCALIDAD:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(495, 127);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 12;
            label6.Text = "GENERO:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(34, 235);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 11;
            label5.Text = "FECHA DE NAC.:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(81, 198);
            label4.Name = "label4";
            label4.Size = new Size(36, 22);
            label4.TabIndex = 10;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 161);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 9;
            label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(50, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 8;
            label2.Text = "NOMBRE:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.unnamed_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(366, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(566, 161);
            label10.Name = "label10";
            label10.Size = new Size(0, 13);
            label10.TabIndex = 27;
            // 
            // cmbLocations
            // 
            cmbLocations.Anchor = AnchorStyles.None;
            cmbLocations.FormattingEnabled = true;
            cmbLocations.Location = new Point(566, 160);
            cmbLocations.Name = "cmbLocations";
            cmbLocations.Size = new Size(248, 23);
            cmbLocations.TabIndex = 28;
            // 
            // cmbCoverMed
            // 
            cmbCoverMed.Anchor = AnchorStyles.None;
            cmbCoverMed.FormattingEnabled = true;
            cmbCoverMed.Location = new Point(566, 197);
            cmbCoverMed.Name = "cmbCoverMed";
            cmbCoverMed.Size = new Size(248, 23);
            cmbCoverMed.TabIndex = 30;
            // 
            // cmbGenders
            // 
            cmbGenders.Anchor = AnchorStyles.None;
            cmbGenders.FormattingEnabled = true;
            cmbGenders.Location = new Point(566, 126);
            cmbGenders.Name = "cmbGenders";
            cmbGenders.Size = new Size(248, 23);
            cmbGenders.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(cmbGenders);
            groupBox1.Controls.Add(cmbCoverMed);
            groupBox1.Controls.Add(cmbLocations);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNamePat);
            groupBox1.Controls.Add(txtLastNamePat);
            groupBox1.Controls.Add(txtDniPat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnRegistar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(28, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 400);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // FrmCreatePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 166, 233);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(904, 498);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCreatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label8;
        private Button btnRegistar;
        private TextBox txtDniPat;
        private TextBox txtLastNamePat;
        private TextBox txtNamePat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label10;
        private ComboBox cmbLocations;
      
        private ComboBox cmbCoverMed;
        private ComboBox cmbGenders;
        private GroupBox groupBox1;
    }
}