using System;
using FarmaTown.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        RolDao oRolDao;

        public Rol()
        {
            oRolDao = new RolDao();
        }

        public List<Rol> recuperarTodos()
        {
            /*
             * Recupera todos los roles
             * sin parámetros.
             */
            return oRolDao.recuperarTodos();
        }

        internal bool esVendedor()
        {
            /*
             * Determina si el rol es
             * del tipo Vendedor
             * 
             * Devuelve:
             * -TRUE: Si es un rol Vendedor.
             * -FALSE: Si no lo es.
             */
            if (this.IdRol == 2)
                return true;
            return false;
        }
    }

}
