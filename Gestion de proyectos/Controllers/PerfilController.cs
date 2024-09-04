using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEMOPROY1.Models;

namespace DEMOPROY1.Controllers
{
    internal class PerfilController
    {
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");

        public DataTable ObtenerPerfil()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM PERFIL";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los perfiles: " + ex.Message);
            }
            return dt;
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

        public void CrearPerfil(Perfil perfil)
        {
            try
            {
                conexion.Open();
                string query = "INSERT INTO PERFIL (Titulo, Gestion, Semestre, Codigo_Estudiante) " +
                               "VALUES (@Titulo, @Gestion, @Semestre, @Codigo_Estudiante)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Titulo", perfil.Titulo);
                cmd.Parameters.AddWithValue("@Gestion", perfil.Gestion);
                cmd.Parameters.AddWithValue("@Semestre", perfil.Semestre);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", perfil.Codigo_Estudiante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el perfil: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para editar un perfil existente
        public void EditarPerfil(Perfil perfil)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE PERFIL SET Titulo = @Titulo, Gestion = @Gestion, Semestre = @Semestre " +
                               "WHERE Codigo_Estudiante = @Codigo_Estudiante";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Titulo", perfil.Titulo);
                cmd.Parameters.AddWithValue("@Gestion", perfil.Gestion);
                cmd.Parameters.AddWithValue("@Semestre", perfil.Semestre);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", perfil.Codigo_Estudiante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el perfil: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para eliminar un perfil
        public void EliminarPerfil(int codigoEstudiante)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM PERFIL WHERE Codigo_Estudiante = @Codigo_Estudiante";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", codigoEstudiante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el perfil: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para buscar un perfil por el Código del Estudiante
        public DataTable BuscarPerfilPorCodigo(int codigoEstudiante)
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM PERFIL WHERE Codigo_Estudiante = @Codigo_Estudiante";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", codigoEstudiante);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el perfil: " + ex.Message);
            }
            return dt;
        }
    }
}
