namespace SistemaPatologiaIA
{
    partial class FormGestionUsuarios
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuarios));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtContraseña = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            chkActivo = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbRol = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAgregarUsuario = new Button();
            dataGridViewUsuarios = new DataGridView();
            databaseConnectionBindingSource = new BindingSource(components);
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 21);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuario";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbRol);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tempus Sans ITC", 10.2F);
            groupBox1.Location = new Point(68, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(174, 150);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(140, 30);
            txtContraseña.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(140, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(173, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 30);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 30);
            txtNombre.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(173, 235);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(80, 26);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 231);
            label7.Name = "label7";
            label7.Size = new Size(57, 22);
            label7.TabIndex = 6;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 188);
            label6.Name = "label6";
            label6.Size = new Size(48, 22);
            label6.TabIndex = 5;
            label6.Text = "IdRol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 150);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(174, 192);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(169, 30);
            cbRol.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 114);
            label4.Name = "label4";
            label4.Size = new Size(49, 22);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 73);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 32);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.Highlight;
            btnAgregarUsuario.Font = new Font("Tempus Sans ITC", 10.2F);
            btnAgregarUsuario.Location = new Point(567, 134);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(106, 32);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(68, 400);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(871, 207);
            dataGridViewUsuarios.TabIndex = 3;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Tempus Sans ITC", 10.2F);
            btnActualizar.Location = new Point(567, 176);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 32);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.Font = new Font("Tempus Sans ITC", 10.2F);
            btnEliminar.Location = new Point(567, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 32);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.Font = new Font("Tempus Sans ITC", 10.2F);
            btnBuscar.Location = new Point(567, 264);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 32);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(952, 726);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Tempus Sans ITC", 10.2F);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAgregarUsuario;
        private DataGridView dataGridViewUsuarios;
        private BindingSource databaseConnectionBindingSource;
        private ComboBox cbRol;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtContraseña;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private CheckBox chkActivo;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}