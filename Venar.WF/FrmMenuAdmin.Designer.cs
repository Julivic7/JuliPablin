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
            btnShowMedic = new Button();
            label5 = new Label();
            PnlControlBtns = new Panel();
            label3 = new Label();
            btnCreatePatient = new Button();
            label1 = new Label();
            labelAdmin = new Label();
            button1 = new Button();
            panelContenedor = new Panel();
            PnlControlBtns.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowMedic
            // 
            btnShowMedic.BackColor = Color.FromArgb(102, 179, 255);
            btnShowMedic.BackgroundImage = Properties.Resources.agregar_usuario;
            btnShowMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowMedic.Cursor = Cursors.Hand;
            btnShowMedic.FlatAppearance.BorderColor = Color.Black;
            btnShowMedic.FlatAppearance.BorderSize = 2;
            btnShowMedic.FlatAppearance.MouseDownBackColor = Color.White;
            btnShowMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowMedic.FlatStyle = FlatStyle.Flat;
            btnShowMedic.Location = new Point(126, 52);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(50, 35);
            btnShowMedic.TabIndex = 10;
            btnShowMedic.UseVisualStyleBackColor = false;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 63);
            label5.Name = "label5";
            label5.Size = new Size(64, 13);
            label5.TabIndex = 16;
            label5.Text = "Ver Medico";
            label5.Click += label5_Click;
            // 
            // PnlControlBtns
            // 
            PnlControlBtns.BackColor = Color.FromArgb(51, 153, 255);
            PnlControlBtns.Controls.Add(label3);
            PnlControlBtns.Controls.Add(btnCreatePatient);
            PnlControlBtns.Controls.Add(label1);
            PnlControlBtns.Controls.Add(labelAdmin);
            PnlControlBtns.Controls.Add(button1);
            PnlControlBtns.Controls.Add(btnShowMedic);
            PnlControlBtns.Controls.Add(label5);
            PnlControlBtns.Dock = DockStyle.Left;
            PnlControlBtns.Location = new Point(0, 0);
            PnlControlBtns.Margin = new Padding(3, 2, 3, 2);
            PnlControlBtns.Name = "PnlControlBtns";
            PnlControlBtns.Size = new Size(210, 446);
            PnlControlBtns.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(74, 13);
            label3.TabIndex = 20;
            label3.Text = "Ver Pacientes";
            label3.Click += label3_Click;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.BackColor = Color.FromArgb(102, 179, 255);
            btnCreatePatient.BackgroundImage = Properties.Resources.paciente;
            btnCreatePatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePatient.Cursor = Cursors.Hand;
            btnCreatePatient.FlatAppearance.BorderColor = Color.Black;
            btnCreatePatient.FlatAppearance.BorderSize = 2;
            btnCreatePatient.FlatAppearance.MouseDownBackColor = Color.White;
            btnCreatePatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePatient.FlatStyle = FlatStyle.Flat;
            btnCreatePatient.Location = new Point(126, 109);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Size = new Size(50, 35);
            btnCreatePatient.TabIndex = 19;
            btnCreatePatient.UseVisualStyleBackColor = false;
            btnCreatePatient.Click += btnCreatePatient_Click;
            // 
            // label1
            // 
            label1.Location = new Point(117, 7);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.BackColor = Color.Transparent;
            labelAdmin.Location = new Point(3, 7);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(100, 15);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "ADMINISTRADOR";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(102, 179, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Location = new Point(35, 407);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 22);
            button1.TabIndex = 18;
            button1.Text = "cerrar sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(230, 242, 255);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(210, 0);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(732, 446);
            panelContenedor.TabIndex = 20;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(942, 446);
            Controls.Add(panelContenedor);
            Controls.Add(PnlControlBtns);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMenuAdmin";
            Text = "FrmMenuAdmin";
            PnlControlBtns.ResumeLayout(false);
            PnlControlBtns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnShowMedic;
        private Label label5;
        private Panel PnlControlBtns;
        private Button button1;
        private Panel panelContenedor;
        private Label labelAdmin;
        private Label label1;
        private Button btnCreatePatient;
        private Label label3;
    }
}