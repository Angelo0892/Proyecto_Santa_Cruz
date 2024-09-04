namespace DEMOPROY1.VIews
{
    partial class DEFENSAINTERNA
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxObservaciones = new System.Windows.Forms.CheckBox();
            this.checkBoxAprobada = new System.Windows.Forms.CheckBox();
            this.listTribunal = new System.Windows.Forms.ListBox();
            this.listTribunal2 = new System.Windows.Forms.ListBox();
            this.listProyectos = new System.Windows.Forms.ListBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDefensas = new System.Windows.Forms.DataGridView();
            this.numericUpCalificacion = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPostulantes = new System.Windows.Forms.ComboBox();
            this.dEMOPROYDataSet18 = new DEMOPROY1.DEMOPROYDataSet18();
            this.dEFENSAINTERNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEFENSA_INTERNATableAdapter = new DEMOPROY1.DEMOPROYDataSet18TableAdapters.DEFENSA_INTERNATableAdapter();
            this.idDefensaInternaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDefensaInternaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aprobadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.calficacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTribunal1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTribunal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefensas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEFENSAINTERNABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE DEFENSA INTERNA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha De Defensa Interna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado de Defensa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre del Primer Tribunal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del Segundo Tribunal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Titulo del proyecto Postulado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(547, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(683, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(832, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxObservaciones
            // 
            this.checkBoxObservaciones.AutoSize = true;
            this.checkBoxObservaciones.Location = new System.Drawing.Point(763, 183);
            this.checkBoxObservaciones.Name = "checkBoxObservaciones";
            this.checkBoxObservaciones.Size = new System.Drawing.Size(118, 24);
            this.checkBoxObservaciones.TabIndex = 13;
            this.checkBoxObservaciones.Text = "Levantadas";
            this.checkBoxObservaciones.UseVisualStyleBackColor = true;
            // 
            // checkBoxAprobada
            // 
            this.checkBoxAprobada.AutoSize = true;
            this.checkBoxAprobada.Location = new System.Drawing.Point(763, 229);
            this.checkBoxAprobada.Name = "checkBoxAprobada";
            this.checkBoxAprobada.Size = new System.Drawing.Size(105, 24);
            this.checkBoxAprobada.TabIndex = 14;
            this.checkBoxAprobada.Text = "Aprobado";
            this.checkBoxAprobada.UseVisualStyleBackColor = true;
            // 
            // listTribunal
            // 
            this.listTribunal.FormattingEnabled = true;
            this.listTribunal.ItemHeight = 20;
            this.listTribunal.Location = new System.Drawing.Point(280, 136);
            this.listTribunal.Name = "listTribunal";
            this.listTribunal.Size = new System.Drawing.Size(105, 84);
            this.listTribunal.TabIndex = 16;
            this.listTribunal.SelectedIndexChanged += new System.EventHandler(this.listTribunal_SelectedIndexChanged);
            // 
            // listTribunal2
            // 
            this.listTribunal2.FormattingEnabled = true;
            this.listTribunal2.ItemHeight = 20;
            this.listTribunal2.Location = new System.Drawing.Point(280, 251);
            this.listTribunal2.Name = "listTribunal2";
            this.listTribunal2.Size = new System.Drawing.Size(105, 84);
            this.listTribunal2.TabIndex = 17;
            this.listTribunal2.SelectedIndexChanged += new System.EventHandler(this.listTribunal2_SelectedIndexChanged);
            // 
            // listProyectos
            // 
            this.listProyectos.FormattingEnabled = true;
            this.listProyectos.ItemHeight = 20;
            this.listProyectos.Location = new System.Drawing.Point(407, 66);
            this.listProyectos.Name = "listProyectos";
            this.listProyectos.Size = new System.Drawing.Size(134, 24);
            this.listProyectos.TabIndex = 18;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(763, 84);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFecha.TabIndex = 19;
            // 
            // dgvDefensas
            // 
            this.dgvDefensas.AutoGenerateColumns = false;
            this.dgvDefensas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDefensas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefensas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDefensaInternaDataGridViewTextBoxColumn,
            this.fechaDefensaInternaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewCheckBoxColumn,
            this.aprobadaDataGridViewCheckBoxColumn,
            this.calficacionDataGridViewTextBoxColumn,
            this.idTribunal1DataGridViewTextBoxColumn,
            this.idTribunal2DataGridViewTextBoxColumn,
            this.idProyectoDataGridViewTextBoxColumn});
            this.dgvDefensas.DataSource = this.dEFENSAINTERNABindingSource;
            this.dgvDefensas.Location = new System.Drawing.Point(41, 353);
            this.dgvDefensas.Name = "dgvDefensas";
            this.dgvDefensas.ReadOnly = true;
            this.dgvDefensas.RowHeadersWidth = 62;
            this.dgvDefensas.RowTemplate.Height = 28;
            this.dgvDefensas.Size = new System.Drawing.Size(1118, 208);
            this.dgvDefensas.TabIndex = 20;
            this.dgvDefensas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefensas_CellContentClick);
            // 
            // numericUpCalificacion
            // 
            this.numericUpCalificacion.Location = new System.Drawing.Point(763, 136);
            this.numericUpCalificacion.Name = "numericUpCalificacion";
            this.numericUpCalificacion.ReadOnly = true;
            this.numericUpCalificacion.Size = new System.Drawing.Size(120, 26);
            this.numericUpCalificacion.TabIndex = 21;
            this.numericUpCalificacion.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpCalificacion.ValueChanged += new System.EventHandler(this.numericUpCalificacion_ValueChanged);
            // 
            // comboBoxPostulantes
            // 
            this.comboBoxPostulantes.FormattingEnabled = true;
            this.comboBoxPostulantes.Location = new System.Drawing.Point(280, 66);
            this.comboBoxPostulantes.Name = "comboBoxPostulantes";
            this.comboBoxPostulantes.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPostulantes.TabIndex = 22;
            // 
            // dEMOPROYDataSet18
            // 
            this.dEMOPROYDataSet18.DataSetName = "DEMOPROYDataSet18";
            this.dEMOPROYDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEFENSAINTERNABindingSource
            // 
            this.dEFENSAINTERNABindingSource.DataMember = "DEFENSA_INTERNA";
            this.dEFENSAINTERNABindingSource.DataSource = this.dEMOPROYDataSet18;
            // 
            // dEFENSA_INTERNATableAdapter
            // 
            this.dEFENSA_INTERNATableAdapter.ClearBeforeFill = true;
            // 
            // idDefensaInternaDataGridViewTextBoxColumn
            // 
            this.idDefensaInternaDataGridViewTextBoxColumn.DataPropertyName = "Id_DefensaInterna";
            this.idDefensaInternaDataGridViewTextBoxColumn.HeaderText = "Id_DefensaInterna";
            this.idDefensaInternaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDefensaInternaDataGridViewTextBoxColumn.Name = "idDefensaInternaDataGridViewTextBoxColumn";
            this.idDefensaInternaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDefensaInternaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDefensaInternaDataGridViewTextBoxColumn
            // 
            this.fechaDefensaInternaDataGridViewTextBoxColumn.DataPropertyName = "FechaDefensaInterna";
            this.fechaDefensaInternaDataGridViewTextBoxColumn.HeaderText = "FechaDefensaInterna";
            this.fechaDefensaInternaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDefensaInternaDataGridViewTextBoxColumn.Name = "fechaDefensaInternaDataGridViewTextBoxColumn";
            this.fechaDefensaInternaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDefensaInternaDataGridViewTextBoxColumn.Width = 150;
            // 
            // observacionesDataGridViewCheckBoxColumn
            // 
            this.observacionesDataGridViewCheckBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewCheckBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.observacionesDataGridViewCheckBoxColumn.Name = "observacionesDataGridViewCheckBoxColumn";
            this.observacionesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.observacionesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // aprobadaDataGridViewCheckBoxColumn
            // 
            this.aprobadaDataGridViewCheckBoxColumn.DataPropertyName = "Aprobada";
            this.aprobadaDataGridViewCheckBoxColumn.HeaderText = "Aprobada";
            this.aprobadaDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.aprobadaDataGridViewCheckBoxColumn.Name = "aprobadaDataGridViewCheckBoxColumn";
            this.aprobadaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aprobadaDataGridViewCheckBoxColumn.Width = 150;
            // 
            // calficacionDataGridViewTextBoxColumn
            // 
            this.calficacionDataGridViewTextBoxColumn.DataPropertyName = "Calficacion";
            this.calficacionDataGridViewTextBoxColumn.HeaderText = "Calficacion";
            this.calficacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.calficacionDataGridViewTextBoxColumn.Name = "calficacionDataGridViewTextBoxColumn";
            this.calficacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.calficacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // idTribunal1DataGridViewTextBoxColumn
            // 
            this.idTribunal1DataGridViewTextBoxColumn.DataPropertyName = "Id_Tribunal1";
            this.idTribunal1DataGridViewTextBoxColumn.HeaderText = "Id_Tribunal1";
            this.idTribunal1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idTribunal1DataGridViewTextBoxColumn.Name = "idTribunal1DataGridViewTextBoxColumn";
            this.idTribunal1DataGridViewTextBoxColumn.ReadOnly = true;
            this.idTribunal1DataGridViewTextBoxColumn.Width = 150;
            // 
            // idTribunal2DataGridViewTextBoxColumn
            // 
            this.idTribunal2DataGridViewTextBoxColumn.DataPropertyName = "Id_Tribunal2";
            this.idTribunal2DataGridViewTextBoxColumn.HeaderText = "Id_Tribunal2";
            this.idTribunal2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idTribunal2DataGridViewTextBoxColumn.Name = "idTribunal2DataGridViewTextBoxColumn";
            this.idTribunal2DataGridViewTextBoxColumn.ReadOnly = true;
            this.idTribunal2DataGridViewTextBoxColumn.Width = 150;
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
            // DEFENSAINTERNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1171, 648);
            this.Controls.Add(this.comboBoxPostulantes);
            this.Controls.Add(this.numericUpCalificacion);
            this.Controls.Add(this.dgvDefensas);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.listProyectos);
            this.Controls.Add(this.listTribunal2);
            this.Controls.Add(this.listTribunal);
            this.Controls.Add(this.checkBoxAprobada);
            this.Controls.Add(this.checkBoxObservaciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DEFENSAINTERNA";
            this.Text = "DEFENSAINTERNA";
            this.Load += new System.EventHandler(this.DEFENSAINTERNA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefensas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEFENSAINTERNABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxObservaciones;
        private System.Windows.Forms.CheckBox checkBoxAprobada;
        private System.Windows.Forms.ListBox listTribunal;
        private System.Windows.Forms.ListBox listTribunal2;
        private System.Windows.Forms.ListBox listProyectos;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dgvDefensas;
        private System.Windows.Forms.NumericUpDown numericUpCalificacion;
        private System.Windows.Forms.ComboBox comboBoxPostulantes;
        private DEMOPROYDataSet18 dEMOPROYDataSet18;
        private System.Windows.Forms.BindingSource dEFENSAINTERNABindingSource;
        private DEMOPROYDataSet18TableAdapters.DEFENSA_INTERNATableAdapter dEFENSA_INTERNATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDefensaInternaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDefensaInternaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn observacionesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aprobadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calficacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTribunal1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTribunal2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
    }
}