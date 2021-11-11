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
            /*
             * Recupera todos los medios de pagos
             * registrados sin parámetros.
             */
            DataTable tabla = DBHelper.getDBHelper().consultarTabla("MediosPago");

            return listMapping(tabla);

        }

        public MedioPago traer(int idMedioPago)
        {
            /*
             * Recupera un medio de pago específico
             * indicado por parámetro.
             */
            string query = "SELECT *" +
                "   FROM MediosPago" +
                "   WHERE borrado = 0" +
                "   AND idMedioPago = " + idMedioPago +
                "   ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return objectMapping(tabla.Rows[0]);
        }

        private List<MedioPago> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de MedioPago
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
             * Tipo MedioPago.
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
