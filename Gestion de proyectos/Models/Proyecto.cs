using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class Proyecto
    {
        public int Id_Proyecto { get; set; }
        public string Titulo { get; set; }
        public string TipoTrabajo { get; set; }
        public string Universidad { get; set; }
        public DateTime FechaProyecto { get; set; }
        public bool ACTAMDG1 { get; set; }
        public bool ACTAMDG2 { get; set; }
        public int Calficacion { get; set; }
        public int ID_DocenteMDG2 { get; set; }
        public int ID_Tutor { get; set; }
        public int ID_Postulante { get; set; }

        public Docente DocenteMDG2 { get; set; }
        public Docente Tutor { get; set; }
        public Postulante Postulante { get; set; }
    }
}
