using ACTIVOS_FIJOS.Controllers;
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
    public partial class DepreciacionForm : Form
    {
        private DepreciacionController controller;
        private ActivoFijoController ActivoFijoController = new ActivoFijoController();
        private DepreciacionController depreciacionController = new DepreciacionController();
        private AsignacionController asignacionController = new AsignacionController();
        public DepreciacionForm()
        {
            InitializeComponent();
            LoadActivosFijos();
            controller = new DepreciacionController();
        }
        private void LoadActivosFijos()
        {
            var activos = ActivoFijoController.GetAllAssetsWithDetailsDepreciacion();
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
                DataPropertyName = "NombreActivo",
                HeaderText = "Nombre del Activo",
                Name = "NombreActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoBaja",
                HeaderText = "Estado",
                Name = "EstadoBaja"
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
                DataPropertyName = "ValorAdquisicion",
                HeaderText = "Valor de Adquisición",
                Name = "ValorAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAdquisicion",
                HeaderText = "Fecha de Adquisición",
                Name = "FechaAdquisicion"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroDepreciaciones",
                HeaderText = "Número de Depreciaciones",
                Name = "NumeroDepreciaciones"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VidaUtil",
                HeaderText = "Vida Útil",
                Name = "VidaUtil"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValoResidual",
                HeaderText = "Valor Residual",
                Name = "ValoResidual"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorDepreciacion",
                HeaderText = "Valor Depreciación",
                Name = "ValorDepreciacion"
            });
        }
        private void dataGridViewActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActivos.Rows[e.RowIndex];

                txtActivoID_.Text = row.Cells["ActivoID"].Value.ToString();
                textCodigoActivoFijo_.Text = row.Cells["CodigoActivo"].Value.ToString();
                txtNombreActivo_.Text = row.Cells["NombreActivo"].Value.ToString();
                //txtEstadoBaja_.Text = row.Cells["EstadoBaja"].Value.ToString();
                //txtCategoriaID_.Text = row.Cells["CategoriaID"].Value.ToString();
                //txtNombreCategoria_.Text = row.Cells["NombreCategoria"].Value.ToString();
                txtValorAdquisicion_.Text = row.Cells["ValorAdquisicion"].Value.ToString();
                dtpFechaAdquisicion_.Value = (DateTime)row.Cells["FechaAdquisicion"].Value;
                txtNumeroDepreciaciones_.Text = row.Cells["NumeroDepreciaciones"].Value.ToString();
                txtVidaUtil_.Text = row.Cells["VidaUtil"].Value.ToString();
                txtValoResidual_.Text = row.Cells["ValoResidual"].Value.ToString();
                txtValorDepreciacion_.Text = row.Cells["ValorDepreciacion"].Value.ToString();
            }
        }        
        private void btnRegistrarDepreciacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del activo fijo seleccionado
                if (int.TryParse(txtActivoID_.Text, out int activoID))
                {
                    // Llamar a la función para registrar la depreciación
                    depreciacionController.RegistrarDepreciacion(activoID);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Depreciación registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de activos fijos para reflejar los cambios
                    LoadActivosFijos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un activo fijo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la depreciación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

