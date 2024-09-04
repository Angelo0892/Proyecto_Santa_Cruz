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
    public partial class UnidadForm : Form
    {
        private UnidadController unidadController = new UnidadController();
        public UnidadForm()
        {
            InitializeComponent();
            LoadUnidades();
        }
        private void LoadUnidades()
        {
            var unidades = unidadController.GetAllUnidades();
            dataGridViewUnidades.DataSource = unidades;
            dataGridViewUnidades.Columns["UnidadID"].Visible = false;
            dataGridViewUnidades.Columns["NombreUnidad"].HeaderText = "Nombre de Unidad";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var unidad = new Unidad
            {
                NombreUnidad = txtNombreUnidad.Text
            };
            unidadController.AddUnidad(unidad);
            LoadUnidades();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var unidad = new Unidad
            {
                UnidadID = int.Parse(txtUnidadID.Text),
                NombreUnidad = txtNombreUnidad.Text
            };
            unidadController.UpdateUnidad(unidad);
            LoadUnidades();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int unidadID = int.Parse(txtUnidadID.Text);
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta unidad?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                unidadController.DeleteUnidad(unidadID);
                LoadUnidades();
            }
        }

        private void dataGridViewUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUnidades.Rows[e.RowIndex];
                txtUnidadID.Text = row.Cells["UnidadID"].Value.ToString();
                txtNombreUnidad.Text = row.Cells["NombreUnidad"].Value.ToString();
            }
        }
    }
}
