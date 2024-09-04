using DEMOPROY1.Controllers;
using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOPROY1.VIews
{
    public partial class PerfilForm : Form
    {
        private PerfilController perfilController;

        public PerfilForm()
        {
            InitializeComponent();
            perfilController = new PerfilController();
            CargarPostulantes();
            CargarPerfiles();
            dgvPerfiles.CellClick += dgvPerfiles_CellClick;

        }
        private void CargarPostulantes()
        {
            DataTable dtPostulante = perfilController.ObtenerPostulante();
            listPostulantes.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listPostulantes.ValueMember = "Codigo_Estudiante"; // Columna con el ID
            listPostulantes.DataSource = dtPostulante;
        }

        private void CargarPerfiles()
        {
            try
            {
                var dtPerfiles = perfilController.ObtenerPerfil();
                dgvPerfiles.DataSource = dtPerfiles; // `dgvPerfiles` es tu DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los perfiles: " + ex.Message);
            }
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtGestion.Clear();
            txtSemestre.Clear();
            listPostulantes.SelectedIndex = -1;
            // Limpiar otros controles si es necesario
        }

        private void PerfilForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet2.PERFIL' Puede moverla o quitarla según sea necesario.
            this.pERFILTableAdapter.Fill(this.dEMOPROYDataSet2.PERFIL);

        }
        private void dgvPerfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                // Verifica que la fila seleccionada sea válida
                if (e.RowIndex >= 0)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow row = dgvPerfiles.Rows[e.RowIndex];

                    // Llena los campos de texto con los valores de las celdas seleccionadas
                    txtTitulo.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty; // Titulo
                    txtGestion.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty; // Gestion
                    txtSemestre.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty; // Semestre

                    // Establecer el valor seleccionado en el ListBox para Codigo_Estudiante
                    int idPostulante = Convert.ToInt32(row.Cells[4].Value); // Asumiendo que Codigo_Estudiante está en la columna 4
                    listPostulantes.SelectedValue = idPostulante;
                }
            }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listPostulantes.SelectedValue == null || !int.TryParse(listPostulantes.SelectedValue.ToString(), out int idPostulante))
                {
                    MessageBox.Show("Selecciona un postulante válido.");
                    return;
                }

                Perfil perfil = new Perfil
                {
                    Titulo = txtTitulo.Text,
                    Gestion = txtGestion.Text,
                    Semestre = txtSemestre.Text,
                    Codigo_Estudiante = idPostulante
                };
                perfilController.CrearPerfil(perfil);
                MessageBox.Show("Perfil creado correctamente.");
                CargarPerfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el perfil: " + ex.Message);
            }

            limpiar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPerfiles.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un perfil para editar.");
                    return;
                }

                Perfil perfil = new Perfil
                {
                    Id_Perfil = Convert.ToInt32(dgvPerfiles.SelectedCells[0].Value),
                    Titulo = txtTitulo.Text,
                    Gestion = txtGestion.Text,
                    Semestre = txtSemestre.Text,
                    Codigo_Estudiante = (int)listPostulantes.SelectedValue
                };

                perfilController.EditarPerfil(perfil);
                MessageBox.Show("Perfil editado correctamente.");
                CargarPerfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el perfil: " + ex.Message);
            }

            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPerfiles.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un perfil para eliminar.");
                    return;
                }

                int idPerfil = Convert.ToInt32(dgvPerfiles.SelectedCells[0].Value);
                perfilController.EliminarPerfil(idPerfil);
                MessageBox.Show("Perfil eliminado correctamente.");
                CargarPerfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el perfil: " + ex.Message);
            }

            limpiar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                // Asegúrate de que el TextBox para el código de estudiante esté presente (txtCodigo)
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Ingresa un código de estudiante para buscar.");
                    return;
                }

                // Convertir el código de estudiante a entero
                int codigoEstudiante;
                if (!int.TryParse(txtCodigo.Text, out codigoEstudiante))
                {
                    MessageBox.Show("Ingresa un código de estudiante válido.");
                    return;
                }

                // Llamar al método BuscarPerfilPorCodigo en el controlador
                DataTable dtPerfil = perfilController.BuscarPerfilPorCodigo(codigoEstudiante);
                dgvPerfiles.DataSource = dtPerfil; // Mostrar el resultado en un DataGridView (dgvPerfiles)

                if (dtPerfil.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún perfil con ese código de estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el perfil: " + ex.Message);
            }

        }

        private void dgvPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   // Verifica que la fila seleccionada sea válida
           
        }
    }
}
