using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class NombreActivoController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<NombreActivo> GetAllNombreActivos()
        {
            List<NombreActivo> nombreActivoList = new List<NombreActivo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NOMBREACTIVO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombreActivoList.Add(new NombreActivo
                    {
                        NombreActivoID = (int)reader["NombreActivoID"],
                        NombreActivo_ = (string)reader["NombreActivo_"]
                    });
                }
            }
            return nombreActivoList;
        }

        public void AddNombreActivo(NombreActivo nombreActivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NOMBREACTIVO (NombreActivo_) VALUES (@NombreActivo_)", conn);
                cmd.Parameters.AddWithValue("@NombreActivo_", nombreActivo.NombreActivo_);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateNombreActivo(NombreActivo nombreActivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NOMBREACTIVO SET NombreActivo_ = @NombreActivo_ WHERE NombreActivoID = @NombreActivoID", conn);
                cmd.Parameters.AddWithValue("@NombreActivoID", nombreActivo.NombreActivoID);
                cmd.Parameters.AddWithValue("@NombreActivo_", nombreActivo.NombreActivo_);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteNombreActivo(int nombreActivoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NOMBREACTIVO WHERE NombreActivoID = @NombreActivoID", conn);
                cmd.Parameters.AddWithValue("@NombreActivoID", nombreActivoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
