using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class FarmaciaDao
    {

        public DataTable recuperarTodos()
        {
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
    }
}
