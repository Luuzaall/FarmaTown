using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoUsuario
{
    class Barrio
    {
        public int IdBarrio { get; set; }
        public string Nombre { get; set; }
        public Localidad IdLocalidad { get; set; }
        public bool Borrado { get; set; }
    }
}
