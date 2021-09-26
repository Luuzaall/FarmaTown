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

        public DataTable recuperarTodos()
        {
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad";

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public DataTable recuperarCParam(string nombre, string calle, string barrio, string localidad)
        {
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
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

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public Farmacia traerFarmacia(int id)
        {
            string query = "SELECT f.idFarmacia" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", f.numero" +
                ", b.id as idBarrio" +
                " FROM Farmacias f" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                "WHERE f.idFarmacia = " + id +
                "AND Borrado = 0;";

            DataTable tablaFarmacias = DBHelper.getDBHelper().consultaSQL(query);

            return this.objectMapping(tablaFarmacias.Rows[0]);
        }

        private Farmacia objectMapping(DataRow row)
        {
            Farmacia oFarmacia = new Farmacia
            {
                IdFarmacia = Convert.ToInt32(row["idFarmacia"].ToString()),
                Nombre = row["nomFarmacia"].ToString(),
                Calle = row["calle"].ToString(),
                Numero = Convert.ToInt32(row["numero"].ToString()),
                Barrio = new Barrio
                {
                    IdBarrio = Convert.ToInt32(row["idBarrio"].ToString())
                }
            };

            return oFarmacia;
        }
    }
}
