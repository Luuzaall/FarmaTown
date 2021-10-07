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
                            ", c.numero " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE b.borrado = 0";

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
                            ", c.numero " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE b.borrado = 0";

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
                NroDoc = Convert.ToInt32(row["nroDoc"].ToString()),
                Calle = row["calle"].ToString(),
                Numero = Convert.ToInt32(row["numero"].ToString()),
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
