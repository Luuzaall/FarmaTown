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

        BarrioDao oBarrio = new BarrioDao();

        public DataTable recuperarTodos()
        {
            return oBarrio.recuperarTodos();
        }
    }
}
