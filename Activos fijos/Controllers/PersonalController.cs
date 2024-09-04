using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class PersonalController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<object> GetAllPersonal()
        {
            List<object> personalList = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT p.PersonalID, p.NombrePersonal, p.Apellido, c.NombreCargo, c.CargoID, u.UnidadID, u.NombreUnidad, p.Email, p.Telefono " +
                    "FROM PERSONAL p " +
                    "JOIN CARGO c ON p.CargoID = c.CargoID " +
                    "JOIN UNIDAD u ON p.UnidadID = u.UnidadID", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    personalList.Add(new
                    {
                        PersonalID = (int)reader["PersonalID"],
                        NombrePersonal = (string)reader["NombrePersonal"],
                        Apellido = (string)reader["Apellido"],
                        CargoID = (int)reader["CargoID"],
                        NombreCargo = (string)reader["NombreCargo"],
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        Email = (string)reader["Email"],
                        Telefono = (string)reader["Telefono"]
                    });
                }
            }
            return personalList;
        }
        public List<object> GetAssignedActivosByPersonalID(int personalID)
        {
            List<object> activosFijos = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    AF.ActivoID,
    AF.CodigoActivo,
    NA.NombreActivo_,
    C.NombreCategoria,
    AF.FechaAdquisicion,
    AF.ValorAdquisicion,
    U.NombreUbicacion,
    UN.NombreUnidad,
    AF.DescripcionActivo,
    A.FechaAsignacion,
    A.Observaciones
FROM 
    ACTIVOFIJO AF
    INNER JOIN NOMBREACTIVO NA ON AF.NombreActivoID = NA.NombreActivoID
    INNER JOIN CATEGORIA C ON AF.CategoriaID = C.CategoriaID
    INNER JOIN UBICACION U ON AF.UbicacionID = U.UbicacionID
    INNER JOIN UNIDAD UN ON AF.UnidadID = UN.UnidadID
    INNER JOIN ASIGNACION A ON AF.ActivoID = A.ActivoID
WHERE 
    A.PersonalID = @PersonalID
    AND NOT EXISTS (
        SELECT 1 
        FROM RETORNO R 
        WHERE R.ActivoID = AF.ActivoID
    );";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonalID", personalID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var activoFijo = new
                    {
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        FechaAdquisicion = (DateTime)reader["FechaAdquisicion"],
                        ValorAdquisicion = (decimal)reader["ValorAdquisicion"],
                        NombreUbicacion = (string)reader["NombreUbicacion"],
                        NombreUnidad = (string)reader["NombreUnidad"],
                        DescripcionActivo = (string)reader["DescripcionActivo"],
                        FechaAsignacion = (DateTime)reader["FechaAsignacion"],
                        Observaciones = reader["Observaciones"] != DBNull.Value ? (string)reader["Observaciones"] : string.Empty
                    };

                    activosFijos.Add(activoFijo);
                }
            }
            return activosFijos;
        }
        public void AddPersonal(Personal personal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PERSONAL (NombrePersonal, Apellido, CargoID, UnidadID, Email, Telefono) VALUES (@NombrePersonal, @Apellido, @CargoID, @UnidadID, @Email, @Telefono)", conn);
                cmd.Parameters.AddWithValue("@NombrePersonal", personal.NombrePersonal);
                cmd.Parameters.AddWithValue("@Apellido", personal.Apellido);
                cmd.Parameters.AddWithValue("@CargoID", personal.CargoID);
                cmd.Parameters.AddWithValue("@UnidadID", personal.UnidadID);
                cmd.Parameters.AddWithValue("@Email", personal.Email);
                cmd.Parameters.AddWithValue("@Telefono", personal.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePersonal(Personal personal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PERSONAL SET NombrePersonal = @NombrePersonal, Apellido = @Apellido, CargoID = @CargoID, UnidadID = @UnidadID, Email = @Email, Telefono = @Telefono WHERE PersonalID = @PersonalID", conn);
                cmd.Parameters.AddWithValue("@PersonalID", personal.PersonalID);
                cmd.Parameters.AddWithValue("@NombrePersonal", personal.NombrePersonal);
                cmd.Parameters.AddWithValue("@Apellido", personal.Apellido);
                cmd.Parameters.AddWithValue("@CargoID", personal.CargoID);
                cmd.Parameters.AddWithValue("@UnidadID", personal.UnidadID);
                cmd.Parameters.AddWithValue("@Email", personal.Email);
                cmd.Parameters.AddWithValue("@Telefono", personal.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePersonal(int personalID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PERSONAL WHERE PersonalID = @PersonalID", conn);
                cmd.Parameters.AddWithValue("@PersonalID", personalID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
