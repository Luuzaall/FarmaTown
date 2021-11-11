using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Farmacia
    {
        public int IdFarmacia { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Barrio Barrio { get; set; }
        public bool Borrado { get; set; }

        FarmaciaDao oFarmaciaDao;
        public Farmacia()
        {
            oFarmaciaDao = new FarmaciaDao();
        }

        public List<Farmacia> recuperarTodos()
        {
            /*
             * Recupera todas las farmacias sin parámetros.
             */
            return oFarmaciaDao.recuperarTodos();
        }

        public List<Farmacia> recuperarCParam(string nombre, string calle
            , string num, string barrio, string localidad)
        {
            /*
             * Recupera las farmacias con los parámetros 
             * recibidos.
             */
            return this.oFarmaciaDao.recuperarCParam(nombre, calle, num
                , barrio, localidad);
        }

        public Farmacia traerFarmacia(int id)
        {
            /*
             * Recupera UNA Farmacia por su ID.
             */
            return oFarmaciaDao.traerFarmacia(id);
        }

        public bool crearFarmacia(Farmacia nuevaFarmacia)
        {
            /*
             * Persiste una nueva farmacia,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirla.
             */
            return validar(this.oFarmaciaDao.crear(nuevaFarmacia));
        }

        public bool actualizarFarmacia(Farmacia farmacia)
        {
            /*
             * Cambia los datos de la farmacia recibida
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar(oFarmaciaDao.actualizar(farmacia));
        }

        public bool cambiarEstadoFarmacia(Farmacia farmacia)
        {
            /*
             * Deshabilita la farmacia recibida.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarla.
             */
            return validar(oFarmaciaDao.cambiarEstado(farmacia));
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
