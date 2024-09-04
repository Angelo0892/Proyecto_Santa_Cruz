using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ACTIVOS_FIJOS.Controllers
{
    internal class AccesoController
    { 
        private SqlConnection conexion;

        public AccesoController()
        {
            string conexionDb = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
            conexion = new SqlConnection(conexionDb);

            try
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al establecer la conexión: {ex.Message}");
            }
        }   
        public string AutenticarUsuarios(string nombreUsuario, string password)
        {

            string query = "SELECT idUsuario, rol FROM Usuario WHERE nombreU=@nombre AND codigo=@password AND estado='Habilitado'";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@nombre", nombreUsuario);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string rol = reader["rol"].ToString();
                        Global.idUsuario = reader["idUsuario"].ToString();
                        reader.Close();
                        //Console.WriteLine(rol);
                        return rol;
                    }
                    else
                    {
                        reader.Close();
                        //Console.WriteLine("Entro en else");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                    //Console.WriteLine("Entro en el catch");
                    return null;
                }
            }
        }
    }
}
