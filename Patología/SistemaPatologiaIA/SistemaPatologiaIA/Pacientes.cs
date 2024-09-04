using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPatologiaIA
{

    public partial class Pacientes : Form
    {
        private PacienteRepository pacienRepo;
        private DoctorRepository doctorRepo;
        public Pacientes()
        {
            InitializeComponent();
            pacienRepo = new PacienteRepository();
            doctorRepo = new DoctorRepository();
            CargarPaciente();
            CargarDoctores();

        }
        private void CargarDoctores()
        {
            List<Doctor> doctores = doctorRepo.ObtenerDoctores();
            cbDoc.DataSource = doctores;
            cbDoc.DisplayMember = "DoctorID";
            cbDoc.ValueMember = "DoctorID";
        }
        private void CargarPaciente()
        {
            PacienteRepository pacienteRepo = new PacienteRepository();

            List<Paciente> paciente = pacienRepo.ObtenerPacientes();
            dataGridViewPaciente.DataSource = paciente;
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Genero = cbGenero.SelectedItem.ToString(),
                DoctorID = Convert.ToInt32(cbDoc.Text),
                FechaRegistro = DateTime.Now, // Fecha de registro establecida al momento actual
                Direccion = txtDireccion.Text,
                NumeroContacto = txtNumeroContacto.Text,
                Email = txtEmail.Text,
                Activo = chkActivo.Checked
            };

            PacienteRepository pacienteRepo = new PacienteRepository();
            pacienteRepo.AgregarPaciente(paciente);
            MessageBox.Show("Paciente agregado exitosamente.");
            CargarPaciente();
        }

        private void dataGridViewPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial Menu = new Historial();

            // Mostrar el nuevo formulario
            Menu.Show();

            // Opcionalmente, ocultar el formulario actual
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();  // Muestra el formulario anterior
            this.Hide();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = pacienRepo.ObtenerPacientes();  // Método que obtendría la lista de pacientes

            ReporteExcel reporte = new ReporteExcel();  // Crea una instancia de la clase que maneja el reporte
            reporte.ExportarReportePacientes(pacientes);
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
