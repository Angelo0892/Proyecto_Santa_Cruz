using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPatologiaIA
{
    public partial class FormGestionUsuarios : Form
    {

        private UsuarioRepository usuarioRepo;
        private RolRepository rolRepo;

        public object passwordHasher { get; private set; }

        public FormGestionUsuarios()
        {
            InitializeComponent();
            usuarioRepo = new UsuarioRepository();
            rolRepo = new RolRepository();
            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            List<Rol> roles = rolRepo.ObtenerRoles();
            cbRol.DataSource = roles;
            cbRol.DisplayMember = "idRol";
            cbRol.ValueMember = "IdRol";
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioRepo.ObtenerUsuarios();
            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
         string.IsNullOrWhiteSpace(txtApellido.Text) ||
         !int.TryParse(cbRol.Text, out int idRol))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Contraseña = txtContraseña.Text,
                IdRol = idRol,
                FechaCreacion = DateTime.Now,
                Activo = true
            };

            UsuarioRepository usuarioRepo = new UsuarioRepository();
            usuarioRepo.GuardarUsuario(usuario);
            MessageBox.Show("Usuario guardado exitosamente.");
            CargarUsuarios();
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtContraseña.Clear();
            cbRol.SelectedIndex = -1;
            chkActivo.Checked = false;
        }
        private void btnLeerUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private bool ValidarCampos()
        {
            // Valida que todos los campos estén llenos antes de proceder
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            return true;
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //if (dataGridViewUsuarios.SelectedRows.Count > 0)
            //{
            //    string nombre = txtNombre.Text;
            //    string email = txtEmail.Text;
            //    string contraseña = txtContraseña.Text;
            //    int idrol = Convert.ToInt32(cbRol.Text);
            //    int usuarioId = int.Parse(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value.ToString());

            //    if (ValidarCampos())
            //    {
            //        // Aquí implementas el hasheo de la nueva contraseña si es necesario.
            //        string hashedPassword = passwordHasher.HashPassword(contraseña);

            //        Usuario usuarioActualizado = new Usuario
            //        {
            //            IdUsuario = usuarioId,
            //            Nombre = nombre,
            //            Email = email,
            //            Contraseña = hashedPassword,
            //            IdRol = idrol
            //        };

            //        bool actualizado = ActualizarUsuarioEnBD(usuarioActualizado);

            //        if (actualizado)
            //        {
            //            MessageBox.Show("Usuario actualizado exitosamente.");
            //            CargarUsuarios();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al actualizar el usuario.");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un usuario para actualizar.");
            //}
        }

        private bool ActualizarUsuarioEnBD(Usuario usuarioActualizado)
        {
            throw new NotImplementedException();
        }
    }
}
