using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string NombreCategoria { get; set; }
        public int VidaUtil { get; set; }
        public decimal ValorResidual { get; set; }

        // Relaciones
        public ICollection<ActivoFijo> ActivosFijos { get; set; }
        public ICollection<CategoriaNombreActivo> CategoriaNombreActivos { get; set; }
    }

}
