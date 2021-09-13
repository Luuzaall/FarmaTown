using System;
using FarmaTown.Datos;

namespace FarmaTown.Logica
{
    public class Usuario
    {
        //Atributos


        //Propiedades
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }
        public bool Borrado { get; set; }

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
    }
}
