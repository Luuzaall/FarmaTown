using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown
{
    class Venta
    {
        public int IdVenta { get; set; }
        public Farmacia IdFarmacia { get; set; }
        public int NroFactura { get; set; }
        public Cliente IdCliente { get; set; }
        public int FechaFactura { get; set; }
        public Empleado IdEmpleado { get; set; }
        public bool Borrado { get; set; }

    }
}
