using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class EstadoDao
    {
        public Estado traer(int idEstado)
        {
            switch (idEstado)
            {
                case 1:
                    {
                        ActivaDao oEstado = new ActivaDao();
                        return oEstado.traer();
                    }
                case 2:
                    {
                        CanceladaDao oEstado = new CanceladaDao();
                        return oEstado.traer();
                    }
            }

            return null;
        }

        internal List<Estado> recuperarTodos()
        {
            string query = " SELECT idEstado" +
                 ", nombre" +
                 " FROM Estados" +
                 " WHERE borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        private List<Estado> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<Estado> lista = new List<Estado>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private Activa objectMapping(DataRow row)
        {
            Activa oEstado = new Activa()
            {
                IdEstado = Convert.ToInt32(row["idEstado"].ToString()),
                Nombre = row["nombre"].ToString(),
            };
            return oEstado;
        }
    }

}
