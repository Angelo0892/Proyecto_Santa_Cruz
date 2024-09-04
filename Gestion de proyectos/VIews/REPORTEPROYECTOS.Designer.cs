namespace DEMOPROY1.VIews
{
    partial class REPORTEPROYECTOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vISTAPROYECTOSFALTANTESACTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEMOPROYDataSet6 = new DEMOPROY1.DEMOPROYDataSet6();
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter = new DEMOPROY1.DEMOPROYDataSet6TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter();
            this.dEMOPROYDataSet14 = new DEMOPROY1.DEMOPROYDataSet14();
            this.reporteProyectosFaltanActasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_Proyectos_Faltan_ActasTableAdapter = new DEMOPROY1.DEMOPROYDataSet14TableAdapters.Reporte_Proyectos_Faltan_ActasTableAdapter();
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTAMDG1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aCTAMDG2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProyectosFaltanActasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE PROYECTOS ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FALTA DE DOCUMENTOS DE ACTA 1 O ACTA 2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProyectoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.tipoTrabajoDataGridViewTextBoxColumn,
            this.aCTAMDG1DataGridViewCheckBoxColumn,
            this.aCTAMDG2DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.reporteProyectosFaltanActasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(307, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // vISTAPROYECTOSFALTANTESACTASBindingSource
            // 
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataMember = "VISTA_PROYECTOS_FALTANTES_ACTAS";
            this.vISTAPROYECTOSFALTANTESACTASBindingSource.DataSource = this.dEMOPROYDataSet6;
            // 
            // dEMOPROYDataSet6
            // 
            this.dEMOPROYDataSet6.DataSetName = "DEMOPROYDataSet6";
            this.dEMOPROYDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter
            // 
            this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter.ClearBeforeFill = true;
            // 
            // dEMOPROYDataSet14
            // 
            this.dEMOPROYDataSet14.DataSetName = "DEMOPROYDataSet14";
            this.dEMOPROYDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteProyectosFaltanActasBindingSource
            // 
            this.reporteProyectosFaltanActasBindingSource.DataMember = "Reporte_Proyectos_Faltan_Actas";
            this.reporteProyectosFaltanActasBindingSource.DataSource = this.dEMOPROYDataSet14;
            // 
            // reporte_Proyectos_Faltan_ActasTableAdapter
            // 
            this.reporte_Proyectos_Faltan_ActasTableAdapter.ClearBeforeFill = true;
            // 
            // idProyectoDataGridViewTextBoxColumn
            // 
            this.idProyectoDataGridViewTextBoxColumn.DataPropertyName = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn.HeaderText = "Id_Proyecto";
            this.idProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProyectoDataGridViewTextBoxColumn.Name = "idProyectoDataGridViewTextBoxColumn";
            this.idProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProyectoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoTrabajoDataGridViewTextBoxColumn
            // 
            this.tipoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.HeaderText = "TipoTrabajo";
            this.tipoTrabajoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoTrabajoDataGridViewTextBoxColumn.Name = "tipoTrabajoDataGridViewTextBoxColumn";
            this.tipoTrabajoDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCTAMDG1DataGridViewCheckBoxColumn
            // 
            this.aCTAMDG1DataGridViewCheckBoxColumn.DataPropertyName = "ACTAMDG1";
            this.aCTAMDG1DataGridViewCheckBoxColumn.HeaderText = "ACTAMDG1";
            this.aCTAMDG1DataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.aCTAMDG1DataGridViewCheckBoxColumn.Name = "aCTAMDG1DataGridViewCheckBoxColumn";
            this.aCTAMDG1DataGridViewCheckBoxColumn.Width = 150;
            // 
            // aCTAMDG2DataGridViewCheckBoxColumn
            // 
            this.aCTAMDG2DataGridViewCheckBoxColumn.DataPropertyName = "ACTAMDG2";
            this.aCTAMDG2DataGridViewCheckBoxColumn.HeaderText = "ACTAMDG2";
            this.aCTAMDG2DataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.aCTAMDG2DataGridViewCheckBoxColumn.Name = "aCTAMDG2DataGridViewCheckBoxColumn";
            this.aCTAMDG2DataGridViewCheckBoxColumn.Width = 150;
            // 
            // REPORTEPROYECTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 728);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "REPORTEPROYECTOS";
            this.Text = "REPORTEPROYECTOS";
            this.Load += new System.EventHandler(this.REPORTEPROYECTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPROYECTOSFALTANTESACTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProyectosFaltanActasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DEMOPROYDataSet6 dEMOPROYDataSet6;
        private System.Windows.Forms.BindingSource vISTAPROYECTOSFALTANTESACTASBindingSource;
        private DEMOPROYDataSet6TableAdapters.VISTA_PROYECTOS_FALTANTES_ACTASTableAdapter vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter;
        private DEMOPROYDataSet14 dEMOPROYDataSet14;
        private System.Windows.Forms.BindingSource reporteProyectosFaltanActasBindingSource;
        private DEMOPROYDataSet14TableAdapters.Reporte_Proyectos_Faltan_ActasTableAdapter reporte_Proyectos_Faltan_ActasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTAMDG1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTAMDG2DataGridViewCheckBoxColumn;
    }
}