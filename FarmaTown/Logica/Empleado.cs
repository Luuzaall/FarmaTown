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
        public List<Empleado> recuperarTodos()
        {
            /*
             * Recupera todos los empleados sin parámetros.
             */
            return oEmpleadoDao.recuperarTodos();
        }

        internal Empleado traerEmpleado(int _idEmpleado)
        {
            /*
             * Recupera UN empleado por ID
             */
            return oEmpleadoDao.traerEmpleado(_idEmpleado);

        }

        public bool existeEmpleado(string nomEmpl, string nroDoc
            , int idTipoDoc, int idFarm)
        {
            /*
             * Determina si, con los datos recibidos, 
             * ya existe un empleado con exactamente
             * los mismos.
             * 
             * Devuelve:
             * -TRUE: si ya existe.
             * -FALSE: Si no existe.
             */
            object emplEncontrado = oEmpleadoDao.buscarEmpleado(nomEmpl, nroDoc, idTipoDoc, idFarm);
            if (emplEncontrado is null)
                return false;
            else
                return true;

        }

        internal object obtenerDatosReporte(string nomEmpleado, string idFarmacia)
        {
            /*
             * Recupera los datos en DataTable 
             * para el ReportViewer.
             */
            return this.oEmpleadoDao.obtenerDatosReporte(nomEmpleado, idFarmacia);
        }

        internal List<Empleado> recuperarEmpleadoCParametros(string nomEmpl, string nroDoc, int idTipoDoc, string nomFarm)
        {
            /*
             * Recupera los empleados con los 
             * parámetros recibidos.
             */
            return oEmpleadoDao.recuperarConParam(nomEmpl, nroDoc, idTipoDoc, nomFarm);
        }

        public bool crearEmpleado(Empleado oEmpleado)
        {
            /*
             * Persiste un nuevo empleado,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return validar( oEmpleadoDao.insertarEmpleado(oEmpleado) );

        }

        public bool actualizarEmpleado(Empleado oEmpleado)
        {
            /*
             * Cambia los datos del empleado recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar( oEmpleadoDao.actualizarEmpleado(oEmpleado) );
        }

        public bool cambiarEstado(Empleado oEmpleado)
        {
            /*
             * Deshabilita el empleado recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return validar( this.oEmpleadoDao.cambiarEstado(oEmpleado) );
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
