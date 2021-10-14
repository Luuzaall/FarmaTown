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
            return oRolDao.recuperarTodos();
        }
    }

}
