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
        public List<Cliente> recuperarTodos(bool esCBorrados)
        {
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

            if (esCBorrados)
                query = query + " OR borrado = 1";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Cliente> listaCliente = new List<Cliente>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaCliente.Add(this.objectMapping(fila));
            }

            return listaCliente;
        }
        public List<Cliente> recuperarConParam(string nombre, string apellido
            , string nroDoc, int idTipoDoc)
        {
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
                query = query + " AND e.tipoDoc = " + idTipoDoc;
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND c.nroDoc LIKE '%" + nroDoc + "%'";
            }
            if (!string.IsNullOrEmpty(apellido))
            {
                query = query + " AND c.apellido LIKE '%" + apellido + "%'";
            }                   

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return this.listMapping(tabla);
        }

        public Cliente recuperar( int idTipoDoc, string nroDoc)
        {
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
                            " AND c.nroDoc = '" + nroDoc + "'" +
                            " AND c.tipoDoc = " + idTipoDoc;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            if (tabla.Rows.Count == 0)
                return null;
            else
                return this.objectMapping(tabla.Rows[0]);

        }

        public Cliente traer(int idCliente)
        {
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
            string query = "UPDATE Clientes " +
               " SET borrado = 1" +
               " WHERE idCliente= " + oCliente.IdCliente;


            //if (seHabilita)
            //    query = query + "0";
            //else
            //    query = query + "1";

            //query = query + " WHERE idEmpleado = " + empl.IdEmpleado;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        private List<Cliente> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
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

        //NUEVA CONTROLAR!!!!!!!!!!!!!!!!!!!!
        public Cliente buscarCliente(string nomCli, string apellido , string calle, string nroDoc, int idTipoDoc, int idBarrio)
        {
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
                return null;
            }
            else
            {
                DataRow fila = tablaClientes.Rows[0];
                return this.objectMapping(fila);
            }

        }
    }
}
