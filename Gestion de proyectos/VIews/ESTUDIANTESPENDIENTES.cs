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
    public partial class ESTUDIANTESPENDIENTES : Form
    {
        public ESTUDIANTESPENDIENTES()
        {
            InitializeComponent();
        }

        private void ESTUDIANTESPENDIENTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet13.Postulantes_No_Defensa_Interna1' Puede moverla o quitarla según sea necesario.
            this.postulantes_No_Defensa_Interna1TableAdapter.Fill(this.dEMOPROYDataSet13.Postulantes_No_Defensa_Interna1);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet12.Postulantes_No_Defensa_Interna' Puede moverla o quitarla según sea necesario.
            this.postulantes_No_Defensa_InternaTableAdapter.Fill(this.dEMOPROYDataSet12.Postulantes_No_Defensa_Interna);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet11.V_Estudiantes_Pendientes_DefensaExterna' Puede moverla o quitarla según sea necesario.
            //this.v_Estudiantes_Pendientes_DefensaExternaTableAdapter.Fill(this.dEMOPROYDataSet11.V_Estudiantes_Pendientes_DefensaExterna);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet10.V_Postulantes_Sin_DefensaInterna' Puede moverla o quitarla según sea necesario.
            //this.v_Postulantes_Sin_DefensaInternaTableAdapter.Fill(this.dEMOPROYDataSet10.V_Postulantes_Sin_DefensaInterna);

            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet5.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNA' Puede moverla o quitarla según sea necesario.
            //this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNATableAdapter.Fill(this.dEMOPROYDataSet5.VISTA_ESTUDIANTES_FALTAN_DEFENSA_EXTERNA);
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet4.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNA' Puede moverla o quitarla según sea necesario.
            //this.vISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNATableAdapter.Fill(this.dEMOPROYDataSet4.VISTA_ESTUDIANTES_FALTAN_DEFENSA_INTERNA);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
