using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Mantenimiento
    {
        public int MantenimientoID { get; set; }
        public int ActivoID { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }

        // Relación
        public ActivoFijo ActivoFijo { get; set; }
    }
}
