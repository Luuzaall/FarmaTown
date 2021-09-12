using FarmaTown.Lógica;
using System;
using FarmaTown.Datos;

namespace FarmaTown
{
    public class Usuario
    {
        //Atributos


        //Propiedades
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Rol Rol { get; set; }
        public bool Borrado { get; set; }

        internal int validarUsuario(string usuario, string clave)
        {
            Usuario usuLogin = DBHelper.getDBHelper().obtenerUsuarioPorNom(usuario);
            if (usuLogin is null)
            {
                return -1;
            }
            else
            {
                if (usuLogin.Clave == clave)
                {
                    return usuLogin.IdUsuario;
                }
            }
            return -1;
        }
    }
}
