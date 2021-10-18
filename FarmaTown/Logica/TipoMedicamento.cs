using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class TipoMedicamento
    {
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        TipoMedDao oTipoMedDao;

        public TipoMedicamento()
        {
            oTipoMedDao = new TipoMedDao();
        }
        public List<TipoMedicamento> recuperarCParam(string descripcion)
        {
            return this.oTipoMedDao.recuperarCParam(descripcion);
        }

        public List<TipoMedicamento> recuperarTodos(bool esCBorrados)
        {
            return this.oTipoMedDao.recuperarTodos(esCBorrados);
        }

        public TipoMedicamento traerTipoMed(int idTipo)
        {
            return this.oTipoMedDao.traer(idTipo);
        }

        public TipoMedicamento traerTipoMed(string descripcion)
        {
            return this.oTipoMedDao.traer(descripcion);
        }

        public bool crearTipoMedicamento(TipoMedicamento nuevoTipoMedicamento)
        {
            return validar(this.oTipoMedDao.crear(nuevoTipoMedicamento));
        }

        public bool actualizar(TipoMedicamento oTipoMed)
        {
            return validar(this.oTipoMedDao.actualizar(oTipoMed));
        }

        public bool cambiarEstado(TipoMedicamento oTipoMed, bool seHabilita)
        {
            return validar(this.oTipoMedDao.cambiarEstado(oTipoMed, false));
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
