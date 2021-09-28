using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class TipoMedicamento
    {
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        TipoMedDao oTipoMedDao;

        public TipoMedicamento()
        {
            oTipoMedDao = new TipoMedDao();
        }
        internal object recuperarTodos()
        {
            return oTipoMedDao.recuperarTodos();
        }
    }

}
