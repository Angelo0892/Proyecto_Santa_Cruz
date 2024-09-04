using DEMOPROY1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEMOPROY1.Models;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

internal class ProyectoController
    {
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-V980KNVQ\\SQLEXPRESS; database=DEMOPROY; integrated security=true");

        public DataTable ObtenerProyectos()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = "SELECT * FROM PROYECTO";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proyectos: " + ex.Message);
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
    public DataTable ObtenerDocente1()
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

    // Método para obtener el postulante por ID
    public DataTable ObtenerPostulante()
    {
        DataTable dt = new DataTable();
        try
        {
            string consulta = "SELECT PostulanteId, PrimerNombre FROM POSTULANTE "; // Asegúrate de que los nombres de columna sean correctos
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


    public void CrearProyecto(Proyecto proyecto)
        {
            try
            {
                conexion.Open();
                string query = "INSERT INTO PROYECTO (Titulo, TipoTrabajo, Universidad, FechaProyecto, ACTAMDG1, ACTAMDG2, Calficacion, ID_DocenteMDG2, ID_Tutor, ID_Postulante) " +
                               "VALUES (@Titulo, @TipoTrabajo, @Universidad, @FechaProyecto, @ACTAMDG1, @ACTAMDG2, @Calficacion, @ID_DocenteMDG2, @ID_Tutor, @ID_Postulante)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Titulo", proyecto.Titulo);
                cmd.Parameters.AddWithValue("@TipoTrabajo", proyecto.TipoTrabajo);
                cmd.Parameters.AddWithValue("@Universidad", proyecto.Universidad);
                cmd.Parameters.AddWithValue("@FechaProyecto", proyecto.FechaProyecto);
                cmd.Parameters.AddWithValue("@ACTAMDG1", proyecto.ACTAMDG1);
                cmd.Parameters.AddWithValue("@ACTAMDG2", proyecto.ACTAMDG2);
                cmd.Parameters.AddWithValue("@Calficacion", proyecto.Calficacion);
                cmd.Parameters.AddWithValue("@ID_DocenteMDG2", proyecto.ID_DocenteMDG2);
                cmd.Parameters.AddWithValue("@ID_Tutor", proyecto.ID_Tutor);
                cmd.Parameters.AddWithValue("@ID_Postulante", proyecto.ID_Postulante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el proyecto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EditarProyecto(Proyecto proyecto)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE PROYECTO SET Titulo = @Titulo, TipoTrabajo = @TipoTrabajo, Universidad = @Universidad, FechaProyecto = @FechaProyecto, ACTAMDG1 = @ACTAMDG1, ACTAMDG2 = @ACTAMDG2, Calficacion = @Calficacion, ID_DocenteMDG2 = @ID_DocenteMDG2, ID_Tutor = @ID_Tutor, ID_Postulante = @ID_Postulante WHERE Id_Proyecto = @Id_Proyecto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id_Proyecto", proyecto.Id_Proyecto);
                cmd.Parameters.AddWithValue("@Titulo", proyecto.Titulo);
                cmd.Parameters.AddWithValue("@TipoTrabajo", proyecto.TipoTrabajo);
                cmd.Parameters.AddWithValue("@Universidad", proyecto.Universidad);
                cmd.Parameters.AddWithValue("@FechaProyecto", proyecto.FechaProyecto);
                cmd.Parameters.AddWithValue("@ACTAMDG1", proyecto.ACTAMDG1);
                cmd.Parameters.AddWithValue("@ACTAMDG2", proyecto.ACTAMDG2);
                cmd.Parameters.AddWithValue("@Calficacion", proyecto.Calficacion);
                cmd.Parameters.AddWithValue("@ID_DocenteMDG2", proyecto.ID_DocenteMDG2);
                cmd.Parameters.AddWithValue("@ID_Tutor", proyecto.ID_Tutor);
                cmd.Parameters.AddWithValue("@ID_Postulante", proyecto.ID_Postulante);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el proyecto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    public void EliminarProyecto(int codigoEstudiante)
    {
        try
        {
            conexion.Open();
            string query = "DELETE FROM PROYECTO WHERE ID_Postulante = @ID_Postulante";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@ID_Postulante", codigoEstudiante);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar el proyecto: " + ex.Message);
        }
        finally
        {
            conexion.Close();
        }
    }

    public DataTable BuscarProyectoPorCodigo(int codigoEstudiante)
    {
        DataTable dt = new DataTable();
        try
        {
            string consulta = "SELECT * FROM PROYECTO WHERE ID_Postulante = @ID_Postulante";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@ID_Postulante", codigoEstudiante);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(dt);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al buscar el proyecto: " + ex.Message);
        }
        return dt;
    }


    // Método para obtener el docente por ID

}
    


