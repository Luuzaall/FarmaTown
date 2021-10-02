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
                            ", c.nombre " +
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
        public List<Cliente> recuperarConParam(string nom, string apellido, string nroDoc, int idTipoDoc, string calle, int numCalle, int idCliente)
        {
            string query = "SELECT c.idCliente" +
                            ", c.nroDoc" +
                            ", c.tipoDoc" +
                            ", c.apellido " +
                            ", c.nombre " +
                            ", c.calle " +
                            ", c.numero " +
                            ", c.idBarrio " +
                            ", b.nombre as nomBarrio" +
                            ", td.nombre as nomTipoDoc" +
                            " FROM Clientes c " +
                            " INNER JOIN Barrios b ON c.idBarrio = b.idBarrio" +
                            " INNER JOIN TiposDocumento td ON c.tipoDoc = td.idTipo" +
                            " WHERE b.borrado = 0";

            if (!string.IsNullOrEmpty(nom))
            {
                query = query + " AND c.nombre LIKE '%" + nom + "%'";
            }
            if (!string.IsNullOrEmpty(nroDoc))
            {
                query = query + " AND c.nroDoc LIKE '%" + nroDoc + "%'";
            }
            if (!string.IsNullOrEmpty(apellido))
            {
                query = query + " AND c.apellido LIKE '%" + apellido + "%'";
            }
            if (!string.IsNullOrEmpty(calle))
            {
                query = query + " AND c.calle LIKE '%" + calle + "%'";
            }
            if (numCalle != -1)
            {
                query = query + " AND e.tipoDoc = " + numCalle;
            }
            if (idCliente != -1)
            {
                query = query + " AND c.idCliente LIKE '%" + idCliente + "%'";
            }
            if (idTipoDoc != -1)
            {
                query = query + " AND e.tipoDoc = " + idTipoDoc;
            }

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

        private Cliente objectMapping(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                IdCliente = Convert.ToInt32(row["idCliente"].ToString()),
                NroDoc = Convert.ToInt32(row["nroDoc"].ToString()),
                TipoDoc = new TipoDocumento()
                {
                    IdTipo = Convert.ToInt32(row["tipoDoc"].ToString()),
                    Nombre = row["nomTipoDoc"].ToString()
                },
                Apellido = row["apellido"].ToString(),
                Nombre = row["nombre"].ToString(),
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
