using OfficeOpenXml.Style;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace SistemaPatologiaIA
{
    public class HistorialMedico
    {
        public int IdHistorial { get; set; }
        public int PacienteID { get; set; }
        public int DoctorID { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
    public class HistorialMedicoRepository
    {
        private DatabaseConnection dbConnection;

        public HistorialMedicoRepository()
        {
            dbConnection = new DatabaseConnection();
        }

        // Método para agregar un nuevo historial médico
        public void AgregarHistorialMedico(HistorialMedico historial)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO HistorialMedico (PacienteID, DoctorID, FechaConsulta, Sintomas, Diagnostico, Tratamiento, Observaciones) VALUES (@PacienteID, @DoctorID, @FechaConsulta, @Sintomas, @Diagnostico, @Tratamiento, @Observaciones)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PacienteID", historial.PacienteID);
                cmd.Parameters.AddWithValue("@DoctorID", historial.DoctorID);
                cmd.Parameters.AddWithValue("@FechaConsulta", historial.FechaConsulta);
                cmd.Parameters.AddWithValue("@Sintomas", historial.Sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                cmd.Parameters.AddWithValue("@Tratamiento", historial.Tratamiento);
                cmd.Parameters.AddWithValue("@Observaciones", historial.Observaciones ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener un historial médico por ID
        public HistorialMedico ObtenerHistorialMedicoPorID(int idHistorial)
        {
            HistorialMedico historial = null;
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM HistorialMedico WHERE IdHistorial = @IdHistorial";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdHistorial", idHistorial);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        historial = new HistorialMedico
                        {
                            IdHistorial = (int)reader["IdHistorial"],
                            PacienteID = (int)reader["PacienteID"],
                            DoctorID = (int)reader["DoctorID"],
                            FechaConsulta = (DateTime)reader["FechaConsulta"],
                            Sintomas = reader["Sintomas"] as string,
                            Diagnostico = reader["Diagnostico"] as string,
                            Tratamiento = reader["Tratamiento"] as string,
                            Observaciones = reader["Observaciones"] as string
                        };
                    }
                }
            }
            return historial;
        }

        // Método para actualizar un historial médico
        public void ActualizarHistorialMedico(HistorialMedico historial)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE HistorialMedico SET PacienteID = @PacienteID, DoctorID = @DoctorID, FechaConsulta = @FechaConsulta, Sintomas = @Sintomas, Diagnostico = @Diagnostico, Tratamiento = @Tratamiento, Observaciones = @Observaciones WHERE IdHistorial = @IdHistorial";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdHistorial", historial.IdHistorial);
                cmd.Parameters.AddWithValue("@PacienteID", historial.PacienteID);
                cmd.Parameters.AddWithValue("@DoctorID", historial.DoctorID);
                cmd.Parameters.AddWithValue("@FechaConsulta", historial.FechaConsulta);
                cmd.Parameters.AddWithValue("@Sintomas", historial.Sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                cmd.Parameters.AddWithValue("@Tratamiento", historial.Tratamiento);
                cmd.Parameters.AddWithValue("@Observaciones", historial.Observaciones ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un historial médico
        public void EliminarHistorialMedico(int idHistorial)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM HistorialMedico WHERE IdHistorial = @IdHistorial";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdHistorial", idHistorial);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los historiales médicos
        public List<HistorialMedico> ObtenerTodosLosHistorialesMedicos()
        {
            List<HistorialMedico> historiales = new List<HistorialMedico>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM HistorialMedico";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        historiales.Add(new HistorialMedico
                        {
                            IdHistorial = (int)reader["IdHistorial"],
                            PacienteID = (int)reader["PacienteID"],
                            DoctorID = (int)reader["DoctorID"],
                            FechaConsulta = (DateTime)reader["FechaConsulta"],
                            Sintomas = reader["Sintomas"] as string,
                            Diagnostico = reader["Diagnostico"] as string,
                            Tratamiento = reader["Tratamiento"] as string,
                            Observaciones = reader["Observaciones"] as string
                        });
                    }
                }
            }
            return historiales;
        }
        public class ReportExcel
        {
            public void ExportarReporteHistorialMedico(List<HistorialMedico> historial)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Guardar Reporte de Historial Médico";
                    saveFileDialog.FileName = "ReporteHistorialMedico.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;

                        using (var package = new ExcelPackage(new FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Historial Médico");

                            worksheet.Cells[1, 1].Value = "Reporte de Historial Médico";
                            worksheet.Cells[1, 1, 1, 5].Merge = true;
                            worksheet.Cells[1, 1, 1, 5].Style.Font.Size = 16;
                            worksheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;
                            worksheet.Cells[1, 1, 1, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            worksheet.Cells[2, 1].Value = "Fecha de Generación:";
                            worksheet.Cells[2, 2].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            worksheet.Cells[2, 1, 2, 5].Style.Font.Bold = true;

                            worksheet.Cells[4, 1].Value = "ID Paciente";
                            worksheet.Cells[4, 2].Value = "Fecha";
                            worksheet.Cells[4, 3].Value = "Diagnóstico";
                            worksheet.Cells[4, 4].Value = "Tratamiento";
                            worksheet.Cells[4, 5].Value = "Doctor";

                            using (var range = worksheet.Cells[4, 1, 4, 5])
                            {
                                range.Style.Font.Bold = true;
                                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                                range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            int row = 5;
                            foreach (var record in historial)
                            {
                                worksheet.Cells[row, 1].Value = record.PacienteID;
                                worksheet.Cells[row, 2].Value = record.FechaConsulta.ToShortDateString();
                                worksheet.Cells[row, 3].Value = record.Diagnostico;
                                worksheet.Cells[row, 4].Value = record.Tratamiento;
                                worksheet.Cells[row, 5].Value = record.DoctorID;

                                using (var range = worksheet.Cells[row, 1, row, 5])
                                {
                                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                }

                                row++;
                            }

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            package.Save();
                        }

                        MessageBox.Show("Reporte generado en " + filePath);
                    }
                }
            }

        }
       
    }


}
