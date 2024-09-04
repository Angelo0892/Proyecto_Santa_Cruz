using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Microsoft.AspNetCore.Identity;
namespace SistemaPatologiaIA
{
   

    public class UsuarioService
    {
        private readonly PasswordHasher<string> _passwordHasher;

        public UsuarioService()
        {
            _passwordHasher = new PasswordHasher<string>();
        }

        // Método para encriptar la contraseña antes de guardarla en la base de datos
        public string HashPassword(string contraseña)
        {
            return _passwordHasher.HashPassword(null, contraseña);
        }

        // Método para verificar si la contraseña ingresada coincide con la contraseña almacenada en la base de datos
        public bool VerifyPassword(string contraseñaIngresada, string contraseñaAlmacenada)
        {
            var result = _passwordHasher.VerifyHashedPassword(null, contraseñaAlmacenada, contraseñaIngresada);
            return result == PasswordVerificationResult.Success;
        }

        private class PasswordHasher<T>
        {
            internal string HashPassword(object value, string contraseña)
            {
                throw new NotImplementedException();
            }

            internal PasswordVerificationResult VerifyHashedPassword(object value, string contraseñaAlmacenada, string contraseñaIngresada)
            {
                throw new NotImplementedException();
            }
        }
    }

}
