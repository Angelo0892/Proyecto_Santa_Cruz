using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaPatologiaIA
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        // Constructor para inicializar la cadena de conexión
        public DatabaseConnection()
        {
            // Modifica la cadena de conexión con los datos correctos de tu servidor de base de datos
            connectionString = "Data Source=DESKTOP-NOJV07T\\SQLEXPRESS;Initial Catalog=PatologiaDB;Integrated Security=True";
        }

        // Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Método opcional para abrir la conexión
        public void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método opcional para cerrar la conexión
        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
