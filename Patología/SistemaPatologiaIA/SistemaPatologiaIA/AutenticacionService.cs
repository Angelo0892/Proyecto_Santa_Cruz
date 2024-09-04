using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPatologiaIA
{
    public class AutenticacionService
    {
        private UsuarioRepository usuarioRepository;

        public AutenticacionService()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public bool AutenticarUsuario(string email, string contraseña)
        {
            Usuario usuario = usuarioRepository.ObtenerUsuarioPorEmail(email);
            if (usuario != null && usuario.Contraseña == contraseña && usuario.Activo)
            {
                // Usuario autenticado exitosamente
                return true;
            }
            return false;
        }
    }

}
