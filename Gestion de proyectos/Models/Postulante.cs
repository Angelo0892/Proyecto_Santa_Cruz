using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class Postulante
    {
        public int PostulanteId { get; set; }
        public int Codigo_Estudiante { get; set; }
        public int CI { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public int Celular { get; set; }
        public int Id_Carrera { get; set; }

        public Carrera Carrera { get; set; }
    }
}
