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
            return this.oClienteDao.recuperarTodos();
        }

        public List<Cliente> recuperarConParam(string nombre, string apellido
            , string nroDoc, int idTipoDoc)
        {
            return oClienteDao.recuperarConParam(nombre, apellido, nroDoc, idTipoDoc);
        }

        public Cliente traerCliente(int idCliente)
        {
            return oClienteDao.traer(idCliente);
        }

        public bool crear(Cliente oCliente)
        {
            return validar( oClienteDao.insertar(oCliente) );
        }

        public bool actualizar(Cliente oCliente)
        {
            return validar(oClienteDao.actualizar(oCliente));
        }

        public object obtenerDatosReporte(string idBarrio, string idLocalidad)
        {
            return oClienteDao.obtenerDatosReporte(idBarrio, idLocalidad);
        }

        public bool cambiarEstado(Cliente oCliente)
        {
            return validar(oClienteDao.cambiarEstado(oCliente));
        }

        private bool validar(int resultado)
        {
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
            object clienteEncontrado = oClienteDao.buscarCliente(nomCliente, nroDoc
                , idTipoDoc, idBarrio);
            if (clienteEncontrado is null)
                return false;
            else
                return true;

        }
    }
}
