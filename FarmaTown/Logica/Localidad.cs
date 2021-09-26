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

        public List<Localidad> recuperarCParam(string nombre)
        {
            return this.oLocalidadDao.recuperarCParam(nombre);
        }

        public List<Localidad> recuperarTodos(bool esCBorrados)
        {
            return this.oLocalidadDao.recuperarTodos(esCBorrados);
        }

        public Localidad traerLocalidad(int idLocalidad)
        {
            return this.oLocalidadDao.traer(idLocalidad);
        }

        public Localidad traerLocalidad(string nombre)
        {
            return this.oLocalidadDao.traer(nombre);
        }

        public bool crearLocalidad(Localidad nuevaLocalidad)
        {
            return validar(this.oLocalidadDao.crear(nuevaLocalidad));

        }

        public bool actualizar(Localidad oLocalidad)
        {
            return validar(this.oLocalidadDao.actualizar(oLocalidad));

        }

        public bool cambiarEstado(Localidad oLocalidad, bool seHabilita)
        {
            return validar(this.oLocalidadDao.cambiarEstado(oLocalidad, false));

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