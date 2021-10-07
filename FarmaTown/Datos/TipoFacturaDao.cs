using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class TipoFacturaDao
    {

        public List<TipoFactura> recuperarTodos()
        {
            string query = "SELECT *" +
                " FROM TiposFactura" +
                " WHERE borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        private List<TipoFactura> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<TipoFactura> lista = new List<TipoFactura>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private TipoFactura objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Tipo Factura.
             */

            TipoFactura oTipoFactura = new TipoFactura
            {
                IdTipofactura = Convert.ToInt32(row["idTipoFactura"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oTipoFactura;
        }
    }
}
