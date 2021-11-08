using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class ObraSocial
    {
        public int IdOS { get; set; }
        public string Nombre { get; set; }
        public List<List<Object>> listaDescuentos { get; set; }
        public bool Borrado { get; set; }


        ObraSocialDao oObraSocialDao;

        public ObraSocial()
        {
            oObraSocialDao = new ObraSocialDao();
        }

        public List<ObraSocial> recuperarCParam(string nombre)
        {
            return this.oObraSocialDao.recuperarCParam(nombre);
        }

        public List<ObraSocial> recuperarTodos()
        {
            return this.oObraSocialDao.recuperarTodos();
        }

        public Object obtenerDatosReporte()
        {
            return oObraSocialDao.obtenerDatosReporte();
        }

        public ObraSocial traerOS(int idOS)
        {
            return this.oObraSocialDao.traer(idOS);
        }

        public ObraSocial traerOS(string nombre)
        {
            return this.oObraSocialDao.traer(nombre);
        }

        public bool crearOS(ObraSocial nuevaOS)
        {
            return validar( this.oObraSocialDao.crear(nuevaOS) );

        }

        public bool actualizar(ObraSocial oOS)
        {
            return validar( this.oObraSocialDao.actualizar(oOS) );
   
        }

        public bool cambiarEstado(ObraSocial oOS, bool seHabilita)
        {
            return validar( this.oObraSocialDao.cambiarEstado(oOS, false) );

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
