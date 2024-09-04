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
    public partial class CargoForm : Form
    {
        private CargoController cargoController = new CargoController();
        public CargoForm()
        {
            InitializeComponent();
            LoadCargos();
        }
        private void LoadCargos()
        {
            var cargos = cargoController.GetAllCargos();
            dataGridViewCargos.DataSource = cargos;
            dataGridViewCargos.Columns["CargoID"].Visible = false;
            dataGridViewCargos.Columns["NombreCargo"].HeaderText = "Nombre de Cargo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var cargo = new Cargo
            {
                NombreCargo = txtNombreCargo.Text
            };
            cargoController.AddCargo(cargo);
            LoadCargos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cargo = new Cargo
            {
                CargoID = int.Parse(txtCargoID.Text),
                NombreCargo = txtNombreCargo.Text
            };
            cargoController.UpdateCargo(cargo);
            LoadCargos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cargoID = int.Parse(txtCargoID.Text);
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cargo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                cargoController.DeleteCargo(cargoID);
                LoadCargos();
            }
        }

        private void dataGridViewCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCargos.Rows[e.RowIndex];
                txtCargoID.Text = row.Cells["CargoID"].Value.ToString();
                txtNombreCargo.Text = row.Cells["NombreCargo"].Value.ToString();
            }
        }
    }
}
