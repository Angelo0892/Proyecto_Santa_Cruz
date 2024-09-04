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
    public partial class DEFENSAEXTERNA : Form
    {
        private DefensaExternaController defensaExternaController;
        public DEFENSAEXTERNA()
        {
            InitializeComponent();
            defensaExternaController = new DefensaExternaController();
            CargarDefensas();
            CargarTrubunal();
            CargarTrubunal2();
            CargarTrubunal3();
            CargarTrubunal4();
            CargarTrubunal5();
            CargarProyectos();
            CargarDefensaInterna();
            dgvDefensas.CellClick += dgvDefensas_CellClick;
        }
        private void CargarTrubunal()
        {
            DataTable dtTribunal = defensaExternaController.ObtenerTribunal();
            listTribunal.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listTribunal.ValueMember = "Id_Tribunal"; // Columna con el ID
            listTribunal.DataSource = dtTribunal;
        }
        private void CargarTrubunal2()
        {
            DataTable dtTribunal = defensaExternaController.ObtenerTribunal();
            listTribunal2.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listTribunal2.ValueMember = "Id_Tribunal"; // Columna con el ID
            listTribunal2.DataSource = dtTribunal;
        }
        private void CargarTrubunal3()
        {
            DataTable dtTribunal = defensaExternaController.ObtenerTribunal();
            listTribunal3.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listTribunal3.ValueMember = "Id_Tribunal"; // Columna con el ID
            listTribunal3.DataSource = dtTribunal;
        }
        private void CargarTrubunal4()
        {
            DataTable dtTribunal = defensaExternaController.ObtenerTribunal();
            listTribunal4.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listTribunal4.ValueMember = "Id_Tribunal"; // Columna con el ID
            listTribunal4.DataSource = dtTribunal;
        }
        private void CargarTrubunal5()
        {
            DataTable dtTribunal = defensaExternaController.ObtenerTribunal();
            listTribunal5.DisplayMember = "PrimerNombre"; // Columna que quieres mostrar
            listTribunal5.ValueMember = "Id_Tribunal"; // Columna con el ID
            listTribunal5.DataSource = dtTribunal;
        }
        private void CargarProyectos()
        {
            DataTable dtProyectos = defensaExternaController.ObtenerProyectos();
            listProyectos.DisplayMember = "Titulo"; // Columna que quieres mostrar
            listProyectos.ValueMember = "Id_Proyecto"; // Columna con el ID
            listProyectos.DataSource = dtProyectos;
        }
        private void CargarDefensaInterna()
        {
            DataTable dtProyectos = defensaExternaController.ObtenerDefensaInterna();
            comboBoxDefensas.DisplayMember = "NombreCompleto"; // Mostrar el nombre completo del postulante
            comboBoxDefensas.ValueMember = "Id_DefensaInterna"; // Mantener el ID de la defensa interna como valor
            comboBoxDefensas.DataSource = dtProyectos;
        }


        private void CargarDefensas()
        {
            try
            {
                var dtDefensas = defensaExternaController.ObtenerDefensaExterna();
                dgvDefensas.DataSource = dtDefensas; // `dgvPerfiles` es tu DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Defensas: " + ex.Message);
            }
        }
        private void dgvDefensas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la fila seleccionada sea válida
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvDefensas.Rows[e.RowIndex];

                // Llena los campos de texto con los valores de las celdas seleccionadas
                dateTimePickerFecha.Value = row.Cells[1].Value != null ? Convert.ToDateTime(row.Cells[1].Value) : DateTime.Now; // Fecha

                // Chequea si la celda tiene un valor no nulo y conviértelo a booleano
                checkBoxEstado.Checked = row.Cells[2].Value != null && Convert.ToBoolean(row.Cells[2].Value); // Aprobado

                // Calificación
                numericUpDownCalificacion.Value = row.Cells[4].Value != null ? Convert.ToDecimal(row.Cells[4].Value) : 0;

                // Establecer el valor seleccionado en el ListBox para Proyectos y Tribunales
                int idProyecto = row.Cells[5].Value != null ? Convert.ToInt32(row.Cells[5].Value) : -1;
                listProyectos.SelectedValue = idProyecto;

                int idTribunal1 = row.Cells[6].Value != null ? Convert.ToInt32(row.Cells[6].Value) : -1;
                listTribunal.SelectedValue = idTribunal1;

                int idTribunal2 = row.Cells[7].Value != null ? Convert.ToInt32(row.Cells[7].Value) : -1;
                listTribunal2.SelectedValue = idTribunal2;

                int idTribunal3 = row.Cells[8].Value != null ? Convert.ToInt32(row.Cells[8].Value) : -1;
                listTribunal3.SelectedValue = idTribunal3;

                int idTribunal4 = row.Cells[9].Value != null ? Convert.ToInt32(row.Cells[9].Value) : -1;
                listTribunal4.SelectedValue = idTribunal4;

                int idTribunal5 = row.Cells[10].Value != null ? Convert.ToInt32(row.Cells[10].Value) : -1;
                listTribunal5.SelectedValue = idTribunal5;

                // Establecer el valor seleccionado para Defensa Interna en el ComboBox
                //int idDefensaInterna = row.Cells[11].Value != null ? Convert.ToInt32(row.Cells[11].Value) : -1;
                //comboBoxDefensas.SelectedValue = idDefensaInterna; // Asignación del Id_DefensaInterna
            }
        }

        private void limpiar()
        {
            // Resetear el valor de numericUpDownCalificacion a su valor predeterminado, por ejemplo 0 o el mínimo
            numericUpDownCalificacion.Value = numericUpDownCalificacion.Minimum;

            // Resetear las listas
            listTribunal.SelectedIndex = -1;
            listTribunal2.SelectedIndex = -1;
            listTribunal3.SelectedIndex = -1;
            listTribunal4.SelectedIndex = -1;
            listTribunal5.SelectedIndex = -1;
            listProyectos.SelectedIndex = -1;

            // Limpiar otros controles si es necesario
            dateTimePickerFecha.Value = DateTime.Now;  // Restablecer a la fecha actual
            checkBoxEstado.Checked = false;

        }

        private void DEFENSAEXTERNA_Load(object sender, EventArgs e)
        {
           
        }
        private bool ValidarTribunalesUnicos()
        {
            List<int> tribunalesSeleccionados = new List<int>
    {
        (int)listTribunal.SelectedValue,
        (int)listTribunal2.SelectedValue,
        (int)listTribunal3.SelectedValue,
        (int)listTribunal4.SelectedValue,
        (int)listTribunal5.SelectedValue
    };

            // Verificar si hay tribunales duplicados
            if (tribunalesSeleccionados.Distinct().Count() != tribunalesSeleccionados.Count)
            {
                MessageBox.Show("No se pueden seleccionar tribunales duplicados.");
                return false;
            }

            return true;
        }
        private void ValidarCalificacionAprobado()
{
    if (numericUpDownCalificacion.Value < 51 && checkBoxEstado.Checked)
    {
        MessageBox.Show("No puedes marcar como aprobado con una calificación menor a 51.");
        checkBoxEstado.Checked = false;
    }
}
        
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(numericUpDownCalificacion.Text, out int calificacion))
                {
                    MessageBox.Show("La calificación debe ser un número entero.");
                    return;
                }                
                    if (!ValidarTribunalesUnicos())
                    {
                        return; // Evitar que continúe si los tribunales no son únicos
                    }

                    DefensaExterna defensaExterna = new DefensaExterna
                {
                    FechaDefensaExterna = dateTimePickerFecha.Value,
                    AProbado = checkBoxEstado.Checked,
                    Calficacion = calificacion,
                    Id_Tribunal1 = (int)listTribunal.SelectedValue,
                    Id_Tribunal2 = (int)listTribunal2.SelectedValue,
                    Id_Tribunal3 = (int)listTribunal3.SelectedValue,
                    Id_Tribunal4 = (int)listTribunal4.SelectedValue,
                    Id_Tribunal5 = (int)listTribunal5.SelectedValue,
                    Id_Proyecto = (int)listProyectos.SelectedValue,
                    Id_DefensaInterna = (int)comboBoxDefensas.SelectedValue,
                };

                defensaExternaController.CreateDefensaExterna(defensaExterna);
                MessageBox.Show("Defensa Externa agregada exitosamente.");
                CargarDefensas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar defensa Externa: " + ex.Message);
            }

            // Limpiar campos después de agregar
            //limpiar();
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvDefensas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDownCalificacion_ValueChanged(object sender, EventArgs e)
        {
            ValidarCalificacionAprobado();
        }
    }
}
