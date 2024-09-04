namespace DEMOPROY1.VIews
{
    partial class ProyectoForm
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
            this.pROYECTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEMOPROYDataSet = new DEMOPROY1.DEMOPROYDataSet();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cmbPostulantes = new System.Windows.Forms.ComboBox();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.listBoxTutores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pROYECTOTableAdapter = new DEMOPROY1.DEMOPROYDataSetTableAdapters.PROYECTOTableAdapter();
            this.cmbActaMDG1 = new System.Windows.Forms.CheckBox();
            this.cmbActaMDG2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTAMDG1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aCTAMDG2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.calficacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocenteMDG2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPostulanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROYECTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dEMOPROYDataSet17 = new DEMOPROY1.DEMOPROYDataSet17();
            this.datetimepickerGestion = new System.Windows.Forms.DateTimePicker();
            this.numericUpCalificacion = new System.Windows.Forms.NumericUpDown();
            this.txtTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.txtUniversidad = new System.Windows.Forms.ComboBox();
            this.pROYECTOTableAdapter1 = new DEMOPROY1.DEMOPROYDataSet17TableAdapters.PROYECTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(474, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pROYECTOBindingSource
            // 
            this.pROYECTOBindingSource.DataMember = "PROYECTO";
            this.pROYECTOBindingSource.DataSource = this.dEMOPROYDataSet;
            // 
            // dEMOPROYDataSet
            // 
            this.dEMOPROYDataSet.DataSetName = "DEMOPROYDataSet";
            this.dEMOPROYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(209, 102);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(110, 26);
            this.txtTitulo.TabIndex = 2;
            // 
            // cmbPostulantes
            // 
            this.cmbPostulantes.FormattingEnabled = true;
            this.cmbPostulantes.Location = new System.Drawing.Point(209, 58);
            this.cmbPostulantes.Name = "cmbPostulantes";
            this.cmbPostulantes.Size = new System.Drawing.Size(121, 28);
            this.cmbPostulantes.TabIndex = 9;
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(605, 161);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(121, 28);
            this.cmbDocentes.TabIndex = 10;
            // 
            // listBoxTutores
            // 
            this.listBoxTutores.FormattingEnabled = true;
            this.listBoxTutores.Location = new System.Drawing.Point(952, 43);
            this.listBoxTutores.Name = "listBoxTutores";
            this.listBoxTutores.Size = new System.Drawing.Size(121, 28);
            this.listBoxTutores.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRO DE PROYECTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "TITULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "TIPO DE TRABAJO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "UNIVERSIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "GESTION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ACTAMGD1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ACTAMGD2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(812, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "CALIFICACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "POSTULANTE";
            // 
            // LBL5
            // 
            this.LBL5.AutoSize = true;
            this.LBL5.Location = new System.Drawing.Point(501, 164);
            this.LBL5.Name = "LBL5";
            this.LBL5.Size = new System.Drawing.Size(86, 20);
            this.LBL5.TabIndex = 23;
            this.LBL5.Text = "DOCENTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(870, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "TUTOR";
            // 
            // pROYECTOTableAdapter
            // 
            this.pROYECTOTableAdapter.ClearBeforeFill = true;
            // 
            // cmbActaMDG1
            // 
            this.cmbActaMDG1.AutoSize = true;
            this.cmbActaMDG1.Location = new System.Drawing.Point(605, 84);
            this.cmbActaMDG1.Name = "cmbActaMDG1";
            this.cmbActaMDG1.Size = new System.Drawing.Size(111, 24);
            this.cmbActaMDG1.TabIndex = 27;
            this.cmbActaMDG1.Text = "Tiene Acta";
            this.cmbActaMDG1.UseVisualStyleBackColor = true;
            // 
            // cmbActaMDG2
            // 
            this.cmbActaMDG2.AutoSize = true;
            this.cmbActaMDG2.Location = new System.Drawing.Point(605, 125);
            this.cmbActaMDG2.Name = "cmbActaMDG2";
            this.cmbActaMDG2.Size = new System.Drawing.Size(111, 24);
            this.cmbActaMDG2.TabIndex = 28;
            this.cmbActaMDG2.Text = "Tiene Acta";
            this.cmbActaMDG2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(622, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 58);
            this.button2.TabIndex = 29;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(766, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 58);
            this.button3.TabIndex = 30;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(1143, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 39);
            this.button4.TabIndex = 31;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(1268, 37);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(131, 26);
            this.txtCodigoEstudiante.TabIndex = 32;
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToOrderColumns = true;
            this.dgvProyectos.AutoGenerateColumns = false;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProyectoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.tipoTrabajoDataGridViewTextBoxColumn,
            this.universidadDataGridViewTextBoxColumn,
            this.fechaProyectoDataGridViewTextBoxColumn,
            this.aCTAMDG1DataGridViewCheckBoxColumn,
            this.aCTAMDG2DataGridViewCheckBoxColumn,
            this.calficacionDataGridViewTextBoxColumn,
            this.iDDocenteMDG2DataGridViewTextBoxColumn,
            this.iDTutorDataGridViewTextBoxColumn,
            this.iDPostulanteDataGridViewTextBoxColumn});
            this.dgvProyectos.DataSource = this.pROYECTOBindingSource1;
            this.dgvProyectos.Location = new System.Drawing.Point(-3, 318);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 62;
            this.dgvProyectos.RowTemplate.Height = 28;
            this.dgvProyectos.Size = new System.Drawing.Size(1467, 289);
            this.dgvProyectos.TabIndex = 33;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick_1);
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
            // universidadDataGridViewTextBoxColumn
            // 
            this.universidadDataGridViewTextBoxColumn.DataPropertyName = "Universidad";
            this.universidadDataGridViewTextBoxColumn.HeaderText = "Universidad";
            this.universidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.universidadDataGridViewTextBoxColumn.Name = "universidadDataGridViewTextBoxColumn";
            this.universidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaProyectoDataGridViewTextBoxColumn
            // 
            this.fechaProyectoDataGridViewTextBoxColumn.DataPropertyName = "FechaProyecto";
            this.fechaProyectoDataGridViewTextBoxColumn.HeaderText = "FechaProyecto";
            this.fechaProyectoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaProyectoDataGridViewTextBoxColumn.Name = "fechaProyectoDataGridViewTextBoxColumn";
            this.fechaProyectoDataGridViewTextBoxColumn.Width = 150;
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
            // calficacionDataGridViewTextBoxColumn
            // 
            this.calficacionDataGridViewTextBoxColumn.DataPropertyName = "Calficacion";
            this.calficacionDataGridViewTextBoxColumn.HeaderText = "Calficacion";
            this.calficacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.calficacionDataGridViewTextBoxColumn.Name = "calficacionDataGridViewTextBoxColumn";
            this.calficacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDocenteMDG2DataGridViewTextBoxColumn
            // 
            this.iDDocenteMDG2DataGridViewTextBoxColumn.DataPropertyName = "ID_DocenteMDG2";
            this.iDDocenteMDG2DataGridViewTextBoxColumn.HeaderText = "ID_DocenteMDG2";
            this.iDDocenteMDG2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDocenteMDG2DataGridViewTextBoxColumn.Name = "iDDocenteMDG2DataGridViewTextBoxColumn";
            this.iDDocenteMDG2DataGridViewTextBoxColumn.Width = 150;
            // 
            // iDTutorDataGridViewTextBoxColumn
            // 
            this.iDTutorDataGridViewTextBoxColumn.DataPropertyName = "ID_Tutor";
            this.iDTutorDataGridViewTextBoxColumn.HeaderText = "ID_Tutor";
            this.iDTutorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDTutorDataGridViewTextBoxColumn.Name = "iDTutorDataGridViewTextBoxColumn";
            this.iDTutorDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPostulanteDataGridViewTextBoxColumn
            // 
            this.iDPostulanteDataGridViewTextBoxColumn.DataPropertyName = "ID_Postulante";
            this.iDPostulanteDataGridViewTextBoxColumn.HeaderText = "ID_Postulante";
            this.iDPostulanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPostulanteDataGridViewTextBoxColumn.Name = "iDPostulanteDataGridViewTextBoxColumn";
            this.iDPostulanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // pROYECTOBindingSource1
            // 
            this.pROYECTOBindingSource1.DataMember = "PROYECTO";
            this.pROYECTOBindingSource1.DataSource = this.dEMOPROYDataSet17;
            // 
            // dEMOPROYDataSet17
            // 
            this.dEMOPROYDataSet17.DataSetName = "DEMOPROYDataSet17";
            this.dEMOPROYDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datetimepickerGestion
            // 
            this.datetimepickerGestion.Location = new System.Drawing.Point(605, 43);
            this.datetimepickerGestion.Name = "datetimepickerGestion";
            this.datetimepickerGestion.Size = new System.Drawing.Size(200, 26);
            this.datetimepickerGestion.TabIndex = 34;
            // 
            // numericUpCalificacion
            // 
            this.numericUpCalificacion.Location = new System.Drawing.Point(952, 88);
            this.numericUpCalificacion.Name = "numericUpCalificacion";
            this.numericUpCalificacion.ReadOnly = true;
            this.numericUpCalificacion.Size = new System.Drawing.Size(120, 26);
            this.numericUpCalificacion.TabIndex = 35;
            // 
            // txtTipoTrabajo
            // 
            this.txtTipoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoTrabajo.FormattingEnabled = true;
            this.txtTipoTrabajo.Items.AddRange(new object[] {
            "Tesis",
            "Proyecto de Grado",
            "Trabajo Dirigido"});
            this.txtTipoTrabajo.Location = new System.Drawing.Point(209, 144);
            this.txtTipoTrabajo.Name = "txtTipoTrabajo";
            this.txtTipoTrabajo.Size = new System.Drawing.Size(121, 28);
            this.txtTipoTrabajo.TabIndex = 36;
            // 
            // txtUniversidad
            // 
            this.txtUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUniversidad.FormattingEnabled = true;
            this.txtUniversidad.Items.AddRange(new object[] {
            "UPS"});
            this.txtUniversidad.Location = new System.Drawing.Point(209, 191);
            this.txtUniversidad.Name = "txtUniversidad";
            this.txtUniversidad.Size = new System.Drawing.Size(121, 28);
            this.txtUniversidad.TabIndex = 37;
            // 
            // pROYECTOTableAdapter1
            // 
            this.pROYECTOTableAdapter1.ClearBeforeFill = true;
            // 
            // ProyectoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 642);
            this.Controls.Add(this.txtUniversidad);
            this.Controls.Add(this.txtTipoTrabajo);
            this.Controls.Add(this.numericUpCalificacion);
            this.Controls.Add(this.datetimepickerGestion);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.txtCodigoEstudiante);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbActaMDG2);
            this.Controls.Add(this.cmbActaMDG1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LBL5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTutores);
            this.Controls.Add(this.cmbDocentes);
            this.Controls.Add(this.cmbPostulantes);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.button1);
            this.Name = "ProyectoForm";
            this.Text = "ProyectoForm";
            this.Load += new System.EventHandler(this.ProyectoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cmbPostulantes;
        private System.Windows.Forms.ComboBox cmbDocentes;
        private System.Windows.Forms.ComboBox listBoxTutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL5;
        private System.Windows.Forms.Label label11;
        private DEMOPROYDataSet dEMOPROYDataSet;
        private System.Windows.Forms.BindingSource pROYECTOBindingSource;
        private DEMOPROYDataSetTableAdapters.PROYECTOTableAdapter pROYECTOTableAdapter;
        private System.Windows.Forms.CheckBox cmbActaMDG1;
        private System.Windows.Forms.CheckBox cmbActaMDG2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.DateTimePicker datetimepickerGestion;
        private System.Windows.Forms.NumericUpDown numericUpCalificacion;
        private System.Windows.Forms.ComboBox txtTipoTrabajo;
        private System.Windows.Forms.ComboBox txtUniversidad;
        private DEMOPROYDataSet17 dEMOPROYDataSet17;
        private System.Windows.Forms.BindingSource pROYECTOBindingSource1;
        private DEMOPROYDataSet17TableAdapters.PROYECTOTableAdapter pROYECTOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTAMDG1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTAMDG2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calficacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocenteMDG2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostulanteDataGridViewTextBoxColumn;
    }
}