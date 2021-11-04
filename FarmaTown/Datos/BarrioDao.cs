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
        public List<Barrio> recuperarCParam(string nombre)
        {
            string query = "SELECT idBarrio" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                ", l.idLocalidad " +
                ", b.borrado" +
                " FROM Barrios b" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE b.nombre LIKE '%" + nombre + "%'" +
                " AND b.borrado = 0 ";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> listaBarrio = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            return this.listMapping(tabla);

        }

        //AGREGADA PARA PODER HACER LA CONSULTA EN ABM CLIENTES
        public List<Barrio> recuperarCParamOtro(string nombre, string localidad)
        {
            string query = "SELECT idBarrio" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                ", l.idLocalidad " +
                " FROM Barrios b" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE b.nombre LIKE '%" + nombre + "%'" +
                " AND l.nombre LIKE '%" + localidad + "%'" +
                " AND b.borrado = 0 ";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> listaBarrio = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            return this.listMapping(tabla);

        }

        public List<Barrio> recuperarTodos()
        {
            string query = "SELECT b.idBarrio" +
                            ", b.nombre as nomBarrio" +
                            ", l.nombre as nomLocalidad" +
                            ", l.idLocalidad " +
                            " FROM Barrios b " +
                            " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                            " WHERE b.borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> listaBarrio = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            return this.listMapping(tabla);
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
                           " AND b.nombre = '" + nombre + "'";

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
                            "(nombre" +
                            ", idLocalidad" +
                            ", borrado)" +
                            " VALUES" +
                            "( '" + nuevoBarrio.Nombre + "'" +
                            ", '" + nuevoBarrio.Localidad.IdLocalidad + "'" +
                            ", 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Barrio oBarrio)
        {
            string query = "UPDATE Barrios" +
                " SET nombre = '" + oBarrio.Nombre + "'" + 
                ",idLocalidad = " + oBarrio.Localidad.IdLocalidad + 
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

        public List<Barrio> recuperarSoloUsadosClientes()
        {
            string query = "SELECT b.nombre" +
                " FROM Clientes c" +
                " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                " GROUP BY b.idBarrio" +
                "	, b.nombre";

            DataTable tablaNoms = DBHelper.getDBHelper().consultaSQL(query);

            List<Barrio> barrios = new List<Barrio>();

            for (int fila = 0; fila < tablaNoms.Rows.Count; fila++)
            {
                string nom = tablaNoms.Rows[fila]["nombre"].ToString();
                barrios.Add(this.traer(nom));
            }

            return barrios;
        }

        private List<Barrio> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<Barrio> lista = new List<Barrio>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
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
