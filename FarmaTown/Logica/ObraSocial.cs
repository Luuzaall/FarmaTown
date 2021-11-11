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

        public List<ObraSocial> recuperarTodos()
        {
            /*
             * Recupera todas las obras sociales 
             * sin parámetros.
             */
            return this.oObraSocialDao.recuperarTodos();
        }

        public List<ObraSocial> recuperarCParam(string nombre)
        {
            /*
             * Recupera todos las obras sociales con los
             * parámetros recibidos.
             */
            return this.oObraSocialDao.recuperarCParam(nombre);
        }

        public Object obtenerDatosReporte(string nomObraSocial)
        {
            /*
             * Obtiene las obras sociales cuyo nombre se parezca
             * al recibido por parámetro
             * Y lo devuelve en DataTable para el 
             * ReportViewer.
             */
            return oObraSocialDao.obtenerDatosReporte(nomObraSocial);
        }

        public ObraSocial traerOS(int idOS)
        {
            /*
             * Recupera una obra social por ID.
             */
            return this.oObraSocialDao.traer(idOS);
        }

        public ObraSocial traerOS(string nombre)
        {
            /*
             * Recupera una obra social por nombre.
             */
            return this.oObraSocialDao.traer(nombre);
        }

        public bool crearOS(ObraSocial nuevaOS)
        {
            /*
             * Persiste una nueva Obra social,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirla.
             */
            return validar( this.oObraSocialDao.crear(nuevaOS) );

        }

        public bool actualizar(ObraSocial oOS)
        {
            /*
             * Cambia los datos de la obra social recibida
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar( this.oObraSocialDao.actualizar(oOS) );
   
        }

        public bool cambiarEstado(ObraSocial oOS)
        {
            /*
             * Deshabilita la obra social recibida.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarla.
             */
            return validar( this.oObraSocialDao.cambiarEstado(oOS) );

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
