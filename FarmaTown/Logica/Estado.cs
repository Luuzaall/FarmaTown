using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public abstract class Estado
    { 
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public virtual void cancelada(Venta oVenta)
        {

        }

        public static List<Estado> recuperarTodos()
        {
            EstadoDao oEstadoDao = new EstadoDao();
            return oEstadoDao.recuperarTodos();
        }
    }
}
