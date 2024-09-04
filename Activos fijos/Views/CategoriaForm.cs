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
    public partial class CategoriaForm : Form
    {
        private CategoriaController categoriaController = new CategoriaController();
        public CategoriaForm()
        {
            InitializeComponent();
            LoadCategorias();
        }
        private void LoadCategorias()
        {
            var categorias = categoriaController.GetAllCategorias();
            dataGridViewCategorias.DataSource = categorias;
            dataGridViewCategorias.Columns["CategoriaID"].Visible = false;
            dataGridViewCategorias.Columns["NombreCategoria"].HeaderText = "Nombre de Categoria";
            dataGridViewCategorias.Columns["VidaUtil"].HeaderText = "Vida Útil";
            dataGridViewCategorias.Columns["ValorResidual"].HeaderText = "Valor Residual";
        }        
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria
            {
                NombreCategoria = txtNombreCategoria.Text,
                VidaUtil = int.Parse(txtVidaUtil.Text),
                ValorResidual = decimal.Parse(txtValorResidual.Text)
            };
            categoriaController.AddCategoria(categoria);
            LoadCategorias();
        }
        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria
            {
                CategoriaID = int.Parse(txtCategoriaID.Text),
                NombreCategoria = txtNombreCategoria.Text,
                VidaUtil = int.Parse(txtVidaUtil.Text),
                ValorResidual = decimal.Parse(txtValorResidual.Text)
            };
            categoriaController.UpdateCategoria(categoria);
            LoadCategorias();
        }
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            int categoriaID = int.Parse(txtCategoriaID.Text);
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                categoriaController.DeleteCategoria(categoriaID);
                LoadCategorias();
            }
        }
        private void dataGridViewCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCategorias.Rows[e.RowIndex];
                txtCategoriaID.Text = row.Cells["CategoriaID"].Value.ToString();
                txtNombreCategoria.Text = row.Cells["NombreCategoria"].Value.ToString();
                txtVidaUtil.Text = row.Cells["VidaUtil"].Value.ToString();
                txtValorResidual.Text = row.Cells["ValorResidual"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario secundario
        }
    }
}
