namespace DEMOPROY1.VIews
{
    partial class DocenteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtgDocentes = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DOCENTES:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Nombre: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Titulo:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(262, 71);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(112, 26);
            this.txtPrimerNombre.TabIndex = 7;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(262, 139);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(112, 26);
            this.txtSegundoNombre.TabIndex = 8;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(663, 71);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(112, 26);
            this.txtPrimerApellido.TabIndex = 9;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(663, 139);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(112, 26);
            this.txtSegundoApellido.TabIndex = 10;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 221);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // dtgDocentes
            // 
            this.dtgDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDocentes.Location = new System.Drawing.Point(61, 421);
            this.dtgDocentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDocentes.Name = "dtgDocentes";
            this.dtgDocentes.ReadOnly = true;
            this.dtgDocentes.RowHeadersWidth = 51;
            this.dtgDocentes.RowTemplate.Height = 24;
            this.dtgDocentes.Size = new System.Drawing.Size(773, 230);
            this.dtgDocentes.TabIndex = 12;
            this.dtgDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnagregar.Location = new System.Drawing.Point(61, 324);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(136, 59);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnactualizar.Location = new System.Drawing.Point(286, 324);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(132, 59);
            this.btnactualizar.TabIndex = 14;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneliminar.Location = new System.Drawing.Point(493, 324);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 59);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlimpiar.Location = new System.Drawing.Point(705, 324);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(128, 59);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(663, 221);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DocenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 666);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtgDocentes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocenteForm";
            this.Text = "DocenteForm";
            this.Load += new System.EventHandler(this.DocenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocentes)).EndInit();
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
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dtgDocentes;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}