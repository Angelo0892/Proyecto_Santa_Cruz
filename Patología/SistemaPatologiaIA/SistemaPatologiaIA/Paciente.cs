using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPatologiaIA
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int DoctorID { get; set; }
        public string Direccion { get; set; }
        public string NumeroContacto { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }  // Para indicar si el paciente está activo o inactivo
    }

    public class PacienteRepository
    {
        private DatabaseConnection dbConnection;

        public PacienteRepository()
        {
            dbConnection = new DatabaseConnection();
        }

        // Crear Paciente
        public void AgregarPaciente(Paciente paciente)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Pacientes (Nombre, Apellido, FechaNacimiento, Genero,FechaRegistro,DoctorID, Direccion, NumeroContacto, Email, Activo) " +
                               "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Genero,@FechaRegistro,@DoctorID, @Direccion, @NumeroContacto, @Email, @Activo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Genero", paciente.Genero);
                cmd.Parameters.AddWithValue("@FechaRegistro", paciente.FechaRegistro);
                cmd.Parameters.AddWithValue("@DoctorID", paciente.DoctorID);
                cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                cmd.Parameters.AddWithValue("@NumeroContacto", paciente.NumeroContacto);
                cmd.Parameters.AddWithValue("@Email", paciente.Email);
                cmd.Parameters.AddWithValue("@Activo", paciente.Activo);

                cmd.ExecuteNonQuery();
            }
        }

        // Leer Pacientes
        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pacientes.Add(new Paciente
                        {
                            PacienteID = (int)reader["PacienteID"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellido"],
                            FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                            Genero = (string)reader["Genero"],
                            FechaRegistro = (DateTime)reader["FechaRegistro"],
                            DoctorID = (int)reader["DoctorID"],
                            Direccion = (string)reader["Direccion"],
                            NumeroContacto = (string)reader["NumeroContacto"],
                            Email = (string)reader["Email"],
                            Activo = (bool)reader["Activo"]
                        });
                    }
                }
            }
            return pacientes;
        }

        // Actualizar Paciente
        public void ActualizarPaciente(Paciente paciente)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Pacientes SET " +
                               "Nombre = @Nombre, " +
                               "Apellido = @Apellido, " +
                               "FechaNacimiento = @FechaNacimiento, " +
                               "Genero = @Genero, " +
                               "FechaRegistro = @FechaRegistro, " +
                               "DoctorID = @DoctorID, " +
                               "Direccion = @Direccion, " +
                               "NumeroContacto = @NumeroContacto, " +
                               "Email = @Email, " +
                               "Activo = @Activo " +
                               "WHERE PacienteID = @PacienteID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Genero", paciente.Genero);
                cmd.Parameters.AddWithValue("@FechaRegistro", paciente.FechaRegistro);
                cmd.Parameters.AddWithValue("@DoctorID", paciente.DoctorID);
                cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                cmd.Parameters.AddWithValue("@NumeroContacto", paciente.NumeroContacto);
                cmd.Parameters.AddWithValue("@Email", paciente.Email);
                cmd.Parameters.AddWithValue("@Activo", paciente.Activo);
                cmd.Parameters.AddWithValue("@PacienteID", paciente.PacienteID);

                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Paciente
        public void EliminarPaciente(int pacienteID)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Pacientes WHERE PacienteID = @PacienteID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PacienteID", pacienteID);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public class ReporteExcel
    {
        public void ExportarReportePacientes(List<Paciente> pacientes)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar Reporte de Pacientes";
                saveFileDialog.FileName = "ReportePacientes.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Pacientes");

                        // Título del reporte
                        worksheet.Cells[1, 1].Value = "Reporte de Pacientes";
                        worksheet.Cells[1, 1, 1, 5].Merge = true; // Combina las celdas A1 a E1
                        worksheet.Cells[1, 1, 1, 5].Style.Font.Size = 16; // Tamaño de fuente
                        worksheet.Cells[1, 1, 1, 5].Style.Font.Bold = true; // Negrita
                        worksheet.Cells[1, 1, 1, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Centrado

                        // Fecha de generación del reporte
                        worksheet.Cells[2, 1].Value = "Fecha de Generación:";
                        worksheet.Cells[2, 2].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        worksheet.Cells[2, 1, 2, 5].Style.Font.Bold = true; // Negrita para el texto

                        // Encabezados de las columnas
                        worksheet.Cells[4, 1].Value = "ID";
                        worksheet.Cells[4, 2].Value = "Nombre";
                        worksheet.Cells[4, 3].Value = "Apellido";
                        worksheet.Cells[4, 4].Value = "Fecha Nacimiento";
                        worksheet.Cells[4, 5].Value = "Género";

                        // Aplicar formato a los encabezados
                        using (var range = worksheet.Cells[4, 1, 4, 5])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                            range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        }

                        // Llenar los datos de los pacientes
                        int row = 5;
                        foreach (var paciente in pacientes)
                        {
                            worksheet.Cells[row, 1].Value = paciente.PacienteID;
                            worksheet.Cells[row, 2].Value = paciente.Nombre;
                            worksheet.Cells[row, 3].Value = paciente.Apellido;
                            worksheet.Cells[row, 4].Value = paciente.FechaNacimiento.ToShortDateString();
                            worksheet.Cells[row, 5].Value = paciente.Genero;

                            // Aplicar borde a cada fila
                            using (var range = worksheet.Cells[row, 1, row, 5])
                            {
                                range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }

                            row++;
                        }

                        // Ajustar el ancho de las columnas automáticamente
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        package.Save();  // Guarda el archivo Excel
                    }

                    MessageBox.Show("Reporte generado en " + filePath);
                }
            }
        }
    }
   
    //Método para obtener un paciente por su ID
    //public Paciente ObtenerPacientePorID(int pacienteID)
    //{
    //    Paciente paciente = null;

    //    using (SqlConnection conn = dbConnection.GetConnection())
    //    {
    //        conn.Open();
    //        string query = "SELECT * FROM Pacientes WHERE PacienteID = @PacienteID";
    //        SqlCommand cmd = new SqlCommand(query, conn);
    //        cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
    //        SqlDataReader reader = cmd.ExecuteReader();

    //        if (reader.Read())
    //        {
    //            paciente = new Paciente
    //            {
    //                PacienteID = (int)reader["PacienteID"],
    //                Nombre = (string)reader["Nombre"],
    //                Apellido = (string)reader["Apellido"],
    //                FechaNacimiento = (DateTime)reader["FechaNacimiento"],
    //                Genero = (string)reader["Genero"],
    //                DoctorID = (int)reader["DoctorID"],
    //                FechaRegistro = (DateTime)reader["FechaRegistro"]
    //            };
    //        }
    //    }

    //    return paciente;
    //}

}
