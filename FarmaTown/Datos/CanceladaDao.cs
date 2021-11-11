using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class CanceladaDao
    {
        public Estado traer()
        {
            /*
             * No recibe parámetro porque ya 
             * se sabe que estado es por instanciar
             * esta clase
             */
            string query = "SELECT *" +
                " FROM Estados " +
                " WHERE borrado = 0" +
                " AND idEstado = 2"; ;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            if (tabla.Rows.Count != 0)
                return objectMapping(tabla.Rows[0]);
            else
                return null;

        }

        private Activa objectMapping(DataRow row)
        {
            /*
             * Toma los datos del DataRow y
             * lo guarda en una instancia del objeto
             */
            Activa oEstado = new Activa()
            {
                IdEstado = Convert.ToInt32(row["idEstado"].ToString()),
                Nombre = row["nombre"].ToString(),
            };
            return oEstado;
        }
    }
}
