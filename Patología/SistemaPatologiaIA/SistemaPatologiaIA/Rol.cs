using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPatologiaIA
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }
    public class RolRepository
    {
        private DatabaseConnection dbConnection;

        public RolRepository()
        {
            dbConnection = new DatabaseConnection();
        }

        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Rol";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new Rol
                        {
                            IdRol = (int)reader["IdRol"],
                            NombreRol = (string)reader["NombreRol"]
                        });
                    }
                }
            }
            return roles;
        }

        // Métodos adicionales para agregar, actualizar y eliminar roles.
    }


}
