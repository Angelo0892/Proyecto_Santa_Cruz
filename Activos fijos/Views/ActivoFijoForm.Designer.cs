namespace ACTIVOS_FIJOS.Views
{
    partial class ActivoFijoForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDescripcionActivo_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteActivo = new System.Windows.Forms.Button();
            this.btnUpdateActivos = new System.Windows.Forms.Button();
            this.comboBoxCategorias_ = new System.Windows.Forms.ComboBox();
            this.txtValorAdquisicion_ = new System.Windows.Forms.TextBox();
            this.txtActivoID_ = new System.Windows.Forms.TextBox();
            this.txtCodigoActivo_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUnidades_ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUbicaciones_ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaAdquisicion_ = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewActivos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescripcionActivo = new System.Windows.Forms.TextBox();
            this.btnAdministrarNombre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.btnAgregarActivo = new System.Windows.Forms.Button();
            this.txtValorAdquisicion = new System.Windows.Forms.TextBox();
            this.txtActivoID = new System.Windows.Forms.TextBox();
            this.txtCodigoActivo = new System.Windows.Forms.TextBox();
            this.btnAdministrarUnidad = new System.Windows.Forms.Button();
            this.comboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdministrarUbicacion = new System.Windows.Forms.Button();
            this.comboBoxUbicaciones = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdministrarCategoria = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNombresActivos = new System.Windows.Forms.ComboBox();
            this.comboBoxNombreActivo_ = new System.Windows.Forms.ComboBox();
            this.txtEstado_ = new System.Windows.Forms.TextBox();
            this.btnBajaActivo = new System.Windows.Forms.Button();
            this.txtMotivoBajaActivo = new System.Windows.Forms.TextBox();
            this.txtMotivoEliminarActivo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 550);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridViewActivos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MOSTRAR ACTIVOS FIJOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMotivoEliminarActivo);
            this.groupBox2.Controls.Add(this.txtMotivoBajaActivo);
            this.groupBox2.Controls.Add(this.btnBajaActivo);
            this.groupBox2.Controls.Add(this.txtEstado_);
            this.groupBox2.Controls.Add(this.comboBoxNombreActivo_);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtDescripcionActivo_);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDeleteActivo);
            this.groupBox2.Controls.Add(this.btnUpdateActivos);
            this.groupBox2.Controls.Add(this.comboBoxCategorias_);
            this.groupBox2.Controls.Add(this.txtValorAdquisicion_);
            this.groupBox2.Controls.Add(this.txtActivoID_);
            this.groupBox2.Controls.Add(this.txtCodigoActivo_);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxUnidades_);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxUbicaciones_);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtpFechaAdquisicion_);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(705, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 512);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTIVO FIJO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 79;
            this.label17.Text = "Descripcion:";
            // 
            // txtDescripcionActivo_
            // 
            this.txtDescripcionActivo_.Location = new System.Drawing.Point(9, 349);
            this.txtDescripcionActivo_.Multiline = true;
            this.txtDescripcionActivo_.Name = "txtDescripcionActivo_";
            this.txtDescripcionActivo_.Size = new System.Drawing.Size(226, 23);
            this.txtDescripcionActivo_.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Codigo:";
            // 
            // btnDeleteActivo
            // 
            this.btnDeleteActivo.BackColor = System.Drawing.Color.Red;
            this.btnDeleteActivo.Location = new System.Drawing.Point(125, 475);
            this.btnDeleteActivo.Name = "btnDeleteActivo";
            this.btnDeleteActivo.Size = new System.Drawing.Size(110, 31);
            this.btnDeleteActivo.TabIndex = 73;
            this.btnDeleteActivo.Text = "ELIMINAR";
            this.btnDeleteActivo.UseVisualStyleBackColor = false;
            this.btnDeleteActivo.Click += new System.EventHandler(this.btnDeleteActivo_Click_1);
            // 
            // btnUpdateActivos
            // 
            this.btnUpdateActivos.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateActivos.Location = new System.Drawing.Point(9, 378);
            this.btnUpdateActivos.Name = "btnUpdateActivos";
            this.btnUpdateActivos.Size = new System.Drawing.Size(226, 27);
            this.btnUpdateActivos.TabIndex = 72;
            this.btnUpdateActivos.Text = "ACTUALIZAR";
            this.btnUpdateActivos.UseVisualStyleBackColor = false;
            this.btnUpdateActivos.Click += new System.EventHandler(this.btnUpdateActivos_Click);
            // 
            // comboBoxCategorias_
            // 
            this.comboBoxCategorias_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias_.Enabled = false;
            this.comboBoxCategorias_.FormattingEnabled = true;
            this.comboBoxCategorias_.Location = new System.Drawing.Point(9, 109);
            this.comboBoxCategorias_.Name = "comboBoxCategorias_";
            this.comboBoxCategorias_.Size = new System.Drawing.Size(226, 21);
            this.comboBoxCategorias_.TabIndex = 77;
            // 
            // txtValorAdquisicion_
            // 
            this.txtValorAdquisicion_.Location = new System.Drawing.Point(9, 188);
            this.txtValorAdquisicion_.Name = "txtValorAdquisicion_";
            this.txtValorAdquisicion_.Size = new System.Drawing.Size(226, 20);
            this.txtValorAdquisicion_.TabIndex = 74;
            // 
            // txtActivoID_
            // 
            this.txtActivoID_.Location = new System.Drawing.Point(163, 8);
            this.txtActivoID_.Name = "txtActivoID_";
            this.txtActivoID_.Size = new System.Drawing.Size(72, 20);
            this.txtActivoID_.TabIndex = 75;
            this.txtActivoID_.Visible = false;
            // 
            // txtCodigoActivo_
            // 
            this.txtCodigoActivo_.Location = new System.Drawing.Point(9, 31);
            this.txtCodigoActivo_.Name = "txtCodigoActivo_";
            this.txtCodigoActivo_.ReadOnly = true;
            this.txtCodigoActivo_.Size = new System.Drawing.Size(226, 20);
            this.txtCodigoActivo_.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estado:";
            // 
            // comboBoxUnidades_
            // 
            this.comboBoxUnidades_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidades_.FormattingEnabled = true;
            this.comboBoxUnidades_.Location = new System.Drawing.Point(9, 267);
            this.comboBoxUnidades_.Name = "comboBoxUnidades_";
            this.comboBoxUnidades_.Size = new System.Drawing.Size(226, 21);
            this.comboBoxUnidades_.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre:";
            // 
            // comboBoxUbicaciones_
            // 
            this.comboBoxUbicaciones_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUbicaciones_.FormattingEnabled = true;
            this.comboBoxUbicaciones_.Location = new System.Drawing.Point(9, 227);
            this.comboBoxUbicaciones_.Name = "comboBoxUbicaciones_";
            this.comboBoxUbicaciones_.Size = new System.Drawing.Size(226, 21);
            this.comboBoxUbicaciones_.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Categoria:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Fecha:";
            // 
            // dtpFechaAdquisicion_
            // 
            this.dtpFechaAdquisicion_.Location = new System.Drawing.Point(9, 149);
            this.dtpFechaAdquisicion_.Name = "dtpFechaAdquisicion_";
            this.dtpFechaAdquisicion_.Size = new System.Drawing.Size(226, 20);
            this.dtpFechaAdquisicion_.TabIndex = 65;
            this.dtpFechaAdquisicion_.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Ubicacion:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Valor de Adquisicion:";
            // 
            // dataGridViewActivos
            // 
            this.dataGridViewActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivos.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewActivos.Name = "dataGridViewActivos";
            this.dataGridViewActivos.Size = new System.Drawing.Size(693, 512);
            this.dataGridViewActivos.TabIndex = 83;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "REGISTRAR ACTIVO FIJO";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNombresActivos);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtDescripcionActivo);
            this.groupBox1.Controls.Add(this.btnAdministrarNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxCategorias);
            this.groupBox1.Controls.Add(this.btnAgregarActivo);
            this.groupBox1.Controls.Add(this.txtValorAdquisicion);
            this.groupBox1.Controls.Add(this.txtActivoID);
            this.groupBox1.Controls.Add(this.txtCodigoActivo);
            this.groupBox1.Controls.Add(this.btnAdministrarUnidad);
            this.groupBox1.Controls.Add(this.comboBoxUnidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdministrarUbicacion);
            this.groupBox1.Controls.Add(this.comboBoxUbicaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdministrarCategoria);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFechaAdquisicion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(254, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 512);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR ACTIVO FIJO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "Descripcion:";
            // 
            // txtDescripcionActivo
            // 
            this.txtDescripcionActivo.Location = new System.Drawing.Point(32, 356);
            this.txtDescripcionActivo.Multiline = true;
            this.txtDescripcionActivo.Name = "txtDescripcionActivo";
            this.txtDescripcionActivo.Size = new System.Drawing.Size(424, 95);
            this.txtDescripcionActivo.TabIndex = 80;
            // 
            // btnAdministrarNombre
            // 
            this.btnAdministrarNombre.BackColor = System.Drawing.Color.Cyan;
            this.btnAdministrarNombre.Location = new System.Drawing.Point(338, 78);
            this.btnAdministrarNombre.Name = "btnAdministrarNombre";
            this.btnAdministrarNombre.Size = new System.Drawing.Size(118, 20);
            this.btnAdministrarNombre.TabIndex = 78;
            this.btnAdministrarNombre.Text = "Administrar Nombre";
            this.btnAdministrarNombre.UseVisualStyleBackColor = false;
            this.btnAdministrarNombre.Click += new System.EventHandler(this.btnAdministrarNombre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Codigo:";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(32, 126);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(300, 21);
            this.comboBoxCategorias.TabIndex = 77;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // btnAgregarActivo
            // 
            this.btnAgregarActivo.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarActivo.Location = new System.Drawing.Point(32, 457);
            this.btnAgregarActivo.Name = "btnAgregarActivo";
            this.btnAgregarActivo.Size = new System.Drawing.Size(424, 40);
            this.btnAgregarActivo.TabIndex = 71;
            this.btnAgregarActivo.Text = "AÑADIR";
            this.btnAgregarActivo.UseVisualStyleBackColor = false;
            this.btnAgregarActivo.Click += new System.EventHandler(this.btnAgregarActivo_Click);
            // 
            // txtValorAdquisicion
            // 
            this.txtValorAdquisicion.Location = new System.Drawing.Point(32, 222);
            this.txtValorAdquisicion.Name = "txtValorAdquisicion";
            this.txtValorAdquisicion.Size = new System.Drawing.Size(424, 20);
            this.txtValorAdquisicion.TabIndex = 74;
            this.txtValorAdquisicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAdquisicion_KeyPress_1);
            // 
            // txtActivoID
            // 
            this.txtActivoID.Location = new System.Drawing.Point(384, 8);
            this.txtActivoID.Name = "txtActivoID";
            this.txtActivoID.Size = new System.Drawing.Size(72, 20);
            this.txtActivoID.TabIndex = 75;
            this.txtActivoID.Visible = false;
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Location = new System.Drawing.Point(32, 31);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.ReadOnly = true;
            this.txtCodigoActivo.Size = new System.Drawing.Size(424, 20);
            this.txtCodigoActivo.TabIndex = 55;
            // 
            // btnAdministrarUnidad
            // 
            this.btnAdministrarUnidad.BackColor = System.Drawing.Color.Cyan;
            this.btnAdministrarUnidad.Location = new System.Drawing.Point(338, 304);
            this.btnAdministrarUnidad.Name = "btnAdministrarUnidad";
            this.btnAdministrarUnidad.Size = new System.Drawing.Size(118, 22);
            this.btnAdministrarUnidad.TabIndex = 67;
            this.btnAdministrarUnidad.Text = "Administrar Unidad";
            this.btnAdministrarUnidad.UseVisualStyleBackColor = false;
            this.btnAdministrarUnidad.Click += new System.EventHandler(this.btnAdministrarUnidad_Click);
            // 
            // comboBoxUnidades
            // 
            this.comboBoxUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidades.FormattingEnabled = true;
            this.comboBoxUnidades.Location = new System.Drawing.Point(32, 305);
            this.comboBoxUnidades.Name = "comboBoxUnidades";
            this.comboBoxUnidades.Size = new System.Drawing.Size(300, 21);
            this.comboBoxUnidades.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Nombre:";
            // 
            // btnAdministrarUbicacion
            // 
            this.btnAdministrarUbicacion.BackColor = System.Drawing.Color.Cyan;
            this.btnAdministrarUbicacion.Location = new System.Drawing.Point(338, 260);
            this.btnAdministrarUbicacion.Name = "btnAdministrarUbicacion";
            this.btnAdministrarUbicacion.Size = new System.Drawing.Size(118, 21);
            this.btnAdministrarUbicacion.TabIndex = 68;
            this.btnAdministrarUbicacion.Text = "Administrar Ubicacion";
            this.btnAdministrarUbicacion.UseVisualStyleBackColor = false;
            this.btnAdministrarUbicacion.Click += new System.EventHandler(this.btnAdministrarUbicacion_Click);
            // 
            // comboBoxUbicaciones
            // 
            this.comboBoxUbicaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUbicaciones.FormattingEnabled = true;
            this.comboBoxUbicaciones.Location = new System.Drawing.Point(32, 260);
            this.comboBoxUbicaciones.Name = "comboBoxUbicaciones";
            this.comboBoxUbicaciones.Size = new System.Drawing.Size(300, 21);
            this.comboBoxUbicaciones.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Unidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Categoria:";
            // 
            // btnAdministrarCategoria
            // 
            this.btnAdministrarCategoria.BackColor = System.Drawing.Color.Cyan;
            this.btnAdministrarCategoria.Location = new System.Drawing.Point(338, 126);
            this.btnAdministrarCategoria.Name = "btnAdministrarCategoria";
            this.btnAdministrarCategoria.Size = new System.Drawing.Size(118, 22);
            this.btnAdministrarCategoria.TabIndex = 66;
            this.btnAdministrarCategoria.Text = "Administrar Categoria";
            this.btnAdministrarCategoria.UseVisualStyleBackColor = false;
            this.btnAdministrarCategoria.Click += new System.EventHandler(this.btnAdministrarCategoria_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Fecha:";
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(32, 174);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(424, 20);
            this.dtpFechaAdquisicion.TabIndex = 65;
            this.dtpFechaAdquisicion.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Ubicacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Valor de Adquisicion:";
            // 
            // comboBoxNombresActivos
            // 
            this.comboBoxNombresActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombresActivos.FormattingEnabled = true;
            this.comboBoxNombresActivos.Location = new System.Drawing.Point(32, 77);
            this.comboBoxNombresActivos.Name = "comboBoxNombresActivos";
            this.comboBoxNombresActivos.Size = new System.Drawing.Size(300, 21);
            this.comboBoxNombresActivos.TabIndex = 82;
            this.comboBoxNombresActivos.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombresActivos_SelectedIndexChanged);
            // 
            // comboBoxNombreActivo_
            // 
            this.comboBoxNombreActivo_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombreActivo_.Enabled = false;
            this.comboBoxNombreActivo_.FormattingEnabled = true;
            this.comboBoxNombreActivo_.Location = new System.Drawing.Point(9, 69);
            this.comboBoxNombreActivo_.Name = "comboBoxNombreActivo_";
            this.comboBoxNombreActivo_.Size = new System.Drawing.Size(226, 21);
            this.comboBoxNombreActivo_.TabIndex = 80;
            // 
            // txtEstado_
            // 
            this.txtEstado_.Location = new System.Drawing.Point(9, 310);
            this.txtEstado_.Name = "txtEstado_";
            this.txtEstado_.ReadOnly = true;
            this.txtEstado_.Size = new System.Drawing.Size(226, 20);
            this.txtEstado_.TabIndex = 81;
            // 
            // btnBajaActivo
            // 
            this.btnBajaActivo.BackColor = System.Drawing.Color.Tomato;
            this.btnBajaActivo.Location = new System.Drawing.Point(9, 475);
            this.btnBajaActivo.Name = "btnBajaActivo";
            this.btnBajaActivo.Size = new System.Drawing.Size(110, 31);
            this.btnBajaActivo.TabIndex = 82;
            this.btnBajaActivo.Text = "DAR DE BAJA";
            this.btnBajaActivo.UseVisualStyleBackColor = false;
            this.btnBajaActivo.Click += new System.EventHandler(this.btnBajaActivo_Click);
            // 
            // txtMotivoBajaActivo
            // 
            this.txtMotivoBajaActivo.Location = new System.Drawing.Point(9, 429);
            this.txtMotivoBajaActivo.Multiline = true;
            this.txtMotivoBajaActivo.Name = "txtMotivoBajaActivo";
            this.txtMotivoBajaActivo.Size = new System.Drawing.Size(110, 40);
            this.txtMotivoBajaActivo.TabIndex = 83;
            // 
            // txtMotivoEliminarActivo
            // 
            this.txtMotivoEliminarActivo.Location = new System.Drawing.Point(125, 429);
            this.txtMotivoEliminarActivo.Multiline = true;
            this.txtMotivoEliminarActivo.Name = "txtMotivoEliminarActivo";
            this.txtMotivoEliminarActivo.Size = new System.Drawing.Size(108, 40);
            this.txtMotivoEliminarActivo.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Motivo de Baja:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(122, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "Motivo de Eliminacion:";
            // 
            // ActivoFijoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ActivoFijoForm";
            this.Text = "ActivoFijoForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.TextBox txtActivoID;
        private System.Windows.Forms.TextBox txtValorAdquisicion;
        private System.Windows.Forms.Button btnAgregarActivo;
        private System.Windows.Forms.ComboBox comboBoxUnidades;
        private System.Windows.Forms.ComboBox comboBoxUbicaciones;
        private System.Windows.Forms.Button btnAdministrarUbicacion;
        private System.Windows.Forms.Button btnAdministrarUnidad;
        private System.Windows.Forms.Button btnAdministrarCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewActivos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteActivo;
        private System.Windows.Forms.Button btnUpdateActivos;
        private System.Windows.Forms.ComboBox comboBoxCategorias_;
        private System.Windows.Forms.TextBox txtValorAdquisicion_;
        private System.Windows.Forms.TextBox txtActivoID_;
        private System.Windows.Forms.TextBox txtCodigoActivo_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUnidades_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUbicaciones_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion_;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDescripcionActivo_;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDescripcionActivo;
        private System.Windows.Forms.Button btnAdministrarNombre;
        private System.Windows.Forms.ComboBox comboBoxNombresActivos;
        private System.Windows.Forms.ComboBox comboBoxNombreActivo_;
        private System.Windows.Forms.TextBox txtEstado_;
        private System.Windows.Forms.Button btnBajaActivo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMotivoEliminarActivo;
        private System.Windows.Forms.TextBox txtMotivoBajaActivo;
    }
}