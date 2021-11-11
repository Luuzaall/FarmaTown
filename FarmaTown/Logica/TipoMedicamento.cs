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
        public List<TipoMedicamento> recuperarTodos()
        {
            /*
             * Recupera todos los tipos de medicamento.
             */
            return this.oTipoMedDao.recuperarTodos();
        }
        public List<TipoMedicamento> recuperarCParam(string descripcion)
        {
            /*
             * Recupera todos los tipos de medicamentos
             * cuya descripción sea parecida a la recibida
             * por parámetro.
             */
            return this.oTipoMedDao.recuperarCParam(descripcion);
        }

        public TipoMedicamento traerTipoMed(int idTipo)
        {
            /*
             * Recupera UN tipo de medicamento por ID.
             */
            return this.oTipoMedDao.traer(idTipo);
        }

        public TipoMedicamento traerTipoMed(string descripcion)
        {
            /*
             * Recupera UN tipo de medicamento por 
             * descripción.
             */
            return this.oTipoMedDao.traer(descripcion);
        }

        public bool crearTipoMedicamento(TipoMedicamento nuevoTipoMedicamento)
        {
            /*
             * Persiste un nuevo tipo de medicamento,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return validar(this.oTipoMedDao.crear(nuevoTipoMedicamento));
        }

        public bool actualizar(TipoMedicamento oTipoMed)
        {
            /*
             * Cambia los datos del tipo de medicamento recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar(this.oTipoMedDao.actualizar(oTipoMed));
        }

        public bool cambiarEstado(TipoMedicamento oTipoMed)
        {
            /*
             * Deshabilita el tipo de medicamento recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return validar(this.oTipoMedDao.cambiarEstado(oTipoMed));
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
