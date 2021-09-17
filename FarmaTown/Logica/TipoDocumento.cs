using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class TipoDocumento
    {
        TipoDocDao oTipoDocDao;
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        public TipoDocumento()
        {
            oTipoDocDao = new TipoDocDao();
        }

        public DataTable recuperarTodos()
        {
            return oTipoDocDao.recuperarTodos();
        }

    }
}
