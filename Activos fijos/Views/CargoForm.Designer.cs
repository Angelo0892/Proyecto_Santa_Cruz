namespace ACTIVOS_FIJOS.Views
{
    partial class CargoForm
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
            this.txtCargoID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewCargos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCargoID);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtNombreCargo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(269, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 212);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Cargos";
            // 
            // txtCargoID
            // 
            this.txtCargoID.Location = new System.Drawing.Point(170, 30);
            this.txtCargoID.Name = "txtCargoID";
            this.txtCargoID.Size = new System.Drawing.Size(65, 20);
            this.txtCargoID.TabIndex = 100;
            this.txtCargoID.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 13);
            this.label25.TabIndex = 103;
            this.label25.Text = "Nombre de Cargo";
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
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(21, 56);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCargo.TabIndex = 101;
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
            // dataGridViewCargos
            // 
            this.dataGridViewCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargos.Location = new System.Drawing.Point(10, 12);
            this.dataGridViewCargos.Name = "dataGridViewCargos";
            this.dataGridViewCargos.Size = new System.Drawing.Size(247, 212);
            this.dataGridViewCargos.TabIndex = 112;
            this.dataGridViewCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCargos_CellClick);
            // 
            // CargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCargos);
            this.Name = "CargoForm";
            this.Text = "CargoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCargoID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewCargos;
    }
}