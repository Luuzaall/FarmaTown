using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public TipoMedicamento TipoMedicamento { get; set; }
        public float PrecioLista { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }

    }
}
