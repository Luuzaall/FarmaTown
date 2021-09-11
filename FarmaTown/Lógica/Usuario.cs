using FarmaTown.Lógica;
using System;

namespace FarmaTown
{
    internal class Usuario
    {
        //Propiedades
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public Rol Rol { get; set; }
        public bool Borrado { get; set; }

        internal int validarUsuario(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }
}