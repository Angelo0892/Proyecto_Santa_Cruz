using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPatologiaIA
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; } // Activo o Inactivo
        public string NumeroLicenciaMedica { get; set; }
        public DateTime FechaExpiracionLicencia { get; set; }
        public string TurnoAsignado { get; set; }
        public string InstitucionGraduacion { get; set; }
        public int AnioGraduacion { get; set; }
        public bool DisponibilidadAsignacionPaciente { get; set; }
    }
    public class DoctorRepository
    {
        private DatabaseConnection dbConnection;

        public DoctorRepository()
        {
            dbConnection = new DatabaseConnection();
        }

        public void AgregarDoctor(Doctor doctor)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Doctores 
                            (Nombre, Apellido, Especialidad, Email, Estado, NumeroLicenciaMedica, 
                             FechaExpiracionLicencia, TurnoAsignado, InstitucionGraduacion, AnioGraduacion, DisponibilidadAsignacionPaciente) 
                             VALUES 
                            (@Nombre, @Apellido, @Especialidad, @Email, @Estado, @NumeroLicenciaMedica, 
                             @FechaExpiracionLicencia, @TurnoAsignado, @InstitucionGraduacion, @AnioGraduacion, @DisponibilidadAsignacionPaciente)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", doctor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", doctor.Apellido);
                cmd.Parameters.AddWithValue("@Especialidad", doctor.Especialidad);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@Estado", doctor.Estado);
                cmd.Parameters.AddWithValue("@NumeroLicenciaMedica", doctor.NumeroLicenciaMedica);
                cmd.Parameters.AddWithValue("@FechaExpiracionLicencia", doctor.FechaExpiracionLicencia);
                cmd.Parameters.AddWithValue("@TurnoAsignado", doctor.TurnoAsignado);
                cmd.Parameters.AddWithValue("@InstitucionGraduacion", doctor.InstitucionGraduacion);
                cmd.Parameters.AddWithValue("@AnioGraduacion", doctor.AnioGraduacion);
                cmd.Parameters.AddWithValue("@DisponibilidadAsignacionPaciente", doctor.DisponibilidadAsignacionPaciente);

                cmd.ExecuteNonQuery();
            }
        }

        public Doctor ObtenerDoctorPorID(int doctorID)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Doctores WHERE DoctorID = @DoctorID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Doctor
                    {
                        DoctorID = Convert.ToInt32(reader["DoctorID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Especialidad = reader["Especialidad"].ToString(),
                        Email = reader["Email"].ToString(),
                        Estado = Convert.ToBoolean(reader["Estado"]),
                        NumeroLicenciaMedica = reader["NumeroLicenciaMedica"].ToString(),
                        FechaExpiracionLicencia = Convert.ToDateTime(reader["FechaExpiracionLicencia"]),
                        TurnoAsignado = reader["TurnoAsignado"].ToString(),
                        InstitucionGraduacion = reader["InstitucionGraduacion"].ToString(),
                        AnioGraduacion = Convert.ToInt32(reader["AnioGraduacion"]),
                        DisponibilidadAsignacionPaciente = Convert.ToBoolean(reader["DisponibilidadAsignacionPaciente"])
                    };
                }

                return null;
            }
        }

        public void ActualizarDoctor(Doctor doctor)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Doctores SET 
                            Nombre = @Nombre, Apellido = @Apellido, Especialidad = @Especialidad, 
                            Email = @Email, Estado = @Estado, NumeroLicenciaMedica = @NumeroLicenciaMedica, 
                            FechaExpiracionLicencia = @FechaExpiracionLicencia, TurnoAsignado = @TurnoAsignado, 
                            InstitucionGraduacion = @InstitucionGraduacion, AnioGraduacion = @AnioGraduacion, 
                            DisponibilidadAsignacionPaciente = @DisponibilidadAsignacionPaciente 
                            WHERE DoctorID = @DoctorID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                cmd.Parameters.AddWithValue("@Nombre", doctor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", doctor.Apellido);
                cmd.Parameters.AddWithValue("@Especialidad", doctor.Especialidad);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@Estado", doctor.Estado);
                cmd.Parameters.AddWithValue("@NumeroLicenciaMedica", doctor.NumeroLicenciaMedica);
                cmd.Parameters.AddWithValue("@FechaExpiracionLicencia", doctor.FechaExpiracionLicencia);
                cmd.Parameters.AddWithValue("@TurnoAsignado", doctor.TurnoAsignado);
                cmd.Parameters.AddWithValue("@InstitucionGraduacion", doctor.InstitucionGraduacion);
                cmd.Parameters.AddWithValue("@AnioGraduacion", doctor.AnioGraduacion);
                cmd.Parameters.AddWithValue("@DisponibilidadAsignacionPaciente", doctor.DisponibilidadAsignacionPaciente);

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarDoctor(int doctorID)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Doctores WHERE DoctorID = @DoctorID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Doctor> ObtenerDoctores()
        {
            List<Doctor> doctores = new List<Doctor>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Doctores";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctores.Add(new Doctor
                        {
                            DoctorID = (int)reader["DoctorID"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellido"],
                            NumeroLicenciaMedica = (string)reader["NumeroLicenciaMedica"],
                            FechaExpiracionLicencia = (DateTime)reader["FechaExpiracionLicencia"],
                            TurnoAsignado = (string)reader["TurnoAsignado"],
                            InstitucionGraduacion = (string)reader["InstitucionGraduacion"],
                            AnioGraduacion = (int)reader["AnioGraduacion"],
                            Estado = (bool)reader["Estado"],
                            DisponibilidadAsignacionPaciente = (bool)reader["DisponibilidadAsignacionPaciente"]
                        });
                    }
                }
            }
            return doctores;
        }

        public class reporteExcel
        {
            public void ExportarReporteDoctores(List<Doctor> doctores)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Guardar Reporte de Doctores";
                    saveFileDialog.FileName = "ReporteDoctores.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;

                        using (var package = new ExcelPackage(new FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Doctores");

                            worksheet.Cells[1, 1].Value = "Reporte de Doctores";
                            worksheet.Cells[1, 1, 1, 6].Merge = true;
                            worksheet.Cells[1, 1, 1, 6].Style.Font.Size = 16;
                            worksheet.Cells[1, 1, 1, 6].Style.Font.Bold = true;
                            worksheet.Cells[1, 1, 1, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            worksheet.Cells[2, 1].Value = "Fecha de Generación:";
                            worksheet.Cells[2, 2].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            worksheet.Cells[2, 1, 2, 6].Style.Font.Bold = true;

                            worksheet.Cells[4, 1].Value = "ID";
                            worksheet.Cells[4, 2].Value = "Nombre";
                            worksheet.Cells[4, 3].Value = "Apellido";
                            worksheet.Cells[4, 4].Value = "Licencia Médica";
                            worksheet.Cells[4, 5].Value = "Turno Asignado";
                            worksheet.Cells[4, 6].Value = "Disponibilidad";

                            using (var range = worksheet.Cells[4, 1, 4, 6])
                            {
                                range.Style.Font.Bold = true;
                                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                                range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            int row = 5;
                            foreach (var doctor in doctores)
                            {
                                worksheet.Cells[row, 1].Value = doctor.DoctorID;
                                worksheet.Cells[row, 2].Value = doctor.Nombre;
                                worksheet.Cells[row, 3].Value = doctor.Apellido;
                                worksheet.Cells[row, 4].Value = doctor.NumeroLicenciaMedica;
                                worksheet.Cells[row, 5].Value = doctor.TurnoAsignado;
                                worksheet.Cells[row, 6].Value = doctor.DisponibilidadAsignacionPaciente;

                                using (var range = worksheet.Cells[row, 1, row, 6])
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
