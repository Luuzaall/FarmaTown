using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class ObraSocialDao
    {
        OSXMedicamentosDao oOSXMed;

        public ObraSocialDao()
        {
            oOSXMed = new OSXMedicamentosDao();
        }

        public List<ObraSocial> recuperarTodos()
        {
            string query = "SELECT *" +
                " FROM ObrasSociales" +
                " WHERE borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<ObraSocial> listaOS = new List<ObraSocial>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaOS.Add(this.objectMapping(fila));
            }

            return listaOS;
        }

        internal object obtenerDatosReporte()
        {
            string query = "SELECT m.nombre as medicamento" +
                ", o.nombre as obraSocial" +
                ", x.descuento as descuento" +
                " FROM OSXMedicamentos x" +
                " INNER JOIN Medicamentos m ON x.idMedicamento = m.idMedicamento" +
                " INNER JOIN ObrasSociales o ON x.idOS = o.idOS" +
                " GROUP BY o.nombre, m.nombre, x.descuento" +
                " ORDER BY x.descuento";

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public List<ObraSocial> recuperarCParam(string nombre)
        {
            string query = "SELECT idOS" +
                ", nombre" +
                ", borrado" +
                " FROM ObrasSociales" +
                " WHERE nombre LIKE '%" + nombre + "%' " +
                " AND borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<ObraSocial> listaOS = new List<ObraSocial>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaOS.Add(this.objectMapping(fila));
            }

            return listaOS;

        }

        public ObraSocial traer(int idOS)
        {
            string query = "SELECT *" +
                " FROM ObrasSociales" + 
                " WHERE idOS = " + idOS;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public ObraSocial traer(string nombre)
        {
            string query = "SELECT *" +
                " FROM ObrasSociales" +
                " WHERE borrado = 0" + 
                " AND nombre = '" + nombre + "'";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            if (tabla.Rows.Count != 0)
            {
                DataRow fila = tabla.Rows[0];
                return this.objectMapping(fila);
            }
            else
                return null;
        }

        public int crear(ObraSocial nuevaOS)
        {
            string query = "INSERT INTO ObrasSociales" +
                "(nombre, borrado)" +
                " VALUES" +
                "('" + nuevaOS.Nombre + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(ObraSocial oOS)
        {
            string query = "UPDATE ObrasSociales" +
                " SET nombre = '" + oOS.Nombre + "'" +
                " WHERE idOS = " + oOS.IdOS;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(ObraSocial oOS, bool seHabilita)
        {
            string query = "UPDATE ObrasSociales" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idOS = " + oOS.IdOS;

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }

        public ObraSocial objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Empleado.
             */

            int idOS = Convert.ToInt32(row["idOS"].ToString());
            ObraSocial oOS = new ObraSocial
            {
                IdOS = idOS,
                Nombre = row["nombre"].ToString(),
                listaDescuentos = oOSXMed.recuperarTodos(idOS),
            };

            return oOS;
        }
    }
}
