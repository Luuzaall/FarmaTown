﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    class TipoFactura
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
    }
}
