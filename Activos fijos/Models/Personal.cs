using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string NombrePersonal { get; set; }
        public string Apellido { get; set; }
        public int CargoID { get; set; }
        public int UnidadID { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        // Relaciones
        public Cargo Cargo { get; set; }
        public Unidad Unidad { get; set; }
        public ICollection<Asignacion> Asignaciones { get; set; }
        public ICollection<Retorno> Retornos { get; set; }
    }

}
