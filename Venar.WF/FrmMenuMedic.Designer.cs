namespace Venar.WF
{
    partial class FrmMenuMedic
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
            label7 = new Label();
            label4 = new Label();
            button1 = new Button();
            btnShowPatient = new Button();
            btnFinishSession = new Button();
            btnCreatePatient = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(22, 163);
            label7.Name = "label7";
            label7.Size = new Size(145, 26);
            label7.TabIndex = 19;
            label7.Text = "Buscar  Pacientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(22, 251);
            label4.Name = "label4";
            label4.Size = new Size(148, 26);
            label4.TabIndex = 16;
            label4.Text = "Analizar Sintomas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImage = Properties.Resources.analizar;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(36, 280);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnShowPatient
            // 
            btnShowPatient.BackColor = SystemColors.HotTrack;
            btnShowPatient.BackgroundImage = Properties.Resources.optometrista;
            btnShowPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPatient.Cursor = Cursors.Hand;
            btnShowPatient.FlatAppearance.BorderSize = 0;
            btnShowPatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowPatient.FlatStyle = FlatStyle.Flat;
            btnShowPatient.Location = new Point(36, 192);
            btnShowPatient.Name = "btnShowPatient";
            btnShowPatient.Size = new Size(121, 33);
            btnShowPatient.TabIndex = 10;
            btnShowPatient.UseVisualStyleBackColor = false;
            btnShowPatient.Click += btnShowPatient_Click;
            // 
            // btnFinishSession
            // 
            btnFinishSession.BackColor = SystemColors.HotTrack;
            btnFinishSession.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnFinishSession.FlatStyle = FlatStyle.Flat;
            btnFinishSession.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinishSession.ForeColor = SystemColors.ButtonHighlight;
            btnFinishSession.Location = new Point(49, 343);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(95, 29);
            btnFinishSession.TabIndex = 9;
            btnFinishSession.Text = "Cerrar Sesion";
            btnFinishSession.UseVisualStyleBackColor = false;
            btnFinishSession.Click += btnFinishSession_Click;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.BackColor = SystemColors.HotTrack;
            btnCreatePatient.BackgroundImage = Properties.Resources.paciente;
            btnCreatePatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePatient.Cursor = Cursors.Hand;
            btnCreatePatient.FlatAppearance.BorderSize = 0;
            btnCreatePatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePatient.FlatStyle = FlatStyle.Flat;
            btnCreatePatient.Location = new Point(36, 106);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(121, 31);
            btnCreatePatient.TabIndex = 5;
            btnCreatePatient.UseVisualStyleBackColor = false;
            btnCreatePatient.Click += btnCreatePatient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 26);
            label1.TabIndex = 0;
            label1.Text = "MEDICO";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnFinishSession);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreatePatient);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnShowPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 393);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 77);
            label2.Name = "label2";
            label2.Size = new Size(129, 26);
            label2.TabIndex = 14;
            label2.Text = "Nuevo Paciente";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(230, 242, 255);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(193, 0);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(895, 393);
            panelContenedor.TabIndex = 24;
            // 
            // FrmMenuMedic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1088, 393);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuMedic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuMedic";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnShowPatient;
        private Button btnFinishSession;
        private Button btnCreatePatient;
        private Label label1;
        private Button button1;
        private Label label7;
        private Label label4;
        private Panel panel1;
        private Panel panelContenedor;
        private Label label2;
    }
}