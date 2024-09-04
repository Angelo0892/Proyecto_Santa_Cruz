using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class DefensaPerfil
    {
        public DateTime FechaDefensa { get; set; }
        public bool EstadoPerfil { get; set; }
        public int Calficacion { get; set; }
        public int ID_DocenteMDG1 { get; set; }
        public int ID_Tribunal1 { get; set; }
        public int ID_Postulante { get; set; }
        public int ID_Perfil { get; set; }

        public Docente DocenteMDG1 { get; set; }
        public Tribunal Tribunal1 { get; set; }
        public Postulante Postulante { get; set; }
        public Perfil Perfil { get; set; }
    }
}
