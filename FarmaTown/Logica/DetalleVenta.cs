using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class DetalleVenta
    {
        public Venta IdVenta { get; set; }
        public Medicamento IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Reintegro { get; set; }
        public ObraSocial IdOS { get; set; }
        public bool Borrado { get; set; }

    }
}
