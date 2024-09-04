using System.Data.SqlClient;

namespace SistemaPatologiaIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void btnRegDoc_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FormGestionUsuarios formularioNuevo = new FormGestionUsuarios();

            // Mostrar el nuevo formulario
            formularioNuevo.Show();

            // Opcionalmente, ocultar el formulario actual
            this.Hide();
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtContraseña.Text;

            txtContraseña.PasswordChar = '*';

            UsuarioRepository usuarioRepo = new UsuarioRepository();
            bool loginSuccess = usuarioRepo.ValidarLogin(email, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login exitoso.");

                Menu formularioMenu = new Menu();

                formularioMenu.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
            
            

        }


        

    }

}
