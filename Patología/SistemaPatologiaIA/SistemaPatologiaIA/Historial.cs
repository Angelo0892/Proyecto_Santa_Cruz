using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaPatologiaIA.HistorialMedicoRepository;

namespace SistemaPatologiaIA
{
    public partial class Historial : Form
    {
        private PacienteRepository pacienRepo;
        private DoctorRepository doctorRepo;
        private HistorialMedicoRepository histRepo;
        public Historial()
        {
            InitializeComponent();
            pacienRepo = new PacienteRepository();
            doctorRepo = new DoctorRepository();
            histRepo = new HistorialMedicoRepository();
            CargarPaciente();
            CargarDoctores();
            CargarHistorial();
        }

        private void CargarDoctores()
        {
            List<Doctor> doctores = doctorRepo.ObtenerDoctores();
            cbDoctor.DataSource = doctores;
            cbDoctor.DisplayMember = "DoctorID";
            cbDoctor.ValueMember = "DoctorID";
        }
        private void CargarHistorial()
        {
            HistorialMedicoRepository historial = new HistorialMedicoRepository();

            List<HistorialMedico> historiales = histRepo.ObtenerTodosLosHistorialesMedicos();
            dataGridViewHistorial.DataSource = historiales;
        }
        private void CargarPaciente()
        {
            List<Paciente> paciente = pacienRepo.ObtenerPacientes();
            cbPaciente.DataSource = paciente;
            cbPaciente.DisplayMember = "PacienteID";
            cbPaciente.ValueMember = "PacienteID";
        }
        private void btnAgregarHistorial_Click(object sender, EventArgs e)
        {
            HistorialMedico historial = new HistorialMedico
            {
                PacienteID = Convert.ToInt32(cbPaciente.SelectedValue),
                DoctorID = Convert.ToInt32(cbDoctor.SelectedValue),
                FechaConsulta = dtpFechaConsulta.Value,
                Sintomas = txtSintomas.Text,
                Diagnostico = txtDiagnostico.Text,
                Tratamiento = txtTratamiento.Text,
                Observaciones = txtObservaciones.Text
            };

            HistorialMedicoRepository historialRepo = new HistorialMedicoRepository();
            historialRepo.AgregarHistorialMedico(historial);
            MessageBox.Show("Historial Médico agregado exitosamente.");
            CargarHistorial();
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            int idHistorial = Convert.ToInt32(txtIdHistorial.Text);
            HistorialMedicoRepository historialRepo = new HistorialMedicoRepository();
            HistorialMedico historial = historialRepo.ObtenerHistorialMedicoPorID(idHistorial);

            if (historial != null)
            {
                cbPaciente.SelectedValue = historial.PacienteID;
                cbDoctor.SelectedValue = historial.DoctorID;
                dtpFechaConsulta.Value = historial.FechaConsulta;
                txtSintomas.Text = historial.Sintomas;
                txtDiagnostico.Text = historial.Diagnostico;
                txtTratamiento.Text = historial.Tratamiento;
                txtObservaciones.Text = historial.Observaciones;
            }
            else
            {
                MessageBox.Show("Historial Médico no encontrado.");
            }
        }

        private void btnActualizarHistorial_Click(object sender, EventArgs e)
        {
            HistorialMedico historial = new HistorialMedico
            {
                IdHistorial = Convert.ToInt32(txtIdHistorial.Text),
                PacienteID = Convert.ToInt32(cbPaciente.SelectedValue),
                DoctorID = Convert.ToInt32(cbDoctor.SelectedValue),
                FechaConsulta = dtpFechaConsulta.Value,
                Sintomas = txtSintomas.Text,
                Diagnostico = txtDiagnostico.Text,
                Tratamiento = txtTratamiento.Text,
                Observaciones = txtObservaciones.Text
            };

            HistorialMedicoRepository historialRepo = new HistorialMedicoRepository();
            historialRepo.ActualizarHistorialMedico(historial);
            MessageBox.Show("Historial Médico actualizado exitosamente.");
        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            int idHistorial = Convert.ToInt32(txtIdHistorial.Text);
            HistorialMedicoRepository historialRepo = new HistorialMedicoRepository();
            historialRepo.EliminarHistorialMedico(idHistorial);
            MessageBox.Show("Historial Médico eliminado exitosamente.");
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Pacientes formpas = new Pacientes();
            formpas.Show();  // Muestra el formulario anterior
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<HistorialMedico> historial = histRepo.ObtenerTodosLosHistorialesMedicos();  // Método que obtendría la lista de pacientes

            ReportExcel reporte = new ReportExcel();  // Crea una instancia de la clase que maneja el reporte
            reporte.ExportarReporteHistorialMedico(historial);
        }
    }
}
