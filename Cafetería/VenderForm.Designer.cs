
namespace Proyecto_almacen
{
    partial class VenderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCantidad;  
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnAgregarAlCarrito;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCarrito;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.AllowUserToAddRows = false;
            this.dgvProductosVenta.AllowUserToDeleteRows = false;
            this.dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVenta.Location = new System.Drawing.Point(12, 127);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.ReadOnly = true;
            this.dgvProductosVenta.RowHeadersVisible = false;
            this.dgvProductosVenta.Size = new System.Drawing.Size(776, 270);
            this.dgvProductosVenta.TabIndex = 0;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(12, 455);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.Size = new System.Drawing.Size(776, 187);
            this.dgvCarrito.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(125, 661);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(128, 403);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(674, 651);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(114, 45);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender Productos";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(621, 403);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarAlCarrito.TabIndex = 4;
            this.btnAgregarAlCarrito.Text = "Agregar";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarAlCarrito_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(702, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(13, 665);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductos.Location = new System.Drawing.Point(9, 32);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(699, 44);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "LISTADO DE PRODUCTOS PARA VENDER";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(12, 432);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(160, 20);
            this.lblCarrito.TabIndex = 8;
            this.lblCarrito.Text = "Carrito de Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 103);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(710, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VenderForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarAlCarrito);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.dgvProductosVenta);
            this.Name = "VenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Productos";
            this.Load += new System.EventHandler(this.VenderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}