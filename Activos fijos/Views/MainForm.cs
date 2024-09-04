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
    public partial class MainForm : Form
    {
        private Button activeButton = null;
        private Form activeForm = null; // Declaración de la variable
        private Timer timer;
        public MainForm()
        {
            InitializeComponent();
            InicializarTimer();
            ShowHomePanel(); // Mostrar el panel principal al inicio
            ActivateButton(btnHome); // Activar el botón "Home" al inicio
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            ActivateButton(btnSender); // Activar el botón
        }
        private void ActivateButton(object btnSender)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromKnownColor(KnownColor.Control); // Restablecer el color del botón anterior
            }
            activeButton = (Button)btnSender;
            activeButton.BackColor = Color.RoyalBlue; // Cambiar el color del botón activo
        }
        private void ShowHomePanel()
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnHome); // Activar el botón "Home"
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomePanel();
        }
        private void btnActivosFijos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ActivoFijoForm(), sender);
        }
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalForm(), sender);
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AsignacionesForm(), sender);
        }
        private void btnRetorno_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RetornoForm(), sender);
        }
        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepreciacionForm(), sender);
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportesForm(), sender);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += new EventHandler(ActualizarHora);
            timer.Start();
        }
        private void ActualizarHora(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            string fechaFormateada = ahora.ToString("d 'de' MMMM 'del' yyyy HH:mm:ss");
            labelHora.Text = fechaFormateada;
        }
    }
}
