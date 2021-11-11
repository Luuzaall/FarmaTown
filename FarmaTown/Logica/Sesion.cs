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
            /*
             * Persiste la sesión y su hora de inicio
             * Los datos están en la misma instancia que lo llama.
             */
            return validar(dao.persistirSesionInicio(this));
        }

        internal bool persistirFinal()
        {
            /*
             * Guarda la hora final de la sesión.
             * Los datos están en la misma instancia que lo llama.
             */
            return validar(dao.persistirSesionFinal(this));
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
