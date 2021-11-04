using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Farmacia Farmacia { get; set; }
        public int NroFactura { get; set; }
        public TipoFactura TipoFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public Empleado Empleado { get; set; }
        public MedioPago MedioPago { get; set; }
        public IList<DetalleVenta> Detalles { get; set; }

        //public bool Borrado { get; set; }

        VentaDao oVenta;
        public Venta()
        {
            oVenta = new VentaDao();
        }

        public bool crearVenta(Venta nuevaVenta)
        {
            return this.oVenta.crear(nuevaVenta);
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

        public Object obtenerDatosReporte(DateTime fechaDesde, DateTime fechaHasta
                , String idFarm, String idLocalidad, int reporte, string idEmpleado
            , string idObraSocial)
        {
            return this.oVenta.obtenerDatosReporte(fechaDesde, fechaHasta
                , idFarm, idLocalidad, reporte, idEmpleado, idObraSocial);
        }
    }
}
