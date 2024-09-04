namespace SistemaPatologiaIA
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            dataGridViewHistorial = new DataGridView();
            btnActualizarHistorial = new Button();
            btnBuscarHistorial = new Button();
            btnEliminarHistorial = new Button();
            groupBox1 = new GroupBox();
            cbDoctor = new ComboBox();
            cbPaciente = new ComboBox();
            txtSintomas = new TextBox();
            txtTratamiento = new TextBox();
            dtpFechaConsulta = new DateTimePicker();
            txtDiagnostico = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtObservaciones = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregarHistorial = new Button();
            txtIdHistorial = new TextBox();
            lblidhistorial = new Label();
            btnvolver = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Location = new Point(797, 130);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.RowHeadersWidth = 51;
            dataGridViewHistorial.Size = new Size(590, 226);
            dataGridViewHistorial.TabIndex = 18;
            // 
            // btnActualizarHistorial
            // 
            btnActualizarHistorial.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarHistorial.Location = new Point(516, 379);
            btnActualizarHistorial.Name = "btnActualizarHistorial";
            btnActualizarHistorial.Size = new Size(94, 29);
            btnActualizarHistorial.TabIndex = 17;
            btnActualizarHistorial.Text = "Actualizar";
            btnActualizarHistorial.UseVisualStyleBackColor = true;
            btnActualizarHistorial.Click += btnActualizarHistorial_Click;
            // 
            // btnBuscarHistorial
            // 
            btnBuscarHistorial.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarHistorial.Location = new Point(299, 380);
            btnBuscarHistorial.Name = "btnBuscarHistorial";
            btnBuscarHistorial.Size = new Size(94, 29);
            btnBuscarHistorial.TabIndex = 14;
            btnBuscarHistorial.Text = "Buscar";
            btnBuscarHistorial.UseVisualStyleBackColor = true;
            btnBuscarHistorial.Click += btnBuscarHistorial_Click;
            // 
            // btnEliminarHistorial
            // 
            btnEliminarHistorial.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarHistorial.Location = new Point(407, 379);
            btnEliminarHistorial.Name = "btnEliminarHistorial";
            btnEliminarHistorial.Size = new Size(94, 29);
            btnEliminarHistorial.TabIndex = 13;
            btnEliminarHistorial.Text = "Eliminar";
            btnEliminarHistorial.UseVisualStyleBackColor = true;
            btnEliminarHistorial.Click += btnEliminarHistorial_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(cbDoctor);
            groupBox1.Controls.Add(cbPaciente);
            groupBox1.Controls.Add(txtSintomas);
            groupBox1.Controls.Add(txtTratamiento);
            groupBox1.Controls.Add(dtpFechaConsulta);
            groupBox1.Controls.Add(txtDiagnostico);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 305);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(190, 89);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(125, 30);
            cbDoctor.TabIndex = 25;
            // 
            // cbPaciente
            // 
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(190, 46);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(125, 30);
            cbPaciente.TabIndex = 24;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(190, 161);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(125, 30);
            txtSintomas.TabIndex = 23;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(565, 46);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(125, 30);
            txtTratamiento.TabIndex = 20;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Location = new Point(190, 125);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(125, 30);
            dtpFechaConsulta.TabIndex = 19;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(190, 208);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(125, 30);
            txtDiagnostico.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label10.Location = new Point(356, 82);
            label10.Name = "label10";
            label10.Size = new Size(125, 22);
            label10.TabIndex = 13;
            label10.Text = "Observaciones";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label9.Location = new Point(356, 49);
            label9.Name = "label9";
            label9.Size = new Size(109, 22);
            label9.TabIndex = 12;
            label9.Text = "Tratamiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label7.Location = new Point(16, 208);
            label7.Name = "label7";
            label7.Size = new Size(110, 22);
            label7.TabIndex = 10;
            label7.Text = " Diagnostico";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(565, 79);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(125, 30);
            txtObservaciones.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label5.Location = new Point(17, 164);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 6;
            label5.Text = "Sintomas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label4.Location = new Point(16, 122);
            label4.Name = "label4";
            label4.Size = new Size(156, 22);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Consulta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 2;
            label3.Text = "DoctorID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 0;
            label2.Text = "PacienteID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 44);
            label1.TabIndex = 11;
            label1.Text = "Registro de Historial";
            // 
            // btnAgregarHistorial
            // 
            btnAgregarHistorial.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarHistorial.Location = new Point(181, 380);
            btnAgregarHistorial.Name = "btnAgregarHistorial";
            btnAgregarHistorial.Size = new Size(94, 29);
            btnAgregarHistorial.TabIndex = 10;
            btnAgregarHistorial.Text = "Registrar";
            btnAgregarHistorial.UseVisualStyleBackColor = true;
            btnAgregarHistorial.Click += btnAgregarHistorial_Click;
            // 
            // txtIdHistorial
            // 
            txtIdHistorial.Location = new Point(917, 85);
            txtIdHistorial.Name = "txtIdHistorial";
            txtIdHistorial.Size = new Size(92, 27);
            txtIdHistorial.TabIndex = 19;
            // 
            // lblidhistorial
            // 
            lblidhistorial.AutoSize = true;
            lblidhistorial.BackColor = Color.Transparent;
            lblidhistorial.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold);
            lblidhistorial.Location = new Point(809, 90);
            lblidhistorial.Name = "lblidhistorial";
            lblidhistorial.Size = new Size(102, 22);
            lblidhistorial.TabIndex = 20;
            lblidhistorial.Text = "Historial ID";
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(52, 16);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(94, 29);
            btnvolver.TabIndex = 21;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(635, 384);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 22;
            btnImprimir.Text = "Imprimir Reporte";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1346, 447);
            Controls.Add(btnImprimir);
            Controls.Add(btnvolver);
            Controls.Add(lblidhistorial);
            Controls.Add(txtIdHistorial);
            Controls.Add(dataGridViewHistorial);
            Controls.Add(btnActualizarHistorial);
            Controls.Add(btnBuscarHistorial);
            Controls.Add(btnEliminarHistorial);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAgregarHistorial);
            Name = "Historial";
            Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistorial;
        private Button btnActualizarHistorial;
        private Button btnBuscarHistorial;
        private Button btnEliminarHistorial;
        private GroupBox groupBox1;
        private TextBox txtSintomas;
        private TextBox txtTratamiento;
        private DateTimePicker dtpFechaConsulta;
        private TextBox txtDiagnostico;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtObservaciones;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregarHistorial;
        private ComboBox cbDoctor;
        private ComboBox cbPaciente;
        private TextBox txtIdHistorial;
        private Label lblidhistorial;
        private Button btnvolver;
        private Button btnImprimir;
    }
}