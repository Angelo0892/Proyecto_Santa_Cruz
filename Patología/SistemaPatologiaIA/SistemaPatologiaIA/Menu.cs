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
    public partial class Menu : Form
    {

        private DateTime horaIngreso;
        public Menu()
        {
            InitializeComponent();
            this.Icon = new Icon("C:\\Users\\Isra Iss\\Desktop\\Ingenieria de Software I\\Proyecto\\Imagenes\\Logo.ico");

            horaIngreso = DateTime.Now;

            // Actualizar los labels con la información

            lblHoraIngreso.Text = "Hora de Ingreso: " + horaIngreso.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Pacientes pacie = new Pacientes();

            // Mostrar el nuevo formulario
            pacie.Show();

            // Opcionalmente, ocultar el formulario actual
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Doctores pacie = new Doctores();

            // Mostrar el nuevo formulario
            pacie.Show();

            // Opcionalmente, ocultar el formulario actual
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 Inic = new Form1();

            // Mostrar el nuevo formulario
            Inic.Show();
            
            // Opcionalmente, ocultar el formulario actual
            this.Hide();
        }
    }
}
