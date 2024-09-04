using ACTIVOS_FIJOS.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ACTIVOS_FIJOS.Views
{
    public partial class ReportesForm : Form
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        private ActivoFijoController ActivoFijoController = new ActivoFijoController();
        public ReportesForm()
        {
            InitializeComponent();
            reporteactivosfijos();
            reporteactivosfijosbaja();
            reporteactivosfijosdepreciacion();
            reporteactivosfijosasignados();
          
        }      
        
        private void reporteactivosfijos()
        {
            var activos = ActivoFijoController.GetAllAssetsWithDetails();
            dataGridViewActivos.AutoGenerateColumns = false;
            dataGridViewActivos.DataSource = activos;
            // Configurar manualmente las columnas
            dataGridViewActivos.Columns.Clear();
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código",
                Name = "CodigoActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivoID",
                HeaderText = "ID Nombre Activo",
                Name = "NombreActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriaID",
                HeaderText = "ID Categoría",
                Name = "CategoriaID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCategoria",
                HeaderText = "Categoría",
                Name = "NombreCategoria"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UbicacionID",
                HeaderText = "ID Ubicación",
                Name = "UbicacionID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUbicacion",
                HeaderText = "Ubicación",
                Name = "NombreUbicacion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadID",
                HeaderText = "ID Unidad",
                Name = "UnidadID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUnidad",
                HeaderText = "Unidad",
                Name = "NombreUnidad"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "EstadoBaja"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionActivo",
                HeaderText = "Descripción",
                Name = "DescripcionActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoBajaActivo",
                HeaderText = "Motivo de Baja",
                Name = "MotivoBajaActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo"
            });
        }
        private void reporteactivosfijosbaja()
        {
            var activos = ActivoFijoController.GetAllAssetsWithDetails_baja_reportes();
            dataGridViewActivosBaja.AutoGenerateColumns = false;
            dataGridViewActivosBaja.DataSource = activos;
            // Configurar manualmente las columnas
            dataGridViewActivosBaja.Columns.Clear();
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código",
                Name = "CodigoActivo"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivoID",
                HeaderText = "ID Nombre Activo",
                Name = "NombreActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriaID",
                HeaderText = "ID Categoría",
                Name = "CategoriaID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCategoria",
                HeaderText = "Categoría",
                Name = "NombreCategoria"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UbicacionID",
                HeaderText = "ID Ubicación",
                Name = "UbicacionID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUbicacion",
                HeaderText = "Ubicación",
                Name = "NombreUbicacion"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadID",
                HeaderText = "ID Unidad",
                Name = "UnidadID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUnidad",
                HeaderText = "Unidad",
                Name = "NombreUnidad"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "EstadoBaja"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionActivo",
                HeaderText = "Descripción",
                Name = "DescripcionActivo"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoBajaActivo",
                HeaderText = "Motivo de Baja",
                Name = "MotivoBajaActivo"
            });
            dataGridViewActivosBaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo"
            });
        }
        private void reporteactivosfijosdepreciacion()
        {
            var activos = ActivoFijoController.GetAllAssetsWithDepreciationRecords();
            dataGridViewDepreciaciones.AutoGenerateColumns = false;
            dataGridViewDepreciaciones.DataSource = activos;
            // Configurar manualmente las columnas
            dataGridViewDepreciaciones.Columns.Clear();
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código",
                Name = "CodigoActivo"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivoID",
                HeaderText = "ID Nombre Activo",
                Name = "NombreActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriaID",
                HeaderText = "ID Categoría",
                Name = "CategoriaID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCategoria",
                HeaderText = "Categoría",
                Name = "NombreCategoria"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UbicacionID",
                HeaderText = "ID Ubicación",
                Name = "UbicacionID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUbicacion",
                HeaderText = "Ubicación",
                Name = "NombreUbicacion"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadID",
                HeaderText = "ID Unidad",
                Name = "UnidadID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUnidad",
                HeaderText = "Unidad",
                Name = "NombreUnidad"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "EstadoBaja"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionActivo",
                HeaderText = "Descripción",
                Name = "DescripcionActivo"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoBajaActivo",
                HeaderText = "Motivo de Baja",
                Name = "MotivoBajaActivo"
            });
            dataGridViewDepreciaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo"
            });
        }
        private void reporteactivosfijosasignados()
        {
            var activos = ActivoFijoController.GetAllAssignedAssets();
            dataGridViewActivosAsignados.AutoGenerateColumns = false;
            dataGridViewActivosAsignados.DataSource = activos;
            // Configurar manualmente las columnas
            dataGridViewActivosAsignados.Columns.Clear();
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código",
                Name = "CodigoActivo"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivoID",
                HeaderText = "ID Nombre Activo",
                Name = "NombreActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriaID",
                HeaderText = "ID Categoría",
                Name = "CategoriaID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCategoria",
                HeaderText = "Categoría",
                Name = "NombreCategoria"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UbicacionID",
                HeaderText = "ID Ubicación",
                Name = "UbicacionID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUbicacion",
                HeaderText = "Ubicación",
                Name = "NombreUbicacion"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadID",
                HeaderText = "ID Unidad",
                Name = "UnidadID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUnidad",
                HeaderText = "Unidad",
                Name = "NombreUnidad"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "Estado"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionActivo",
                HeaderText = "Descripción",
                Name = "DescripcionActivo"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoBajaActivo",
                HeaderText = "Motivo de Baja",
                Name = "MotivoBajaActivo"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PersonalID",
                HeaderText = "ID Personal",
                Name = "PersonalID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombrePersonal",
                HeaderText = "Nombre del Personal",
                Name = "NombrePersonal"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Name = "Apellido"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "Email"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Name = "Telefono"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAsignacion",
                HeaderText = "Fecha de Asignación",
                Name = "FechaAsignacion"
            });
            dataGridViewActivosAsignados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observaciones",
                HeaderText = "Observaciones",
                Name = "Observaciones"
            });
        }     
        private void ExportarDataGridViewAExcel(DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ExportedData";

            // Agregar encabezados
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            // Agregar datos
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();
            }
        }
        private void ExportarDataGridViewAPDF(DataGridView dgv)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                pdfDoc.Open();

                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Agregar encabezados
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Agregar datos
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
            }
        }               
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dataGridViewActivos);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAPDF(dataGridViewActivos);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dataGridViewDepreciaciones);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAPDF(dataGridViewDepreciaciones);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dataGridViewActivosAsignados);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAPDF((dataGridViewActivosAsignados));
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dataGridViewActivosBaja);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAPDF((dataGridViewActivosBaja));
        }
    }
}
