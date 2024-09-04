using ACTIVOS_FIJOS.Controllers;
using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVOS_FIJOS.Views
{
    public partial class LoginForm : Form
    {
        private AccesoController dbConexion;
        public LoginForm()
        {
            InitializeComponent();
            dbConexion = new AccesoController();
        }
        private DbConexion dbConexion;
        
        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=DESKTOP-TFHCQ27\\SQLEXPRESS;Database=Almacen;Integrated security=true;";        //sql rodri

            string nombreUsuario = txtusuario.Text;
            string password = txtcontra.Text;

            string rol = dbConexion.AutenticarUsuarios(nombreUsuario, password);

            if (!string.IsNullOrEmpty(rol))
            {
                if (rol == "Administrador")
                {
                    MessageBox.Show($"Bienvenido {nombreUsuario}, eres Administrador.");
                    GestionUsuario gestusadmin = new GestionUsuario();
                    gestusadmin.Show();
                    this.Hide();
                }
                else if (rol == "Usuario")
                {
                    MessageBox.Show($"Bienvenido {nombreUsuario}, eres un Usuario.");
                    // Aquí podrías abrir la ventana correspondiente para el rol de Usuario
                    // UserForm userForm = new UserForm();
                    // userForm.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido.");
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos o el usuario está inactivo.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
