using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class NombreActivo
    {
        public int NombreActivoID { get; set; }
        public string NombreActivo_ { get; set; }

        // Relaciones
        public ICollection<ActivoFijo> ActivosFijos { get; set; }
        public ICollection<CategoriaNombreActivo> CategoriaNombreActivos { get; set; }
    }
}
