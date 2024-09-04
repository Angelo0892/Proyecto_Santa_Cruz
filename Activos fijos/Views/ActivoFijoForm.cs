using ACTIVOS_FIJOS.Controllers;
using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACTIVOS_FIJOS.Views
{
    public partial class ActivoFijoForm : Form
    {
        private string connectionString = "Server=DESKTOP-TM74ECK\\SQLEXPRESS;Database=ActivosFijosDB;Integrated Security=True;";
        private ActivoFijoController ActivoFijoController = new ActivoFijoController();
        public ActivoFijoForm()
        {
            InitializeComponent();
            LoadActivosFijos();
            LoadComboBoxes();            
            dataGridViewActivos.CellClick += dataGridViewActivos_CellClick;
            comboBoxNombresActivos.SelectedIndexChanged += comboBoxNombresActivos_SelectedIndexChanged;
            comboBoxCategorias.SelectedIndexChanged += comboBoxCategorias_SelectedIndexChanged;
        }
        private void LoadComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cargar Nombres de Activos
                string queryNombreActivo = "SELECT NombreActivoID, NombreActivo_ FROM NOMBREACTIVO";
                SqlDataAdapter adapterNombreActivo = new SqlDataAdapter(queryNombreActivo, connection);
                DataTable dataTableNombreActivo = new DataTable();
                adapterNombreActivo.Fill(dataTableNombreActivo);
                comboBoxNombresActivos.DataSource = dataTableNombreActivo;
                comboBoxNombresActivos.DisplayMember = "NombreActivo_";
                comboBoxNombresActivos.ValueMember = "NombreActivoID";
                comboBoxNombreActivo_.DataSource = dataTableNombreActivo.Copy();
                comboBoxNombreActivo_.DisplayMember = "NombreActivo_";
                comboBoxNombreActivo_.ValueMember = "NombreActivoID";
                // Cargar Categorías
                string queryCategoria = "SELECT CategoriaID, NombreCategoria FROM CATEGORIA";
                SqlDataAdapter adapterCategoria = new SqlDataAdapter(queryCategoria, connection);
                DataTable dataTableCategoria = new DataTable();
                adapterCategoria.Fill(dataTableCategoria);
                comboBoxCategorias.DataSource = dataTableCategoria;
                comboBoxCategorias.DisplayMember = "NombreCategoria";
                comboBoxCategorias.ValueMember = "CategoriaID";
                comboBoxCategorias_.DataSource = dataTableCategoria.Copy();
                comboBoxCategorias_.DisplayMember = "NombreCategoria";
                comboBoxCategorias_.ValueMember = "CategoriaID";
                // Cargar Unidades
                string queryUnidad = "SELECT UnidadID, NombreUnidad FROM UNIDAD";
                SqlDataAdapter adapterUnidad = new SqlDataAdapter(queryUnidad, connection);
                DataTable dataTableUnidad = new DataTable();
                adapterUnidad.Fill(dataTableUnidad);
                comboBoxUnidades.DataSource = dataTableUnidad;
                comboBoxUnidades.DisplayMember = "NombreUnidad";
                comboBoxUnidades.ValueMember = "UnidadID";
                comboBoxUnidades_.DataSource = dataTableUnidad.Copy();
                comboBoxUnidades_.DisplayMember = "NombreUnidad";
                comboBoxUnidades_.ValueMember = "UnidadID";
                // Cargar Ubicaciones
                string queryUbicacion = "SELECT UbicacionID, NombreUbicacion FROM UBICACION";
                SqlDataAdapter adapterUbicacion = new SqlDataAdapter(queryUbicacion, connection);
                DataTable dataTableUbicacion = new DataTable();
                adapterUbicacion.Fill(dataTableUbicacion);
                comboBoxUbicaciones.DataSource = dataTableUbicacion;
                comboBoxUbicaciones.DisplayMember = "NombreUbicacion";
                comboBoxUbicaciones.ValueMember = "UbicacionID";
                comboBoxUbicaciones_.DataSource = dataTableUbicacion.Copy();
                comboBoxUbicaciones_.DisplayMember = "NombreUbicacion";
                comboBoxUbicaciones_.ValueMember = "UbicacionID";
            }
        }
        private bool CodigoActivoExiste(string codigo)
        {
            // Suponiendo que ActivoFijoController tiene un método para obtener activos por código
            var activo = ActivoFijoController.GetActivoByCodigo(codigo);
            return activo != null;
        } 
        private void LoadActivosFijos()
        {
            var activos = ActivoFijoController.GetAllAssetsWithDetails();
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
                Name = "NumeroDepreciaciones"
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
                Name = "MotivoBajaActivo"
            });
            dataGridViewActivos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoEliminarActivo",
                HeaderText = "Motivo de Eliminación",
                Name = "MotivoEliminarActivo"
            });
        }
        private void dataGridViewActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewActivos.Rows[e.RowIndex];

                txtActivoID_.Text = row.Cells["ActivoID"].Value.ToString();
                txtCodigoActivo_.Text = row.Cells["CodigoActivo"].Value.ToString();
                comboBoxNombreActivo_.SelectedValue = row.Cells["NombreActivoID"].Value.ToString();
                comboBoxCategorias_.SelectedValue = row.Cells["CategoriaID"].Value;
                dtpFechaAdquisicion_.Value = (DateTime)row.Cells["FechaAdquisicion"].Value;
                txtValorAdquisicion_.Text = row.Cells["ValorAdquisicion"].Value.ToString();
                comboBoxUbicaciones_.SelectedValue = row.Cells["UbicacionID"].Value;
                comboBoxUnidades_.SelectedValue = row.Cells["UnidadID"].Value;
                txtEstado_.Text = row.Cells["EstadoBaja"].Value.ToString();
                txtDescripcionActivo_.Text = row.Cells["DescripcionActivo"].Value.ToString();
                //comboBoxEstados.SelectedItem = row.Cells["EstadoBaja"].Value.ToString();
            }
        }
        private void btnAgregarActivo_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedValue != null && comboBoxUnidades.SelectedValue != null && comboBoxUbicaciones.SelectedValue != null && comboBoxNombresActivos.SelectedValue != null)
            {
                if (string.IsNullOrWhiteSpace(txtValorAdquisicion.Text) || string.IsNullOrWhiteSpace(txtCodigoActivo.Text))
                {
                    MessageBox.Show("Por favor, llena los campos necesarios: Valor de Adquisición y Código del Activo.");
                    return;
                }

                string codigoActivo = txtCodigoActivo.Text;

                if (CodigoActivoExiste(codigoActivo))
                {
                    MessageBox.Show("El código de activo ya está registrado.");
                    return;
                }

                var activos = new ActivoFijo
                {
                    CodigoActivo = codigoActivo,
                    NombreActivoID = (int)comboBoxNombresActivos.SelectedValue, // Obtener el ID del nombre del activo seleccionado
                    CategoriaID = (int)comboBoxCategorias.SelectedValue, // Obtener el ID de la categoría seleccionada
                    FechaAdquisicion = dtpFechaAdquisicion.Value,
                    ValorAdquisicion = decimal.Parse(txtValorAdquisicion.Text),
                    UbicacionID = (int)comboBoxUbicaciones.SelectedValue, // Obtener el ID de la ubicación seleccionada
                    UnidadID = (int)comboBoxUnidades.SelectedValue, // Obtener el ID de la unidad seleccionada
                    //EstadoBaja = comboBoxEstados.SelectedItem.ToString(), // Usar el valor seleccionado del ComboBox
                    //NumeroDepreciaciones = 0, // Valor inicial
                    DescripcionActivo = txtDescripcionActivo.Text, // Nuevo campo
                    //MotivoBajaActivo = txtMotivoBajaActivo.Text, // Nuevo campo
                    //MotivoEliminarActivo = txtMotivoEliminarActivo.Text // Nuevo campo
                };

                ActivoFijoController.AddAsset(activos);
                LoadActivosFijos();

                MessageBox.Show("Activo agregado con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría, unidad, ubicación y nombre del activo.");
            }
        }
        private void btnUpdateActivos_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias_.SelectedValue != null && comboBoxUnidades_.SelectedValue != null && comboBoxUbicaciones_.SelectedValue != null && comboBoxNombreActivo_.SelectedValue != null)
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionActivo_.Text) || string.IsNullOrWhiteSpace(txtValorAdquisicion_.Text) || string.IsNullOrWhiteSpace(txtCodigoActivo_.Text))
                {
                    MessageBox.Show("Por favor, llena los campos necesarios: Descripción del Activo, Valor de Adquisición y Código del Activo.");
                    return;
                }
                var activos = new ActivoFijo
                {
                    ActivoID = int.Parse(txtActivoID_.Text),
                    CodigoActivo = txtCodigoActivo_.Text,
                    NombreActivoID = (int)comboBoxNombreActivo_.SelectedValue, // Obtener el ID del nombre del activo seleccionado
                    CategoriaID = (int)comboBoxCategorias_.SelectedValue, // Obtener el ID de la categoría seleccionada
                    FechaAdquisicion = dtpFechaAdquisicion_.Value,
                    ValorAdquisicion = decimal.Parse(txtValorAdquisicion_.Text),
                    UbicacionID = (int)comboBoxUbicaciones_.SelectedValue, // Obtener el ID de la ubicación seleccionada
                    UnidadID = (int)comboBoxUnidades_.SelectedValue, // Obtener el ID de la unidad seleccionada
                    DescripcionActivo = txtDescripcionActivo_.Text,
                };

                ActivoFijoController.UpdateAsset(activos);
                LoadActivosFijos();

                MessageBox.Show("Activo actualizado con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona valores para todas las listas desplegables.");
            }
        }
        private void btnBajaActivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtActivoID_.Text) || string.IsNullOrWhiteSpace(txtMotivoBajaActivo.Text))
            {
                MessageBox.Show("Por favor, llena los campos necesarios: ID del Activo y Motivo de Baja.");
                return;
            }

            int activoID = int.Parse(txtActivoID_.Text);
            string motivoBajaActivo = txtMotivoBajaActivo.Text;

            ActivoFijoController.UpdateAssetStatusbaja(activoID, motivoBajaActivo);
            LoadActivosFijos();

            MessageBox.Show("Activo dado de baja con éxito.");
        }
        private void btnDeleteActivo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtActivoID_.Text) || string.IsNullOrWhiteSpace(txtMotivoEliminarActivo.Text))
            {
                MessageBox.Show("Por favor, llena los campos necesarios: ID del Activo y Motivo de Eliminación.");
                return;
            }

            int activoID = int.Parse(txtActivoID_.Text);
            string motivoEliminarActivo = txtMotivoEliminarActivo.Text;

            ActivoFijoController.UpdateAssetToEliminated(activoID, motivoEliminarActivo);
            LoadActivosFijos();

            MessageBox.Show("Activo eliminado con éxito.");
        }
        private void btnDeleteActivo_Click(object sender, EventArgs e)
        {
            int activos = int.Parse(txtActivoID.Text);
            // Mostrar un cuadro de diálogo de confirmación
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                "Confirmar Eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            // Si el usuario hace clic en "Sí", proceder con la eliminación
            if (confirmResult == DialogResult.Yes)
            {
                ActivoFijoController.DeleteAsset(activos);
                LoadActivosFijos();
            }
        }        
        
        private void btnAdministrarNombre_Click(object sender, EventArgs e)
        {
            NombreActivoForm administrarNombreActivo = new NombreActivoForm();
            administrarNombreActivo.ShowDialog(); // Abre el formulario como una ventana modal
            LoadComboBoxes();
        }
        private void btnAdministrarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaForm administrarCategoria = new CategoriaForm();
            administrarCategoria.ShowDialog();
            LoadComboBoxes();// Abre el formulario como una ventana modal
        }
        private void btnAdministrarUbicacion_Click(object sender, EventArgs e)
        {
            UbicacionForm administrarUbicacion = new UbicacionForm();
            administrarUbicacion.ShowDialog();
            LoadComboBoxes();
        }
        private void btnAdministrarUnidad_Click(object sender, EventArgs e)
        {
            UnidadForm administrarUnidad = new UnidadForm();
            administrarUnidad.ShowDialog();
            LoadComboBoxes();
        }

        private void comboBoxNombresActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }
        private void UpdateTextBox()
        {
            if (comboBoxNombresActivos.SelectedItem != null && comboBoxCategorias.SelectedItem != null)
            {
                string firstLetterComboBox1 = comboBoxNombresActivos.Text.Substring(0, 1);
                string firstLetterComboBox2 = comboBoxCategorias.Text.Substring(0, 1);
                int nextId = GetNextActivoID();
                txtCodigoActivo.Text = $"{firstLetterComboBox1}{firstLetterComboBox2}{nextId}";
            }
        }
        private int GetNextActivoID()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dataGridViewActivos.Rows)
            {
                if (row.Cells["ActivoID"].Value != null)
                {
                    int currentId = Convert.ToInt32(row.Cells["ActivoID"].Value);
                    if (currentId > maxId)
                    {
                        maxId = currentId;
                    }
                }
            }
            return maxId + 1;
        }

        private void txtValorAdquisicion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea un control y que sea un dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
