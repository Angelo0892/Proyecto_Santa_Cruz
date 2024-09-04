using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOPROY1.VIews
{
    public partial class REPORTEPROYECTOS : Form
    {
        public REPORTEPROYECTOS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void REPORTEPROYECTOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet14.Reporte_Proyectos_Faltan_Actas' Puede moverla o quitarla según sea necesario.
            this.reporte_Proyectos_Faltan_ActasTableAdapter.Fill(this.dEMOPROYDataSet14.Reporte_Proyectos_Faltan_Actas);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet6.VISTA_PROYECTOS_FALTANTES_ACTAS' Puede moverla o quitarla según sea necesario.
            //this.vISTA_PROYECTOS_FALTANTES_ACTASTableAdapter.Fill(this.dEMOPROYDataSet6.VISTA_PROYECTOS_FALTANTES_ACTAS);

        }
    }
}
