using System;
using System.Collections.Generic;
using System.Linq;
using APPBTS.Datos;
using System.Data;
using System.Threading.Tasks;

namespace APPBTS.Negocio
{
    class Usuario
    {
        //Atributos.
        private int id_usuario;

        //Métodos de definición.

        public int Id_usuario
        {
            //PROPIEDAD es un tipo de elemento que tiene
            //el get y el set. No los separa
            get { return id_usuario;  }
            set { id_usuario = value;  }
        }

        public int Id_perfil { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }


        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" 
                + nombre + "' AND password = '" + clave 
                + "' AND borrado=0";
            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultaSQL(consulta);

            if (tabla.Rows.Count > 0)
            {
                return (int) tabla.Rows[0][0];
            }
            else
            {
                return 0;
            }
           
        }



    }
}
