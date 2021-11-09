using System;
using System.Collections.Generic;
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
            Usuario usuLogin = this.traerUsuario(usuario);
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
            Usuario oUsuario = oUsuarioDao.obtenerUsuarioPorNom(usuario);
            if (oUsuario != null)
            {
                return oUsuario;
            }
            return null;
        } 

        public List<Usuario> recuperarTodos()
        {
            return this.oUsuarioDao.recuperarTodos();
        }

        public List<Usuario> recurperarUsuarioCParametros(string nom, int idRol)
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

        public bool cambiarEstadoUsuario(Usuario oUsuario, bool seHabilita)
        {
            return this.oUsuarioDao.cambiarEstado(oUsuario, seHabilita);
        }

        internal bool esVendedor()
        {
            return Rol.esVendedor();
        }
    }
}
