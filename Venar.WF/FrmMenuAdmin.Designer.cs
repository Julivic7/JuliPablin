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
            btnCreateMedic = new Button();
            btnShowMedic = new Button();
            btnDeleatMedic = new Button();
            btnModifyMedic = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            PnlControlBtns = new Panel();
            btnCreatePatient = new Button();
            label1 = new Label();
            labelAdmin = new Label();
            button1 = new Button();
            panelContenedor = new Panel();
            PnlControlBtns.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateMedic
            // 
            btnCreateMedic.BackColor = Color.Teal;
            btnCreateMedic.BackgroundImage = Properties.Resources.agregar_usuario;
            btnCreateMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreateMedic.Cursor = Cursors.Hand;
            btnCreateMedic.FlatAppearance.BorderColor = Color.Black;
            btnCreateMedic.FlatAppearance.BorderSize = 2;
            btnCreateMedic.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCreateMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateMedic.FlatStyle = FlatStyle.Flat;
            btnCreateMedic.ImageAlign = ContentAlignment.TopLeft;
            btnCreateMedic.Location = new Point(129, 47);
            btnCreateMedic.Name = "btnCreateMedic";
            btnCreateMedic.Size = new Size(50, 35);
            btnCreateMedic.TabIndex = 5;
            btnCreateMedic.TextAlign = ContentAlignment.BottomCenter;
            btnCreateMedic.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCreateMedic.UseVisualStyleBackColor = false;
            btnCreateMedic.Click += btnCreateMedic_Click;
            // 
            // btnShowMedic
            // 
            btnShowMedic.BackColor = Color.Teal;
            btnShowMedic.BackgroundImage = Properties.Resources.ver;
            btnShowMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowMedic.Cursor = Cursors.Hand;
            btnShowMedic.FlatAppearance.BorderColor = Color.Black;
            btnShowMedic.FlatAppearance.BorderSize = 2;
            btnShowMedic.FlatAppearance.MouseDownBackColor = Color.White;
            btnShowMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnShowMedic.FlatStyle = FlatStyle.Flat;
            btnShowMedic.Location = new Point(129, 106);
            btnShowMedic.Name = "btnShowMedic";
            btnShowMedic.Size = new Size(50, 35);
            btnShowMedic.TabIndex = 10;
            btnShowMedic.UseVisualStyleBackColor = false;
            btnShowMedic.Click += btnShowMedic_Click;
            // 
            // btnDeleatMedic
            // 
            btnDeleatMedic.BackColor = Color.Teal;
            btnDeleatMedic.BackgroundImage = Properties.Resources.borrar_usuario;
            btnDeleatMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleatMedic.Cursor = Cursors.Hand;
            btnDeleatMedic.FlatAppearance.BorderColor = Color.Black;
            btnDeleatMedic.FlatAppearance.BorderSize = 2;
            btnDeleatMedic.FlatAppearance.MouseDownBackColor = Color.White;
            btnDeleatMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnDeleatMedic.FlatStyle = FlatStyle.Flat;
            btnDeleatMedic.Location = new Point(129, 242);
            btnDeleatMedic.Name = "btnDeleatMedic";
            btnDeleatMedic.Size = new Size(50, 35);
            btnDeleatMedic.TabIndex = 11;
            btnDeleatMedic.UseVisualStyleBackColor = false;
            // 
            // btnModifyMedic
            // 
            btnModifyMedic.BackColor = Color.Teal;
            btnModifyMedic.BackgroundImage = Properties.Resources.edicion_de_usuario;
            btnModifyMedic.BackgroundImageLayout = ImageLayout.Zoom;
            btnModifyMedic.Cursor = Cursors.Hand;
            btnModifyMedic.FlatAppearance.BorderColor = Color.Black;
            btnModifyMedic.FlatAppearance.BorderSize = 2;
            btnModifyMedic.FlatAppearance.MouseOverBackColor = Color.White;
            btnModifyMedic.FlatStyle = FlatStyle.Flat;
            btnModifyMedic.ForeColor = SystemColors.ControlLight;
            btnModifyMedic.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifyMedic.Location = new Point(129, 170);
            btnModifyMedic.Name = "btnModifyMedic";
            btnModifyMedic.Size = new Size(50, 35);
            btnModifyMedic.TabIndex = 12;
            btnModifyMedic.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 13);
            label2.TabIndex = 13;
            label2.Text = "Crear Medico";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 262);
            label3.Name = "label3";
            label3.Size = new Size(89, 13);
            label3.TabIndex = 14;
            label3.Text = "Eliminar Medico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 190);
            label4.Name = "label4";
            label4.Size = new Size(97, 13);
            label4.TabIndex = 15;
            label4.Text = "Modificar Medico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 127);
            label5.Name = "label5";
            label5.Size = new Size(64, 13);
            label5.TabIndex = 16;
            label5.Text = "Ver Medico";
            // 
            // PnlControlBtns
            // 
            PnlControlBtns.BackColor = Color.Teal;
            PnlControlBtns.Controls.Add(btnCreatePatient);
            PnlControlBtns.Controls.Add(label1);
            PnlControlBtns.Controls.Add(labelAdmin);
            PnlControlBtns.Controls.Add(button1);
            PnlControlBtns.Controls.Add(btnDeleatMedic);
            PnlControlBtns.Controls.Add(btnModifyMedic);
            PnlControlBtns.Controls.Add(btnShowMedic);
            PnlControlBtns.Controls.Add(btnCreateMedic);
            PnlControlBtns.Controls.Add(label2);
            PnlControlBtns.Controls.Add(label3);
            PnlControlBtns.Controls.Add(label4);
            PnlControlBtns.Controls.Add(label5);
            PnlControlBtns.Dock = DockStyle.Left;
            PnlControlBtns.Location = new Point(0, 0);
            PnlControlBtns.Margin = new Padding(3, 2, 3, 2);
            PnlControlBtns.Name = "PnlControlBtns";
            PnlControlBtns.Size = new Size(210, 446);
            PnlControlBtns.TabIndex = 17;
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.BackColor = Color.Teal;
            btnCreatePatient.BackgroundImage = Properties.Resources.borrar_usuario;
            btnCreatePatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePatient.Cursor = Cursors.Hand;
            btnCreatePatient.FlatAppearance.BorderColor = Color.Black;
            btnCreatePatient.FlatAppearance.BorderSize = 2;
            btnCreatePatient.FlatAppearance.MouseDownBackColor = Color.White;
            btnCreatePatient.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePatient.FlatStyle = FlatStyle.Flat;
            btnCreatePatient.Location = new Point(129, 307);
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
            button1.BackColor = Color.Teal;
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
        private Button btnCreateMedic;
        private Button btnShowMedic;
        private Button btnDeleatMedic;
        private Button btnModifyMedic;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel PnlControlBtns;
        private Button button1;
        private Panel panelContenedor;
        private Label labelAdmin;
        private Label label1;
        private Button btnCreatePatient;
    }
}