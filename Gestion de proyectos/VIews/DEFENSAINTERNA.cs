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
    public partial class DEFENSAINTERNA : Form
    {
        private DefensaInternaController defensaInternaController;
        public DEFENSAINTERNA()
        {
            InitializeComponent();
            defensaInternaController = new DefensaInternaController();
            CargarDefensas();
            CargarTribunal();
            CargarTribunal2();
            CargarProyectos();
            dgvDefensas.CellClick += dgvDefensas_CellClick;

        }
        private void CargarTribunal()
        {
            try
            {
                DataTable dtTribunal = defensaInternaController.ObtenerTribunal();
                listTribunal.DisplayMember = "Tribunal1_NombreCompleto";
                listTribunal.ValueMember = "Id_Tribunal1";
                listTribunal.DataSource = dtTribunal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tribunales: " + ex.Message);
            }
        }


        private void CargarTribunal2()
        {
            try
            {
                DataTable dtTribunal = defensaInternaController.ObtenerTribunal();
                listTribunal2.DisplayMember = "Tribunal2_NombreCompleto";
                listTribunal2.ValueMember = "Id_Tribunal2";
                listTribunal2.DataSource = dtTribunal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tribunales: " + ex.Message);
            }
        }

        private void CargarProyectos()
        {
            try
            {
                DataTable dtProyectos = defensaInternaController.ObtenerProyectos();
                listProyectos.DisplayMember = "Titulo"; // Mostrar el título del proyecto
                listProyectos.ValueMember = "Id_Proyecto"; // Mantener el ID del proyecto
                listProyectos.DataSource = dtProyectos;

                // Si deseas mostrar el nombre del estudiante también
                comboBoxPostulantes.DisplayMember = "EstudianteNombreCompleto"; // Mostrar el nombre completo del estudiante
                comboBoxPostulantes.ValueMember = "Codigo_Estudiante"; // Código del estudiante
                comboBoxPostulantes.DataSource = dtProyectos; // Usa la misma fuente de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos y estudiantes: " + ex.Message);

            }
        }

        private void CargarDefensas()
            {
            try
            {
                var dtDefensas = defensaInternaController.ObtenerDefensas();
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
                checkBoxObservaciones.Checked = row.Cells[2].Value != null && Convert.ToBoolean(row.Cells[2].Value); // Observaciones
                checkBoxAprobada.Checked = row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value); // Aprobada

                // Calificación
                numericUpCalificacion.Value = row.Cells[4].Value != null ? Convert.ToDecimal(row.Cells[4].Value) : 0;

                // Establecer el valor seleccionado en el ListBox para Proyectos y Tribunal
                int idProyecto = row.Cells[5].Value != null ? Convert.ToInt32(row.Cells[5].Value) : -1;
                listProyectos.SelectedValue = idProyecto;

                int idTribunal1 = row.Cells[6].Value != null ? Convert.ToInt32(row.Cells[6].Value) : -1;
                listTribunal.SelectedValue = idTribunal1;

                int idTribunal2 = row.Cells[7].Value != null ? Convert.ToInt32(row.Cells[7].Value) : -1;
                listTribunal2.SelectedValue = idTribunal2;
            }
        }

        private void limpiar()
        {
            // Resetear el valor de numericUpDownCalificacion a su valor predeterminado, por ejemplo 0 o el mínimo
            numericUpCalificacion.Value = numericUpCalificacion.Minimum;

            // Resetear las listas
            listTribunal.SelectedIndex = -1;
            listTribunal2.SelectedIndex = -1;
            listProyectos.SelectedIndex = -1;

            // Limpiar otros controles si es necesario
            dateTimePickerFecha.Value = DateTime.Now;  // Restablecer a la fecha actual
            checkBoxObservaciones.Checked = false;
            checkBoxAprobada.Checked = false;
        }


        private void DEFENSAINTERNA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet18.DEFENSA_INTERNA' Puede moverla o quitarla según sea necesario.
            this.dEFENSA_INTERNATableAdapter.Fill(this.dEMOPROYDataSet18.DEFENSA_INTERNA);

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(numericUpCalificacion.Text, out int calificacion))
                {
                    MessageBox.Show("La calificación debe ser un número entero.");
                    return;
                }

                // Validar que la calificación sea mayor o igual a 51 si se ha marcado como aprobada
                if (checkBoxAprobada.Checked && calificacion < 51)
                {
                    MessageBox.Show("No se puede marcar como aprobada con una calificación menor a 51.");
                    return;
                }

                // Validación adicional para evitar seleccionar el mismo tribunal en ambos campos
                if ((int)listTribunal.SelectedValue == (int)listTribunal2.SelectedValue)
                {
                    MessageBox.Show("No se puede seleccionar el mismo tribunal en ambos campos.");
                    return;
                }

                // Validación de rango de fecha (hoy hasta 6 meses)
                DateTime fechaActual = DateTime.Now.Date; // Solo la fecha, sin la hora
                DateTime fechaMaxima = fechaActual.AddMonths(6); // Se agrega 6 meses
                DateTime fechaSeleccionada = dateTimePickerFecha.Value.Date;
                if (fechaSeleccionada < fechaActual || fechaSeleccionada > fechaMaxima)
                {
                    MessageBox.Show("La fecha debe estar entre hoy y los próximos 6 meses.");
                    return;
                }

                // Crear una nueva instancia del modelo DefensaInterna
                DefensaInterna defensaInterna = new DefensaInterna
                {
                    FechaDefensaInterna = dateTimePickerFecha.Value,
                    Observaciones = checkBoxObservaciones.Checked,
                    Aprobada = checkBoxAprobada.Checked,
                    Calficacion = calificacion,
                    Id_Tribunal1 = (int)listTribunal.SelectedValue,
                    Id_Tribunal2 = (int)listTribunal2.SelectedValue,
                    Id_Proyecto = (int)listProyectos.SelectedValue
                };

                // Llamar al método para agregar en el controlador
                defensaInternaController.CreateDefensaInterna(defensaInterna);
                MessageBox.Show("Defensa interna agregada exitosamente.");
                CargarDefensas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar defensa interna: " + ex.Message);
            }

            limpiar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (dgvDefensas.SelectedCells.Count == 0)
                    {
                        MessageBox.Show("Selecciona una Defensa para editar.");
                        return;
                    }
                // Crear una instancia del modelo con los datos actualizados
                DefensaInterna defensaInterna = new DefensaInterna
                    {
                        Id_DefensaInterna = Convert.ToInt32(dgvDefensas.SelectedCells[0].Value),
                        FechaDefensaInterna = dateTimePickerFecha.Value,
                        Observaciones = checkBoxObservaciones.Checked,
                        Aprobada = checkBoxAprobada.Checked,
                        Calficacion = (int)numericUpCalificacion.Value,
                        Id_Tribunal1 = (int)listTribunal.SelectedValue,
                        Id_Tribunal2 = (int)listTribunal2.SelectedValue,
                        Id_Proyecto = (int)listProyectos.SelectedValue
                    };

                    // Llamar al método para editar en el controlador
                    defensaInternaController.UpdateDefensaInterna(defensaInterna);
                    MessageBox.Show("Defensa interna editada exitosamente.");
                    CargarDefensas();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar defensa interna: " + ex.Message);
                }

            limpiar();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDefensas.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Selecciona un perfil para eliminar.");
                    return;
                }

                int idDefensa = Convert.ToInt32(dgvDefensas.SelectedCells[0].Value);
                defensaInternaController.DeleteDefensaInterna(idDefensa);
                MessageBox.Show("Defensa eliminado correctamente.");
                CargarDefensas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el perfil: " + ex.Message);
            }

            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {/*
              try
    {
        int idDefensa = Convert.ToInt32(numericUpDownCalificacion.Text); // Obtienes el ID de la defensa interna

        // Primero obtienes el código del estudiante basado en el proyecto
        int codigoEstudiante = defensaInternaController.GetCodigoEstudiante(idDefensa);

        // Luego obtienes la defensa interna usando el código del estudiante
        DefensaInterna defensaInterna = defensaInternaController.GetDefensaInternaPorCodigoEstudiante(codigoEstudiante);

        if (defensaInterna != null)
        {
                    dateTimePickerFecha.Value = defensaInterna.FechaDefensaInterna;
                    checkBoxObservaciones.Checked = defensaInterna.Observaciones;
                    checkBoxAprobada.Checked = defensaInterna.Aprobada;
                    numericUpDownCalificacion.Value = defensaInterna.Calficacion;  // Asignar el valor a 'Value'
                    listTribunal.SelectedValue = defensaInterna.Id_Tribunal1;
                    listTribunal2.SelectedValue = defensaInterna.Id_Tribunal2;
                    listProyectos.SelectedValue = defensaInterna.Id_Proyecto;

                }
                else
        {
            MessageBox.Show("No se encontró la defensa interna con el ID proporcionado.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al buscar defensa interna: " + ex.Message);
    }*/
            }


        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Verifica si la calificación es menor a 51
            if (numericUpCalificacion.Value < 51)
            {
                checkBoxAprobada.Checked = false; // Desmarcar el checkbox
                checkBoxAprobada.Enabled = false; // Deshabilitar el checkbox
            }
            else
            {
                checkBoxAprobada.Enabled = true; // Habilitar el checkbox si la calificación es 51 o mayor
            }
        }

        private void listTribunal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTribunal.SelectedValue != null && listTribunal2.SelectedValue != null)
            {
                if ((int)listTribunal.SelectedValue == (int)listTribunal2.SelectedValue)
                {
                    MessageBox.Show("No se puede seleccionar el mismo tribunal en ambos campos.");
                    listTribunal.SelectedIndex = -1; // Reiniciar la selección
                }
            }
        }

        private void dgvDefensas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listTribunal2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTribunal.SelectedValue != null && listTribunal2.SelectedValue != null)
            {
                if ((int)listTribunal.SelectedValue == (int)listTribunal2.SelectedValue)
                {
                    MessageBox.Show("No se puede seleccionar el mismo tribunal en ambos campos.");
                    listTribunal2.SelectedIndex = -1; // Reiniciar la selección
                }
            }
        }
            
        private void numericUpCalificacion_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpCalificacion.Value < 51)
            {
                checkBoxAprobada.Checked = false; // Desmarcar el checkbox
                checkBoxAprobada.Enabled = false; // Deshabilitar el checkbox
            }
            else
            {
                checkBoxAprobada.Enabled = true; // Habilitar el checkbox si la calificación es 51 o mayor
            }
        }   

    }
}
