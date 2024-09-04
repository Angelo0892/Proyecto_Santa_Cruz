using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace ACTIVOS_FIJOS.Controllers
{
    public class ReporteController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<object> GetAllAssignedAssets()
        {
            List<object> assets = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    a.ActivoID, a.CodigoActivo, na.NombreActivoID, na.NombreActivo_, a.EstadoBaja, 
    c.CategoriaID, c.NombreCategoria, u.UbicacionID, u.NombreUbicacion, 
    un.UnidadID, un.NombreUnidad, a.FechaAdquisicion, a.ValorAdquisicion, 
    a.Numero_Depreciaciones, a.DescripcionActivo, a.MotivoBajaActivo, 
    a.MotivoEliminarActivo, p.PersonalID, p.NombrePersonal, p.Apellido, 
    p.Email, p.Telefono, asg.FechaAsignacion, asg.Observaciones
FROM ACTIVOFIJO a
JOIN CATEGORIA c ON a.CategoriaID = c.CategoriaID
JOIN UBICACION u ON a.UbicacionID = u.UbicacionID
JOIN UNIDAD un ON a.UnidadID = un.UnidadID
JOIN NOMBREACTIVO na ON a.NombreActivoID = na.NombreActivoID
JOIN ASIGNACION asg ON a.ActivoID = asg.ActivoID
JOIN PERSONAL p ON asg.PersonalID = p.PersonalID
WHERE a.EstadoBaja <> 'Eliminado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asset = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        EstadoBaja = (string)reader["EstadoBaja"],
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NumeroDepreciaciones = (int)reader["Numero_Depreciaciones"],
                        DescripcionActivo = reader["DescripcionActivo"] != DBNull.Value ? (string)reader["DescripcionActivo"] : string.Empty,
                        MotivoBajaActivo = reader["MotivoBajaActivo"] != DBNull.Value ? (string)reader["MotivoBajaActivo"] : string.Empty,
                        MotivoEliminarActivo = reader["MotivoEliminarActivo"] != DBNull.Value ? (string)reader["MotivoEliminarActivo"] : string.Empty,
                        PersonalID = (int)reader["PersonalID"],
                        NombrePersonal = (string)reader["NombrePersonal"],
                        Apellido = (string)reader["Apellido"],
                        Email = (string)reader["Email"],
                        Telefono = (string)reader["Telefono"],
                        FechaAsignacion = (DateTime)reader["FechaAsignacion"],
                        Observaciones = reader["Observaciones"] != DBNull.Value ? (string)reader["Observaciones"] : string.Empty
                    };

                    assets.Add(asset);
                }
            }
            return assets;
        }
        /*
        private void ExportToExcel(List<object> activos)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Activos Asignados");
                // Agregar encabezados
                worksheet.Cell(1, 1).Value = "ID Activo";
                worksheet.Cell(1, 2).Value = "Código";
                worksheet.Cell(1, 3).Value = "Nombre del Activo";
                worksheet.Cell(1, 4).Value = "Categoría";
                worksheet.Cell(1, 5).Value = "Ubicación";
                worksheet.Cell(1, 6).Value = "Unidad";
                worksheet.Cell(1, 7).Value = "Fecha de Adquisición";
                worksheet.Cell(1, 8).Value = "Valor de Adquisición";
                worksheet.Cell(1, 9).Value = "Estado";
                worksheet.Cell(1, 10).Value = "Número de Depreciaciones";
                worksheet.Cell(1, 11).Value = "Descripción";
                worksheet.Cell(1, 12).Value = "Motivo de Baja";
                worksheet.Cell(1, 13).Value = "Motivo de Eliminación";
                worksheet.Cell(1, 14).Value = "Nombre del Personal";
                worksheet.Cell(1, 15).Value = "Apellido";
                worksheet.Cell(1, 16).Value = "Email";
                worksheet.Cell(1, 17).Value = "Teléfono";
                worksheet.Cell(1, 18).Value = "Fecha de Asignación";
                worksheet.Cell(1, 19).Value = "Observaciones";
                // Agregar datos
                for (int i = 0; i < activos.Count; i++)
                {
                    var activo = activos[i];
                    worksheet.Cell(i + 2, 1).Value = activo.ActivoID;
                    worksheet.Cell(i + 2, 2).Value = activo.CodigoActivo;
                    worksheet.Cell(i + 2, 3).Value = activo.NombreActivo;
                    worksheet.Cell(i + 2, 4).Value = activo.NombreCategoria;
                    worksheet.Cell(i + 2, 5).Value = activo.NombreUbicacion;
                    worksheet.Cell(i + 2, 6).Value = activo.NombreUnidad;
                    worksheet.Cell(i + 2, 7).Value = activo.FechaAdquisicion;
                    worksheet.Cell(i + 2, 8).Value = activo.ValorAdquisicion;
                    worksheet.Cell(i + 2, 9).Value = activo.EstadoBaja;
                    worksheet.Cell(i + 2, 10).Value = activo.NumeroDepreciaciones;
                    worksheet.Cell(i + 2, 11).Value = activo.DescripcionActivo;
                    worksheet.Cell(i + 2, 12).Value = activo.MotivoBajaActivo;
                    worksheet.Cell(i + 2, 13).Value = activo.MotivoEliminarActivo;
                    worksheet.Cell(i + 2, 14).Value = activo.NombrePersonal;
                    worksheet.Cell(i + 2, 15).Value = activo.Apellido;
                    worksheet.Cell(i + 2, 16).Value = activo.Email;
                    worksheet.Cell(i + 2, 17).Value = activo.Telefono;
                    worksheet.Cell(i + 2, 18).Value = activo.FechaAsignacion;
                    worksheet.Cell(i + 2, 19).Value = activo.Observaciones;
                }
                // Guardar el archivo
                workbook.SaveAs("ActivosAsignados.xlsx");
            }
        }

        public void ExportToPDF(List<object> activos)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("ActivosAsignados.pdf", FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(19);
            table.AddCell("ID Activo");
            table.AddCell("Código");
            table.AddCell("Nombre del Activo");
            table.AddCell("Categoría");
            table.AddCell("Ubicación");
            table.AddCell("Unidad");
            table.AddCell("Fecha de Adquisición");
            table.AddCell("Valor de Adquisición");
            table.AddCell("Estado");
            table.AddCell("Número de Depreciaciones");
            table.AddCell("Descripción");
            table.AddCell("Motivo de Baja");
            table.AddCell("Motivo de Eliminación");
            table.AddCell("Nombre del Personal");
            table.AddCell("Apellido");
            table.AddCell("Email");
            table.AddCell("Teléfono");
            table.AddCell("Fecha de Asignación");
            table.AddCell("Observaciones");
            foreach (var activo in activos)
            {
                table.AddCell(activo.ActivoID.ToString());
                table.AddCell(activo.CodigoActivo);
                table.AddCell(activo.NombreActivo);
                table.AddCell(activo.NombreCategoria);
                table.AddCell(activo.NombreUbicacion);
                table.AddCell(activo.NombreUnidad);
                table.AddCell(activo.FechaAdquisicion.ToString());
                table.AddCell(activo.ValorAdquisicion.ToString());
                table.AddCell(activo.EstadoBaja);
                table.AddCell(activo.NumeroDepreciaciones.ToString());
                table.AddCell(activo.DescripcionActivo);
                table.AddCell(activo.MotivoBajaActivo);
                table.AddCell(activo.MotivoEliminarActivo);
                table.AddCell(activo.NombrePersonal);
                table.AddCell(activo.Apellido);
                table.AddCell(activo.Email);
                table.AddCell(activo.Telefono);
                table.AddCell(activo.FechaAsignacion.ToString());
                table.AddCell(activo.Observaciones);
            }
            document.Add(table);
            document.Close();
        }*/
    }

}
