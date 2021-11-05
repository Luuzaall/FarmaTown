using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class DetalleVentaDao
    {
        MedicamentoDao oMedicamentoDao;

        public DetalleVentaDao()
        {
            oMedicamentoDao = new MedicamentoDao();
        }
        public List<DetalleVenta> recuperarTodos(int idVenta)
        {
            string query = "SELECT d.idVenta" +
                " , m.nombre as nomMedicamento" +
                " , m.idMedicamento" +
                " , d.cantidad" +
                " , d.precio" +
                " FROM DetalleVentas d" +
                " INNER JOIN Medicamentos m ON d.idMedicamento = m.idMedicamento" +
                " WHERE d.idVenta = 18" +
                " AND d.borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);


        }

        private List<DetalleVenta> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<DetalleVenta> lista = new List<DetalleVenta>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private DetalleVenta objectMapping(DataRow row)
        {
            string nomMedicamento = row["nomMedicamento"].ToString();
            DetalleVenta oDetalleVenta = new DetalleVenta
            {
                Medicamento = this.oMedicamentoDao.obtenerMedicamentoPorNom(nomMedicamento),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                PrecioUnitario = Convert.ToDouble(row["precio"].ToString())
                
            };
            return oDetalleVenta;
        }
    }
}
