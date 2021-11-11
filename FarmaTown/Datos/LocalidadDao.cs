using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class LocalidadDao
    {

        public List<Localidad> recuperarTodos()
        {
            /*
             * Recupera todas las localidades
             * y las devuelve en la lista.
             */
            string query = "SELECT *" +
                " FROM Localidades" +
                " WHERE borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return this.listMapping(tabla);
        }
        public List<Localidad> recuperarCParam(string nombre)
        {
            /*
             * Recupera todas las localidades en 
             * base al parámetro recibido.
             */
            string query = "SELECT idLocalidad" +
                ", nombre" +
                ", borrado" +
                " FROM Localidades" +
                " WHERE nombre LIKE '%" + nombre + "%'" +
                " AND borrado = 0" +
                " ORDER BY nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            
            return this.listMapping(tabla);
        }

        public List<Localidad> recuperarSoloUsadosClientes()
        {
            /*
             * Recupera sólo las localidades que estén
             * utilizando al menos un cliente.
             */
            string query = "SELECT l.idLocalidad" +
                " FROM Clientes c" +
                " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " GROUP BY l.idLocalidad" +
                " , l.nombre" +
                " ORDER BY l.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            List<Localidad> listaLoc = new List<Localidad>();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                int id = Convert.ToInt32(tabla.Rows[fila]["idLocalidad"].ToString());
                listaLoc.Add(traer(id));
            }

            return listaLoc;
        }

        public Localidad traer(int idLocalidad)
        {
            /*
             * Recupera la localidad cuyo ID
             * se recibe por parámetro.
             */
            string query = "SELECT *" +
                " FROM Localidades" +
                " WHERE borrado = 0" +
                " AND idLocalidad = " + idLocalidad;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public Localidad traer(string nombre)
        {
            /*
             * Recupera la localidad cuyo
             * nombre se recibe por parámetro.
             */
            string query = "SELECT *" +
                " FROM Localidades" +
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

        public int crear(Localidad nuevaLocalidad)
        {
            /*
             * Persiste una localidad recibida por 
             * parámetro.
             */
            string query = "INSERT INTO Localidades" +
                "(nombre, borrado)" +
                " VALUES" +
                "('" + nuevaLocalidad.Nombre + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Localidad oLocalidad)
        {
            /*
             * Cambia los datos de la localidad a los
             * que recibe por parámetro.
             */
            string query = "UPDATE Localidades" +
                " SET nombre = '" + oLocalidad.Nombre + "'" +
                " WHERE idLocalidad = " + oLocalidad.IdLocalidad;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(Localidad oLocalidad)
        {
            /*
             * Aplica el borrado lógico sobre
             * la localidad recibida.
             */
            string query = "UPDATE Localidades" +
                " SET borrado = 1";

            query = query + " WHERE idLocalidad = " + oLocalidad.IdLocalidad;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }


        private List<Localidad> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Localidad
             */
            List<Localidad> lista = new List<Localidad>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private Localidad objectMapping(DataRow row)
        {
            /*
             * Guarda los datos de la fila recibida
             * en una instancia de la clase
             * de Localidad.
             */
            Localidad oLocalidad = new Localidad
            {
                IdLocalidad = Convert.ToInt32(row["idLocalidad"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oLocalidad;
        }
    }
}