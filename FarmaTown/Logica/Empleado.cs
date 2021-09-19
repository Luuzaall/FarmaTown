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
        public int NroDoc { get; set; }
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

        internal Empleado traerEmpleado(string _idEmpleado)
        {
            return oEmpleadoDao.traerEmpleado(_idEmpleado);

        }

        public bool existeEmpleado(string nomEmpl, string nroDoc, int idTipoDoc, string nomFarm)
        {
            object emplEncontrado = oEmpleadoDao.buscarEmpleado(nomEmpl, nroDoc, idTipoDoc, nomFarm);
            if (emplEncontrado is null)
                return false;
            else
                return true;

        }
        internal DataTable recuperarEmpleadoCParametros(string nomEmpl, string nroDoc, int idTipoDoc, string nomFarm)
        {
            return oEmpleadoDao.recuperarConParam(nomEmpl, nroDoc, idTipoDoc, nomFarm);
        }
    }
}
