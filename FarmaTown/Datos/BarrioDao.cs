using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class BarrioDao
    {

        public DataTable recuperarTodos()
        {
            string query = "SELECT b.idBarrio" +
                            ", b.nombre as nomBarrio" +
                            ", l.nombre as nomLocalidad" +
                            "FROM Barrios b " +
                            "INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                            "WHERE borrado = 0;";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
    }
}
