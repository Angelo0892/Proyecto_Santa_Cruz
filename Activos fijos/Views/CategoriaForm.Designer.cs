namespace ACTIVOS_FIJOS.Views
{
    partial class CategoriaForm
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
            this.label25 = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorResidual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 13);
            this.label25.TabIndex = 103;
            this.label25.Text = "Nombre de la Categoria:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(21, 56);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCategoria.TabIndex = 101;
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(170, 30);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(65, 20);
            this.txtCategoriaID.TabIndex = 100;
            this.txtCategoriaID.Visible = false;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(21, 285);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(214, 23);
            this.btnEliminarCategoria.TabIndex = 99;
            this.btnEliminarCategoria.Text = "ELIMINAR";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(21, 247);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(214, 23);
            this.btnActualizarCategoria.TabIndex = 98;
            this.btnActualizarCategoria.Text = "ACTUALIZAR";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(21, 210);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(214, 23);
            this.btnAgregarCategoria.TabIndex = 97;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.Size = new System.Drawing.Size(247, 336);
            this.dataGridViewCategorias.TabIndex = 96;
            this.dataGridViewCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategorias_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValorResidual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVidaUtil);
            this.groupBox1.Controls.Add(this.txtCategoriaID);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnAgregarCategoria);
            this.groupBox1.Controls.Add(this.btnActualizarCategoria);
            this.groupBox1.Controls.Add(this.txtNombreCategoria);
            this.groupBox1.Controls.Add(this.btnEliminarCategoria);
            this.groupBox1.Location = new System.Drawing.Point(271, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 320);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Años de vida Util:";
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(21, 114);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(214, 20);
            this.txtVidaUtil.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Valor Residual:";
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Location = new System.Drawing.Point(21, 170);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Size = new System.Drawing.Size(214, 20);
            this.txtValorResidual.TabIndex = 106;
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Name = "CategoriaForm";
            this.Text = "CategoriaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVidaUtil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorResidual;
    }
}