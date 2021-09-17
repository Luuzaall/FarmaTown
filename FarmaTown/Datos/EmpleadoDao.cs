using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class EmpleadoDao
    {
        public DataTable recuperarTodos()
        {
            string query = "SELECT e.idEmpleado" +
                ", e.nroDoc" +
                ", t.nombre as nomTipoDoc" +
                ", f.nombre as nomFarmacia" +
                ", e.nombre as nomEmpleado" +
                " FROM Empleados e" +
                " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                " INNER JOIN TiposDocumento t ON e.tipoDoc = t.idTipo" +
                " WHERE e.borrado = 0;";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
    }
}
