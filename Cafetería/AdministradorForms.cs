using System;
using System.Windows.Forms;

namespace Proyecto_almacen
{
    public partial class AdministradorForms : Form
    {
        public AdministradorForms()
        {
            InitializeComponent();
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            GestionUsuario gestionUsuarioForm = new GestionUsuario();
            gestionUsuarioForm.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentasForm ventasForm = new VentasForm();
            ventasForm.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            reportesForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
