namespace ACTIVOS_FIJOS.Views
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnActivosFijos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDepreciacion = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnActivosFijos);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnDepreciacion);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnRetorno);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Location = new System.Drawing.Point(1, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 552);
            this.panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 60);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnActivosFijos
            // 
            this.btnActivosFijos.Location = new System.Drawing.Point(3, 81);
            this.btnActivosFijos.Name = "btnActivosFijos";
            this.btnActivosFijos.Size = new System.Drawing.Size(108, 60);
            this.btnActivosFijos.TabIndex = 3;
            this.btnActivosFijos.Text = "ACTIVOS FIJOS";
            this.btnActivosFijos.UseVisualStyleBackColor = true;
            this.btnActivosFijos.Click += new System.EventHandler(this.btnActivosFijos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(4, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 60);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "EXIT";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(4, 411);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(108, 60);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.Location = new System.Drawing.Point(4, 345);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(108, 60);
            this.btnDepreciacion.TabIndex = 7;
            this.btnDepreciacion.Text = "DEPRECIACION";
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            this.btnDepreciacion.Click += new System.EventHandler(this.btnDepreciacion_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(3, 147);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(108, 60);
            this.btnPersonal.TabIndex = 4;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnRetorno
            // 
            this.btnRetorno.Location = new System.Drawing.Point(3, 279);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(108, 60);
            this.btnRetorno.TabIndex = 6;
            this.btnRetorno.Text = "RETORNO";
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(3, 213);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(108, 60);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Text = "ASIGNAR";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Location = new System.Drawing.Point(122, 101);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 537);
            this.panelMain.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 531);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.labelHora);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 94);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVOS FIJOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(892, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(662, 34);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(35, 13);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActivosFijos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnDepreciacion;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
    }
}