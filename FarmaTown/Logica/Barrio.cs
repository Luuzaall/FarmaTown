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

        BarrioDao oBarrioDao;

        public Barrio()
        {
            oBarrioDao = new BarrioDao();
        }
        public DataTable recuperarTodos()
        {
            return oBarrioDao.recuperarTodos();
        }
        public DataTable recuperarCParam(string nombre, string localidad)
        {
            return this.oBarrioDao.recuperarCParam(nombre, localidad);
        }

        public Barrio traerBarrio(int idBarrio)
        {
            return oBarrioDao.traerBarrio(idBarrio);
        }
    }
}
