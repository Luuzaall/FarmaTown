using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown
{
    class Farmacia
    {
        public int IdFarmacia { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Barrio IdBarrio { get; set; }
        public bool Borrado { get; set; }

    }
}
