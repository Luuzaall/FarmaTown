using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class FarmaciaDao
    {

        public List<Farmacia> recuperarTodos()
        {
            /*
             * Recupera las farmacias sin parámetros.
             */
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", b.idBarrio" +
                ", l.nombre as nomLocalidad" +
                ", l.idLocalidad" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE f.borrado = 0" +
                " ORDER BY f.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        public List<Farmacia> recuperarCParam(string nombre, string calle
            , string num, string barrio, string localidad)
        {
            /*
             * Recupera todas las farmacias con un filtro
             * especificado por parámetro.
             */
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", b.idBarrio" +
                ", l.nombre as nomLocalidad" +
                ", l.idLocalidad" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE f.borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query + " AND f.nombre LIKE '%" + nombre + "%'";
            }
            if (!string.IsNullOrEmpty(calle))
            {
                query = query + " AND f.calle LIKE '%" + calle + "%'";
            }
            if (!string.IsNullOrEmpty(barrio))
            {
                query = query + " AND b.nombre LIKE '%" + barrio + "%'";
            }
            if (!string.IsNullOrEmpty(localidad))
            {
                query = query + " AND l.nombre LIKE '%" + localidad + "%'";
            }
            if (!string.IsNullOrEmpty(num))
            {
                query = query + " AND f.numero LIKE '%" + num + "%'";
            }

            query += " ORDER BY f.nombre";
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        public Farmacia traerFarmacia(int id)
        {
            /*
             * Recupera una farmacia particualr
             * indicada por su id.
             */
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", b.idBarrio" +
                ", l.nombre as nomLocalidad" +
                ", l.idLocalidad" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE f.idFarmacia = " + id;

            DataTable tablaFarmacias = DBHelper.getDBHelper().consultaSQL(query);

            return this.objectMapping(tablaFarmacias.Rows[0]);
        }

        public int crear(Farmacia nuevaFarmacia)
        {
            /*
             * Persiste una farmacia nueva con los datos
             * recibidos por parámetro.
             */
            string query = "INSERT INTO Farmacias" +
                "(nombre, calle, numero,idBarrio, borrado)" +
                " VALUES" +
                "('" + nuevaFarmacia.Nombre + "', '"+ nuevaFarmacia.Calle +"' , "+ nuevaFarmacia.Numero +" , "+ nuevaFarmacia.Barrio.IdBarrio +" , 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Farmacia farmacia)
        {
            /*
             * Cambia los datos de la farmacia a 
             * unos nuevos recibidos por parámetro.
             */
            string query = "UPDATE Farmacias" +
            " SET nombre = '" + farmacia.Nombre + "',calle = '" + farmacia.Calle + "' ,numero = " + farmacia.Numero + " , idBarrio = " + farmacia.Barrio.IdBarrio + " " +
            " WHERE idFarmacia = " + farmacia.IdFarmacia;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(Farmacia farmacia)
        {
            /*
             * Aplica el borrado lógico 
             * para la farmacia indicada.
             */
            string query = "UPDATE Farmacias" +
            " SET borrado = 1";

            query = query + " WHERE idFarmacia = " + farmacia.IdFarmacia;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        private List<Farmacia> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Farmacia
             */
            List<Farmacia> lista = new List<Farmacia>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }
        private Farmacia objectMapping(DataRow row)
        {
            /*
             * Guarda los datos de la fila recibida
             * en una instancia de la clase Farmacia.
             */
            Farmacia oFarmacia = new Farmacia
            {
                IdFarmacia = Convert.ToInt32(row["idFarmacia"].ToString()),
                Nombre = row["nomFarmacia"].ToString(),
                Calle = row["calle"].ToString(),
                Numero = Convert.ToInt32(row["numero"].ToString()),
                Barrio = new Barrio
                {
                    IdBarrio = Convert.ToInt32(row["idBarrio"].ToString()),
                    Nombre = row["nomBarrio"].ToString(),
                    Localidad = new Localidad
                    {
                        IdLocalidad = Convert.ToInt32(row["idLocalidad"].ToString()),
                        Nombre = row["nomLocalidad"].ToString()
                    }
                }
            };

            return oFarmacia;
        }
    }
}
