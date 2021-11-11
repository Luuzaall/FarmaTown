using FarmaTown;
using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Sesion
    {
        public int IdSesion { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Borrado { get; set; }

        SesionDao dao;
        public Sesion()
        {
            dao = new SesionDao();
        }

        internal bool persistirInicio()
        {
            return validar(dao.persistirSesionInicio(this));
        }

        internal bool persistirFinal()
        {
            return validar(dao.persistirSesionFinal(this));
        }
        private bool validar(int resultado)
        {
            if (resultado == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
