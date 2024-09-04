using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class UnidadController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<Unidad> GetAllUnidades()
        {
            List<Unidad> unidadList = new List<Unidad>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UNIDAD", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    unidadList.Add(new Unidad
                    {
                        UnidadID = (int)reader["UnidadID"],
                        NombreUnidad = (string)reader["NombreUnidad"]
                    });
                }
            }
            return unidadList;
        }

        public void AddUnidad(Unidad unidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UNIDAD (NombreUnidad) VALUES (@NombreUnidad)", conn);
                cmd.Parameters.AddWithValue("@NombreUnidad", unidad.NombreUnidad);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUnidad(Unidad unidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UNIDAD SET NombreUnidad = @NombreUnidad WHERE UnidadID = @UnidadID", conn);
                cmd.Parameters.AddWithValue("@UnidadID", unidad.UnidadID);
                cmd.Parameters.AddWithValue("@NombreUnidad", unidad.NombreUnidad);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUnidad(int unidadID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UNIDAD WHERE UnidadID = @UnidadID", conn);
                cmd.Parameters.AddWithValue("@UnidadID", unidadID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
