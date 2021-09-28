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
            return oFarmaciaDao.recuperarTodos();
        }

        public List<Farmacia> recuperarCParam(string nombre, string calle, string num, string barrio, string localidad)
        {
            return this.oFarmaciaDao.recuperarCParam(nombre, calle, num, barrio, localidad);
        }

        public Farmacia traerFarmacia(int id)
        {
            return oFarmaciaDao.traerFarmacia(id);
        }

        public bool crearFarmacia(Farmacia nuevaFarmacia)
        {
            return validar(this.oFarmaciaDao.crear(nuevaFarmacia));
        }

        public bool actualizarFarmacia(Farmacia farmacia)
        {
            return validar(oFarmaciaDao.actualizar(farmacia));
        }

        public bool cambiarEstadoFarmacia(Farmacia farmacia, bool habilitar)
        {
            return validar(oFarmaciaDao.cambiarEstado(farmacia, habilitar));
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
