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
    public partial class TUTORESYTUTORADOS : Form
    {
        public TUTORESYTUTORADOS()
        {
            InitializeComponent();
        }

        private void TUTORESYTUTORADOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet16.Reporte_Postulantes_Tutores_Gestion' Puede moverla o quitarla según sea necesario.
            //this.reporte_Postulantes_Tutores_GestionTableAdapter.Fill(this.dEMOPROYDataSet16.Reporte_Postulantes_Tutores_Gestion);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet15.Reporte_Postulantes_Tutores' Puede moverla o quitarla según sea necesario.
            this.reporte_Postulantes_TutoresTableAdapter.Fill(this.dEMOPROYDataSet15.Reporte_Postulantes_Tutores);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet7.VISTA_TUTORES_Y_POSTULANTES' Puede moverla o quitarla según sea necesario.
            this.vISTA_TUTORES_Y_POSTULANTESTableAdapter.Fill(this.dEMOPROYDataSet7.VISTA_TUTORES_Y_POSTULANTES);

        }
    }
}
