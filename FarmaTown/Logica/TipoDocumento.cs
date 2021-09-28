using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class TipoDocumento
    {
        TipoDocDao oTipoDocDao;
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento()
        {
            oTipoDocDao = new TipoDocDao();
        }

        public DataTable recuperarTodos(bool conBorrados)
        {
            return oTipoDocDao.recuperarTodos(conBorrados);
        }

        public List<TipoDocumento> recuperarTodosList(bool conBorrados)
        {
            return oTipoDocDao.recuperarTodosList(conBorrados);
        }

        public List<TipoDocumento> recuperarCParam(string nombre, string palabraClave)
        {
            return this.oTipoDocDao.recuperarCParam(nombre, palabraClave);
        }

        public TipoDocumento traerTipoDoc(int idTipo)
        {
            return this.oTipoDocDao.traer(idTipo);
        }
        
        public TipoDocumento traerTipoDoc(string nom)
        {
            return this.oTipoDocDao.traer(nom);
        }

        public bool crearNuevo(TipoDocumento oNuevoTipoDoc)
        {
            return validar( this.oTipoDocDao.crear(oNuevoTipoDoc) );
        }

        public bool actualizar(TipoDocumento oTipoDoc)
        {
            return validar( this.oTipoDocDao.actualizar(oTipoDoc) );
        }

        public bool cambiarEstado(bool seHabilita, TipoDocumento oTipoDoc)
        {
            return validar( this.oTipoDocDao.cambiarEstado(seHabilita, oTipoDoc) );
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
