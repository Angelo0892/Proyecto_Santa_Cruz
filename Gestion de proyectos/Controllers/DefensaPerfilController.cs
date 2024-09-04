using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;


namespace DEMOPROY1.Controllers
{
    public class DefensaPerfilController
    {
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");


        public DataTable ObtenerPerfil(int codigoEstudiante)
        {
            // Consulta SQL para obtener los perfiles relacionados con el postulante
            string query = "SELECT p.Id_Perfil, p.Titulo, p.Gestion, p.Semestre " +
                           "FROM PERFIL p " +
                           "INNER JOIN POSTULANTE po ON p.Codigo_Estudiante = po.Codigo_Estudiante " +
                           "WHERE po.Codigo_Estudiante = @Codigo_Estudiante";

            // Inicializamos la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexion"))
            {
                // Inicializamos el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añadimos el parámetro necesario para la consulta
                    command.Parameters.AddWithValue("@Codigo_Estudiante", codigoEstudiante);

                    // Ejecutamos la consulta y obtenemos los resultados en un DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);  // Llena el DataTable con los resultados
                        return dt;  // Retorna los perfiles obtenidos
                    }
                }
            }
        }

        public DataTable ObtenerPostulante()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Codigo_Estudiante, PrimerNombre FROM POSTULANTE";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el postulante: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerTribunal()
        {
            conexion.Open();
            DataTable dt = new DataTable();
            try
            {
                string consulta = @"
          SELECT 
            DP.ID_Perfil,
            T1.Id_Tribunal AS Id_Tribunal1,
            T1.PrimerNombre + ' ' + T1.PrimerApellido AS Tribunal1_NombreCompleto
            FROM 
            DEFENSA_PERFIL DP
            JOIN 
            TRIBUNAL T1 ON DP.ID_Tribunal1 = T1.Id_Tribunal";

         
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Tribunal: " + ex.Message);
            }
            return dt;

        }
        public DataTable ObtenerPerfil()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Perfil, Titulo FROM PERFIL";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el postulante: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerDocente()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Docente , PrimerNombre FROM DOCENTE";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el docente: " + ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerDefensaPerfil()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM DEFENSA_PERFIL";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Defensas De Perfil " + ex.Message);
            }
            return dt;
        }
        // Método para agregar una defensa de perfil
        public void AgregarDefensaPerfil(DefensaPerfil defensaPerfil)
        {
            
                conexion.Open();
                string query = "INSERT INTO DEFENSA_PERFIL (FechaDefensa, ESTADOPERFIL, Calficacion, ID_DocenteMDG1, ID_Tribunal1, ID_Postulante, ID_Perfil) " +
                               "VALUES (@FechaDefensa, @ESTADOPERFIL, @Calficacion, @ID_DocenteMDG1, @ID_Tribunal1, @ID_Postulante, @ID_Perfil)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDefensa", defensaPerfil.FechaDefensa);
                    cmd.Parameters.AddWithValue("@ESTADOPERFIL", defensaPerfil.EstadoPerfil);
                    cmd.Parameters.AddWithValue("@Calficacion", defensaPerfil.Calficacion);
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", defensaPerfil.ID_DocenteMDG1);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", defensaPerfil.ID_Tribunal1);
                    cmd.Parameters.AddWithValue("@ID_Postulante", defensaPerfil.ID_Postulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", defensaPerfil.ID_Perfil);

                    cmd.ExecuteNonQuery();
                conexion.Close();
                }
            
        }

        // Método para obtener todas las defensas de perfil
        public List<DefensaPerfil> ObtenerDefensasPerfil()
        {
            List<DefensaPerfil> defensasPerfil = new List<DefensaPerfil>();

            
                conexion.Open();
                string query = "SELECT * FROM DEFENSA_PERFIL";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DefensaPerfil defensaPerfil = new DefensaPerfil
                        {
                            FechaDefensa = (DateTime)reader["FechaDefensa"],
                            EstadoPerfil = (bool)reader["ESTADOPERFIL"],
                            Calficacion = (int)reader["Calficacion"],
                            ID_DocenteMDG1 = (int)reader["ID_DocenteMDG1"],
                            ID_Tribunal1 = (int)reader["ID_Tribunal1"],
                            ID_Postulante = (int)reader["ID_Postulante"],
                            ID_Perfil = (int)reader["ID_Perfil"]
                        };
                        defensasPerfil.Add(defensaPerfil);
                    conexion.Close();
                }
                }
            

            return defensasPerfil;
        }

        // Método para actualizar una defensa de perfil
        public void ActualizarDefensaPerfil(DefensaPerfil defensaPerfil)
        {
            
                conexion.Open();
                string query = "UPDATE DEFENSA_PERFIL SET FechaDefensa = @FechaDefensa, ESTADOPERFIL = @ESTADOPERFIL, Calficacion = @Calficacion, " +
                               "ID_DocenteMDG1 = @ID_DocenteMDG1, ID_Tribunal1 = @ID_Tribunal1, ID_Postulante = @ID_Postulante, ID_Perfil = @ID_Perfil " +
                               "WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDefensa", defensaPerfil.FechaDefensa);
                    cmd.Parameters.AddWithValue("@ESTADOPERFIL", defensaPerfil.EstadoPerfil);
                    cmd.Parameters.AddWithValue("@Calficacion", defensaPerfil.Calficacion);
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", defensaPerfil.ID_DocenteMDG1);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", defensaPerfil.ID_Tribunal1);
                    cmd.Parameters.AddWithValue("@ID_Postulante", defensaPerfil.ID_Postulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", defensaPerfil.ID_Perfil);

                    cmd.ExecuteNonQuery();
                conexion.Close();
            }
            
        }

        // Método para eliminar una defensa de perfil
        public void EliminarDefensaPerfil(int idDocente, int idTribunal, int idPostulante, int idPerfil)
        {
            
                conexion.Open();
                string query = "DELETE FROM DEFENSA_PERFIL WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", idDocente);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", idTribunal);
                    cmd.Parameters.AddWithValue("@ID_Postulante", idPostulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", idPerfil);

                    cmd.ExecuteNonQuery();
                conexion.Close();
            }
            
        }

        // Método para obtener una defensa de perfil por sus IDs
        public DefensaPerfil ObtenerDefensaPerfilPorIds(int idDocente, int idTribunal, int idPostulante, int idPerfil)
        {
            DefensaPerfil defensaPerfil = null;

            
                conexion.Open();
                string query = "SELECT * FROM DEFENSA_PERFIL WHERE ID_DocenteMDG1 = @ID_DocenteMDG1 AND ID_Tribunal1 = @ID_Tribunal1 AND ID_Postulante = @ID_Postulante AND ID_Perfil = @ID_Perfil";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_DocenteMDG1", idDocente);
                    cmd.Parameters.AddWithValue("@ID_Tribunal1", idTribunal);
                    cmd.Parameters.AddWithValue("@ID_Postulante", idPostulante);
                    cmd.Parameters.AddWithValue("@ID_Perfil", idPerfil);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            defensaPerfil = new DefensaPerfil
                            {
                                FechaDefensa = (DateTime)reader["FechaDefensa"],
                                EstadoPerfil = (bool)reader["ESTADOPERFIL"],
                                Calficacion = (int)reader["Calificacion"],
                                ID_DocenteMDG1 = (int)reader["ID_DocenteMDG1"],
                                ID_Tribunal1 = (int)reader["ID_Tribunal1"],
                                ID_Postulante = (int)reader["ID_Postulante"],
                                ID_Perfil = (int)reader["ID_Perfil"]
                            };
                        }
                    }
                }
            conexion.Close();

            return defensaPerfil;
        }
    }

}
