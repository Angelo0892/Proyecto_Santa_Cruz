namespace ACTIVOS_FIJOS.Views
{
    partial class UbicacionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUbicacionID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombreUbicacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewUbicaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUbicacionID);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtNombreUbicacion);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(269, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 212);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Ubicaciones";
            // 
            // txtUbicacionID
            // 
            this.txtUbicacionID.Location = new System.Drawing.Point(170, 30);
            this.txtUbicacionID.Name = "txtUbicacionID";
            this.txtUbicacionID.Size = new System.Drawing.Size(65, 20);
            this.txtUbicacionID.TabIndex = 100;
            this.txtUbicacionID.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 103;
            this.label25.Text = "Nombre de Ubicacion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(21, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(214, 23);
            this.btnAgregar.TabIndex = 97;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizar.Location = new System.Drawing.Point(21, 130);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(214, 23);
            this.btnActualizar.TabIndex = 98;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombreUbicacion
            // 
            this.txtNombreUbicacion.Location = new System.Drawing.Point(21, 56);
            this.txtNombreUbicacion.Name = "txtNombreUbicacion";
            this.txtNombreUbicacion.Size = new System.Drawing.Size(214, 20);
            this.txtNombreUbicacion.TabIndex = 101;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(21, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(214, 23);
            this.btnEliminar.TabIndex = 99;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridViewUbicaciones
            // 
            this.dataGridViewUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicaciones.Location = new System.Drawing.Point(10, 12);
            this.dataGridViewUbicaciones.Name = "dataGridViewUbicaciones";
            this.dataGridViewUbicaciones.Size = new System.Drawing.Size(247, 212);
            this.dataGridViewUbicaciones.TabIndex = 110;
            this.dataGridViewUbicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicaciones_CellClick);
            // 
            // UbicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewUbicaciones);
            this.Name = "UbicacionForm";
            this.Text = "Administrar Ubicaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUbicacionID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombreUbicacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewUbicaciones;
    }
}