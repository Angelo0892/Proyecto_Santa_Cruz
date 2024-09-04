using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class UbicacionController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<Ubicacion> GetAllUbicaciones()
        {
            List<Ubicacion> ubicacionList = new List<Ubicacion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UBICACION", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ubicacionList.Add(new Ubicacion
                    {
                        UbicacionID = (int)reader["UbicacionID"],
                        NombreUbicacion = (string)reader["NombreUbicacion"]
                    });
                }
            }
            return ubicacionList;
        }

        public void AddUbicacion(Ubicacion ubicacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UBICACION (NombreUbicacion) VALUES (@NombreUbicacion)", conn);
                cmd.Parameters.AddWithValue("@NombreUbicacion", ubicacion.NombreUbicacion);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUbicacion(Ubicacion ubicacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UBICACION SET NombreUbicacion = @NombreUbicacion WHERE UbicacionID = @UbicacionID", conn);
                cmd.Parameters.AddWithValue("@UbicacionID", ubicacion.UbicacionID);
                cmd.Parameters.AddWithValue("@NombreUbicacion", ubicacion.NombreUbicacion);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUbicacion(int ubicacionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UBICACION WHERE UbicacionID = @UbicacionID", conn);
                cmd.Parameters.AddWithValue("@UbicacionID", ubicacionID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
