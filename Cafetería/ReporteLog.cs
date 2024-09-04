using Proyecto_almacen.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_almacen
{
    public partial class ReporteLog : Form
    {
        private DbConexion dbConexion;

        private string nombreId;

        private string fecha;
        private string tabla;
        private string idUsuario;

        public ReporteLog()
        {
            InitializeComponent();

            dbConexion = new DbConexion();
            nombreId = "idUsuario";
        }

        private void AccionBuscar(object sender, EventArgs e)
        {
            ObtenerDatosFromulario();
            LlenarDataGrid(this.fecha, this.tabla, this.idUsuario);
        }

        private void ObtenerDatosFromulario()
        {
            this.fecha = textoFecha.Text;
            this.tabla = textoTabla.Text;
            this.idUsuario = textoIdUsuario.Text;
        }

        private void LlenarDataGrid(string fecha, string tabla, string idUsuario)
        {
            DateTime cambiarFecha = DateTime.ParseExact(fecha, "dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            fecha = cambiarFecha.ToString("yyyy-MM-dd");

            DataTable datosTabla = new DataTable();

            string[] columnas = new string[6];

            columnas[0] = "nombreU";
            columnas[1] = "tabla";
            columnas[2] = "fecha";
            columnas[3] = "hora";
            columnas[4] = "operacion";
            columnas[5] = "logO";

            string[] nombreTablas = new string[2];

            nombreTablas[0] = "Logs";
            nombreTablas[1] = "Usuario";

            string[] nombreColumnas = new string[3];

            nombreColumnas[0] = "fecha";
            nombreColumnas[1] = "tabla";
            nombreColumnas[2] = "Usuario.idUsuario";

            string[] columnasBuscar = new string[3];
            columnasBuscar[0] = fecha;
            columnasBuscar[1] = tabla;
            columnasBuscar[2] = idUsuario;

            datosTabla = dbConexion.BuscarDosTablas(this.nombreId, columnas, nombreTablas, nombreColumnas, columnasBuscar);

            reportesLog.DataSource = datosTabla;
        }

        private void ObtenerDatosFila(object sender, DataGridViewCellEventArgs e)
        {
            datoNombreU.Text = reportesLog.SelectedCells[0].Value.ToString();
            datoTabla.Text = reportesLog.SelectedCells[1].Value.ToString();
            datoFecha.Text = reportesLog.SelectedCells[2].Value.ToString();
            datoHora.Text = reportesLog.SelectedCells[3].Value.ToString();
            datoOperacion.Text = reportesLog.SelectedCells[4].Value.ToString();
            datoOperacionLog.Text = reportesLog.SelectedCells[5].Value.ToString();
        }

        private void ReporteLog_Load(object sender, EventArgs e)
        {

        }
    }
}
