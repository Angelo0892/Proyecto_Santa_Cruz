using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Depreciacion
    {
        public int DepreciacionID { get; set; }
        public int ActivoID { get; set; }
        public DateTime FechaDesgaste { get; set; }
        public decimal ValorDepreciacionAnual { get; set; }
        public decimal ValorDepreciacionCalculado { get; set; }
        public string Descripcion { get; set; }

        // Relaciones
        public ActivoFijo ActivoFijo { get; set; }
    }

}
