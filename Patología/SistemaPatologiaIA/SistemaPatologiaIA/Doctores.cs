using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaPatologiaIA.DoctorRepository;

namespace SistemaPatologiaIA
{
    public partial class Doctores : Form
    {
        private DoctorRepository DoctorRepo;
        public Doctores()
        {
            InitializeComponent();
            DoctorRepo = new DoctorRepository();
            CargarDoctor();
        }
        private void CargarDoctor()
        {
            List<Doctor> doctores = DoctorRepo.ObtenerDoctores();
            dataGridViewDoctor.DataSource = doctores;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = txtEspecialidad.Text,
                Email = txtemail.Text,
                Estado = cbEstado.Checked, // Suponiendo que es un checkbox
                NumeroLicenciaMedica = txtNumeroLicenciaMedica.Text,
                FechaExpiracionLicencia = dtpFechaExpiracionLicencia.Value,
                TurnoAsignado = txtTurnoAsignado.Text,
                InstitucionGraduacion = txtInstitucionGraduacion.Text,
                AnioGraduacion = Convert.ToInt32(txtAnioGraduacion.Text),
                DisponibilidadAsignacionPaciente = cbDisponibilidad.Checked // Suponiendo que es un checkbox
            };

            DoctorRepository doctorRepo = new DoctorRepository();
            doctorRepo.AgregarDoctor(doctor);
            MessageBox.Show("Doctor agregado exitosamente.");
            CargarDoctor();
        }


        private void btnBuscarDoctor_Click_1(object sender, EventArgs e)
        {
            int doctorID = Convert.ToInt32(txtDoctorID.Text);
            DoctorRepository doctorRepo = new DoctorRepository();
            Doctor doctor = doctorRepo.ObtenerDoctorPorID(doctorID);

            if (doctor != null)
            {
                txtNombre.Text = doctor.Nombre;
                txtApellido.Text = doctor.Apellido;
                txtEspecialidad.Text = doctor.Especialidad;
                txtemail.Text = doctor.Email;
                cbEstado.Checked = doctor.Estado;
                txtNumeroLicenciaMedica.Text = doctor.NumeroLicenciaMedica;
                dtpFechaExpiracionLicencia.Value = doctor.FechaExpiracionLicencia;
                txtTurnoAsignado.Text = doctor.TurnoAsignado;
                txtInstitucionGraduacion.Text = doctor.InstitucionGraduacion;
                txtAnioGraduacion.Text = doctor.AnioGraduacion.ToString();
                cbDisponibilidad.Checked = doctor.DisponibilidadAsignacionPaciente;
                MessageBox.Show("Doctor encontrado.");
            }
            else
            {
                MessageBox.Show("Doctor no encontrado.");
            }
        }

        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            int doctorID = Convert.ToInt32(txtDoctorID.Text);
            DoctorRepository doctorRepo = new DoctorRepository();
            doctorRepo.EliminarDoctor(doctorID);
            MessageBox.Show("Doctor eliminado exitosamente.");
        }

        private void btnActualizarDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                DoctorID = Convert.ToInt32(txtDoctorID.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = txtEspecialidad.Text,
                Email = txtemail.Text,
                Estado = cbEstado.Checked,
                NumeroLicenciaMedica = txtNumeroLicenciaMedica.Text,
                FechaExpiracionLicencia = dtpFechaExpiracionLicencia.Value,
                TurnoAsignado = txtTurnoAsignado.Text,
                InstitucionGraduacion = txtInstitucionGraduacion.Text,
                AnioGraduacion = Convert.ToInt32(txtAnioGraduacion.Text),
                DisponibilidadAsignacionPaciente = cbDisponibilidad.Checked
            };

            DoctorRepository doctorRepo = new DoctorRepository();
            doctorRepo.ActualizarDoctor(doctor);
            MessageBox.Show("Doctor actualizado exitosamente.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu formMen = new Menu();
            formMen.Show();  // Muestra el formulario anterior
            this.Hide();
        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            List<Doctor> doctores = DoctorRepo.ObtenerDoctores();  // Método que obtendría la lista de pacientes

            reporteExcel reporte = new reporteExcel();  // Crea una instancia de la clase que maneja el reporte
            reporte.ExportarReporteDoctores(doctores);
        }
    }
}
