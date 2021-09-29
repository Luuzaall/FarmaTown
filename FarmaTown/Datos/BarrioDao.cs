using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class BarrioDao
    {
        public DataTable recuperarTodos()
        {
            string query = "SELECT b.idBarrio" +
                            ", b.nombre as nomBarrio" +
                            ", l.nombre as nomLocalidad" +
                            //NUEVA
                            ", l.idLocalidad " +
                            " FROM Barrios b" +
                            " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                            " WHERE b.borrado = 0";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
        public List<Barrio> recuperarCParam(string nombre)
        {
            string query = "SELECT idBarrio" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                //NUEVA
                ", l.idLocalidad " +
                ", b.borrado" +
                " FROM Barrios b" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE b.nombre LIKE '%" + nombre + "%'";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> listaBarrio = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaBarrio.Add(this.objectMapping(fila));
            }

            return listaBarrio;

        }

        public List<Barrio> recuperarTodos(bool esCBorrados)
        {
            string query = "SELECT b.idBarrio" +
                            ", b.nombre as nomBarrio" +
                            ", l.nombre as nomLocalidad" +
                            ", l.idLocalidad " +
                            " FROM Barrios b " +
                            " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                            " WHERE b.borrado = 0";

            if (esCBorrados)
                query = query + " OR borrado = 1";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> listaBarrio = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaBarrio.Add(this.objectMapping(fila));
            }

            return listaBarrio;
        }

        public Barrio traer(int idBarrio)
        {
            string query = "SELECT b.idBarrio" +
                           ", b.nombre as nomBarrio" +
                           ", l.nombre as nomLocalidad" +
                           ", l.idLocalidad " +
                           " FROM Barrios b " +
                           " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                           " WHERE b.borrado = 0"+
                           " AND idBarrio = " + idBarrio;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public Barrio traer(string nombre)
        {
            string query = "SELECT b.idBarrio" +
                           ", b.nombre as nomBarrio" +
                           ", l.nombre as nomLocalidad" +
                           ", l.idLocalidad " +
                           " FROM Barrios b " +
                           " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                           " WHERE b.borrado = 0" +
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
        public int crear(Barrio nuevoBarrio)
        {
            string query = "INSERT INTO Barrios" +
                            //nuevo idLocalidad y nombre
                            "(nombre" +
                            ", idLocalidad" +
                            ", nomLocalidad" +
                            ", borrado" +
                            " VALUES" +
                            //Nueva lo de nuevobarrio.Localidad id y nombre
                            "( '" + nuevoBarrio.Nombre + "'" +
                            ", '" + nuevoBarrio.Localidad.IdLocalidad + "'" +
                            ", '" + nuevoBarrio.Localidad.Nombre + "'" +
                            ", 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Barrio oBarrio)
        {
            string query = "UPDATE Barrios" +
                //Nuevo a partir de idLocalidad y nomLocalidad
                " SET nombre = '" + oBarrio.Nombre + "'" + 
                //"',idLocalidad = '" + oBarrio.Localidad.IdLocalidad + 
                //"' ,nomLocalidad = " + oBarrio.Localidad.Nombre +
                " WHERE idBarrio = " + oBarrio.IdBarrio;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

            public int cambiarEstado(Barrio oBarrio, bool seHabilita)
        {
            string query = "UPDATE Barrios" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idBarrio = " + oBarrio.IdBarrio;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        private Barrio objectMapping(DataRow row)
        {
            Barrio oBarrio = new Barrio
            {
                IdBarrio = Convert.ToInt32(row["idBarrio"].ToString()),
                Nombre = row["nomBarrio"].ToString(),
                Localidad = new Localidad()
                {
                    IdLocalidad = Convert.ToInt32(row["idLocalidad"].ToString()),
                    Nombre = row["nomLocalidad"].ToString(),
                }
            };
            return oBarrio;
        }
    }
}
