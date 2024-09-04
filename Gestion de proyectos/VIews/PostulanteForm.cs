using DEMOPROY1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEMOPROY1.Models;
using System.Data.SqlClient;

namespace DEMOPROY1.VIews
{
    public partial class PostulanteForm : Form
    {
        private PostulanteController postulanteController;
        public PostulanteForm()
        {
            InitializeComponent();
            postulanteController = new PostulanteController();
            CargarPostulantes();
            CargarCarreras();
        }
        public void limpiar()
        {
            txtCodigo.Clear();
            txtCI.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            // Limpiar otros controles si es necesario
        }

        private void CargarPostulantes()
        {
            try
            {
                var dtPostulantes = postulanteController.ObtenerPostulantes();
                dgvPostulantes.DataSource = dtPostulantes; // `dgvPostulantes` es tu DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los postulantes: " + ex.Message);
            }
        }
        private void CargarCarreras()
        {
            try
            {
                var dtCarreras = postulanteController.ObtenerCarreras();
                listBoxCarreras.DisplayMember = "Nombre"; // Nombre de la columna que se mostrará en el ListBox
                listBoxCarreras.ValueMember = "Id_Carrera"; // El valor asociado con cada ítem
                listBoxCarreras.DataSource = dtCarreras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las carreras: " + ex.Message);
            }
        }
        private void dtgPostulantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvPostulantes.SelectedCells[1].Value.ToString();
            txtCI.Text = dgvPostulantes.SelectedCells[2].Value.ToString();
            txtPrimerNombre.Text = dgvPostulantes.SelectedCells[3].Value.ToString();
            txtSegundoNombre.Text = dgvPostulantes.SelectedCells[4].Value.ToString();
            txtPrimerApellido.Text = dgvPostulantes.SelectedCells[5].Value.ToString();
            txtSegundoApellido.Text = dgvPostulantes.SelectedCells[6].Value.ToString();
            txtEmail.Text = dgvPostulantes.SelectedCells[7].Value.ToString();
            txtCelular.Text = dgvPostulantes.SelectedCells[8].Value.ToString();

            // Establecer el valor seleccionado en el ListBox para Id_Carrera
            int idCarrera = Convert.ToInt32(dgvPostulantes.SelectedCells[9].Value);
            listBoxCarreras.SelectedValue = idCarrera;
        }



        private void PostulanteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Postulante postulante = new Postulante
                {
                    Codigo_Estudiante = int.Parse(txtCodigo.Text),
                    CI = int.Parse(txtCI.Text),
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    Email = txtEmail.Text,
                    Celular = int.Parse(txtCelular.Text),
                    Id_Carrera = (int)listBoxCarreras.SelectedValue // Usa el valor seleccionado del ListBox
                };

                postulanteController.CrearPostulante(postulante);
                MessageBox.Show("Postulante creado correctamente.");
                CargarPostulantes(); // Recargar la lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear postulante: " + ex.Message);
            }

            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    Postulante postulante = new Postulante
                    {
                        Codigo_Estudiante = int.Parse(txtCodigo.Text),
                        CI = int.Parse(txtCI.Text),
                        PrimerNombre = txtPrimerNombre.Text,
                        SegundoNombre = txtSegundoNombre.Text,
                        PrimerApellido = txtPrimerApellido.Text,
                        SegundoApellido = txtSegundoApellido.Text,
                        Email = txtEmail.Text,
                        Celular = int.Parse(txtCelular.Text),
                        Id_Carrera = (int)listBoxCarreras.SelectedValue // Obtener ID de la carrera seleccionada
                    };

                    postulanteController.EditarPostulante(postulante); // Implementa el método EditarPostulante en el controlador
                    MessageBox.Show("Postulante editado correctamente.");
                    CargarPostulantes(); // Recargar la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar postulante: " + ex.Message);
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoEstudiante = int.Parse(txtCodigo.Text); // Suponiendo que tienes un TextBox para el código del postulante a eliminar
                postulanteController.EliminarPostulante(codigoEstudiante); // Implementa el método EliminarPostulante en el controlador
                MessageBox.Show("Postulante eliminado correctamente.");
                CargarPostulantes(); // Recargar la lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar postulante: " + ex.Message);
            }
        }

        private void dgvPostulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPostulantes.Rows.Count)
            {
                DataGridViewRow row = dgvPostulantes.Rows[e.RowIndex];

                // Asignar valores a los campos de texto usando las celdas de la fila seleccionada
                txtCodigo.Text = row.Cells["Codigo_Estudiante"].Value.ToString();
                txtCI.Text = row.Cells["CI"].Value.ToString();
                txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCelular.Text = row.Cells["Celular"].Value.ToString();

                // Obtener el Id_Carrera de la fila seleccionada
                int idCarrera = Convert.ToInt32(row.Cells["Id_Carrera"].Value);
                listBoxCarreras.SelectedValue = idCarrera;
            }
        }
    }
}
