﻿using System;
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

        internal int validarUsuario(string usuario, string clave)
        {
            Usuario usuLogin = traerUsuario(usuario);
            if (usuLogin != null)
            {
                if (usuLogin.Clave == clave)
                {
                    return usuLogin.IdUsuario;
                }
            }
            return -1;
        }

        internal Usuario traerUsuario(string usuario)
        {
            Usuario usuLogin = DBHelper.getDBHelper().obtenerUsuarioPorNom(usuario);
            if (usuLogin != null)
            {
                return usuLogin;
            }
            return null;
        }
    }
}
