﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVOS_FIJOS.Models
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public string NombreCargo { get; set; }

        // Relaciones
        public ICollection<Personal> Personal { get; set; }
    }

}
