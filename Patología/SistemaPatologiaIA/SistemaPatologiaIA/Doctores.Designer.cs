namespace SistemaPatologiaIA
{
    partial class Doctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctores));
            btnAgregarDoctor = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtemail = new TextBox();
            cbDisponibilidad = new CheckBox();
            txtAnioGraduacion = new TextBox();
            txtTurnoAsignado = new TextBox();
            dtpFechaExpiracionLicencia = new DateTimePicker();
            txtNumeroLicenciaMedica = new TextBox();
            cbEstado = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtInstitucionGraduacion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEspecialidad = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnEliminarDoctor = new Button();
            btnBuscarDoctor = new Button();
            txtDoctorID = new TextBox();
            label13 = new Label();
            btnActualizarDoctor = new Button();
            dataGridViewDoctor = new DataGridView();
            btnVolver = new Button();
            btnImprimirReporte = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarDoctor
            // 
            btnAgregarDoctor.Location = new Point(197, 386);
            btnAgregarDoctor.Name = "btnAgregarDoctor";
            btnAgregarDoctor.Size = new Size(94, 29);
            btnAgregarDoctor.TabIndex = 0;
            btnAgregarDoctor.Text = "Registrar";
            btnAgregarDoctor.UseVisualStyleBackColor = true;
            btnAgregarDoctor.Click += btnAgregarDoctor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 15);
            label1.Name = "label1";
            label1.Size = new Size(190, 27);
            label1.TabIndex = 1;
            label1.Text = "Registro de Doctores";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(cbDisponibilidad);
            groupBox1.Controls.Add(txtAnioGraduacion);
            groupBox1.Controls.Add(txtTurnoAsignado);
            groupBox1.Controls.Add(dtpFechaExpiracionLicencia);
            groupBox1.Controls.Add(txtNumeroLicenciaMedica);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtInstitucionGraduacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(58, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 305);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(190, 145);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 30);
            txtemail.TabIndex = 23;
            // 
            // cbDisponibilidad
            // 
            cbDisponibilidad.AutoSize = true;
            cbDisponibilidad.Checked = true;
            cbDisponibilidad.CheckState = CheckState.Checked;
            cbDisponibilidad.Location = new Point(574, 178);
            cbDisponibilidad.Name = "cbDisponibilidad";
            cbDisponibilidad.Size = new Size(139, 26);
            cbDisponibilidad.TabIndex = 22;
            cbDisponibilidad.Text = "Esta Disponible";
            cbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // txtAnioGraduacion
            // 
            txtAnioGraduacion.Location = new Point(574, 142);
            txtAnioGraduacion.Name = "txtAnioGraduacion";
            txtAnioGraduacion.Size = new Size(125, 30);
            txtAnioGraduacion.TabIndex = 21;
            // 
            // txtTurnoAsignado
            // 
            txtTurnoAsignado.Location = new Point(574, 72);
            txtTurnoAsignado.Name = "txtTurnoAsignado";
            txtTurnoAsignado.Size = new Size(125, 30);
            txtTurnoAsignado.TabIndex = 20;
            // 
            // dtpFechaExpiracionLicencia
            // 
            dtpFechaExpiracionLicencia.Location = new Point(574, 39);
            dtpFechaExpiracionLicencia.Name = "dtpFechaExpiracionLicencia";
            dtpFechaExpiracionLicencia.Size = new Size(125, 30);
            dtpFechaExpiracionLicencia.TabIndex = 19;
            // 
            // txtNumeroLicenciaMedica
            // 
            txtNumeroLicenciaMedica.Location = new Point(190, 208);
            txtNumeroLicenciaMedica.Name = "txtNumeroLicenciaMedica";
            txtNumeroLicenciaMedica.Size = new Size(125, 30);
            txtNumeroLicenciaMedica.TabIndex = 18;
            // 
            // cbEstado
            // 
            cbEstado.AutoSize = true;
            cbEstado.Checked = true;
            cbEstado.CheckState = CheckState.Checked;
            cbEstado.Location = new Point(190, 178);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(112, 26);
            cbEstado.TabIndex = 17;
            cbEstado.Text = "Esta Activo";
            cbEstado.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(365, 178);
            label12.Name = "label12";
            label12.Size = new Size(209, 22);
            label12.TabIndex = 15;
            label12.Text = "Disponibilidad de asignación";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(365, 145);
            label11.Name = "label11";
            label11.Size = new Size(150, 22);
            label11.TabIndex = 14;
            label11.Text = "Año de Graduación";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(365, 108);
            label10.Name = "label10";
            label10.Size = new Size(195, 22);
            label10.TabIndex = 13;
            label10.Text = "Instirucion de Graduación";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(365, 75);
            label9.Name = "label9";
            label9.Size = new Size(121, 22);
            label9.TabIndex = 12;
            label9.Text = "Turno asignado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 45);
            label8.Name = "label8";
            label8.Size = new Size(172, 22);
            label8.TabIndex = 11;
            label8.Text = "Fecha de Expiración Lic";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 208);
            label7.Name = "label7";
            label7.Size = new Size(157, 22);
            label7.TabIndex = 10;
            label7.Text = " Numero de Licencia";
            label7.Click += label7_Click;
            // 
            // txtInstitucionGraduacion
            // 
            txtInstitucionGraduacion.Location = new Point(574, 105);
            txtInstitucionGraduacion.Name = "txtInstitucionGraduacion";
            txtInstitucionGraduacion.Size = new Size(125, 30);
            txtInstitucionGraduacion.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 178);
            label6.Name = "label6";
            label6.Size = new Size(57, 22);
            label6.TabIndex = 8;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 145);
            label5.Name = "label5";
            label5.Size = new Size(169, 22);
            label5.TabIndex = 6;
            label5.Text = "Fecha de Contratación";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(190, 112);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(125, 30);
            txtEspecialidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 112);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 4;
            label4.Text = "Especialidad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(190, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 30);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // btnEliminarDoctor
            // 
            btnEliminarDoctor.Location = new Point(423, 385);
            btnEliminarDoctor.Name = "btnEliminarDoctor";
            btnEliminarDoctor.Size = new Size(94, 29);
            btnEliminarDoctor.TabIndex = 4;
            btnEliminarDoctor.Text = "Eliminar";
            btnEliminarDoctor.UseVisualStyleBackColor = true;
            btnEliminarDoctor.Click += btnEliminarDoctor_Click;
            // 
            // btnBuscarDoctor
            // 
            btnBuscarDoctor.Location = new Point(315, 386);
            btnBuscarDoctor.Name = "btnBuscarDoctor";
            btnBuscarDoctor.Size = new Size(94, 29);
            btnBuscarDoctor.TabIndex = 5;
            btnBuscarDoctor.Text = "Buscar";
            btnBuscarDoctor.UseVisualStyleBackColor = true;
            btnBuscarDoctor.Click += btnBuscarDoctor_Click_1;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new Point(824, 112);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(125, 27);
            txtDoctorID.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(824, 80);
            label13.Name = "label13";
            label13.Size = new Size(76, 22);
            label13.TabIndex = 7;
            label13.Text = "IDDoctor";
            // 
            // btnActualizarDoctor
            // 
            btnActualizarDoctor.Location = new Point(532, 385);
            btnActualizarDoctor.Name = "btnActualizarDoctor";
            btnActualizarDoctor.Size = new Size(94, 29);
            btnActualizarDoctor.TabIndex = 8;
            btnActualizarDoctor.Text = "Actualizar";
            btnActualizarDoctor.UseVisualStyleBackColor = true;
            btnActualizarDoctor.Click += btnActualizarDoctor_Click;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Location = new Point(824, 149);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 51;
            dataGridViewDoctor.Size = new Size(590, 226);
            dataGridViewDoctor.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(58, 15);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnImprimirReporte
            // 
            btnImprimirReporte.Location = new Point(653, 389);
            btnImprimirReporte.Name = "btnImprimirReporte";
            btnImprimirReporte.Size = new Size(94, 29);
            btnImprimirReporte.TabIndex = 11;
            btnImprimirReporte.Text = "Imprimir Reporte";
            btnImprimirReporte.UseVisualStyleBackColor = true;
            btnImprimirReporte.Click += btnImprimirReporte_Click;
            // 
            // Doctores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1445, 450);
            Controls.Add(btnImprimirReporte);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewDoctor);
            Controls.Add(btnActualizarDoctor);
            Controls.Add(label13);
            Controls.Add(txtDoctorID);
            Controls.Add(btnBuscarDoctor);
            Controls.Add(btnEliminarDoctor);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAgregarDoctor);
            Name = "Doctores";
            Text = "Doctores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarDoctor;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtInstitucionGraduacion;
        private Label label6;
        private Label label5;
        private TextBox txtEspecialidad;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private CheckBox cbEstado;
        private TextBox txtNumeroLicenciaMedica;
        private CheckBox cbDisponibilidad;
        private TextBox txtAnioGraduacion;
        private TextBox txtTurnoAsignado;
        private DateTimePicker dtpFechaExpiracionLicencia;
        private TextBox txtemail;
        private Button btnEliminarDoctor;
        private Button btnBuscarDoctor;
        private TextBox txtDoctorID;
        private Label label13;
        private Button btnActualizarDoctor;
        private DataGridView dataGridViewDoctor;
        private Button btnVolver;
        private Button btnImprimirReporte;
    }
}