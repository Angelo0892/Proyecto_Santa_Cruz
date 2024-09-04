namespace DEMOPROY1.VIews
{
    partial class TribunalForm
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dtgTribunales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.txtInstitucion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTribunales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnagregar.Location = new System.Drawing.Point(35, 359);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 59);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnactualizar.Location = new System.Drawing.Point(276, 359);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(134, 59);
            this.btnactualizar.TabIndex = 1;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneliminar.Location = new System.Drawing.Point(511, 359);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(136, 59);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlimpiar.Location = new System.Drawing.Point(738, 359);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(122, 59);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // dtgTribunales
            // 
            this.dtgTribunales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTribunales.Location = new System.Drawing.Point(35, 439);
            this.dtgTribunales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgTribunales.Name = "dtgTribunales";
            this.dtgTribunales.ReadOnly = true;
            this.dtgTribunales.RowHeadersWidth = 51;
            this.dtgTribunales.RowTemplate.Height = 24;
            this.dtgTribunales.Size = new System.Drawing.Size(825, 234);
            this.dtgTribunales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "REGISTRO DE TRIBUNAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primer Nombre: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Primer Apellido: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Institución: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Titulo:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(198, 61);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(112, 26);
            this.txtPrimerNombre.TabIndex = 13;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(198, 141);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(112, 26);
            this.txtSegundoNombre.TabIndex = 14;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(656, 61);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(112, 26);
            this.txtPrimerApellido.TabIndex = 15;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(656, 141);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(112, 26);
            this.txtSegundoApellido.TabIndex = 16;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 299);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Interno ",
            "Externo"});
            this.txtTipo.Location = new System.Drawing.Point(198, 217);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 28);
            this.txtTipo.TabIndex = 20;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtInstitucion.FormattingEnabled = true;
            this.txtInstitucion.Items.AddRange(new object[] {
            "UPS",
            "UPDS",
            "UMSA"});
            this.txtInstitucion.Location = new System.Drawing.Point(656, 222);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(121, 28);
            this.txtInstitucion.TabIndex = 21;
            // 
            // TribunalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 688);
            this.Controls.Add(this.txtInstitucion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTribunales);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TribunalForm";
            this.Text = "TribunalForm";
            this.Load += new System.EventHandler(this.TribunalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTribunales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DataGridView dtgTribunales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.ComboBox txtInstitucion;
    }
}