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
            /*
             * La venta le delega la responsabilidad de cancelarla
             * y a sus detalles.
             */
            Cancelada nuevoEstado = new Cancelada();
            oVenta.setEstado(nuevoEstado);
        }
    }
}
