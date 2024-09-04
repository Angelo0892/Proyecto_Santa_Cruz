using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTIVOS_FIJOS.Controllers;
using ACTIVOS_FIJOS.Models;

namespace ACTIVOS_FIJOS.Views
{
    public partial class UbicacionForm : Form
    {
        private UbicacionController ubicacionController = new UbicacionController();
        public UbicacionForm()
        {
            InitializeComponent();
            LoadUbicaciones();
        }
        private void LoadUbicaciones()
        {
            var ubicaciones = ubicacionController.GetAllUbicaciones();
            dataGridViewUbicaciones.DataSource = ubicaciones;
            dataGridViewUbicaciones.Columns["UbicacionID"].Visible = false;
            dataGridViewUbicaciones.Columns["NombreUbicacion"].HeaderText = "Nombre de Ubicación";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ubicacion = new Ubicacion
            {
                NombreUbicacion = txtNombreUbicacion.Text
            };
            ubicacionController.AddUbicacion(ubicacion);
            LoadUbicaciones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var ubicacion = new Ubicacion
            {
                UbicacionID = int.Parse(txtUbicacionID.Text),
                NombreUbicacion = txtNombreUbicacion.Text
            };
            ubicacionController.UpdateUbicacion(ubicacion);
            LoadUbicaciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ubicacionID = int.Parse(txtUbicacionID.Text);
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta ubicación?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ubicacionController.DeleteUbicacion(ubicacionID);
                LoadUbicaciones();
            }
        }        
        private void dataGridViewUbicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUbicaciones.Rows[e.RowIndex];
                txtUbicacionID.Text = row.Cells["UbicacionID"].Value.ToString();
                txtNombreUbicacion.Text = row.Cells["NombreUbicacion"].Value.ToString();
            }
        }
    }
}
