using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    public class DefensaInterna
    {
        public int Id_DefensaInterna { get; set; }
        public DateTime FechaDefensaInterna { get; set; }
        public bool Observaciones { get; set; }
        public bool Aprobada { get; set; }
        public int Calficacion { get; set; }
        public int Id_Tribunal1 { get; set; }
        public int Id_Tribunal2 { get; set; }
        public int Id_Proyecto { get; set; }

        public Tribunal Tribunal1 { get; set; }
        public Tribunal Tribunal2 { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
