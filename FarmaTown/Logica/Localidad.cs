using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        LocalidadDao oLocalidadDao;

        public Localidad()
        {
            oLocalidadDao = new LocalidadDao();
        }
        public List<Localidad> recuperarTodos()
        {
            /*
             * Recupera todas las localidades.
             */
            return this.oLocalidadDao.recuperarTodos();
        }

        public List<Localidad> recuperarCParam(string nombre)
        {
            /*
             * Recupera todas las localidades 
             * según sea parecido al nombre recibido.
             */
            return this.oLocalidadDao.recuperarCParam(nombre);
        }
        public List<Localidad> recuperarSoloUsadosClientes()
        {
            /*
             * Recupera sólo las localidades que tengan al 
             * menos un cliente registrados.
             */
            return this.oLocalidadDao.recuperarSoloUsadosClientes();
        }
        public Localidad traerLocalidad(int idLocalidad)
        {
            /*
             * Recupera UNA localidad según su ID.
             */
            return this.oLocalidadDao.traer(idLocalidad);
        }

        public Localidad traerLocalidad(string nombre)
        {
            /*
             * Recupera UNA localidad según su Nombre.
             */
            return this.oLocalidadDao.traer(nombre);
        }

        public bool crearLocalidad(Localidad nuevaLocalidad)
        {
            /*
             * Persiste una nueva localidad,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirla.
             */
            return validar(this.oLocalidadDao.crear(nuevaLocalidad));

        }

        public bool actualizar(Localidad oLocalidad)
        {
            /*
             * Cambia los datos de la localidad recibida
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar(this.oLocalidadDao.actualizar(oLocalidad));

        }

        public bool cambiarEstado(Localidad oLocalidad)
        {
            /*
             * Deshabilita la localidad recibida.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarla.
             */
            return validar(this.oLocalidadDao.cambiarEstado(oLocalidad));
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