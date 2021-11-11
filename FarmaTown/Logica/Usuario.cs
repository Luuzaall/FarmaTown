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
            /*
             * Recibe los datos de un usuario y 
             * verifica si se encuentra registrado.
             * 
             * Devuelve:
             * -TRUE: Si se encuentra registrado.
             * -FALSE: Si no lo está.
             */
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
            /*
             * Trae un usuario por su nombre.
             */
            Usuario oUsuario = oUsuarioDao.obtenerUsuarioPorNom(usuario);
            if (oUsuario != null)
            {
                return oUsuario;
            }
            return null;
        } 

        public List<Usuario> recuperarTodos()
        {
            /*
             * Recupera todos los usuarios.
             */
            return this.oUsuarioDao.recuperarTodos();
        }

        public List<Usuario> recurperarUsuarioCParametros(string nom
            , int idRol)
        {
            /*
             * Recupera todos los usuarios con parámetros.
             */
            return this.oUsuarioDao.consultarUsuariosCParam(nom
                , idRol);
        }

        public bool crearUsuario(Usuario oUsuario)
        {
            /*
             * Persiste un nuevo Usuario,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return this.validar(this.oUsuarioDao.insertar(oUsuario));
        }

        public bool actualizarUsuario(Usuario oUsuario)
        {
            /*
             * Cambia los datos del Usuario recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return this.oUsuarioDao.actualizar(oUsuario);
        }

        public bool cambiarEstadoUsuario(Usuario oUsuario)
        {
            /*
             * Deshabilita el Usuario recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return this.validar(this.oUsuarioDao.cambiarEstado(oUsuario));
        }

        internal bool esVendedor()
        {
            /*
             * Determina si el usuario es un vendedor.
             * Lo delega al rol que posee.
             * 
             * Devuelve:
             * -TRUE: Si es un vendedor.
             * -FALSE: Si no lo es.
             */
            return Rol.esVendedor();
        }
        private bool validar(int resultado)
        {
            /*
             * Determina si se pudo 
             * llevar a cabo la tarea, o no.
             */
            if (resultado == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
