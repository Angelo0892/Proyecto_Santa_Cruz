using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace Proyecto_almacen
{
    public partial class VenderForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Cafet"].ConnectionString;
        private List<ProductosVenta> carrito = new List<ProductosVenta>();

        public VenderForm()
        {
            InitializeComponent();
            LoadProductos();
        }

        private void LoadProductos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProductosVenta.DataSource = dt;
            }
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProductosVenta.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("No se pudo encontrar la fila seleccionada.");
                return;
            }

            int cantidadVenta;
            if (!int.TryParse(txtCantidad.Text, out cantidadVenta) || cantidadVenta <= 0)
            {
                MessageBox.Show("Cantidad inválida. Debe ser un número entero mayor que 0.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(row.Cells["IDProducto"].Value);
            string nombreProd = row.Cells["NombreProd"].Value.ToString();
            decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
            int cantidadDisponible = Convert.ToInt32(row.Cells["CantidadDisponible"].Value);

            if (cantidadVenta > cantidadDisponible)
            {
                MessageBox.Show("Cantidad a vender no puede ser mayor que la cantidad disponible.");
                return;
            }

            // Agregar al carrito
            var item = carrito.FirstOrDefault(p => p.IDProducto == idProducto);
            if (item != null)
            {
                item.CantidadVenta += cantidadVenta;
                item.Total = item.CantidadVenta * item.PrecioVenta;
            }
            else
            {
                carrito.Add(new ProductosVenta
                {
                    IDProducto = idProducto,
                    NombreProd = nombreProd,
                    PrecioVenta = precioVenta,
                    CantidadVenta = cantidadVenta,
                    Total = cantidadVenta * precioVenta
                });
            }

            // Actualizar DataGrid del carrito
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            // Calcular total
            txtTotal.Text = carrito.Sum(p => p.Total).ToString("C");
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Crear una nueva venta
                string insertVentaQuery = "INSERT INTO Ventas (FechaVenta, TotalVenta) OUTPUT INSERTED.IDVenta VALUES (@FechaVenta, @TotalVenta)";
                SqlCommand insertVentaCmd = new SqlCommand(insertVentaQuery, conn);
                insertVentaCmd.Parameters.AddWithValue("@FechaVenta", DateTime.Now.Date); // Fecha actual
                insertVentaCmd.Parameters.AddWithValue("@TotalVenta", carrito.Sum(p => p.Total));

                int idVenta;
                try
                {
                    idVenta = (int)insertVentaCmd.ExecuteScalar(); // Obtiene el ID de la venta recién insertada
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error al registrar la venta: {ex.Message}");
                    return;
                }

                // Insertar detalles de la venta
                foreach (var item in carrito)
                {
                    string insertDetalleQuery = "INSERT INTO DetalleVenta (IDVenta, IDProducto, Cantidad, PrecioUnitario) VALUES (@IDVenta, @IDProducto, @Cantidad, @PrecioUnitario)";
                    SqlCommand insertDetalleCmd = new SqlCommand(insertDetalleQuery, conn);
                    insertDetalleCmd.Parameters.AddWithValue("@IDVenta", idVenta);
                    insertDetalleCmd.Parameters.AddWithValue("@IDProducto", item.IDProducto);
                    insertDetalleCmd.Parameters.AddWithValue("@Cantidad", item.CantidadVenta);
                    insertDetalleCmd.Parameters.AddWithValue("@PrecioUnitario", item.PrecioVenta);

                    try
                    {
                        insertDetalleCmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Error al registrar el detalle de la venta: {ex.Message}");
                        return;
                    }

                    // Actualizar cantidad disponible
                    string updateProductoQuery = "UPDATE Productos SET CantidadDisponible = CantidadDisponible - @Cantidad WHERE IDProducto = @IDProducto";
                    SqlCommand updateProductoCmd = new SqlCommand(updateProductoQuery, conn);
                    updateProductoCmd.Parameters.AddWithValue("@Cantidad", item.CantidadVenta);
                    updateProductoCmd.Parameters.AddWithValue("@IDProducto", item.IDProducto);

                    try
                    {
                        updateProductoCmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Error al actualizar la cantidad disponible: {ex.Message}");
                        return;
                    }
                }

                // Limpiar carrito y actualizar interfaz
                carrito.Clear();
                dgvCarrito.DataSource = null;
                txtTotal.Text = string.Empty;
                LoadProductos();

                MessageBox.Show("Venta registrada exitosamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("No se pudo encontrar la fila seleccionada.");
                return;
            }

            var productToRemove = (ProductosVenta)dgvCarrito.CurrentRow.DataBoundItem;

            // Remover el producto del carrito
            carrito.Remove(productToRemove);

            // Actualizar la interfaz
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            // Actualizar el total
            txtTotal.Text = carrito.Sum(p => p.Total).ToString("C");

            MessageBox.Show($"{productToRemove.NombreProd} eliminado del carrito.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VenderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class ProductosVenta
    {
        public int IDProducto { get; set; }
        public string NombreProd { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadVenta { get; set; }
        public decimal Total { get; set; }
    }
}