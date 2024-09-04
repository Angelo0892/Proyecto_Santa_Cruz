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



namespace DEMOPROY1.VIews
{
    public partial class ProyectoForm : Form
    {
        private ProyectoController proyectoController;


        public ProyectoForm()
        {
            InitializeComponent();
            proyectoController = new ProyectoController();
            CargarDocentes();
            CargarDocentes1();
            CargarPostulantes();
            CargarProyectos();
            dgvProyectos.CellClick += dgvProyectos_CellClick;
        }
        private void CargarDocentes()
        {
            try
            {
                DataTable dtDocente = proyectoController.ObtenerDocente();
                cmbDocentes.DisplayMember = "PrimerNombre";
                cmbDocentes.ValueMember = "Id_Docente";
                cmbDocentes.DataSource = dtDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }

        private void CargarDocentes1()
        {
            try
            {
                DataTable dtDocente = proyectoController.ObtenerDocente1();
                listBoxTutores.DisplayMember = "PrimerNombre";
                listBoxTutores.ValueMember = "Id_Docente";
                listBoxTutores.DataSource = dtDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }

        private void CargarPostulantes()
        {
            try
            {
                DataTable dtPostulante = proyectoController.ObtenerPostulante();
                cmbPostulantes.DisplayMember = "PrimerNombre";
                cmbPostulantes.ValueMember = "PostulanteId";
                cmbPostulantes.DataSource = dtPostulante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los postulantes: " + ex.Message);
            }
        }

        private void CargarProyectos()
        {
            try
            {
                DataTable dtProyectos = proyectoController.ObtenerProyectos();
                dgvProyectos.DataSource = dtProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            //txtTipoTrabajo.Clear();
            //txtUniversidad.Clear();
            //datetimepickerGestion.Clear();
            //numericUpCalificacion.Clear();
            cmbDocentes.SelectedIndex = -1;
            listBoxTutores.SelectedIndex = -1;
            cmbPostulantes.SelectedIndex = -1;
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la fila seleccionada sea válida
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvProyectos.Rows[e.RowIndex];

                // Llena los campos de texto con los valores de las celdas seleccionadas usando índices
                txtTitulo.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                txtTipoTrabajo.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                txtUniversidad.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;

                // Llena el DateTimePicker con la fecha del proyecto
                datetimepickerGestion.Value = row.Cells[4].Value != null ? Convert.ToDateTime(row.Cells[4].Value) : DateTime.Now;

                // Llena los CheckBoxes para Acta MDG1 y MDG2
                cmbActaMDG1.Checked = row.Cells[5].Value != null && Convert.ToBoolean(row.Cells[5].Value);
                cmbActaMDG2.Checked = row.Cells[6].Value != null && Convert.ToBoolean(row.Cells[6].Value);

                // Llena el campo de calificación
                numericUpCalificacion.Value = row.Cells[7].Value != null ? Convert.ToDecimal(row.Cells[7].Value) : 0;

                // Establece el valor seleccionado en los ComboBox para Docente, Tutor y Postulante
                cmbDocentes.SelectedValue = row.Cells[8].Value != null ? Convert.ToInt32(row.Cells[8].Value) : -1;
                listBoxTutores.SelectedValue = row.Cells[9].Value != null ? Convert.ToInt32(row.Cells[9].Value) : -1;
                cmbPostulantes.SelectedValue = row.Cells[10].Value != null ? Convert.ToInt32(row.Cells[10].Value) : -1;
            }
        }






        private void ProyectoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet17.PROYECTO' Puede moverla o quitarla según sea necesario.
            this.pROYECTOTableAdapter1.Fill(this.dEMOPROYDataSet17.PROYECTO);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay campos vacíos
                if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtTipoTrabajo.Text) ||
                    string.IsNullOrEmpty(txtUniversidad.Text) || cmbDocentes.SelectedIndex == -1 ||
                    cmbPostulantes.SelectedIndex == -1 || listBoxTutores.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Validar la calificación
                // Validar la calificación
                // Validar la calificación
                int calificacion = (int)numericUpCalificacion.Value;
                if (calificacion > 100)
                {
                    MessageBox.Show("La calificación no puede ser mayor a 100.");
                    numericUpCalificacion.Value = 100;
                }
                else if (calificacion < 1)
                {
                    MessageBox.Show("La calificación no puede ser menor a 1.");
                    numericUpCalificacion.Value = 1;
                }

                // Verificar si el docente es el mismo que el tutor
                if (cmbDocentes.SelectedValue.ToString() == listBoxTutores.SelectedValue.ToString())
                {
                    MessageBox.Show("El docente no puede ser el mismo que el tutor.");
                    return;
                }

                // Validación de rango de fecha (hoy hasta 6 meses)
                DateTime fechaActual = DateTime.Now.Date; // Solo la fecha, sin la hora
                DateTime fechaMaxima = fechaActual.AddMonths(6); // Se agrega 6 meses
                DateTime fechaSeleccionada = datetimepickerGestion.Value.Date;
                if (fechaSeleccionada < fechaActual || fechaSeleccionada > fechaMaxima)
                {
                    MessageBox.Show("La fecha debe estar entre hoy y los próximos 6 meses.");
                    return;
                }

                // Validación para el docente de MDG II
                if (cmbDocentes.SelectedValue == null || !int.TryParse(cmbDocentes.SelectedValue.ToString(), out int idDocenteMDG2))
                {
                    MessageBox.Show("Selecciona un docente válido para MDG II.");
                    return;
                }

                // Validación para el postulante
                if (cmbPostulantes.SelectedValue == null || !int.TryParse(cmbPostulantes.SelectedValue.ToString(), out int idPostulante))
                {
                    MessageBox.Show("Selecciona un postulante válido.");
                    return;
                }

                // Validación para el tutor
                if (listBoxTutores.SelectedValue == null || !int.TryParse(listBoxTutores.SelectedValue.ToString(), out int idTutor))
                {
                    MessageBox.Show("Selecciona un tutor válido.");
                    return;
                }

                // Creación del objeto Proyecto
                Proyecto proyecto = new Proyecto
                {
                    Titulo = txtTitulo.Text,
                    TipoTrabajo = txtTipoTrabajo.Text,
                    Universidad = txtUniversidad.Text,
                    FechaProyecto = datetimepickerGestion.Value,
                    ACTAMDG1 = cmbActaMDG1.Checked,
                    ACTAMDG2 = cmbActaMDG2.Checked,
                    Calficacion = calificacion,
                    ID_DocenteMDG2 = idDocenteMDG2,
                    ID_Tutor = idTutor,
                    ID_Postulante = idPostulante,
                };

                // Llama al controlador para crear el proyecto
                proyectoController.CrearProyecto(proyecto);

                // Mensaje de éxito
                MessageBox.Show("Proyecto registrado correctamente.");
            }
            catch (Exception ex)
            {
                // Mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al registrar el proyecto: " + ex.Message);
            }

            CargarProyectos();

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una celda (no en el encabezado de la columna o fila)
         
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se ha seleccionado un proyecto en el DataGridView
                if (dgvProyectos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un proyecto para editar.");
                    return;
                }

                // La calificación ya es un número entero cuando se obtiene del NumericUpDown
                int calificacion = (int)numericUpCalificacion.Value;

                // Crea una instancia del proyecto con los valores actuales
                Proyecto proyecto = new Proyecto
                {
                    Id_Proyecto = Convert.ToInt32(dgvProyectos.SelectedCells[0].Value), // Obtiene el ID del proyecto seleccionado
                    Titulo = txtTitulo.Text,
                    TipoTrabajo = txtTipoTrabajo.Text,
                    Universidad = txtUniversidad.Text,
                    FechaProyecto = datetimepickerGestion.Value,
                    ACTAMDG1 = cmbActaMDG1.Checked,
                    ACTAMDG2 = cmbActaMDG2.Checked,
                    Calficacion = calificacion,  // Asegúrate de que el nombre sea correcto
                    ID_DocenteMDG2 = (int)cmbDocentes.SelectedValue,  // Asegúrate de que haya un valor seleccionado
                    ID_Tutor = (int)listBoxTutores.SelectedValue,  // Asegúrate de que haya un valor seleccionado
                    ID_Postulante = (int)cmbPostulantes.SelectedValue  // Asegúrate de que haya un valor seleccionado
                };

                // Llama al controlador para editar el proyecto
                proyectoController.EditarProyecto(proyecto);

                // Muestra un mensaje de éxito
                MessageBox.Show("Proyecto editado exitosamente.");

                // Recarga la lista de proyectos para reflejar los cambios
                CargarProyectos();

                // Limpia los campos después de la edición
                limpiar();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al editar el proyecto: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyectos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un proyecto para eliminar.");
                    return;
                }

                int idProyecto = Convert.ToInt32(dgvProyectos.SelectedCells[0].Value);
                proyectoController.EliminarProyecto(idProyecto);
                MessageBox.Show("Proyecto eliminado correctamente.");
                CargarProyectos();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proyecto: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoEstudiante.Text))
                {
                    MessageBox.Show("Ingresa un código de estudiante para buscar.");
                    return;
                }

                if (!int.TryParse(txtCodigoEstudiante.Text, out int codigoEstudiante))
                {
                    MessageBox.Show("Ingresa un código de estudiante válido.");
                    return;
                }

                DataTable dtProyecto = proyectoController.BuscarProyectoPorCodigo(codigoEstudiante);
                dgvProyectos.DataSource = dtProyecto;

                if (dtProyecto.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún proyecto con ese código de estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el proyecto: " + ex.Message);
            }
        }

        private void dgvProyectos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

