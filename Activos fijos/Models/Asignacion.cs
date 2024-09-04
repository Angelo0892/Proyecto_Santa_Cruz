using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Asignacion
    {
        public int AsignacionID { get; set; }
        public int ActivoID { get; set; }
        public int PersonalID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Observaciones { get; set; }

        // Relaciones
        public ActivoFijo ActivoFijo { get; set; }
        public Personal Personal { get; set; }
    }

}
