using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class ObraSocial
    {
        public int IdOS { get; set; }
        public string NombreOS { get; set; }
        public bool Borrado { get; set; }

        ObraSocialDao oObraSocialDao;

        public ObraSocial()
        {
            oObraSocialDao = new ObraSocialDao();
        }


    }
}
