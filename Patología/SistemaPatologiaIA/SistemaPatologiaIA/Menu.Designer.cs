namespace SistemaPatologiaIA
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnPaciente = new Button();
            btnDoctor = new Button();
            btndiagnost = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblHoraIngreso = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPaciente
            // 
            btnPaciente.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaciente.Location = new Point(12, 69);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(159, 48);
            btnPaciente.TabIndex = 0;
            btnPaciente.Text = "Paciente";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoctor.Location = new Point(12, 176);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(159, 45);
            btnDoctor.TabIndex = 1;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = true;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btndiagnost
            // 
            btndiagnost.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndiagnost.Location = new Point(12, 123);
            btndiagnost.Name = "btndiagnost";
            btndiagnost.Size = new Size(159, 47);
            btndiagnost.TabIndex = 2;
            btndiagnost.Text = "Diagnostico Automatico";
            btndiagnost.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(223, 25);
            label1.Name = "label1";
            label1.Size = new Size(285, 40);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Patologia";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(536, 429);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(55, 21);
            lblHoraIngreso.TabIndex = 5;
            lblHoraIngreso.Text = "label2";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 421);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar Secion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 473);
            Controls.Add(btnCerrar);
            Controls.Add(lblHoraIngreso);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btndiagnost);
            Controls.Add(btnDoctor);
            Controls.Add(btnPaciente);
            Font = new Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPaciente;
        private Button btnDoctor;
        private Button btndiagnost;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblHoraIngreso;
        private Button btnCerrar;
    }
}