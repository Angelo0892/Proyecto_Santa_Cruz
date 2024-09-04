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
using System.Data;
using System.Data.SqlClient;

namespace ACTIVOS_FIJOS.Views
{
    public partial class PersonalForm : Form
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        private PersonalController personalController = new PersonalController();
        public PersonalForm()
        {
            InitializeComponent();
            LoadComboBoxes();
            LoadPersonal();
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
            dataGridViewPersonal.Columns["UnidadID"].Visible = false;
            dataGridViewPersonal.Columns["NombreCargo"].HeaderText = "Cargo";
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
        private void LoadComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cargar Unidades
                string queryUnidad = "SELECT UnidadID, NombreUnidad FROM UNIDAD";
                SqlDataAdapter adapterUnidad = new SqlDataAdapter(queryUnidad, connection);
                DataTable dataTableUnidad = new DataTable();
                adapterUnidad.Fill(dataTableUnidad);
                comboBoxUnidades.DataSource = dataTableUnidad;
                comboBoxUnidades.DisplayMember = "NombreUnidad";
                comboBoxUnidades.ValueMember = "UnidadID";
                // Cargar Cargos
                string queryCargo = "SELECT CargoID, NombreCargo FROM CARGO";
                SqlDataAdapter adapterCargo = new SqlDataAdapter(queryCargo, connection);
                DataTable dataTableCargo = new DataTable();
                adapterCargo.Fill(dataTableCargo);
                comboBoxCargos.DataSource = dataTableCargo;
                comboBoxCargos.DisplayMember = "NombreCargo";
                comboBoxCargos.ValueMember = "CargoID";
            }
        }
        private void BtnAgregarPersonal_Click_1(object sender, EventArgs e)
        {
            var personal = new Personal
            {
                NombrePersonal = txtNombrePersonal.Text,
                Apellido = txtApellido.Text,
                CargoID = (int)comboBoxCargos.SelectedValue,
                UnidadID = (int)comboBoxUnidades.SelectedValue,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text
            };
            personalController.AddPersonal(personal);
            LoadPersonal();
        }
        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            var personal = new Personal
            {
                PersonalID = int.Parse(txtPersonalID.Text),
                NombrePersonal = txtNombrePersonal.Text,
                Apellido = txtApellido.Text,
                CargoID = (int)comboBoxCargos.SelectedValue,
                UnidadID = (int)comboBoxUnidades.SelectedValue,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text
            };
            personalController.UpdatePersonal(personal);
            LoadPersonal();
        }
        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            int personalID = int.Parse(txtPersonalID.Text);
            // Mostrar un cuadro de diálogo de confirmación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            // Si el usuario hace clic en "Sí", proceder con la eliminación
            if (confirmResult == DialogResult.Yes)
            {
                personalController.DeletePersonal(personalID);
                LoadPersonal();
            }
        }
        private void dataGridViewPersonal_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en el encabezado
            {
                DataGridViewRow row = dataGridViewPersonal.Rows[e.RowIndex];
                txtPersonalID.Text = row.Cells["PersonalID"].Value.ToString();
                txtNombrePersonal.Text = row.Cells["NombrePersonal"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                comboBoxCargos.SelectedValue = row.Cells["CargoID"].Value;
                comboBoxUnidades.SelectedValue = row.Cells["UnidadID"].Value;
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }
        private void btnAdminCargo_Click(object sender, EventArgs e)
        {
            CargoForm administrarCargo = new CargoForm();
            administrarCargo.ShowDialog();
        }
        private void btnAdminUnidad_Click(object sender, EventArgs e)
        {
            UnidadForm administrarUnidad = new UnidadForm();
            administrarUnidad.ShowDialog();
        }
    }
}
