using Proyecto_almacen.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_almacen.Controladores
{
    internal class DbConexion
    {
        private SqlConnection conexion;

        public DbConexion()
        {
            //bd rodri "Server=DESKTOP-TFHCQ27\\SQLEXPRESS;Database=Almacen;Integrated security=true;";
            //ServerPircing: DESKTOP-TFHCQ27\\SQLEXPRESS
            //ServerDonPipis: LAPTOP-HNTNC1IL\\SQLEXPRESS

            string conexionDb = "Server=JHON\\SQLEXPRESS;Database=cafet;Integrated security=true;";
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

        public void Insertar(string nombreTabla, string[] _solicitudInsercion)
        {
            ModificarIdTemporal();

            int primer_valor = 0;
            string[] solicitudInsercion = _solicitudInsercion;

            string query = "INSERT INTO " + nombreTabla + " VALUES (";

            foreach (string valor in solicitudInsercion)
            {
                if (primer_valor != 0)
                {
                    query += ", ";
                }

                if (int.TryParse(valor, out int intValue))
                {
                    query = query + valor;
                }
                else if (double.TryParse(valor, out double doubleValue))
                {
                    query = query + valor;
                }
                else
                {
                    query += "'" + valor + "'";
                }
                primer_valor++;
            }

            query = query + ")";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            Console.WriteLine(query);
        }

        public void Moficar(string nombreTabla, string[] nombreColumna, string[] solicitudModicacion, string id)
        {
            ModificarIdTemporal();

            int indice = 0;

            string query = "UPDATE " + nombreTabla + " SET ";

            foreach (string valor in solicitudModicacion)
            {
                if (indice != 0)
                {
                    query += ", ";
                }

                if (int.TryParse(valor, out int intValue))
                {
                    query += nombreColumna[indice] + " = " + valor;
                }
                else if (double.TryParse(valor, out double doubleValue))
                {
                    query += nombreColumna[indice] + "=" + valor;
                }
                else
                {
                    query += nombreColumna[indice] + " = '" + valor + "'";
                }

                indice++;
            }

            query += " WHERE " + nombreColumna[indice] + " = " + id;

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            Console.WriteLine(query);
        }

        public void Eliminar(string nombreTabla, string nombreId, string id)
        {
            ModificarIdTemporal();

            string query = "DELETE FROM " + nombreTabla;
            query += " WHERE " + nombreId + " = " + id;

            if (!id.Equals(""))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }

            Console.WriteLine(query);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        public DataTable BuscarTabla(string nombreTabla)
        {
            string query = "SELECT * FROM " + nombreTabla;

            SqlDataAdapter comando = new SqlDataAdapter(query, conexion);

            DataTable datosTabla = new DataTable();
            comando.Fill(datosTabla);

            return datosTabla;
        }


        public DataTable BuscarDosTablas(string nombreId, string[] columnas
            , string[] nombreTablas, string[] nombreColumnas, string[] columnasBuscar)
        {
            int conteo = 0;
            string query = "SELECT ";

            foreach (string columna in columnas)
            {
                if (conteo != 0)
                {
                    query += ", ";
                }
                query += columna;

                conteo++;
            }

            query += " FROM ";
            conteo = 0;

            query += nombreTablas[0];
            query += " INNER JOIN ";
            query += nombreTablas[1];
            query += " ON ";
            query += nombreTablas[0] + "." + nombreId + " = " + nombreTablas[1] 
                + "." + nombreId;

            query += " WHERE ";

            foreach (string nombreColumna in nombreColumnas)
            {
                if (conteo != 0)
                {
                    query += " and ";
                }

                if (int.TryParse(nombreColumna, out int intValue))
                {
                    query += nombreColumna + " = " + columnasBuscar[conteo];
                }
                else if (double.TryParse(nombreColumna, out double doubleValue))
                {
                    query += nombreColumna + "=" + columnasBuscar[conteo];
                }
                else
                {
                    query += nombreColumna + " = '" + columnasBuscar[conteo] + "'";
                }

                conteo++;
            }

            Console.WriteLine(query);

            SqlDataAdapter comando = new SqlDataAdapter(query, conexion);
            DataTable datosTablas = new DataTable();
            comando.Fill(datosTablas);

            return datosTablas;
        }

        public void ModificarIdTemporal()
        {
            const string ID = "1";
            string query = "UPDATE IdTemporal SET idTemporal = " + Global.idUsuario + " Where id = " + ID;
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        //Codigo en proceso, Función que devulve varias tablas como DataTable
        /*
        public DataTable BuscarVariasTablas(int cantidadTablas, string[] , string[] nombreTablas)
        {
            string query = "SELECT * FROM ";
            
            for (int i = 0; i < cantidadTablas; i++)
            {

            }

            return datosTabla;
        }
        */
    }
}   
