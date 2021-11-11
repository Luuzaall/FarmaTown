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
        public List<Usuario> recuperarTodos()
        {
            /*
             * Recupera todos los usuarios sin parámetros.
             */
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
                    " WHERE u.borrado = 0" +
                    " ORDER BY u.nombre";

            
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        public List<Usuario> consultarUsuariosCParam(string nomUs, int idRol)
        {
            /*
             * Recupera todos los usuarios con los
             * parámetros que recibe.
             */
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

            if (!(string.IsNullOrEmpty(nomUs)))
            {
                query = query + " AND u.nombre LIKE '%" + nomUs + "%'";
            }
            if (!(idRol == -1))
            {
                query = query + " AND u.idRol = " + idRol;
            }

            query += " ORDER BY u.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        public int insertar(Usuario oUsuario)
        {
            /*
             * Inserta el usuario nuevo en la base de datos.
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
            return afectadas;
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

        public int cambiarEstado(Usuario oUsuario)
        {
            /*
             * Aplica la baja lógica del usuario
             * recibido.
             */
            string query = "UPDATE Usuarios" +
                " SET borrado = 1";

            query = query + " WHERE idUsuario = " + oUsuario.IdUsuario;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            return afectadas;
        }

        public Usuario obtenerUsuarioPorNom(string nomUs)
        {
            /*
            * Permite obtener UN usuario por su nombre
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
             * tipo de Usuario
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
            Empleado oEmplDelUsuario = (new Empleado())
                    .traerEmpleado(Convert.ToInt32(row["idEmpleado"].ToString() ) );
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
                Empleado = oEmplDelUsuario,
            };

            return oUsuario;
        }
    }
}
