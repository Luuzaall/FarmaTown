using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class VentaDao
    {
        public int crear(Venta nuevaVenta)
        {
            string query = "INSERT INTO Ventas" +
                            "(idFarmacia" +
                            ", nroFactura" +
                            ", idCliente" +
                            ", fechaFactura" +
                            ", idEmpleado" +
                            ", tipoFactura" +
                            ", borrado)" +
                            " VALUES" +
                            "( '" + nuevaVenta.Farmacia.IdFarmacia + "'" +
                            ", '" + nuevaVenta.NroFactura + "'" +
                            ", '" + nuevaVenta.Cliente.IdCliente + "'" +
                            ", '" + nuevaVenta.FechaFactura + "'" +
                            ", '" + nuevaVenta.Empleado.IdEmpleado + "'" +
                            ", '" + nuevaVenta.TipoFactura + "'" +
                            ", 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }
    }
}
