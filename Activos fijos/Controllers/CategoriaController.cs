using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Controllers
{
    public class CategoriaController
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";

        public List<Categoria> GetAllCategorias()
        {
            List<Categoria> categoriaList = new List<Categoria>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIA", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categoriaList.Add(new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = (string)reader["NombreCategoria"],
                        VidaUtil = (int)reader["VidaUtil"],
                        ValorResidual = (decimal)reader["ValoResidual"]
                    });
                }
            }
            return categoriaList;
        }

        public void AddCategoria(Categoria categoria)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CATEGORIA (NombreCategoria, VidaUtil, ValoResidual) VALUES (@NombreCategoria, @VidaUtil, @ValoResidual)", conn);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@VidaUtil", categoria.VidaUtil);
                cmd.Parameters.AddWithValue("@ValoResidual", categoria.ValorResidual);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCategoria(Categoria categoria)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CATEGORIA SET NombreCategoria = @NombreCategoria, VidaUtil = @VidaUtil, ValorResidual = @ValoResidual WHERE CategoriaID = @CategoriaID", conn);
                cmd.Parameters.AddWithValue("@CategoriaID", categoria.CategoriaID);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@VidaUtil", categoria.VidaUtil);
                cmd.Parameters.AddWithValue("@ValorResidual", categoria.ValorResidual);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCategoria(int categoriaID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIA WHERE CategoriaID = @CategoriaID", conn);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
