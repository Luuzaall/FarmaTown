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
        public DataTable recuperarTodos()
        {
            string query = "SELECT u.idUsuario" +
                    ", u.nombre as nomUsuario" +
                    ", r.nombre as nomRol" +
                    ", e.nombre as nomEmpleado" +
                    " FROM Usuarios u" +
                    " INNER JOIN Empleados e ON u.idEmpleado = e.idEmpleado" +
                    " INNER JOIN Roles r ON r.idRol = u.idRol" +
                    " WHERE u.borrado = 0";
            return DBHelper.getDBHelper().consultaSQL(query);
        }

        public DataTable consultarUsuariosCParam(string nomUs, int idRol)
        {
            string query = "SELECT u.idUsuario" +
                ", u.nombre as nomUsuario" +
                ", r.nombre as nomRol" +
                ", e.nombre as nomEmpleado" +
                " FROM Usuarios u " +
                " INNER JOIN Roles r ON u.idRol = r.idRol" +
                " INNER JOIN Empleados e ON u.idEmpleado = e.idEmpleado" +
                " WHERE u.borrado = 0";

            if (!( string.IsNullOrEmpty(nomUs) ) )
            {
                query = query + " AND u.nombre LIKE '%" + nomUs + "%'";
            }
            if (!(idRol == -1))
            {
                query = query + " AND u.idRol = " + idRol;
            }

            return DBHelper.getDBHelper().consultaSQL(query);
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

        public bool cambiarEstado(Usuario oUsuario)
        {
            string query = "UPDATE Usuarios" +
                " SET borrado = 1" +
                " WHERE idUsuario = " + oUsuario.IdUsuario;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas > 0)
            {
                return true;
            }
            return false;

        }
    }
}
