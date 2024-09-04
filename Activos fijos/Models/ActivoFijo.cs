using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class ActivoFijo
    {
        public int ActivoID { get; set; }
        public string CodigoActivo { get; set; }
        public int NombreActivoID { get; set; } // Cambiado de string a int
        public int CategoriaID { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public decimal ValorAdquisicion { get; set; }
        public int UbicacionID { get; set; }
        public int UnidadID { get; set; }
        public string DescripcionActivo { get; set; }
        public string MotivoBajaActivo { get; set; }
        public string MotivoEliminarActivo { get; set; }
        public string EstadoBaja { get; set; } = "Inactivo"; // Valor por defecto cambiado a 'Inactivo'
        public int NumeroDepreciaciones { get; set; } = 0; // Nuevo atributo

        // Relaciones
        public Categoria Categoria { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public Unidad Unidad { get; set; }
        public NombreActivo NombreActivo { get; set; } // Nueva relación
    }
}
