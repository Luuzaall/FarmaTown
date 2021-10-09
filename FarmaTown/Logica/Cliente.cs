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

        public List<Cliente> recuperarTodos(bool esCBorrados)
        {
            return this.oClienteDao.recuperarTodos(esCBorrados);
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

        public bool existe(int idTipoDoc, string nroDoc)
        {
            Cliente resultado = oClienteDao.recuperar(idTipoDoc, nroDoc);

            if (resultado is null)
                return false;
            else
                return true;
        }

        public bool crear(Cliente oCliente)
        {
            return validar( oClienteDao.insertar(oCliente) );
        }

        public bool actualizar(Cliente oCliente)
        {
            return validar(oClienteDao.actualizar(oCliente));
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
        public bool existeCliente(string nomCliente, string apellido, string calle, string nroDoc, int idTipoDoc, int idBarrio)
        {
            object clienteEncontrado = oClienteDao.buscarCliente(nomCliente,apellido, calle, nroDoc, idTipoDoc, idBarrio);
            if (clienteEncontrado is null)
                return false;
            else
                return true;

        }
    }
}
