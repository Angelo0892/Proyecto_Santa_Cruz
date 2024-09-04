using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class RetornoController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        public void AddRetorno(Retorno retorno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO RETORNO (ActivoID, PersonalID, FechaRetorno, Condicion) VALUES (@ActivoID, @PersonalID, @FechaRetorno, @Condicion)", conn);
                cmd.Parameters.AddWithValue("@ActivoID", retorno.ActivoID);
                cmd.Parameters.AddWithValue("@PersonalID", retorno.PersonalID);
                cmd.Parameters.AddWithValue("@FechaRetorno", retorno.FechaRetorno);
                cmd.Parameters.AddWithValue("@Condicion", retorno.Condicion);
                cmd.ExecuteNonQuery();
            }
        }
        public List<object> GetAllRetornos()
        {
            List<object> retornos = new List<object>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        r.RetornoID, af.ActivoID, af.CodigoActivo, na.NombreActivo_, 
                        p.NombrePersonal, p.Apellido, c.NombreCargo, r.FechaRetorno, r.Condicion
                    FROM RETORNO r
                    JOIN ACTIVOFIJO af ON r.ActivoID = af.ActivoID
                    JOIN NOMBREACTIVO na ON af.NombreActivoID = na.NombreActivoID
                    JOIN PERSONAL p ON r.PersonalID = p.PersonalID
                    JOIN CARGO c ON p.CargoID = c.CargoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var retorno = new
                    {
                        RetornoID = (int)reader["RetornoID"],
                        ActivoID = (int)reader["ActivoID"],
                        CodigoActivo = (string)reader["CodigoActivo"],
                        NombreActivo = (string)reader["NombreActivo_"],
                        NombrePersonal = (string)reader["NombrePersonal"],
                        Apellido = (string)reader["Apellido"],
                        NombreCargo = (string)reader["NombreCargo"],
                        FechaRetorno = (DateTime)reader["FechaRetorno"],
                        Condicion = reader["Condicion"] != DBNull.Value ? (string)reader["Condicion"] : string.Empty
                    };

                    retornos.Add(retorno);
                }
            }
            return retornos;
        }
        public void UpdateRetorno(Retorno retorno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RETORNO SET FechaRetorno = @FechaRetorno, Condicion = @Condicion WHERE RetornoID = @RetornoID", conn);
                cmd.Parameters.AddWithValue("@RetornoID", retorno.RetornoID);
                cmd.Parameters.AddWithValue("@FechaRetorno", retorno.FechaRetorno);
                cmd.Parameters.AddWithValue("@Condicion", retorno.Condicion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
