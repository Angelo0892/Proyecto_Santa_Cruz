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
    public partial class RetornoForm : Form
    {
        private ActivoFijoController ActivoFijoController = new ActivoFijoController();
        private PersonalController personalController = new PersonalController();
        private RetornoController retornoController = new RetornoController();
        public RetornoForm()
        {
            InitializeComponent();
            LoadPersonal();
            LoadRetornos();
        }
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
        private void dataGridViewPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPersonal.Rows[e.RowIndex];
                int personalID = (int)row.Cells["PersonalID"].Value;
                txtPersonalID.Text = row.Cells["PersonalID"].Value.ToString();

                // Concatenar nombre y apellido
                string nombreCompleto = $"{row.Cells["NombrePersonal"].Value.ToString()} {row.Cells["Apellido"].Value.ToString()}";
                txtNombreCompleto.Text = nombreCompleto; // Asignar al TextBox correspondiente

                txtCargoID.Text = row.Cells["NombreCargo"].Value.ToString();

                var activosFijos = personalController.GetAssignedActivosByPersonalID(personalID);
                dataGridViewActivosFijos.DataSource = activosFijos;

                // Configurar manualmente las columnas si es necesario
                dataGridViewActivosFijos.AutoGenerateColumns = false;
                dataGridViewActivosFijos.Columns.Clear();

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ActivoID",
                    HeaderText = "ID Activo",
                    Name = "ActivoID"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CodigoActivo",
                    HeaderText = "Código Activo",
                    Name = "CodigoActivo"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreActivo",
                    HeaderText = "Nombre del Activo",
                    Name = "NombreActivo"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreCategoria",
                    HeaderText = "Categoría",
                    Name = "NombreCategoria"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FechaAdquisicion",
                    HeaderText = "Fecha de Adquisición",
                    Name = "FechaAdquisicion"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ValorAdquisicion",
                    HeaderText = "Valor de Adquisición",
                    Name = "ValorAdquisicion"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreUbicacion",
                    HeaderText = "Ubicación",
                    Name = "NombreUbicacion"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreUnidad",
                    HeaderText = "Unidad",
                    Name = "NombreUnidad"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DescripcionActivo",
                    HeaderText = "Descripción",
                    Name = "DescripcionActivo"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FechaAsignacion",
                    HeaderText = "Fecha de Asignación",
                    Name = "FechaAsignacion"
                });

                dataGridViewActivosFijos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Observaciones",
                    HeaderText = "Observaciones",
                    Name = "Observaciones"
                });
            }
        }
        private void dataGridViewActivosFijos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActivosFijos.Rows[e.RowIndex];

                txtActivoID.Text = row.Cells["ActivoID"].Value.ToString();
                txtCodigoActivo.Text = row.Cells["CodigoActivo"].Value.ToString();
                txtNombreActivo.Text = row.Cells["NombreActivo"].Value.ToString();
            }
        }    
        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var retorno = new Retorno
                {
                    ActivoID = int.Parse(txtActivoID.Text),
                    PersonalID = int.Parse(txtPersonalID.Text),
                    FechaRetorno = dtpFechaRetorno.Value,
                    Condicion = txtCondicion.Text
                };
                retornoController.AddRetorno(retorno);
                LoadRetornos();
                //dataGridViewPersonal_CellClick();
                //LoadActivosFijos();
                // Mostrar mensaje de confirmación
                MessageBox.Show("Retorno registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show($"Error al registrar el retorno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // CARGAR DATOS DE RETORNO EN EL DATAGRIDVIEW
        private void LoadRetornos()
        {
            var retornos = retornoController.GetAllRetornos();
            dgvRetornos.AutoGenerateColumns = false;
            dgvRetornos.DataSource = retornos;

            // Configurar manualmente las columnas
            dgvRetornos.Columns.Clear();

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RetornoID",
                HeaderText = "ID Retorno",
                Name = "RetornoID",
                Visible = false
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActivoID",
                HeaderText = "ID Activo",
                Name = "ActivoID",
                Visible = false
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoActivo",
                HeaderText = "Código Activo",
                Name = "CodigoActivo"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombrePersonal",
                HeaderText = "Nombre del Personal",
                Name = "NombrePersonal"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido del Personal",
                Name = "Apellido"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCargo",
                HeaderText = "Nombre del Cargo",
                Name = "NombreCargo"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaRetorno",
                HeaderText = "Fecha de Retorno",
                Name = "FechaRetorno"
            });

            dgvRetornos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Condicion",
                HeaderText = "Condición",
                Name = "Condicion"
            });
        }
        private void dgvRetornos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRetornos.Rows[e.RowIndex];

                txtRetornoID_.Text = row.Cells["RetornoID"].Value.ToString();
                textCodigoActivoFijo_.Text = row.Cells["CodigoActivo"].Value.ToString();
                txtNombreActivo_.Text = row.Cells["NombreActivo"].Value.ToString();
                txtNombreCompletoPersonal_.Text = $"{row.Cells["NombrePersonal"].Value} {row.Cells["Apellido"].Value}";
                txtNombreCargo_.Text = row.Cells["NombreCargo"].Value.ToString();
                dtpFechaRetorno_.Value = (DateTime)row.Cells["FechaRetorno"].Value;
                txtCondicion_.Text = row.Cells["Condicion"].Value.ToString();
            }
        }
        private void btnActualizarRetorno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCondicion_.Text))
            {
                MessageBox.Show("Por favor, llena el campo de Condición.");
                return;
            }

            if (int.TryParse(txtRetornoID_.Text, out int retornoID))
            {
                var retorno = new Retorno
                {
                    RetornoID = retornoID,
                    FechaRetorno = dtpFechaRetorno_.Value,
                    Condicion = txtCondicion_.Text
                };

                retornoController.UpdateRetorno(retorno);
                LoadRetornos();

                MessageBox.Show("Retorno actualizado con éxito.");
            }
            else
            {
                MessageBox.Show("Seleccione un retorno válido.");
            }
        }

    }
}
