using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class UsuarioDao
    {
        public List<Usuario> recuperarTodos(bool esConBorrados)
        {
            string query = "SELECT u.idUsuario" +
                    ", u.nombre as nomUsuario" +
                    ", u.clave" + 
                    ", u.idRol" + 
                    ", r.nombre as nomRol" +
                    ", u.idEmpleado" + 
                    ", e.nombre as nomEmpleado" +
                    ", e.borrado " +
                    " FROM Usuarios u" +
                    " INNER JOIN Empleados e ON u.idEmpleado = e.idEmpleado" +
                    " INNER JOIN Roles r ON r.idRol = u.idRol" +
                    " WHERE u.borrado = 0";

            if (esConBorrados)
            {
                query = query + " OR u.borrado = 1";
            }
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        public List<Usuario> consultarUsuariosCParam(string nomUs, int idRol, bool conBorrados)
        {
            string query = "SELECT u.idUsuario" +
                    ", u.nombre as nomUsuario" +
                    ", u.clave" +
                    ", u.idRol" +
                    ", r.nombre as nomRol" +
                    ", u.idEmpleado" +
                    ", e.nombre as nomEmpleado" +
                    ", e.borrado " +
                    " FROM Usuarios u" +
                    " INNER JOIN Empleados e ON u.idEmpleado = e.idEmpleado" +
                    " INNER JOIN Roles r ON r.idRol = u.idRol" +
                    " WHERE u.borrado = 0";

            if (conBorrados)
                query = query + " OR u.borrado = 1";

            if (!(string.IsNullOrEmpty(nomUs)))
            {
                query = query + " AND u.nombre LIKE '%" + nomUs + "%'";
            }
            if (!(idRol == -1))
            {
                query = query + " AND u.idRol = " + idRol;
            }

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        public bool insertar(Usuario oUsuario)
        {
            /*
             * Inserta el usuario nuevo en la base de datos.
             * Su resultado se retornará en booleano.
             * - TRUE si se insertó exitosamente
             * - FALSE si no se logró insertar.
             */
            string query = "INSERT INTO Usuarios" +
                "(idEmpleado" +
                ", nombre" +
                ", clave" +
                ", idRol" +
                ", borrado)" +
                " VALUES" +
                "(" + oUsuario.Empleado.IdEmpleado +
                ", '" + oUsuario.Nombre + "'" +
                ", '" + oUsuario.Clave + "'" +
                ", " + oUsuario.Rol.IdRol +
                ", 0)";

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas == 0)
            {
                return false;
            }
            else return true;
        }

        public bool actualizar(Usuario oUsuario)
        {
            /*
             * Actualiza los datos del usuario obtenido
             * en la base de datos, con los nuevos cambios.
             */
            string query = "UPDATE Usuarios " +
                " SET nombre = '" + oUsuario.Nombre + "'" +
                " , clave = '" + oUsuario.Clave + "'" +
                " , idRol = " + oUsuario.Rol.IdRol +
                " , idEmpleado = " + oUsuario.Empleado.IdEmpleado +
                " WHERE idUsuario = " + oUsuario.IdUsuario;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas > 0)
            {
                return true;
            }
            return false;
        }

        public bool cambiarEstado(Usuario oUsuario, bool seHabilita)
        {
            string query = "UPDATE Usuarios" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idUsuario = " + oUsuario.IdUsuario;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas > 0)
            {
                return true;
            }
            return false;

        }

        public Usuario obtenerUsuarioPorNom(string nomUs)
        {
            /*
            * Permite obtener el usuario por su nombre
            */
            string query = "SELECT u.idUsuario" +
                " , u.idEmpleado" +
                " , u.nombre as nomUsuario" +
                " , u.clave " +
                " , r.idRol" +
                " , r.nombre as nomRol " +
                " , e.nombre as nomEmpleado" +
                " , e.idEmpleado" +
                " FROM Usuarios u" +
                " INNER JOIN Roles r ON u.idRol = r.idRol" +
                " INNER JOIN Empleados e ON u.idEmpleado = e.idEmpleado " +
                " WHERE u.nombre = '" + nomUs + "'" +
                " AND u.borrado = 0;";

            DataTable tablaUs = DBHelper.getDBHelper().consultaSQL(query);
            if (tablaUs.Rows.Count > 0)
            {
                return objectMapping(tablaUs.Rows[0]);
            }
            return null;
        }

        private List<Usuario> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<Usuario> lista = new List<Usuario>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private Usuario objectMapping(DataRow row)
        {
            /*
             * A partir del registro de un usuario,
             * tranforma esa información en un 
             * objeto del tipo Usuario
             */
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["idUsuario"].ToString()),
                Nombre = row["nomUsuario"].ToString(),
                Clave = row["clave"].ToString(),
                Rol = new Rol()
                {
                    IdRol = Convert.ToInt32(row["idRol"].ToString()),
                    Nombre = row["nomRol"].ToString(),
                },
                Empleado = new Empleado()
                {
                    IdEmpleado = Convert.ToInt32(row["idEmpleado"].ToString()),
                    Nombre = row["nomEmpleado"].ToString(),
                }
            };

            return oUsuario;
        }
    }
}
