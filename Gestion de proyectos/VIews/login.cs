using DEMOPROY1.Controllers;
using DEMOPROY1.Models;
using DEMOPROY1.VIews;
using Proyecto_almacen.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_almacen
{
    public partial class login : Form
    {
        private DbConexion dbConexion;
        public login()
        {
            InitializeComponent();
            dbConexion = new DbConexion();
        }

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
                    INDEX gestusadmin = new INDEX();
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

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
