using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Controllers
{
    internal class PostulanteController
    {
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");

        public DataTable ObtenerCarreras()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT Id_Carrera, Nombre FROM CARRERA"; // Asegúrate de que los nombres de columna sean correctos
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las carreras: " + ex.Message);
            }
            return dt;
        }


        public DataTable ObtenerPostulantes()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM POSTULANTE";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los postulantes: " + ex.Message);
            }
            return dt;
        }

        public void CrearPostulante(Postulante postulante)
        {
            try
            {
                conexion.Open();
                string query = "INSERT INTO POSTULANTE (Codigo_Estudiante, CI, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Email, Celular, Id_Carrera) " +
                               "VALUES (@Codigo_Estudiante, @CI, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Email, @Celular, @Id_Carrera)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", postulante.Codigo_Estudiante);
                cmd.Parameters.AddWithValue("@CI", postulante.CI);
                cmd.Parameters.AddWithValue("@PrimerNombre", postulante.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", postulante.SegundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", postulante.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", postulante.SegundoApellido);
                cmd.Parameters.AddWithValue("@Email", postulante.Email);
                cmd.Parameters.AddWithValue("@Celular", postulante.Celular);
                cmd.Parameters.AddWithValue("@Id_Carrera", postulante.Id_Carrera);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el postulante: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void EditarPostulante(Postulante postulante)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE POSTULANTE SET CI = @CI, PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Email = @Email, Celular = @Celular, Id_Carrera = @Id_Carrera WHERE Codigo_Estudiante = @Codigo_Estudiante";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", postulante.Codigo_Estudiante);
                cmd.Parameters.AddWithValue("@CI", postulante.CI);
                cmd.Parameters.AddWithValue("@PrimerNombre", postulante.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", postulante.SegundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", postulante.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", postulante.SegundoApellido);
                cmd.Parameters.AddWithValue("@Email", postulante.Email);
                cmd.Parameters.AddWithValue("@Celular", postulante.Celular);
                cmd.Parameters.AddWithValue("@Id_Carrera", postulante.Id_Carrera);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el postulante: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarPostulante(int codigoEstudiante)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM POSTULANTE WHERE Codigo_Estudiante = @Codigo_Estudiante";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Codigo_Estudiante", codigoEstudiante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el postulante: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        // Otros métodos de negocio como actualizar, eliminar, etc.
    }
}



