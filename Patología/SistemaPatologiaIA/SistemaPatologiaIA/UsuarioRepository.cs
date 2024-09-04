using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPatologiaIA
{
    public class UsuarioRepository
    {
        private DatabaseConnection dbConnection;
        private PasswordHasher passwordHasher;

        public UsuarioRepository()
        {
            dbConnection = new DatabaseConnection();
            passwordHasher = new PasswordHasher();
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Usuario (Nombre, Apellido, Email, Contraseña, IdRol, FechaCreacion, Activo) " +
                               "VALUES (@Nombre, @Apellido, @Email, @Contraseña, @IdRol, @FechaCreacion, @Activo)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Contraseña", passwordHasher.HashPassword(usuario.Contraseña));
                cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@FechaCreacion", usuario.FechaCreacion);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                cmd.ExecuteNonQuery();
            }
        }

        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            Usuario usuario = null;

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Usuario WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellido"],
                            Email = (string)reader["Email"],
                            Contraseña = (string)reader["Contraseña"],
                            IdRol = (int)reader["IdRol"],
                            FechaCreacion = (DateTime)reader["FechaCreacion"],
                            Activo = (bool)reader["Activo"]
                        };
                    }
                }
            }

            return usuario;
        }

        public bool ValidarLogin(string email, string plainPassword)
        {
            Usuario usuario = ObtenerUsuarioPorEmail(email);
            if (usuario != null && usuario.Activo)
            {
                return passwordHasher.VerifyPassword(usuario.Contraseña, plainPassword);
            }
            return false;
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, " +
                               "IdRol = @IdRol, Activo = @Activo WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);

                cmd.ExecuteNonQuery();
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cmd.ExecuteNonQuery();
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Usuario";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Nombre = (string)reader["Nombre"],
                            Apellido = (string)reader["Apellido"],
                            Email = (string)reader["Email"],
                            Contraseña = (string)reader["Contraseña"],
                            IdRol = (int)reader["IdRol"],
                            FechaCreacion = (DateTime)reader["FechaCreacion"],
                            Activo = (bool)reader["Activo"]
                        });
                    }
                }
            }
            return usuarios;
        }

    }
}
