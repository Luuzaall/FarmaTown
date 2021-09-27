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
                            "FROM Barrios b " +
                            "INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                            "WHERE borrado = 0;";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
        public List<Barrio> recuperarCParam(string nombre, string localidad)
        {
            string query = "SELECT idBarrio" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                ", borrado" +
                " FROM Barrios" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE nombre LIKE '%" + nombre + "%'";

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
            string query = "SELECT *" +
                " FROM Barrios" +
                " WHERE borrado = 0";
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
            string query = "SELECT *" +
                " FROM Barrios" +
                " WHERE borrado = 0" +
                " AND idBarrio = " + idBarrio;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public Barrio traer(string nombre)
        {
            string query = "SELECT *" +
                " FROM Barrios" +
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
        public int crear(Barrio nuevoBarrio)
        {
            string query = "INSERT INTO Barrios" +
                "(nombre, borrado)" +
                " VALUES" +
                "('" + nuevoBarrio.Nombre + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Barrio oBarrio)
        {
            string query = "UPDATE Barrios" +
                " SET nombre = '" + oBarrio.Nombre + "'" +
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
                Nombre = row["nombre"].ToString(),
                Localidad = new Localidad()
                {
                    Nombre = row["nomLocalidad"].ToString(),
                }
            };
            return oBarrio;
        }
    }
}
