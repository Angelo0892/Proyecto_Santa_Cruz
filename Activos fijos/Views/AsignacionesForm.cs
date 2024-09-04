using ACTIVOS_FIJOS.Controllers;
using ACTIVOS_FIJOS.Models;
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
    public partial class AsignacionesForm : Form
    {
        private ActivoFijoController ActivoFijoController = new ActivoFijoController();
        private PersonalController personalController = new PersonalController();
        private AsignacionController asignacionController = new AsignacionController();
        public AsignacionesForm()
        {
            InitializeComponent();
            LoadAsignaciones();
            LoadActivosFijos();
            LoadPersonal();
        }
        //CARGAR DATOS DE ACTIVOS FIJOS EN EL DATAGRIDVIEW
        private void LoadActivosFijos()
        {
            var activos = ActivoFijoController.GetInactiveAssets();
            dataGridViewActivos.AutoGenerateColumns = false;
            dataGridViewActivos.DataSource = activos;
            // Configurar manualmente las columnas
            dataGridViewActivos.Columns.Clear();
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código",
                Name = "CodigoActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivoID",
                HeaderText = "ID Nombre Activo",
                Name = "NombreActivoID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriaID",
                HeaderText = "ID Categoría",
                Name = "CategoriaID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCategoria",
                HeaderText = "Categoría",
                Name = "NombreCategoria"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UbicacionID",
                HeaderText = "ID Ubicación",
                Name = "UbicacionID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUbicacion",
                HeaderText = "Ubicación",
                Name = "NombreUbicacion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadID",
                HeaderText = "ID Unidad",
                Name = "UnidadID",
                Visible = false // Ocultar la columna de ID
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUnidad",
                HeaderText = "Unidad",
                Name = "NombreUnidad"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "EstadoBaja"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones",
                Visible = false
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionActivo",
                HeaderText = "Descripción",
                Name = "DescripcionActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoBajaActivo",
                HeaderText = "Motivo de Baja",
                Name = "MotivoBajaActivo",
                Visible = false
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo",
                Visible = false
            });
        }        
        //CARGAR DATOS DE PERSONAL EN EL DATAGRIDVIEW
        private void LoadPersonal()
        {
            var personalList = personalController.GetAllPersonal();
            dataGridViewPersonal.DataSource = personalList;
            // Ocultar la columna PersonalID
            dataGridViewPersonal.Columns["PersonalID"].Visible = false;
            // Configurar el orden y los nombres de las columnas
            dataGridViewPersonal.Columns["NombrePersonal"].HeaderText = "Nombre";
            dataGridViewPersonal.Columns["Apellido"].HeaderText = "Apellido";
            dataGridViewPersonal.Columns["CargoID"].Visible = false;
            dataGridViewPersonal.Columns["NombreCargo"].HeaderText = "Cargo";
            dataGridViewPersonal.Columns["UnidadID"].Visible = false;
            dataGridViewPersonal.Columns["NombreUnidad"].HeaderText = "Unidad";
            dataGridViewPersonal.Columns["Email"].HeaderText = "Correo Electrónico";
            dataGridViewPersonal.Columns["Telefono"].HeaderText = "Teléfono";
            // Reordenar las columnas
            dataGridViewPersonal.Columns["NombrePersonal"].DisplayIndex = 0;
            dataGridViewPersonal.Columns["Apellido"].DisplayIndex = 1;
            dataGridViewPersonal.Columns["NombreCargo"].DisplayIndex = 2;
            dataGridViewPersonal.Columns["NombreUnidad"].DisplayIndex = 3;
            dataGridViewPersonal.Columns["Email"].DisplayIndex = 4;
            dataGridViewPersonal.Columns["Telefono"].DisplayIndex = 5;
        }
        //CARGAR DATOS DE ASIGNACION EN EL DATAGRIDVIEW
        private void LoadAsignaciones()
        {
            var asignaciones = asignacionController.GetAllAsignaciones();
            dgvAsignaciones.AutoGenerateColumns = false;
            dgvAsignaciones.DataSource = asignaciones;

            // Configurar manualmente las columnas
            dgvAsignaciones.Columns.Clear();

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AsignacionID",
                HeaderText = "ID Asignación",
                Name = "AsignacionID",
                Visible = false
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código Activo",
                Name = "CodigoActivo"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombrePersonal",
                HeaderText = "Nombre del Personal",
                Name = "NombrePersonal"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido del Personal",
                Name = "Apellido"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCargo",
                HeaderText = "Nombre del Cargo",
                Name = "NombreCargo"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAsignacion",
                HeaderText = "Fecha de Asignación",
                Name = "FechaAsignacion"
            });

            dgvAsignaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observaciones",
                HeaderText = "Observaciones",
                Name = "Observaciones"
            });
        }

        //CARGAR DATOS DE ASIGNACION EN EL DATAGRIDVIEW        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                var asignacion = new Asignacion
                {
                    ActivoID = int.Parse(txtActivoID.Text),
                    PersonalID = int.Parse(txtPersonalID.Text),
                    FechaAsignacion = dtpFechaAsignacion.Value,
                    Observaciones = txtObservaciones.Text
                };
                asignacionController.AddAsignacion(asignacion);
                LoadAsignaciones();
                LoadActivosFijos();

                // Mostrar mensaje de confirmación
                MessageBox.Show("Asignación realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show($"Error al realizar la asignación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActivos.Rows[e.RowIndex];

                txtActivoID.Text = row.Cells["ActivoID"].Value.ToString();
                txtCodigoActivo.Text = row.Cells["CodigoActivo"].Value.ToString();
                txtNombreActivo.Text = row.Cells["NombreActivo"].Value.ToString();
            }
        }
        private void dataGridViewPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en el encabezado
            {
                DataGridViewRow row = dataGridViewPersonal.Rows[e.RowIndex];
                txtPersonalID.Text = row.Cells["PersonalID"].Value.ToString();

                // Concatenar nombre y apellido
                string nombreCompleto = $"{row.Cells["NombrePersonal"].Value.ToString()} {row.Cells["Apellido"].Value.ToString()}";
                txtNombreCompleto.Text = nombreCompleto; // Asignar al TextBox correspondiente

                txtCargoID.Text = row.Cells["NombreCargo"].Value.ToString();
            }
        }
        private void dgvAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAsignaciones.Rows[e.RowIndex];

                txtAsignacionID_.Text = row.Cells["AsignacionID"].Value.ToString();
                textCodigoActivoFijo_.Text = row.Cells["CodigoActivo"].Value.ToString();
                txtNombreActivo_.Text = row.Cells["NombreActivo"].Value.ToString();
                txtNombreCompletoPersonal_.Text = $"{row.Cells["NombrePersonal"].Value} {row.Cells["Apellido"].Value}";
                txtNombreCargo_.Text = row.Cells["NombreCargo"].Value.ToString();
                dtpFechaAsignacion_.Value = (DateTime)row.Cells["FechaAsignacion"].Value;
                txtObservaciones_.Text = row.Cells["Observaciones"].Value.ToString();
            }
        }

        private void btnActualizarAsignacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObservaciones_.Text))
            {
                MessageBox.Show("Por favor, llena el campo de Observaciones.");
                return;
            }

            if (int.TryParse(txtAsignacionID_.Text, out int asignacionID))
            {
                var asignacion = new Asignacion
                {
                    AsignacionID = asignacionID,
                    FechaAsignacion = dtpFechaAsignacion_.Value,
                    Observaciones = txtObservaciones_.Text
                };

                asignacionController.UpdateAsignacion(asignacion);
                LoadAsignaciones();

                MessageBox.Show("Asignación actualizada con éxito.");
            }
            else
            {
                MessageBox.Show("Seleccione una asignación válida.");
            }
        } 
    }
}
