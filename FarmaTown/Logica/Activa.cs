using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    class Activa : Estado
    {
        public override void cancelada(Venta oVenta)
        {
            Cancelada nuevoEstado = new Cancelada();
            oVenta.setEstado(nuevoEstado);
        }
    }
}
