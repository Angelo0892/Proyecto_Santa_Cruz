using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Proyecto_almacen
{
    public partial class VentasForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Cafet"].ConnectionString;

        public VentasForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadProductNames();  // Cargar nombres de productos en el ComboBox

            // Suscribirse al evento CellClick
            dgProductos.CellClick += new DataGridViewCellEventHandler(dgProductos_CellClick);

            // Suscribirse al evento KeyPress de txtCantidadIngresada
            txtCantidadIngresada.KeyPress += new KeyPressEventHandler(txtCantidadIngresada_KeyPress);
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgProductos.DataSource = dt;
            }
        }

        private void LoadProductNames()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IDProducto, NombreProd FROM Productos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbProductos.DataSource = dt;
                cbProductos.DisplayMember = "NombreProd";
                cbProductos.ValueMember = "IDProducto";
            }
        }

        private void txtCantidadIngresada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos numéricos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento
                MessageBox.Show("Solo se permiten números positivos en el campo de cantidad ingresada.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Verificar si se está intentando ingresar un '0' como el primer dígito
                if (e.KeyChar == '0' && txtCantidadIngresada.Text.Length == 0)
                {
                    e.Handled = true; // Cancela el evento
                    MessageBox.Show("El valor no puede ser 0. Por favor, ingrese un número positivo mayor que 0.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private bool ValidateForm()
        {
            bool isValid = true;

            // Validar Nombre
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$") || txtNombre.Text.Length > 20)
            {
                txtNombre.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.Color.White;
            }


            // Validar Descripción
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtDescripcion.BackColor = System.Drawing.Color.White;
            }

            // Validar PrecioCompra
            decimal precioCompra;
            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra) || precioCompra < 0)
            {
                txtPrecioCompra.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtPrecioCompra.BackColor = System.Drawing.Color.White;
                txtPrecioCompra.Text = precioCompra.ToString("F2");
            }

            // Validar PrecioVenta
            decimal precioVenta;
            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta) || precioVenta < 0)
            {
                txtPrecioVenta.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtPrecioVenta.BackColor = System.Drawing.Color.White;
                txtPrecioVenta.Text = precioVenta.ToString("F2");
            }

            // Validar Cantidad
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 0)
            {
                txtCantidad.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtCantidad.BackColor = System.Drawing.Color.White;
            }

            

            return isValid;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Validación de datos inválido, cambie los datos marcados con rojo.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos (NombreProd, Descripcion, PrecioCompra, PrecioVenta, CantidadDisponible, FechaIngreso, Categoria) " +
                   "VALUES (@NombreProd, @Descripcion, @PrecioCompra, @PrecioVenta, @CantidadDisponible, @FechaIngreso, @Categoria)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreProd", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@PrecioCompra", Convert.ToDecimal(txtPrecioCompra.Text));
                cmd.Parameters.AddWithValue("@PrecioVenta", Convert.ToDecimal(txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@CantidadDisponible", Convert.ToInt32(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@FechaIngreso", DateTime.Now);
                cmd.Parameters.AddWithValue("@Categoria", comboBox1.SelectedItem.ToString()); // Cambiado a comboBox1

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto agregado exitosamente.");
                LoadProducts(); // Reload data to reflect changes
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Validación de datos inválido, cambie los datos marcados con rojo.");
                return;
            }

            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            DataGridViewRow row = dgProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(row.Cells["IDProducto"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET NombreProd = @NombreProd, Descripcion = @Descripcion, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, CantidadDisponible = @CantidadDisponible, Categoria = @Categoria WHERE IDProducto = @IDProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                cmd.Parameters.AddWithValue("@NombreProd", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@PrecioCompra", Convert.ToDecimal(txtPrecioCompra.Text));
                cmd.Parameters.AddWithValue("@PrecioVenta", Convert.ToDecimal(txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@CantidadDisponible", Convert.ToInt32(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@Categoria", comboBox1.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto modificado exitosamente.");
                LoadProducts(); // Reload data to reflect changes
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            DataGridViewRow row = dgProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(row.Cells["IDProducto"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE IDProducto = @IDProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado exitosamente.");
                LoadProducts(); // Reload data to reflect changes
            }
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedValue == null || string.IsNullOrEmpty(txtCantidadIngresada.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto e ingrese la cantidad.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int idProducto = (int)cbProductos.SelectedValue;
                int cantidadIngresada = Convert.ToInt32(txtCantidadIngresada.Text);
                DateTime fechaIngreso = dpFechaIngreso.Value;

                string query = "INSERT INTO IngresoProductos (IDProducto, CantidadIngresada, Fecha) " +
                               "VALUES (@IDProducto, @CantidadIngresada, @Fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                cmd.Parameters.AddWithValue("@CantidadIngresada", cantidadIngresada);
                cmd.Parameters.AddWithValue("@Fecha", fechaIngreso);

                conn.Open();
                cmd.ExecuteNonQuery();

                query = "UPDATE Productos SET CantidadDisponible = CantidadDisponible + @CantidadIngresada WHERE IDProducto = @IDProducto";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CantidadIngresada", cantidadIngresada);
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ingreso de producto registrado exitosamente.");
                LoadProducts(); // Reload data to reflect changes
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow row = dgProductos.Rows[e.RowIndex];

                // Cargar los datos en los TextBoxes
                txtNombre.Text = row.Cells["NombreProd"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecioCompra.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtCantidad.Text = row.Cells["CantidadDisponible"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Categoria"].Value.ToString();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdministradorForms AdministradorForms = new AdministradorForms();
            AdministradorForms.Show();
            this.Hide();
        }
    }
}
