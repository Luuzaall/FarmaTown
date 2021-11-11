using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class RolDao
    {

        public List<Rol> recuperarTodos()
        {
            /*
             * Recupera todos los roles registrados
             * sin parámetros.
             */
            DataTable tabla = DBHelper.getDBHelper().consultarTabla("Roles");

            return listMapping(tabla);
        }

        private List<Rol> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Rol
             */
            List<Rol> lista = new List<Rol>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private Rol objectMapping(DataRow row)
        {
            /*
             * Recibe una registro de datos y lo 
             * tranforma a una instancia de una clase 
             * Tipo Rol.
             */

            Rol oRol = new Rol
            {
                IdRol = Convert.ToInt32(row["idRol"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oRol;
        }

    }
}
