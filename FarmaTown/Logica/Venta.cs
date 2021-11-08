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
        public string NroFactura { get; set; }

        internal void setEstado(Cancelada nuevoEstado)
        {
            throw new NotImplementedException();
        }

        public TipoFactura TipoFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public Empleado Empleado { get; set; }
        public MedioPago MedioPago { get; set; }
        public IList<DetalleVenta> Detalles { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public Estado estadoActual { get; set; }

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

        public List<Venta> recuperarTodos()
        {
            return this.oVenta.recuperarTodos();
        }
        internal List<Venta> recuperarVentasConParam(string idFarm, string idLocalidad
            , string idEmpleado, string idObraSocial, string fechaDesde
            , string fechaHasta)
        {
            return this.oVenta.recuperarVentasConParam(idFarm, idLocalidad
                , idEmpleado, idObraSocial, fechaDesde, fechaHasta);
        }


        public Object obtenerDatosReporte(DateTime fechaDesde, DateTime fechaHasta
                , String idFarm, String idLocalidad, int reporte, string idEmpleado
            , string idObraSocial)
        {
            return this.oVenta.obtenerDatosReporte(fechaDesde, fechaHasta
                , idFarm, idLocalidad, reporte, idEmpleado, idObraSocial);
        }

        public List<double> obtenerTotales()
        {
            double totalConDescuento = 0;
            double totalSinDescuento = 0;
            foreach (DetalleVenta detalle in Detalles)
            {
                totalSinDescuento += detalle.PrecioUnitario;
                totalConDescuento += detalle.PrecioUnitario - (detalle.PrecioUnitario * detalle.Reintegro);
            }

            List<double> totales = new List<double>();
            totales.Add(Math.Round(totalSinDescuento, 2));
            totales.Add(Math.Round(totalConDescuento, 2));

            return totales;
        }

        internal void cancelada(Venta oVenta)
        {
            this.estadoActual.cancelada(this);
        }

        public void setEstado(Estado nuevoEstado)
        {
            estadoActual = nuevoEstado;
        }

        public Venta traer(string nroVenta)
        {
            return this.oVenta.traer(nroVenta);
        }
    }
}
