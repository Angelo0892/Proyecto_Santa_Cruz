using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class Tribunal
    {
        public int Id_Tribunal { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Tipo { get; set; }
        public string Institucion { get; set; }
        public int Id_Titulo { get; set; }

        public TituloProfesional TituloProfesional { get; set; }
    }
}
