using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public Barrio Barrio { get; set; }
        public bool Borrado { get; set; }

        ClienteDao oClienteDao;

        public Cliente()
        {
            oClienteDao = new ClienteDao();
        }

        public List<Cliente> recuperarTodos()
        {
            /*
             * Recupera todos los clientes sin parámetros.
             */
            return this.oClienteDao.recuperarTodos();
        }

        public List<Cliente> recuperarConParam(string nombre, string apellido
            , string nroDoc, int idTipoDoc)
        {
            /*
             * Recpera todos los clientes con 
             * los parámetros recibidos
             */
            return oClienteDao.recuperarConParam(nombre, apellido, nroDoc, idTipoDoc);
        }

        public Cliente traerCliente(int idCliente)
        {
            /*
             * Recuper UN cliente por ID.
             */
            return oClienteDao.traer(idCliente);
        }

        public bool crear(Cliente oCliente)
        {
            /*
             * Persiste un nuevo cliente,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return validar( oClienteDao.insertar(oCliente) );
        }

        public bool actualizar(Cliente oCliente)
        {
            /*
             * Cambia los datos del cliente recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return validar(oClienteDao.actualizar(oCliente));
        }

        public bool cambiarEstado(Cliente oCliente)
        {
            /*
             * Deshabilita el cliente recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return validar(oClienteDao.cambiarEstado(oCliente));
        }
        public object obtenerDatosReporte(string idBarrio, string idLocalidad)
        {
            /*
             * Recupera los datos en formato
             * DataTable para entregarlos al ReportViewer
             */
            return oClienteDao.obtenerDatosReporte(idBarrio, idLocalidad);
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
        public bool existeCliente(string nomCliente, string nroDoc
            , int idTipoDoc, int idBarrio)
        {
            /*
             * Con los datos recibidos, determina
             * si el cliente ya existe.
             * 
             * Devuelve:
             * -TRUE: Si el cliente EXISTE.
             * -FALSE: Si el cliente NO existe.
             */
            object clienteEncontrado = oClienteDao.buscarCliente(nomCliente, nroDoc
                , idTipoDoc, idBarrio);
            if (clienteEncontrado is null)
                return false;
            else
                return true;

        }
    }
}
