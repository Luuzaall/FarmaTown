using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class MedioPagoDao
    {
        public List<MedioPago> recuperarTodos()
        {
            DataTable tabla = DBHelper.getDBHelper().consultarTabla("MediosPago");

            return listMapping(tabla);

        }

        private List<MedioPago> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<MedioPago> lista = new List<MedioPago>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private MedioPago objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Tipo Factura.
             */

            MedioPago oMedioPago = new MedioPago
            {
                idMedioPago = Convert.ToInt32(row["idMedioPago"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oMedioPago;
        }

    }
}
