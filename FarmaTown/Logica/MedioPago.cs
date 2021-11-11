using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class MedioPago
    {
        public int idMedioPago { get; set; }
        public string Nombre { get; set; }

        MedioPagoDao dao;

        public MedioPago()
        {
            dao = new MedioPagoDao();
        }

        public List<MedioPago> recuperarTodos()
        {
            /*
             * Recupera todos los medios de pago 
             * sin parámetros.
             */
            return dao.recuperarTodos();
        }
    }
}
