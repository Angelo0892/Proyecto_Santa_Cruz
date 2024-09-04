using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Ubicacion
    {
        public int UbicacionID { get; set; }
        public string NombreUbicacion { get; set; }

        // Relaciones
        public ICollection<ActivoFijo> ActivosFijos { get; set; }
    }

}
