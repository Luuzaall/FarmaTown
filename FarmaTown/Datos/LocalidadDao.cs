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
        public List<Localidad> recuperarCParam(string nombre)
        {
            string query = "SELECT idLocalidad" +
                ", nombre" +
                ", borrado" +
                " FROM Localidades" +
                " WHERE nombre LIKE '%" + nombre + "%'" +
                " AND borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Localidad> listaLoc = new List<Localidad>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaLoc.Add(this.objectMapping(fila));
            }

            return listaLoc;

        }

        public List<Localidad> recuperarTodos(bool esCBorrados)
        {
            string query = "SELECT *" +
                " FROM Localidades" +
                " WHERE borrado = 0";
            if (esCBorrados)
                query = query + " OR borrado = 1";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Localidad> listaLoc = new List<Localidad>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaLoc.Add(this.objectMapping(fila));
            }

            return listaLoc;
        }

        public Localidad traer(int idLocalidad)
        {
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
            string query = "INSERT INTO Localidades" +
                "(nombre, borrado)" +
                " VALUES" +
                "('" + nuevaLocalidad.Nombre + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Localidad oLocalidad)
        {
            string query = "UPDATE Localidades" +
                " SET nombre = '" + oLocalidad.Nombre + "'" +
                " WHERE idLocalidad = " + oLocalidad.IdLocalidad;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(Localidad oLocalidad, bool seHabilita)
        {
            string query = "UPDATE Localidades" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idLocalidad = " + oLocalidad.IdLocalidad;

            return DBHelper.getDBHelper().ejecutarSQL(query);


        }

        private Localidad objectMapping(DataRow row)
        {
            Localidad oLocalidad = new Localidad
            {
                IdLocalidad = Convert.ToInt32(row["idLocalidad"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oLocalidad;
        }
    }
}