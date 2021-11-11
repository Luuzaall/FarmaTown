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

        public List<TipoDocumento> recuperarTodos()
        {
            /*
             * Recupera todos los tipos de documento
             * sin parámetros.
             */
            DataTable tabla = DBHelper.getDBHelper().consultarTabla("TiposDocumento");
            int cantFilas = tabla.Rows.Count;

            return listMapping(tabla);
        }

        public List<TipoDocumento> recuperarCParam(string nombre, string pClave)
        {
            /*
             * Recupera todos los tipo de documento
             * filtrados con los parámetros recibidos.
             */
            string query = "SELECT idTipo" +
                ", nombre" +
                ", descripcion" +
                ", borrado" +
                " FROM TiposDocumento" +
                " WHERE borrado = 0";

            if ( !(string.IsNullOrEmpty(nombre)
                || nombre == " ") )
                query = query + " AND nombre LIKE '%" + nombre + "%'";
            if (!(string.IsNullOrEmpty(pClave)
                || pClave == " "))
                query = query + " AND descripcion LIKE '%" + pClave + "%'";

            query += " ORDER BY nombre";
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        public TipoDocumento traer(int idTipo)
        {
            /*
             * Recupera un tipo de documento
             * en particular con su ID:
             */
            string query = "SELECT *" +
                " FROM TiposDocumento" +
                " WHERE borrado = 0" +
                " AND idTipo = " + idTipo;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public TipoDocumento traer(string nom)
        {
            /*
             * Recupera un tipo de documento
             * en particular con su nombre:
             */
            string query = "SELECT *" +
                " FROM TiposDocumento" +
                " WHERE borrado = 0" +
                " AND nombre = '" + nom + "'";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            int cantFilas = tabla.Rows.Count;
            if (cantFilas == 0)
                return null;
            else
            {
                DataRow fila = tabla.Rows[0];
                return this.objectMapping(fila);
            }
        }

        public int crear(TipoDocumento oNuevoTipoDoc)
        {
            /*
             * Persite el tipo de documento
             * recibido por parámetro.
             */
            string query = "INSERT INTO TiposDocumento" +
                "(nombre, borrado, descripcion)" +
                " VALUES" +
                "('" + oNuevoTipoDoc.Nombre + "'" + 
                ", 0, '" + oNuevoTipoDoc.Descripcion + "')";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(TipoDocumento oTipoDoc)
        {
            string query = "UPDATE TiposDocumento" +
                " SET nombre = '" + oTipoDoc.Nombre + "'" +
                ", descripcion = '" + oTipoDoc.Descripcion + "'" +
                " WHERE idTipo = " + oTipoDoc.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(bool seHabilita, TipoDocumento oTipoDoc)
        {
            string query = "UPDATE TiposDocumento" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idTipo = " + oTipoDoc.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        private List<TipoDocumento> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de TipoDocumento
             */
            List<TipoDocumento> lista = new List<TipoDocumento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private TipoDocumento objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * TipoDocumento.
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
