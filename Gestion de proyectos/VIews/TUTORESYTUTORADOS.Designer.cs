namespace DEMOPROY1.VIews
{
    partial class TUTORESYTUTORADOS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vISTATUTORESYPOSTULANTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEMOPROYDataSet7 = new DEMOPROY1.DEMOPROYDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.vISTA_TUTORES_Y_POSTULANTESTableAdapter = new DEMOPROY1.DEMOPROYDataSet7TableAdapters.VISTA_TUTORES_Y_POSTULANTESTableAdapter();
            this.dEMOPROYDataSet15 = new DEMOPROY1.DEMOPROYDataSet15();
            this.reportePostulantesTutoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_Postulantes_TutoresTableAdapter = new DEMOPROY1.DEMOPROYDataSet15TableAdapters.Reporte_Postulantes_TutoresTableAdapter();
            this.dEMOPROYDataSet16 = new DEMOPROY1.DEMOPROYDataSet16();
            this.reportePostulantesTutoresGestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_Postulantes_Tutores_GestionTableAdapter = new DEMOPROY1.DEMOPROYDataSet16TableAdapters.Reporte_Postulantes_Tutores_GestionTableAdapter();
            this.postulanteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePostulanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTATUTORESYPOSTULANTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePostulantesTutoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePostulantesTutoresGestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postulanteIdDataGridViewTextBoxColumn,
            this.nombrePostulanteDataGridViewTextBoxColumn,
            this.nombreTutorDataGridViewTextBoxColumn,
            this.tituloProyectoDataGridViewTextBoxColumn,
            this.fechaRegistroProyectoDataGridViewTextBoxColumn,
            this.gestionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportePostulantesTutoresGestionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // vISTATUTORESYPOSTULANTESBindingSource
            // 
            this.vISTATUTORESYPOSTULANTESBindingSource.DataMember = "VISTA_TUTORES_Y_POSTULANTES";
            this.vISTATUTORESYPOSTULANTESBindingSource.DataSource = this.dEMOPROYDataSet7;
            // 
            // dEMOPROYDataSet7
            // 
            this.dEMOPROYDataSet7.DataSetName = "DEMOPROYDataSet7";
            this.dEMOPROYDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTORES Y TOTURADOS, SEMETRE Y GESTION";
            // 
            // vISTA_TUTORES_Y_POSTULANTESTableAdapter
            // 
            this.vISTA_TUTORES_Y_POSTULANTESTableAdapter.ClearBeforeFill = true;
            // 
            // dEMOPROYDataSet15
            // 
            this.dEMOPROYDataSet15.DataSetName = "DEMOPROYDataSet15";
            this.dEMOPROYDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportePostulantesTutoresBindingSource
            // 
            this.reportePostulantesTutoresBindingSource.DataMember = "Reporte_Postulantes_Tutores";
            this.reportePostulantesTutoresBindingSource.DataSource = this.dEMOPROYDataSet15;
            // 
            // reporte_Postulantes_TutoresTableAdapter
            // 
            this.reporte_Postulantes_TutoresTableAdapter.ClearBeforeFill = true;
            // 
            // dEMOPROYDataSet16
            // 
            this.dEMOPROYDataSet16.DataSetName = "DEMOPROYDataSet16";
            this.dEMOPROYDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportePostulantesTutoresGestionBindingSource
            // 
            this.reportePostulantesTutoresGestionBindingSource.DataMember = "Reporte_Postulantes_Tutores_Gestion";
            this.reportePostulantesTutoresGestionBindingSource.DataSource = this.dEMOPROYDataSet16;
            // 
            // reporte_Postulantes_Tutores_GestionTableAdapter
            // 
            this.reporte_Postulantes_Tutores_GestionTableAdapter.ClearBeforeFill = true;
            // 
            // postulanteIdDataGridViewTextBoxColumn
            // 
            this.postulanteIdDataGridViewTextBoxColumn.DataPropertyName = "PostulanteId";
            this.postulanteIdDataGridViewTextBoxColumn.HeaderText = "PostulanteId";
            this.postulanteIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postulanteIdDataGridViewTextBoxColumn.Name = "postulanteIdDataGridViewTextBoxColumn";
            this.postulanteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombrePostulanteDataGridViewTextBoxColumn
            // 
            this.nombrePostulanteDataGridViewTextBoxColumn.DataPropertyName = "NombrePostulante";
            this.nombrePostulanteDataGridViewTextBoxColumn.HeaderText = "NombrePostulante";
            this.nombrePostulanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombrePostulanteDataGridViewTextBoxColumn.Name = "nombrePostulanteDataGridViewTextBoxColumn";
            this.nombrePostulanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePostulanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreTutorDataGridViewTextBoxColumn
            // 
            this.nombreTutorDataGridViewTextBoxColumn.DataPropertyName = "NombreTutor";
            this.nombreTutorDataGridViewTextBoxColumn.HeaderText = "NombreTutor";
            this.nombreTutorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreTutorDataGridViewTextBoxColumn.Name = "nombreTutorDataGridViewTextBoxColumn";
            this.nombreTutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTutorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloProyectoDataGridViewTextBoxColumn
            // 
            this.tituloProyectoDataGridViewTextBoxColumn.DataPropertyName = "Titulo_Proyecto";
            this.tituloProyectoDataGridViewTextBoxColumn.HeaderText = "Titulo_Proyecto";
            this.tituloProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloProyectoDataGridViewTextBoxColumn.Name = "tituloProyectoDataGridViewTextBoxColumn";
            this.tituloProyectoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaRegistroProyectoDataGridViewTextBoxColumn
            // 
            this.fechaRegistroProyectoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Registro_Proyecto";
            this.fechaRegistroProyectoDataGridViewTextBoxColumn.HeaderText = "Fecha_Registro_Proyecto";
            this.fechaRegistroProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaRegistroProyectoDataGridViewTextBoxColumn.Name = "fechaRegistroProyectoDataGridViewTextBoxColumn";
            this.fechaRegistroProyectoDataGridViewTextBoxColumn.Width = 150;
            // 
            // gestionDataGridViewTextBoxColumn
            // 
            this.gestionDataGridViewTextBoxColumn.DataPropertyName = "Gestion";
            this.gestionDataGridViewTextBoxColumn.HeaderText = "Gestion";
            this.gestionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gestionDataGridViewTextBoxColumn.Name = "gestionDataGridViewTextBoxColumn";
            this.gestionDataGridViewTextBoxColumn.ReadOnly = true;
            this.gestionDataGridViewTextBoxColumn.Width = 150;
            // 
            // TUTORESYTUTORADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TUTORESYTUTORADOS";
            this.Text = "TUTORESYTUTORADOS";
            this.Load += new System.EventHandler(this.TUTORESYTUTORADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTATUTORESYPOSTULANTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePostulantesTutoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePostulantesTutoresGestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DEMOPROYDataSet7 dEMOPROYDataSet7;
        private System.Windows.Forms.BindingSource vISTATUTORESYPOSTULANTESBindingSource;
        private DEMOPROYDataSet7TableAdapters.VISTA_TUTORES_Y_POSTULANTESTableAdapter vISTA_TUTORES_Y_POSTULANTESTableAdapter;
        private DEMOPROYDataSet15 dEMOPROYDataSet15;
        private System.Windows.Forms.BindingSource reportePostulantesTutoresBindingSource;
        private DEMOPROYDataSet15TableAdapters.Reporte_Postulantes_TutoresTableAdapter reporte_Postulantes_TutoresTableAdapter;
        private DEMOPROYDataSet16 dEMOPROYDataSet16;
        private System.Windows.Forms.BindingSource reportePostulantesTutoresGestionBindingSource;
        private DEMOPROYDataSet16TableAdapters.Reporte_Postulantes_Tutores_GestionTableAdapter reporte_Postulantes_Tutores_GestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postulanteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePostulanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionDataGridViewTextBoxColumn;
    }
}