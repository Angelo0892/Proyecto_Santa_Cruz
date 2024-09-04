using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Unidad
    {
        public int UnidadID { get; set; }
        public string NombreUnidad { get; set; }

        // Relaciones
        public ICollection<ActivoFijo> ActivosFijos { get; set; }
        public ICollection<Personal> Personal { get; set; }
    }
}
