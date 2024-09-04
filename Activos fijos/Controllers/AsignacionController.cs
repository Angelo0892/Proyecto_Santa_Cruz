using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class AsignacionController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<object> GetAllAsignaciones()
        {
            List<object> asignaciones = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                            SELECT 
                                a.AsignacionID, af.ActivoID, af.CodigoActivo, na.NombreActivo_, 
                                p.NombrePersonal, p.Apellido, c.NombreCargo, a.FechaAsignacion, a.Observaciones
                            FROM ASIGNACION a
                            JOIN ACTIVOFIJO af ON a.ActivoID = af.ActivoID
                            JOIN NOMBREACTIVO na ON af.NombreActivoID = na.NombreActivoID
                            JOIN PERSONAL p ON a.PersonalID = p.PersonalID
                            JOIN CARGO c ON p.CargoID = c.CargoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var asignacion = new
                    {
                        AsignacionID = (int)reader["AsignacionID"],
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        NombrePersonal = (string)reader["NombrePersonal"],
                        Apellido = (string)reader["Apellido"],
                        NombreCargo = (string)reader["NombreCargo"],
                        FechaAsignacion = (DateTime)reader["FechaAsignacion"],
                        Observaciones = reader["Observaciones"] != DBNull.Value ? (string)reader["Observaciones"] : string.Empty
                    };

                    asignaciones.Add(asignacion);
                }
            }
            return asignaciones;
        }
        public void AddAsignacion(Asignacion asignacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ASIGNACION (ActivoID, PersonalID, FechaAsignacion, Observaciones) VALUES (@ActivoID, @PersonalID, @FechaAsignacion, @Observaciones)", conn);
                cmd.Parameters.AddWithValue("@ActivoID", asignacion.ActivoID);
                cmd.Parameters.AddWithValue("@PersonalID", asignacion.PersonalID);
                cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.FechaAsignacion);
                cmd.Parameters.AddWithValue("@Observaciones", asignacion.Observaciones);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateAsignacion(Asignacion asignacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ASIGNACION SET FechaAsignacion = @FechaAsignacion, Observaciones = @Observaciones WHERE AsignacionID = @AsignacionID", conn);
                cmd.Parameters.AddWithValue("@AsignacionID", asignacion.AsignacionID);
                cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.FechaAsignacion);
                cmd.Parameters.AddWithValue("@Observaciones", asignacion.Observaciones);
                cmd.ExecuteNonQuery();
            }
        }        
    }
}

