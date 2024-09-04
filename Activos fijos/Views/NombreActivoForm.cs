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
    public partial class NombreActivoForm : Form
    {
        private NombreActivoController nombreActivoController = new NombreActivoController();
        public NombreActivoForm()
        {
            InitializeComponent();
            LoadNombreActivos();
        }
        private void LoadNombreActivos()
        {
            var nombreActivos = nombreActivoController.GetAllNombreActivos();
            dataGridViewNombreActivos.DataSource = nombreActivos;
            dataGridViewNombreActivos.Columns["NombreActivoID"].Visible = false;
            dataGridViewNombreActivos.Columns["NombreActivo_"].HeaderText = "Nombre de Activo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nombreActivo = new NombreActivo
            {
                NombreActivo_ = txtNombreActivo.Text
            };
            nombreActivoController.AddNombreActivo(nombreActivo);
            LoadNombreActivos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var nombreActivo = new NombreActivo
            {
                NombreActivoID = int.Parse(txtNombreActivoID.Text),
                NombreActivo_ = txtNombreActivo.Text
            };
            nombreActivoController.UpdateNombreActivo(nombreActivo);
            LoadNombreActivos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nombreActivoID = int.Parse(txtNombreActivoID.Text);
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este nombre de activo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                nombreActivoController.DeleteNombreActivo(nombreActivoID);
                LoadNombreActivos();
            }
        }

        private void dataGridViewNombreActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNombreActivos.Rows[e.RowIndex];
                txtNombreActivoID.Text = row.Cells["UnidadID"].Value.ToString();
                txtNombreActivo.Text = row.Cells["NombreUnidad"].Value.ToString();
            }
        }
    }
}
