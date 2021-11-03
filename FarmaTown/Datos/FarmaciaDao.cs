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

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Farmacia> listaFarmacia = new List<Farmacia>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaFarmacia.Add(this.objectMapping(fila));
            }

            return listaFarmacia;
        }

        public List<Farmacia> recuperarCParam(string nombre, string calle, string num, string barrio, string localidad)
        {
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
                query = query + " AND f.numero LIKE '" + Convert.ToInt32(num) + "'";
            }

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Farmacia> listaFarmacia = new List<Farmacia>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaFarmacia.Add(this.objectMapping(fila));
            }

            return listaFarmacia;
        }

        public Farmacia traerFarmacia(int id)
        {
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
                " WHERE f.idFarmacia = " + id +
                " AND f.borrado = 0;";

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

        public int crear(Farmacia nuevaFarmacia)
        {
            string query = "INSERT INTO Farmacias" +
                "(nombre, calle, numero,idBarrio, borrado)" +
                " VALUES" +
                "('" + nuevaFarmacia.Nombre + "', '"+ nuevaFarmacia.Calle +"' , "+ nuevaFarmacia.Numero +" , "+ nuevaFarmacia.Barrio.IdBarrio +" , 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(Farmacia farmacia)
        {
            string query = "UPDATE Farmacias" +
            " SET nombre = '" + farmacia.Nombre + "',calle = '" + farmacia.Calle + "' ,numero = " + farmacia.Numero + " , idBarrio = " + farmacia.Barrio.IdBarrio + " " +
            " WHERE idFarmacia = " + farmacia.IdFarmacia;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(Farmacia farmacia, bool seHabilita)
        {
            string query = "UPDATE Farmacias" +
    " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idFarmacia = " + farmacia.IdFarmacia;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }
    }
}
