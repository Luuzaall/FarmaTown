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

        public List<TipoDocumento> recuperarTodos()
        {
            /*
             * Recupera todos los tipos de documentos
             * sin parámetros.
             */
            return oTipoDocDao.recuperarTodos();
        }

        public List<TipoDocumento> recuperarCParam(string nombre
            , string palabraClave)
        {
            /*
             * Recupera todos con los parámetros recibidos.
             */
            return this.oTipoDocDao.recuperarCParam(nombre
                , palabraClave);
        }

        public TipoDocumento traerTipoDoc(int idTipo)
        {
            /*
             * Recupera UN Tipo de Documento por ID.
             */
            return this.oTipoDocDao.traer(idTipo);
        }
        
        public TipoDocumento traerTipoDoc(string nom)
        {
            /*
             * Recupera UN Tipo de Documento por nombre.
             */
            return this.oTipoDocDao.traer(nom);
        }

        public bool crearNuevo(TipoDocumento oNuevoTipoDoc)
        {
            /*
             * Persiste un nuevo tipo de documento,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return validar( this.oTipoDocDao.crear(oNuevoTipoDoc) );
        }

        public bool actualizar(TipoDocumento oTipoDoc)
        {
            /*
             * Cambia los datos del tipo de documento recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar( this.oTipoDocDao.actualizar(oTipoDoc) );
        }

        public bool cambiarEstado(bool seHabilita, TipoDocumento oTipoDoc)
        {
            /*
             * Deshabilita el tipo de documento recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return validar( this.oTipoDocDao.cambiarEstado(seHabilita, oTipoDoc) );
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
