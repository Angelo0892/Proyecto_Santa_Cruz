namespace SistemaPatologiaIA
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            btnAgregarPaciente = new Button();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            chkActivo = new CheckBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtNumeroContacto = new TextBox();
            txtDireccion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cbDoc = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            cbGenero = new ComboBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewPaciente = new DataGridView();
            btnEliminarPaciente = new Button();
            btnActualizarPaciente = new Button();
            button2 = new Button();
            btnHistorial = new Button();
            btnVolver = new Button();
            btnGenerarReporte = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPaciente.Location = new Point(40, 318);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(94, 29);
            btnAgregarPaciente.TabIndex = 0;
            btnAgregarPaciente.Text = "Agregar";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNumeroContacto);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbDoc);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(cbGenero);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 206);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(485, 29);
            label11.Name = "label11";
            label11.Size = new Size(53, 18);
            label11.TabIndex = 20;
            label11.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(494, 78);
            label10.Name = "label10";
            label10.Size = new Size(62, 18);
            label10.TabIndex = 18;
            label10.Text = "Estado";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(563, 79);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(84, 22);
            chkActivo.TabIndex = 17;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(563, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 25);
            txtEmail.TabIndex = 16;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 19;
            // 
            // txtNumeroContacto
            // 
            txtNumeroContacto.Location = new Point(354, 154);
            txtNumeroContacto.Name = "txtNumeroContacto";
            txtNumeroContacto.Size = new Size(125, 25);
            txtNumeroContacto.TabIndex = 14;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(358, 116);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 25);
            txtDireccion.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 161);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 12;
            label7.Text = "Numero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 119);
            label8.Name = "label8";
            label8.Size = new Size(89, 18);
            label8.TabIndex = 11;
            label8.Text = "Direccion";
            // 
            // cbDoc
            // 
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(358, 77);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(121, 26);
            cbDoc.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(114, 147);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(123, 25);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbGenero.Location = new Point(354, 28);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(125, 26);
            cbGenero.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 25);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 25);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 78);
            label6.Name = "label6";
            label6.Size = new Size(89, 18);
            label6.TabIndex = 4;
            label6.Text = "ID Doctor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 27);
            label5.Name = "label5";
            label5.Size = new Size(62, 18);
            label5.TabIndex = 3;
            label5.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 116);
            label4.Name = "label4";
            label4.Size = new Size(152, 18);
            label4.TabIndex = 2;
            label4.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 69);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 27);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 2;
            label1.Text = "Registro de Pacientes";
            // 
            // dataGridViewPaciente
            // 
            dataGridViewPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaciente.Location = new Point(963, 68);
            dataGridViewPaciente.Name = "dataGridViewPaciente";
            dataGridViewPaciente.RowHeadersWidth = 51;
            dataGridViewPaciente.Size = new Size(669, 188);
            dataGridViewPaciente.TabIndex = 3;
            dataGridViewPaciente.CellContentClick += dataGridViewPaciente_CellContentClick;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(162, 321);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(94, 29);
            btnEliminarPaciente.TabIndex = 4;
            btnEliminarPaciente.Text = "Eliminar";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPaciente
            // 
            btnActualizarPaciente.Location = new Point(284, 324);
            btnActualizarPaciente.Name = "btnActualizarPaciente";
            btnActualizarPaciente.Size = new Size(94, 29);
            btnActualizarPaciente.TabIndex = 5;
            btnActualizarPaciente.Text = "Actualizar";
            btnActualizarPaciente.UseVisualStyleBackColor = true;
            btnActualizarPaciente.Click += btnActualizarPaciente_Click;
            // 
            // button2
            // 
            button2.Location = new Point(422, 324);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(541, 327);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(94, 29);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(36, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(664, 326);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(94, 52);
            btnGenerarReporte.TabIndex = 9;
            btnGenerarReporte.Text = "Imprimir Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1452, 469);
            Controls.Add(btnGenerarReporte);
            Controls.Add(btnVolver);
            Controls.Add(btnHistorial);
            Controls.Add(button2);
            Controls.Add(btnActualizarPaciente);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(dataGridViewPaciente);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregarPaciente);
            Name = "Pacientes";
            Text = "Pacientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPaciente;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbGenero;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DataGridView dataGridViewPaciente;
        private ComboBox cbDoc;
        private TextBox txtNumeroContacto;
        private TextBox txtDireccion;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private CheckBox chkActivo;
        private Label label11;
        private Button btnEliminarPaciente;
        private Button btnActualizarPaciente;
        private Button button2;
        private Button btnHistorial;
        private Button btnVolver;
        private Button btnGenerarReporte;
    }
}