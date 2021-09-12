using FarmaTown.Lógica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Lógica

{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int NroDoc { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public Farmacia IdFarmacia { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }
        public Rol IdRol { get; set; }

    }
}
