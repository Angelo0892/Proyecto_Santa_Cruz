namespace DEMOPROY1.VIews
{
    partial class INDEX
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dEMOPROYDataSet3 = new DEMOPROY1.DEMOPROYDataSet3();
            this.vISTAPROYECTOSFALTANTESACTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter = new DEMOPROY1.DEMOPROYDataSet3TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cABALLOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cABALLOSDataSet = new DEMOPROY1.CABALLOSDataSet();
            this.cABALLOSTableAdapter = new DEMOPROY1.CABALLOSDataSetTableAdapters.CABALLOSTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.caballosDataSet1 = new DEMOPROY1.CABALLOSDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caballosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTRO DE POSTULANTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "REGISTRO DE PERFIL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "REGISTRO DE PROYECTO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(779, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(443, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "REPORTE DE PROYECTOS SIN ACTA 1 O 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(779, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(443, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "REPORTE DE DEFENSAS PENDIENTES INTERNA Y EXTERNA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(779, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(443, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "REPORTE DE POSTULANTES Y SUS TUTORADOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dEMOPROYDataSet3
            // 
            this.dEMOPROYDataSet3.DataSetName = "DEMOPROYDataSet3";
            this.dEMOPROYDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTAPROYECTOSFALTANTESACTASBindingSource
            // 
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataMember = "VISTA_PROYECTOS_FALTANTES_ACTAS";
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataSource = this.dEMOPROYDataSet3;
            // 
            // vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter
            // 
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 492);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 57);
            this.button7.TabIndex = 10;
            this.button7.Text = "REGISTRO DE DEFENSAS INTERNAS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 555);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(303, 53);
            this.button8.TabIndex = 11;
            this.button8.Text = "REGISTRO DE DEFENSA EXTERNA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cABALLOSBindingSource
            // 
            this.cABALLOSBindingSource.DataMember = "CABALLOS";
            this.cABALLOSBindingSource.DataSource = this.cABALLOSDataSet;
            // 
            // cABALLOSDataSet
            // 
            this.cABALLOSDataSet.DataSetName = "CABALLOSDataSet";
            this.cABALLOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cABALLOSTableAdapter
            // 
            this.cABALLOSTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(788, 528);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(443, 36);
            this.button9.TabIndex = 13;
            this.button9.Text = "REGISTRO DE USUARIOS";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(788, 488);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(443, 34);
            this.button10.TabIndex = 14;
            this.button10.Text = "REPORTE DE LOGS";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 221);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(303, 44);
            this.button11.TabIndex = 15;
            this.button11.Text = "REGISTRO DE DOCENTES";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 430);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(303, 56);
            this.button12.TabIndex = 16;
            this.button12.Text = "REGISTRO DE DEFENSA PERFIL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 271);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(303, 42);
            this.button13.TabIndex = 17;
            this.button13.Text = "REGISTRO TRIBUNAL";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 138);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(969, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE PROYECTOS";
            // 
            // caballosDataSet1
            // 
            this.caballosDataSet1.DataSetName = "CABALLOSDataSet";
            this.caballosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DEMOPROY1.Properties.Resources.WELCOME;
            this.pictureBox2.Location = new System.Drawing.Point(340, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 419);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DEMOPROY1.Properties.Resources.upsc;
            this.pictureBox1.Location = new System.Drawing.Point(1045, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // INDEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 641);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "INDEX";
            this.Text = "INDEX";
            this.Load += new System.EventHandler(this.INDEX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABALLOSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caballosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private DEMOPROYDataSet3 dEMOPROYDataSet3;
        private System.Windows.Forms.BindingSource vISTAPROYECTOSFALTANTESACTASBindingSource;
        private DEMOPROYDataSet3TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private CABALLOSDataSet cABALLOSDataSet;
        private System.Windows.Forms.BindingSource cABALLOSBindingSource;
        private CABALLOSDataSetTableAdapters.CABALLOSTableAdapter cABALLOSTableAdapter;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CABALLOSDataSet caballosDataSet1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}