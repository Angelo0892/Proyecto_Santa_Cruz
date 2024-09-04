using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class Perfil
    {
        public int Id_Perfil { get; set; }
        public string Titulo { get; set; }
        public string Gestion { get; set; }
        public string Semestre { get; set; }
        public int Codigo_Estudiante { get; set; }

        public Postulante Postulante { get; set; }
    }
}
