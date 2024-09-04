using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class CargoController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<Cargo> GetAllCargos()
        {
            List<Cargo> cargoList = new List<Cargo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CARGO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cargoList.Add(new Cargo
                    {
                        CargoID = (int)reader["CargoID"],
                        NombreCargo = (string)reader["NombreCargo"]
                    });
                }
            }
            return cargoList;
        }

        public void AddCargo(Cargo cargo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CARGO (NombreCargo) VALUES (@NombreCargo)", conn);
                cmd.Parameters.AddWithValue("@NombreCargo", cargo.NombreCargo);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCargo(Cargo cargo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CARGO SET NombreCargo = @NombreCargo WHERE CargoID = @CargoID", conn);
                cmd.Parameters.AddWithValue("@CargoID", cargo.CargoID);
                cmd.Parameters.AddWithValue("@NombreCargo", cargo.NombreCargo);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCargo(int cargoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CARGO WHERE CargoID = @CargoID", conn);
                cmd.Parameters.AddWithValue("@CargoID", cargoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
