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
    public partial class DefensaPerfilForm : Form
    {
        private DefensaPerfilController defensaPerfilController;
        public DefensaPerfilForm()
        {
            defensaPerfilController = new DefensaPerfilController();
            InitializeComponent();
            CargarTribunal();
            CargarPostulantes();
            CargarPerfil();
            CargarDocentes();
            CargarPerfiles();
            CargarPerfil();
            dgvDefensas.CellClick += dgvDefensas_CellClick;



        }
        private void dgvDefensas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la fila seleccionada sea válida (que no sea el encabezado)
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow row = dgvDefensas.Rows[e.RowIndex];

                // Llenar los controles del formulario con los valores de la fila seleccionada

                // Fecha de defensa (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["FechaDefensa"].Value != null)
                {
                    dtp.Value = Convert.ToDateTime(row.Cells["FechaDefensa"].Value);
                }

                // Estado del perfil (si está aprobado o no)
                rdestado.Checked = row.Cells["EstadoPerfil"].Value != null && Convert.ToBoolean(row.Cells["EstadoPerfil"].Value);

                // Calificación (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["Calficacion"].Value != null)
                {
                    numericUpCalificacion.Value = Convert.ToDecimal(row.Cells["Calficacion"].Value);
                }

                // ID del docente (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["ID_DocenteMDG1"].Value != null)
                {
                    cmbDocentes.SelectedValue = Convert.ToInt32(row.Cells["ID_DocenteMDG1"].Value);
                }

                // ID del primer tribunal (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["ID_Tribunal1"].Value != null)
                {
                    listTribunal.SelectedValue = Convert.ToInt32(row.Cells["ID_Tribunal1"].Value);
                }

                // ID del postulante (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["ID_Postulante"].Value != null)
                {
                    listPostulantes.SelectedValue = Convert.ToInt32(row.Cells["ID_Postulante"].Value);
                }

                // ID del perfil (asegurarse de que no sea nulo antes de asignarlo)
                if (row.Cells["ID_Perfil"].Value != null)
                {
                    listPerfil.SelectedValue = Convert.ToInt32(row.Cells["ID_Perfil"].Value);
                }
            }
        }
        private void CargarPerfiles()
        {
            try
            {
                var dtDefensas = defensaPerfilController.ObtenerDefensaPerfil();
                dgvDefensas.DataSource = dtDefensas; // `dgvPerfiles` es tu DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Defensas: " + ex.Message);
            }
        }



        private void CargarTribunal()
        {
            try
            {
                // Obtiene los datos de los tribunales desde el controlador
                DataTable dtTribunal = defensaPerfilController.ObtenerTribunal();

                // Asigna las columnas correctas al DisplayMember y ValueMember
                listTribunal.DisplayMember = "Tribunal1_NombreCompleto";  // Nombre completo del tribunal
                listTribunal.ValueMember = "Id_Tribunal1";  // ID del tribunal

                // Asigna la fuente de datos
                listTribunal.DataSource = dtTribunal;
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show("Error al cargar los tribunales: " + ex.Message);
            }
        }

        private void CargarPostulantes()
        {
            // Llamada al controlador para obtener los postulantes
            DataTable dtPostulante = defensaPerfilController.ObtenerPostulante();

            // Asignamos los datos al ListBox de postulantes
            listPostulantes.DisplayMember = "PrimerNombre";  // Columna que se mostrará
            listPostulantes.ValueMember = "Codigo_Estudiante";  // Columna con el ID
            listPostulantes.DataSource = dtPostulante;
        }
        private void CargarPerfil(int codigoEstudiante)
        {
            // Llamada al controlador para obtener los perfiles del postulante seleccionado
            DataTable dtPerfil = defensaPerfilController.ObtenerPerfil(codigoEstudiante);

            // Asignamos los datos al ListBox de perfiles
            listPerfil.DisplayMember = "Titulo";  // Columna que se mostrará
            listPerfil.ValueMember = "Id_Perfil";  // Columna con el ID del perfil
            listPerfil.DataSource = dtPerfil;
        }

        private void listPostulantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el Código del estudiante seleccionado
            if (listPostulantes.SelectedValue != null)
            {
                int codigoEstudiante = (int)listPostulantes.SelectedValue;

                // Llamar al método CargarPerfil para mostrar los perfiles del postulante seleccionado
                CargarPerfil(codigoEstudiante);
            }
        }

        private void CargarPerfil()
        {
            DataTable dtPerfil = defensaPerfilController.ObtenerPerfil();
            listPerfil.DisplayMember = "Titulo"; // Columna que quieres mostrar
            listPerfil.ValueMember = "ID_Perfil"; // Columna con el ID
            listPerfil.DataSource = dtPerfil;
        }
        private void CargarDocentes()
        {
            try
            {
                DataTable dtDocente = defensaPerfilController.ObtenerDocente();
                cmbDocentes.DisplayMember = "PrimerNombre";
                cmbDocentes.ValueMember = "Id_Docente";
                cmbDocentes.DataSource = dtDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }



        private void DefensaPerfilForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si la calificación es válida
                int calificacion = (int)numericUpCalificacion.Value; // Usar Value en lugar de Text

                var defensaperfil = new DefensaPerfil
                {
                    FechaDefensa = dtp.Value, // Asignar la fecha de defensa seleccionada
                    EstadoPerfil = rdestado.Checked, // Asignar el estado del perfil (aprobado o no)
                    Calficacion = calificacion, // Asignar la calificación ingresada
                    ID_DocenteMDG1 = (int)cmbDocentes.SelectedValue, // Asignar el ID del docente seleccionado
                    ID_Tribunal1 = (int)listTribunal.SelectedValue, // Asignar el ID del primer tribunal seleccionado
                    ID_Postulante = (int)listPostulantes.SelectedValue, // Asignar el ID del postulante seleccionado
                    ID_Perfil = (int)listPerfil.SelectedValue // Asignar el ID del perfil seleccionado
                                                              // Asegúrate de manejar otros campos como Id_Titulo si es necesario
                };

                // Llamar al controlador para agregar la defensa de perfil
                defensaPerfilController.AgregarDefensaPerfil(defensaperfil);

                // Actualizar la lista de defensas de perfil si es necesario
                // ActualizarListaDefensaPerfil(); // Descomentar si se implementa

                // Mostrar un mensaje de éxito al usuario
                MessageBox.Show("Defensa de Perfil agregada exitosamente");
            }
            catch (Exception ex)
            {
                // Manejar cualquier error y mostrar un mensaje de error al usuario
                MessageBox.Show("Error al agregar defensa Perfil: " + ex.Message);
            }

        }
    }
}
