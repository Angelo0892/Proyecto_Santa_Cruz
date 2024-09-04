using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class TituloProfesional
    {
            public int Id_Titulo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Institucion { get; set; }
            public DateTime FechaObtencion { get; set; }
            public string NivelAcademico { get; set; }
            public string Especializacion { get; set; }
            public string RegistroProfesional { get; set; }
            public DateTime? FechaRegistro { get; set; }
       

    }
}
