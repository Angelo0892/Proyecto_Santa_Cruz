using Proyecto_almacen.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                    AdministradorForms gestusadmin = new AdministradorForms();
                    gestusadmin.Show();
                    this.Hide();
                }
                else if (rol == "Empleado")
                {
                    MessageBox.Show($"Bienvenido {nombreUsuario}, eres un Empleado.");
                    VenderForm gestusadmin = new VenderForm();
                    gestusadmin.Show();
                    this.Hide();
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

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
