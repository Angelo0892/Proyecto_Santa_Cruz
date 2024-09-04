using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class CategoriaNombreActivo
    {
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

        public int NombreActivoID { get; set; }
        public NombreActivo NombreActivo { get; set; }
    }

}
