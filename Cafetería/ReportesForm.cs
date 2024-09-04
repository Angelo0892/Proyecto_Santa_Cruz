using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Proyecto_almacen
{
    public partial class ReportesForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Cafet"].ConnectionString;

        public ReportesForm()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string tipoReporte = cbTipoReporte.SelectedItem?.ToString();
            string query = "";

            switch (tipoReporte)
            {
                case "Ventas":
                    query = @"
                SELECT V.IDVenta, CONVERT(VARCHAR, V.FechaVenta, 105) AS FechaVenta, 
                       V.TotalVenta, P.NombreProd, DV.Cantidad, DV.PrecioUnitario
                FROM Ventas V
                INNER JOIN DetalleVenta DV ON V.IDVenta = DV.IDVenta
                INNER JOIN Productos P ON DV.IDProducto = P.IDProducto
                ORDER BY V.FechaVenta DESC;";
                    break;

                case "Productos":
                    query = @"
                SELECT IDProducto, NombreProd, Descripcion, PrecioCompra, PrecioVenta, CantidadDisponible, 
                       CONVERT(VARCHAR, FechaIngreso, 105) AS FechaIngreso, Categoria 
                FROM Productos 
                ORDER BY FechaIngreso DESC;";
                    break;

                case "Productos más vendidos":
                    query = @"
    SELECT 
        P.IDProducto, 
        P.NombreProd, 
        SUM(DV.Cantidad) AS TotalVendido,
        AVG(DV.PrecioUnitario) AS PrecioPromedio,
        SUM(DV.Cantidad * (DV.PrecioUnitario - P.PrecioCompra)) AS GananciaTotal
    FROM 
        DetalleVenta DV
    INNER JOIN 
        Productos P ON DV.IDProducto = P.IDProducto
    GROUP BY 
        P.IDProducto, 
        P.NombreProd
    ORDER BY 
        TotalVendido DESC;";
                    break;


                case "Ventas totales por día":
                    query = @"
                SELECT 
                    CONVERT(VARCHAR, V.FechaVenta, 105) AS FechaVenta, 
                    SUM(DV.Cantidad * DV.PrecioUnitario) AS TotalVendido, 
                    COUNT(DISTINCT V.IDVenta) AS CantidadVentas, 
                    P.NombreProd, 
                    SUM(DV.Cantidad) AS CantidadVendida,
                    SUM(DV.PrecioUnitario * DV.Cantidad) - SUM(P.PrecioCompra * DV.Cantidad) AS Ganancia
                FROM Ventas V
                INNER JOIN DetalleVenta DV ON V.IDVenta = DV.IDVenta
                INNER JOIN Productos P ON DV.IDProducto = P.IDProducto
                GROUP BY CONVERT(VARCHAR, V.FechaVenta, 105), P.NombreProd
                ORDER BY FechaVenta DESC;";
                    break;

                default:
                    MessageBox.Show("Tipo de reporte no válido.");
                    return;
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                    lvReporte.Clear();

                    // Configure ListView columns based on report type
                    if (tipoReporte == "Ventas")
                    {
                        lvReporte.Columns.Add("IDVenta", 100);
                        lvReporte.Columns.Add("FechaVenta", 150);
                        lvReporte.Columns.Add("TotalVenta", 100);
                        lvReporte.Columns.Add("NombreProd", 150);
                        lvReporte.Columns.Add("Cantidad", 100);
                        lvReporte.Columns.Add("Precio Unitario", 100);
                    }
                    else if (tipoReporte == "Productos")
                    {
                        lvReporte.Columns.Add("IDProducto", 100);
                        lvReporte.Columns.Add("NombreProd", 150);
                        lvReporte.Columns.Add("Descripción", 200);
                        lvReporte.Columns.Add("PrecioCompra", 100);
                        lvReporte.Columns.Add("PrecioVenta", 100);
                        lvReporte.Columns.Add("Cantidad Disponible", 150);
                        lvReporte.Columns.Add("Fecha Ingreso", 100);
                        lvReporte.Columns.Add("Categoría", 100);
                    }
                    else if (tipoReporte == "Productos más vendidos")
                    {
                        lvReporte.Columns.Add("IDProducto", 100);
                        lvReporte.Columns.Add("NombreProd", 150);
                        lvReporte.Columns.Add("TotalVendido", 150);
                        lvReporte.Columns.Add("PrecioPromedio", 150);
                        lvReporte.Columns.Add("GananciaTotal", 150);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["IDProducto"].ToString());
                            item.SubItems.Add(row["NombreProd"].ToString());
                            item.SubItems.Add(row["TotalVendido"].ToString());
                            item.SubItems.Add(row["PrecioPromedio"].ToString());
                            item.SubItems.Add(row["GananciaTotal"].ToString());

                            lvReporte.Items.Add(item);
                        }
                    }

                    else if (tipoReporte == "Ventas totales por día")
                    {
                        lvReporte.Columns.Add("FechaVenta", 150);
                        lvReporte.Columns.Add("Total Vendido", 150);
                        lvReporte.Columns.Add("Cantidad Ventas", 150);
                        lvReporte.Columns.Add("Nombre Producto", 150);
                        lvReporte.Columns.Add("Cantidad Vendida", 150);
                        lvReporte.Columns.Add("Ganancia", 150);
                    }

                    // Add rows to ListView
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item;

                        if (tipoReporte == "Ventas")
                        {
                            item = new ListViewItem(row["IDVenta"].ToString());
                            item.SubItems.Add(row["FechaVenta"].ToString());
                            item.SubItems.Add(row["TotalVenta"].ToString());
                            item.SubItems.Add(row["NombreProd"].ToString());
                            item.SubItems.Add(row["Cantidad"].ToString());
                            item.SubItems.Add(row["PrecioUnitario"].ToString());
                        }
                        else if (tipoReporte == "Productos")
                        {
                            item = new ListViewItem(row["IDProducto"].ToString());
                            item.SubItems.Add(row["NombreProd"].ToString());
                            item.SubItems.Add(row["Descripcion"].ToString());
                            item.SubItems.Add(row["PrecioCompra"].ToString());
                            item.SubItems.Add(row["PrecioVenta"].ToString());
                            item.SubItems.Add(row["CantidadDisponible"].ToString());
                            item.SubItems.Add(row["FechaIngreso"].ToString());
                            item.SubItems.Add(row["Categoria"].ToString());

                            // Check for low stock and set background color
                            int cantidadDisponible;
                            if (int.TryParse(row["CantidadDisponible"].ToString(), out cantidadDisponible) && cantidadDisponible < 10)
                            {
                                item.BackColor = System.Drawing.Color.LightCoral;
                                MessageBox.Show($"Producto con bajo stock: {row["NombreProd"].ToString()} (ID: {row["IDProducto"].ToString()})");
                            }
                        }
                        else if (tipoReporte == "Productos más vendidos")
                        {
                            item = new ListViewItem(row["IDProducto"].ToString());
                            item.SubItems.Add(row["NombreProd"].ToString());
                            item.SubItems.Add(row["TotalVendido"].ToString());
                        }
                        else if (tipoReporte == "Ventas totales por día")
                        {
                            item = new ListViewItem(row["FechaVenta"].ToString());
                            item.SubItems.Add(row["TotalVendido"].ToString());
                            item.SubItems.Add(row["CantidadVentas"].ToString());
                            item.SubItems.Add(row["NombreProd"].ToString());
                            item.SubItems.Add(row["CantidadVendida"].ToString());
                            item.SubItems.Add(row["Ganancia"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Tipo de reporte no reconocido.");
                            return;
                        }

                        lvReporte.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el reporte: " + ex.Message);
                }
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            Font printFont = new Font("Arial", 10);
            SolidBrush printBrush = new SolidBrush(Color.Black);

            string[] columnHeaders = new string[lvReporte.Columns.Count];
            string headerText = "";

            switch (cbTipoReporte.SelectedItem.ToString())
            {
                case "Ventas":
                    headerText = "Reporte de Ventas";
                    for (int i = 0; i < lvReporte.Columns.Count; i++)
                    {
                        columnHeaders[i] = lvReporte.Columns[i].Text;
                    }
                    break;
                case "Productos":
                    headerText = "Reporte de Productos";
                    for (int i = 0; i < lvReporte.Columns.Count; i++)
                    {
                        columnHeaders[i] = lvReporte.Columns[i].Text;
                    }
                    break;
                case "Productos más vendidos":
                    headerText = "Reporte de Productos Más Vendidos";
                    for (int i = 0; i < lvReporte.Columns.Count; i++)
                    {
                        columnHeaders[i] = lvReporte.Columns[i].Text;
                    }
                    break;
                case "Ventas totales por día":
                    headerText = "Reporte de Ventas Totales por Día";
                    for (int i = 0; i < lvReporte.Columns.Count; i++)
                    {
                        columnHeaders[i] = lvReporte.Columns[i].Text;
                    }
                    break;
                default:
                    MessageBox.Show("Tipo de reporte no válido.");
                    return;
            }

            e.Graphics.DrawString(headerText, new Font("Arial", 14, FontStyle.Bold), printBrush, leftMargin, topMargin);
            yPos += printFont.GetHeight(e.Graphics);

            // Draw column headers
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                e.Graphics.DrawString(columnHeaders[i], printFont, printBrush, leftMargin + i * 100, yPos);
            }

            yPos += printFont.GetHeight(e.Graphics);

            // Draw rows
            foreach (ListViewItem item in lvReporte.Items)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    e.Graphics.DrawString(item.SubItems[i].Text, printFont, printBrush, leftMargin + i * 100, yPos);
                }
                yPos += printFont.GetHeight(e.Graphics);
            }
        }
        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el cambio en el ComboBox
            // Esto podría incluir la actualización de la vista o la habilitación de botones, etc.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdministradorForms AdministradorForms = new AdministradorForms();
            AdministradorForms.Show();
            this.Hide();
        }
    }
}
