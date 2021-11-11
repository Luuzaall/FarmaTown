using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Barrio
    {
        public int IdBarrio { get; set; }
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
        public bool Borrado { get; set; }

        BarrioDao oBarrioDao;
        public Barrio()
        {
            oBarrioDao = new BarrioDao();
        }
        public List<Barrio> recuperarCParam(string nombre)
        {
            /*
             * Recupera todos los barrios por nombre.
             */
            return this.oBarrioDao.recuperarCParam(nombre);
        }
        public List<Barrio> recuperarCParamOtro(string nombre, string localidad)
        {
            /*
             * Recupera todos los barrios con los parámetros recibidos.
             */
            return this.oBarrioDao.recuperarCParamOtro(nombre, localidad);
        }
        public List<Barrio> recuperarTodos()
        {
            /*
             * Recupera sin parámetros.
             */
            return this.oBarrioDao.recuperarTodos();
        }

        public List<Barrio> recuperarSoloUsadosClientes()
        {
            /*
             * Recupera los barrios que tengan al 
             * menos un cliente registrado.
             */
            return this.oBarrioDao.recuperarSoloUsadosClientes();
        }
        public Barrio traerBarrio(int idBarrio)
        {
            /*
             * 
             */
            return this.oBarrioDao.traer(idBarrio);
        }

        public Barrio traerBarrio(string nombre)
        {
            return this.oBarrioDao.traer(nombre);
        }

        public bool crearBarrio(Barrio nuevoBarrio)
        {
            return validar(this.oBarrioDao.crear(nuevoBarrio));

        }

        public bool actualizar(Barrio oBarrio)
        {
            return validar(this.oBarrioDao.actualizar(oBarrio));

        }

        public bool cambiarEstado(Barrio oBarrio)
        {
            return validar(this.oBarrioDao.cambiarEstado(oBarrio));

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
