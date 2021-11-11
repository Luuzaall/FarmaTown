using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class ClienteDao
    {
        public List<Cliente> recuperarTodos()
        {
            /*
             * Recupera todos los clientes sin parámetros
             *  y devuelve como lista el resultado.
             */
            string query = "SELECT c.idCliente" +
                            ", c.nroDoc" +
                            ", c.tipoDoc" +
                            ", c.apellido " +
                            ", c.nombre as nomCliente" +
                            ", c.calle " +
                            ", c.nroCalle " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE c.borrado = 0" +
                            " ORDER BY c.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }
        public List<Cliente> recuperarConParam(string nombre, string apellido
            , string nroDoc, int idTipoDoc)
        {
            /*
             * Recupera los clientes filtrados por
             * los parámetros indicados.
             */
            string query = "SELECT c.idCliente" +
                            ", c.nroDoc" +
                            ", c.tipoDoc" +
                            ", c.apellido " +
                            ", c.nombre as nomCliente" +
                            ", c.calle " +
                            ", c.nroCalle " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE c.borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query + " AND c.nombre LIKE '%" + nombre + "%'";
            }
            if (idTipoDoc != -1)
            {
                query = query + " AND c.tipoDoc = " + idTipoDoc;
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND c.nroDoc LIKE '%" + nroDoc + "%'";
            }
            if (!string.IsNullOrEmpty(apellido))
            {
                query = query + " AND c.apellido LIKE '%" + apellido + "%'";
            }                   

            query += " ORDER BY c.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return this.listMapping(tabla);
        }

        public Object obtenerDatosReporte(string idBarrio, string idLocalidad)
        {
            /*
             * Obtiene los filtros y devuelve los clientes 
             * como DataTable para que lo reciba el 
             * ReportViewer.
             */
            string query = "SELECT c.nombre" +
                " , c.apellido" +
                " , t.nombre as tipoDocumento" +
                " , c.nroDoc as nroDocumento" +
                " , b.nombre as barrio" +
                " , l.nombre as localidad" +
                " FROM Clientes c " +
                " INNER JOIN TiposDocumento t ON c.tipoDoc = t.idTipo" +
                " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " WHERE c.borrado = 0";

            if (idBarrio != "-1")
                query += " AND c.idBarrio = " + idBarrio;
            if (idLocalidad != "-1")
                query += " AND b.idLocalidad = " + idLocalidad;

            query += " ORDER BY c.nombre";

            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public Cliente traer(int idCliente)
        {
            /*
             * Recupera el cliente en base a su número
             * identificatorio.
             */
            string query = "SELECT c.idCliente" +
                            ", c.nroDoc" +
                            ", c.tipoDoc" +
                            ", c.apellido " +
                            ", c.nombre as nomCliente" +
                            ", c.calle " +
                            ", c.nroCalle " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE c.borrado = 0" +
                            " AND c.idCliente =" + idCliente;
            DataRow row = ( DBHelper.getDBHelper().consultaSQL(query) ).Rows[0];
            return objectMapping(row);
        }

        public int insertar(Cliente oCliente) 
        {
            /*
             * Guarda los datos de un NUEVO cliente
             * traidos por parámetro.
             */
            string query = "INSERT INTO Clientes" +
                "(nroDoc, tipoDoc, apellido, nombre, calle, nroCalle" +
                ", idBarrio, borrado)" +
                "VALUES " +
                "('"  + oCliente.NroDoc + "'" +
                ", "  + oCliente.TipoDoc.IdTipo +
                ", '" + oCliente.Apellido + "'" +
                ", '" + oCliente.Nombre + "'" +
                ", '" + oCliente.Calle + "'" +
                ", "  + oCliente.NroCalle +
                ", "  + oCliente.Barrio.IdBarrio +
                 ", 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }

        public int actualizar(Cliente oCliente)
        {
            /*
             * Cambia los valores ya existentes del cliente
             * a los nuevos recibidos por parámetro.
             */
            string query = "UPDATE Clientes" +
                   " SET nroDoc = '" + oCliente.NroDoc + "'" +
                    ", tipoDoc = " + oCliente.TipoDoc.IdTipo +
                    ", apellido = '" + oCliente.Apellido + "'" +
                    ", nombre = '" + oCliente.Nombre + "'" +
                    ", calle = '" + oCliente.Calle + "'" +
                    ", nroCalle = " + oCliente.NroCalle +
                    ", idBarrio = " + oCliente.Barrio.IdBarrio +
                    " WHERE idCliente = " + oCliente.IdCliente;

            return DBHelper.getDBHelper().ejecutarSQL(query);

        }

        public int cambiarEstado(Cliente oCliente)
        {
            /*
             * Deshabilita el cliente indicado
             * por parámetro.
             */
            string query = "UPDATE Clientes " +
               " SET borrado = 1" +
               " WHERE idCliente= " + oCliente.IdCliente;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public Cliente buscarCliente(string nomCli
            , string nroDoc, int idTipoDoc, int idBarrio)
        {
            /*
             * Busca un cliente particular con todos los parámetros
             * indicador.
             */
            string query = "SELECT c.idCliente" +
                            ", c.nroDoc" +
                            ", c.tipoDoc" +
                            ", c.apellido " +
                            ", c.nombre as nomCliente" +
                            ", c.calle " +
                            ", c.nroCalle " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE c.borrado = 0";

            if (!string.IsNullOrEmpty(nomCli))
            {
                query = query + " AND c.nombre = '" + nomCli + "'";
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND c.nroDoc = '" + nroDoc + "'";
            }
            if (!(idBarrio == 0))
            {
                query = query + " AND c.idBarrio = " + idBarrio;
            }
            if (idTipoDoc != -1)
            {
                query = query + " AND c.tipoDoc = " + idTipoDoc;
            }

            DataTable tablaClientes = DBHelper.getDBHelper().consultaSQL(query);
            if (tablaClientes.Rows.Count == 0)
            {
                // Si no se encontró...
                return null;
            }
            else
            {
                DataRow fila = tablaClientes.Rows[0];
                return this.objectMapping(fila);
            }

        }
        private List<Cliente> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Cliente
             */
            List<Cliente> lista = new List<Cliente>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }
        private Cliente objectMapping(DataRow row)
        {
            /*
             * Recibe una fila del DataTable
             * y utiliza todos sus datos para guardarlos
             * en una instancia de cliente.
             */
            Cliente oCliente = new Cliente
            {
                IdCliente = Convert.ToInt32(row["idCliente"].ToString()),
                Nombre = row["nomCliente"].ToString(),
                Apellido = row["apellido"].ToString(),
                TipoDoc = new TipoDocumento()
                {
                    IdTipo = Convert.ToInt32(row["tipoDoc"].ToString()),
                    Nombre = row["nomTipoDoc"].ToString()
                },
                NroDoc = row["nroDoc"].ToString(),
                Calle = row["calle"].ToString(),
                NroCalle = Convert.ToInt32(row["nroCalle"].ToString()),
                Barrio = new Barrio()
                {
                    IdBarrio = Convert.ToInt32(row["idBarrio"].ToString()),
                    Nombre = row["nomBarrio"].ToString(),
                }
            };
            return oCliente;
        }
    }
}
