using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class TipoDocDao
    {
        public DataTable recuperarTodos()
        {
            return DBHelper.getDBHelper().consultarTabla("TiposDocumento");
        }

        public List<TipoDocumento> recuperarCParam(string nombre, string pClave)
        {
            string query = "SELECT idTipo" +
                ", nombre" +
                ", descripcion" +
                ", borrado" +
                " FROM ObrasSociales" +
                " WHERE borrado = 0";

            if ( !(string.IsNullOrEmpty(nombre)
                || nombre == " ") )
                query = query + " AND nombre LIKE '%" + nombre + "%'";
            if (!(string.IsNullOrEmpty(pClave)
                || pClave == " "))
                query = query + " AND descripcion LIKE '%" + pClave + "%'";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<TipoDocumento> listaTD = new List<TipoDocumento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaTD.Add(this.objectMapping(fila));
            }

            return listaTD;

        }

        public TipoDocumento traer(int idTipo)
        {
            string query = "SELECT *" +
                " FROM TiposDocumentos" +
                " WHERE borrado = 0" +
                " AND idTipo = " + idTipo;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        private TipoDocumento objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Empleado.
             */

            TipoDocumento oOS = new TipoDocumento
            {
                IdTipo = Convert.ToInt32(row["idTipo"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
            };

            return oOS;
        }
    }
}
