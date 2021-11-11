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
            // Instancia la clase que necesita para 
            // el objectMapping.
            oOSXMed = new OSXMedicamentosDao();
        }

        public List<ObraSocial> recuperarTodos()
        {
            /*
             * Recupera todas las obras sociales sin 
             * parámetros.
             */
            string query = "SELECT *" +
                " FROM ObrasSociales" +
                " WHERE borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        internal object obtenerDatosReporte(string nomObraSocial)
        {
            /*
             * Recupera todas las obras sociales
             * sólo con el parámetro de su nombre
             * y devuelve una DataTable
             * para el ReportViewer.
             */
            string query = "SELECT m.nombre as medicamento" +
                ", o.nombre as obraSocial" +
                ", x.descuento as descuento" +
                " FROM OSXMedicamentos x" +
                " INNER JOIN Medicamentos m ON x.idMedicamento = m.idMedicamento" +
                " INNER JOIN ObrasSociales o ON x.idOS = o.idOS";

            if (nomObraSocial != "") {
                query += " WHERE o.nombre LIKE '" + nomObraSocial + "'";
            }

            query += " GROUP BY o.nombre, m.nombre, x.descuento" +
                " ORDER BY x.descuento";

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public List<ObraSocial> recuperarCParam(string nombre)
        {
            /*
             * Recupera una lista de obras sociales
             * con el parámetro de su nombre.
             */
            string query = "SELECT idOS" +
                ", nombre" +
                ", borrado" +
                " FROM ObrasSociales" +
                " WHERE nombre LIKE '%" + nombre + "%' " +
                " AND borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
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
            /*
             * Recupera una única obra social
             * con su nombre.
             */
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
            /*
             * Persiste la obra social recibida por
             * parámetro.
             */
            string query = "INSERT INTO ObrasSociales" +
                "(nombre, borrado)" +
                " VALUES" +
                "('" + nuevaOS.Nombre + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(ObraSocial oOS)
        {
            /*
             * Cambia los valores de la obra social
             * a unos nuevos, recibido por parámetro.
             */
            string query = "UPDATE ObrasSociales" +
                " SET nombre = '" + oOS.Nombre + "'" +
                " WHERE idOS = " + oOS.IdOS;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(ObraSocial oOS)
        {
            /*
             * Aplica el borrado lógico sobre
             * la obra social recibida por 
             * parámetro.
             */
            string query = "UPDATE ObrasSociales" +
                " SET borrado = 1";

            query = query + " WHERE idOS = " + oOS.IdOS;

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }
        private List<ObraSocial> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de ObraSocial
             */
            List<ObraSocial> lista = new List<ObraSocial>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }


        public ObraSocial objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * ObraSocial.
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
