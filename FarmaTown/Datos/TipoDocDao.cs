using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class TipoDocDao
    {
        public DataTable recuperarTodos()
        {
            return DBHelper.getDBHelper().consultarTabla("TiposDocumento");
        }
    }
}
