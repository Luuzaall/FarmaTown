using System;
using System.Data;
using FarmaTown.Datos;

namespace FarmaTown.Logica
{
    public class Usuario
    {

        //Propiedades
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }
        public bool Borrado { get; set; }

        //Atributos
        UsuarioDao oUsuarioDao;

        public Usuario()
        {
            oUsuarioDao = new UsuarioDao();
        }
        internal string validarUsuario(string usuario, string clave)
        {
            Usuario usuLogin = traerUsuario(usuario);
            if (usuLogin != null)
            {
                if (usuLogin.Clave == clave)
                {
                    return usuLogin.Nombre;
                }
            }
            return null;
        }

        internal Usuario traerUsuario(string usuario)
        {
            Usuario oUsuario = DBHelper.getDBHelper().obtenerUsuarioPorNom(usuario);
            if (oUsuario != null)
            {
                return oUsuario;
            }
            return null;
        }
        public DataTable recuperarTodos()
        {
            return this.oUsuarioDao.recuperarTodos();
        }

        public DataTable recurperarUsuarioCParametros(string nom, int idRol)
        {
            return this.oUsuarioDao.consultarUsuariosCParam(nom, idRol);
        }

        public bool crearUsuario(Usuario oUsuario)
        {
            return this.oUsuarioDao.insertar(oUsuario);
        }

        public bool actualizarUsuario(Usuario oUsuario)
        {
            return this.oUsuarioDao.actualizar(oUsuario);
        }

        public bool cambiarEstadoUsuario(Usuario oUsuario)
        {
            return this.oUsuarioDao.cambiarEstado(oUsuario);
        }
    }
}
