using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class EmpleadoDao
    {
        public List<Empleado> recuperarTodos()
        {
            /*
             * Recupera todos los empleados sin 
             * parámetros.
             */
            string query = "SELECT e.idEmpleado" +
                ", e.nroDoc" +
                ", e.nombre as nomEmpleado" +
                ", t.idTipo" +
                ", t.nombre as nomTipoDoc" +
                ", e.idFarmacia " +
                ", f.nombre as nomFarmacia" +
                ", f.calle" + 
                ", b.nombre as nomBarrio" + 
                ", l.nombre as nomLocalidad" +
                " FROM Empleados e" +
                " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" + 
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" + 
                " INNER JOIN TiposDocumento t ON e.tipoDoc = t.idTipo" +
                " WHERE e.borrado = 0" +
                " ORDER BY e.nombre;";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        internal List<Empleado> recuperarConParam(string nomEmpl, string nroDoc
            , int idTipoDoc, string nomFarm)
        {
            /*
             * Recupera los empleados filtrados en base a los
             * parámetros recibidos.
             */
            string query = "SELECT e.idEmpleado" +
                ", e.nroDoc" +
                ", t.idTipo" +
                ", e.nombre as nomEmpleado" +
                ", t.nombre as nomTipoDoc" +
                ", e.idFarmacia " +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                " FROM Empleados e" +
                " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " INNER JOIN TiposDocumento t ON e.tipoDoc = t.idTipo" +
                " WHERE e.borrado = 0";

            if (! string.IsNullOrEmpty(nomEmpl))
            {
                query = query + " AND e.nombre LIKE '%" + nomEmpl + "%'";
            }
            if (! string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND e.nroDoc LIKE '%" + nroDoc + "%'";
            }
            if (! string.IsNullOrEmpty(nomFarm))
            {
                query = query + " AND f.nombre LIKE '%" + nomFarm + "%'";
            }
            if ( idTipoDoc != -1 )
            {
                query = query + " AND e.tipoDoc = " + idTipoDoc;
            }

            query += " ORDER BY e.nombre";
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        internal object obtenerDatosReporte(string nomEmpleado, string idFarmacia)
        {
            /*
             * Recupera todos los empleados
             * en base a los parámetros para el 
             * ReportViewer, pasándole el DataTable.
             */
            string query = "SELECT e.nombre, e.nroDoc" +
                ", td.nombre AS tipoDoc, f.nombre AS farmacia" +
                " FROM Empleados e" +
                " INNER JOIN TiposDocumento td ON e.tipoDoc = td.idTipo" +
                " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                " WHERE e.borrado = 0 ";

            if (! (string.IsNullOrEmpty(nomEmpleado)
                || nomEmpleado == " ") )
                query += " AND e.nombre LIKE '" + nomEmpleado + "%'"; 

            if (idFarmacia != "-1")
                query += " AND e.idFarmacia = " + idFarmacia;

            query += " ORDER BY e.nombre";

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        internal Empleado traerEmpleado(int idEmpleado)
        {
            /*
             * Recupera un empleado particular con su id.
             */
            string query = "SELECT e.idEmpleado" +
                ", td.idTipo" +
                ", e.idFarmacia" +
                ", e.nombre as nomEmpleado" +
                ", e.nroDoc" +
                ", f.nombre as nomFarmacia" +
                ", f.calle" +
                ", b.nombre as nomBarrio" +
                ", l.nombre as nomLocalidad" +
                ", td.nombre as nomTipoDoc" +
                " FROM Empleados e" +
                    " INNER JOIN TiposDocumento td ON e.tipoDoc = td.idTipo" +
                    " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                    " INNER JOIN Barrios b on f.idBarrio = b.idBarrio"+
                    " INNER JOIN Localidades l on l.idLocalidad=b.idLocalidad"+
                " WHERE e.idEmpleado = " + idEmpleado + 
                    " AND e.borrado = 0;";

            DataTable tablaEmpleados = DBHelper.getDBHelper().consultaSQL(query);

            return this.objectMapping(tablaEmpleados.Rows[0]);
        }

        public Empleado buscarEmpleado(string nomEmpl, string nroDoc, int idTipoDoc
            , int idFarm)
        {
            /*
             * Busca un empleado que cumpla con todos 
             * los parámetros que se reciben.
             */
            string query = "SELECT e.idEmpleado" +
                ", e.nombre as nomEmpleado" +
                ", e.nroDoc " +
                ", t.nombre as nomTipoDoc" +
                ", e.idFarmacia" +
                " FROM Empleados e" +
                " INNER JOIN TiposDocumento t ON e.tipoDoc = t.idTipo" +
                " WHERE e.borrado = 0";

            if (!string.IsNullOrEmpty(nomEmpl))
            {
                query = query + " AND e.nombre = '" + nomEmpl + "'";
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND e.nroDoc = '" + nroDoc + "'";
            }
            if (!(idFarm == 0))
            {
                query = query + " AND e.idFarmacia = " + idFarm;
            }
            if (idTipoDoc != -1)
            {
                query = query + " AND e.tipoDoc = " + idTipoDoc;
            }

            DataTable tablaEmpleados = DBHelper.getDBHelper().consultaSQL(query);
            if(tablaEmpleados.Rows.Count == 0)
            {
                // Si no se encontró...
                return null;
            }
            else
            {
                DataRow fila = tablaEmpleados.Rows[0];
                return this.objectMapping(fila);
            }
            
        }

        public int insertarEmpleado(Empleado oEmpleado)
        {
            /*
             * Guadra un empleado con los datos
             * que se reciben por parámetro.
             */
            string query = "INSERT INTO Empleados" +
                "(nroDoc, tipoDoc, idFarmacia, nombre, borrado)" +
                "VALUES " +
                "('" + oEmpleado.NroDoc + "'" + 
                ", " + oEmpleado.TipoDoc.IdTipo + 
                ", " + oEmpleado.Farmacia.IdFarmacia +
                ", '" + oEmpleado.Nombre + "'" +
                 ", 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }

        public int actualizarEmpleado(Empleado oEmpleado)
        {
            /*
             * Cambia los valores a unos nuevos 
             * recibidos por parámetro de un 
             * empleado en particular.
             */
            string query = "UPDATE Empleados" +
                " SET nroDoc = '" + oEmpleado.NroDoc + "'" + 
                ", tipoDoc = " + oEmpleado.TipoDoc.IdTipo +
                ", idFarmacia = " + oEmpleado.Farmacia.IdFarmacia +
                ", nombre = '" + oEmpleado.Nombre + "'"  +
                " WHERE idEmpleado = " + oEmpleado.IdEmpleado;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(Empleado empl)
        {
            /*
             * Aplica el borrado lógico para el
             * empleado indicado.
             */
            string query = "UPDATE Empleados " +
                " SET borrado = 1";

            query = query + " WHERE idEmpleado = " + empl.IdEmpleado;

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }

        private List<Empleado> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<Empleado> lista = new List<Empleado>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private Empleado objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Empleado.
             */

            Empleado oEmpleado = new Empleado
            {
                IdEmpleado = Convert.ToInt32(row["idEmpleado"].ToString()),
                Nombre = row["nomEmpleado"].ToString(),
                NroDoc = row["nroDoc"].ToString(),
                TipoDoc = new TipoDocumento()
                {
                    IdTipo = Convert.ToInt32(row["idTipo"].ToString()),
                    Nombre = row["nomTipoDoc"].ToString(),
                },
                Farmacia = new Farmacia()
                {
                    IdFarmacia = Convert.ToInt32(row["idFarmacia"].ToString()),
                    Nombre = row["nomFarmacia"].ToString(),
                    Calle = row["calle"].ToString(),
                    Barrio = new Barrio()
                    {
                        Nombre = row["nomBarrio"].ToString(),
                        Localidad = new Localidad()
                        {
                            Nombre = row["nomLocalidad"].ToString(),
                        }
                    }
                },
            };

            return oEmpleado;
        }

    }
}
