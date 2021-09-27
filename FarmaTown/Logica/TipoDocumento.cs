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

        public DataTable recuperarTodos()
        {
            return oTipoDocDao.recuperarTodos();
        }

        public List<TipoDocumento> recuperarCParam(string nombre, string palabraClave)
        {
            return this.oTipoDocDao.recuperarCParam(nombre, palabraClave);
        }

        public TipoDocumento traerTipoDOc(int idTipo)
        {
            return this.oTipoDocDao.traer(idTipo);
        }
    }
}
