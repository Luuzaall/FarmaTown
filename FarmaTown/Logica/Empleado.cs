using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica

{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NroDoc { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public Farmacia Farmacia { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        EmpleadoDao oEmpleadoDao;

        public Empleado()
        {
            oEmpleadoDao = new EmpleadoDao();
        }
        public DataTable recuperarTodos()
        {
            return oEmpleadoDao.recuperarTodos();
        }

        internal Empleado traerEmpleado(int _idEmpleado)
        {
            return oEmpleadoDao.traerEmpleado(_idEmpleado);

        }

        public bool existeEmpleado(string nomEmpl, string nroDoc, int idTipoDoc, int idFarm)
        {
            object emplEncontrado = oEmpleadoDao.buscarEmpleado(nomEmpl, nroDoc, idTipoDoc, idFarm);
            if (emplEncontrado is null)
                return false;
            else
                return true;

        }
        internal DataTable recuperarEmpleadoCParametros(string nomEmpl, string nroDoc, int idTipoDoc, string nomFarm)
        {
            return oEmpleadoDao.recuperarConParam(nomEmpl, nroDoc, idTipoDoc, nomFarm);
        }

        public bool crearEmpleado(Empleado oEmpleado)
        {
            bool resultado = oEmpleadoDao.insertarEmpleado(oEmpleado);

            return resultado;
        }

        public bool actualizarEmpleado(Empleado oEmpleado)
        {
            bool resultado = oEmpleadoDao.actualizarEmpleado(oEmpleado);

            return resultado;
        }

        public bool cambiarEstadoEmpleado(Empleado oEmpleado, bool seHabilita)
        {
            return this.oEmpleadoDao.cambiarEstado(oEmpleado, seHabilita);
        }
    }
}
