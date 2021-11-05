using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class TipoFactura
    {
        public int IdTipofactura { get; set; }
        public string Nombre { get; set; }

        TipoFacturaDao oTipoFacDao;

        public TipoFactura()
        {
            oTipoFacDao = new TipoFacturaDao();
        }

        public List<TipoFactura> recuperarTodos()
        {
            return oTipoFacDao.recuperarTodos();
        }

        public TipoFactura traer (int idTipoFactura)
        {
            return oTipoFacDao.traer(idTipoFactura);
        }
    }
}
