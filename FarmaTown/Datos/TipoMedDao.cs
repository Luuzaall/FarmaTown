using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class TipoMedDao
    {
        public List<TipoMedicamento> recuperarTodos()
        {
            DataTable tabla = DBHelper.getDBHelper().consultarTabla("TiposMedicamento");
            return listMapping(tabla);
        }

        private List<TipoMedicamento> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<TipoMedicamento> lista = new List<TipoMedicamento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private TipoMedicamento objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Tipo Factura.
             */

            TipoMedicamento oMedioPago = new TipoMedicamento
            {
                IdTipo = Convert.ToInt32(row["idTipo"].ToString()),
                Descripcion = row["descripcion"].ToString(),
            };

            return oMedioPago;
        }
    }
}
