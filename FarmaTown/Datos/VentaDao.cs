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
        public bool crear(Venta nuevaVenta)
        {
            DBHelper helper = DBHelper.getDBHelper();
            try
            {
                helper.open();
                helper.beginTransaction();

                string query = "INSERT INTO Ventas" +
                                "(idFarmacia" +
                                ", nroFactura" +
                                ", idCliente" +
                                ", fechaFactura" +
                                ", idEmpleado" +
                                ", idTipoFactura" +
                                ", idMedioPago" +
                                ", borrado)" +
                            " VALUES" +
                                "( @idFarmacia" +
                                ", @nroFact" +
                                ", @idCliente" +
                                ", @fechaFact" +
                                ", @idEmpleado" +
                                ", @tipoFact" +
                                ", @idTipoPago" +
                                ", @borrado)";

                var parametros = new Dictionary<string, object>();
                parametros.Add("idFarmacia", nuevaVenta.Farmacia.IdFarmacia);
                parametros.Add("nroFact", nuevaVenta.NroFactura);
                parametros.Add("idCliente", nuevaVenta.Cliente.IdCliente);
                parametros.Add("fechaFact", nuevaVenta.FechaFactura);
                parametros.Add("idEmpleado", nuevaVenta.Empleado.IdEmpleado);
                parametros.Add("tipoFact", nuevaVenta.TipoFactura.IdTipofactura);
                parametros.Add("idTipoPago", nuevaVenta.MedioPago.idMedioPago);
                parametros.Add("borrado", 0);
                helper.ejecutarSQLCONPARAMETROS(query, parametros);

                var newId = helper.consultaSQLScalar(" SELECT @@IDENTITY");
                nuevaVenta.IdVenta = Convert.ToInt32(newId);

                // Dentro de la transacción, se genera
                // el nro factura y se lo ubica en la tabla venta.
                string idVenta = nuevaVenta.IdVenta.ToString();
                string idFarma = nuevaVenta.Farmacia.IdFarmacia.ToString();

                int diferencia = 6 - idVenta.Length;
                int nroFact = int.Parse(idFarma + string.Concat(Enumerable.Repeat("0", diferencia)) + idVenta);

                string modifyQuery = " UPDATE Ventas" +
                    " SET nroFactura = @nroFact" + 
                    " WHERE idVenta = " + int.Parse(idVenta);

                var paramNroFact = new Dictionary<string, object>();
                paramNroFact.Add("nroFact", nroFact);

                helper.ejecutarSQLCONPARAMETROS(modifyQuery, paramNroFact);

                nuevaVenta.NroFactura = nroFact;

                foreach (var itemVenta in nuevaVenta.Detalles)
                {
                    string queryDetalle = string.Concat(" INSERT INTO [dbo].[DetalleVentas]   ",
                                                        "           ([idVenta]              ",
                                                        "           ,[idMedicamento]        ",
                                                        "           ,[cantidad]             ",
                                                        "           ,[precio]               ",
                                                        "           ,[reintegro]            ",
                                                        "           ,[idOS]                 ",
                                                        "           ,[borrado] )             ",
                                                        "     VALUES                        ",
                                                        "           (@idVenta               ",
                                                        "           ,@idMedicamento         ",
                                                        "           ,@cantidad              ",
                                                        "           ,@precio                ",
                                                        "           ,@reintegro             ",
                                                        "           ,@idOS                ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("idVenta", nuevaVenta.IdVenta);
                    paramDetalle.Add("idMedicamento", itemVenta.Medicamento.IdMedicamento);
                    paramDetalle.Add("cantidad", itemVenta.Cantidad);
                    paramDetalle.Add("precio", itemVenta.PrecioUnitario);
                    paramDetalle.Add("reintegro", itemVenta.Reintegro);
                    paramDetalle.Add("idOS", itemVenta.ObraSocial.IdOS);
                    paramDetalle.Add("borrado", 0);

                    helper.ejecutarSQLCONPARAMETROS(queryDetalle, paramDetalle);
                }
                helper.commit();

            }
            catch (Exception ex)
            {
                helper.rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                helper.close();

            }
            return true;

        }

        public Object obtenerDatosReporte(DateTime fechaDesde, DateTime fechaHasta
                , String idFarm, String idLocalidad)
        {
            string query = "SELECT v.idVenta" +
                    ", v.nroFactura" +
                    ", f.nombre as farmacia" +
                    ", CONVERT(varchar(10), v.fechaFactura, 103) as fecha" +
                    ", e.nombre as empleado" +
                    ", t.nombre as tipoFactura" +
                    ", m.nombre as medioPago" +
                    ", o.nombre as obraSocial" +
                    ", l.nombre as localidad" +
                    ", ROUND(SUM(precio), 2) as 'Total'" +
                    " FROM Ventas v" +
                    " INNER JOIN DetalleVentas d ON d.idVenta = v.idVenta" +
                    " INNER JOIN ObrasSociales o ON d.idOS = o.idOS" +
                    " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                    " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                    " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                    " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                    " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                    " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                    " WHERE v.fechaFactura BETWEEN CONVERT(DATE,'" + fechaDesde + "',105)" +
                        " AND CONVERT(DATE,'" + fechaHasta + "',105)";

            if (idFarm != "-1")
                query += " AND f.idFarmacia = " + idFarm;
            if (idLocalidad != "-1")
                query += " AND l.idLocalidad = " + idLocalidad;

            query += " GROUP BY v.idVenta" +
                        " , f.nombre" +
                        " , v.fechaFactura" +
                        " , e.nombre" +
                        " , t.nombre" +
                        " , m.nombre" +
                        " , v.nroFactura" +
                        ", o.nombre" +
                        ", l.nombre";
            if (reporte == 1)
            {
                string query = "SELECT v.idVenta" +
                        ", v.nroFactura" +
                        ", f.nombre as farmacia" +
                        ", CONVERT(varchar(10), v.fechaFactura, 103) as fecha" +
                        ", e.nombre as empleado" +
                        ", t.nombre as tipoFactura" +
                        ", m.nombre as medioPago" +
                        ", ROUND(SUM(precio), 2) as 'Total'" +
                        " FROM Ventas v" +
                        " INNER JOIN DetalleVentas d ON d.idVenta = v.idVenta" +
                        " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                        " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                        " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                        " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                        " WHERE v.fechaFactura BETWEEN CONVERT(DATE,'" + fechaDesde + "',105)" +
                            " AND CONVERT(DATE,'" + fechaHasta + "',105)" +
                        " GROUP BY v.idVenta" +
                            " , f.nombre" +
                            " , v.fechaFactura" +
                            " , e.nombre" +
                            " , t.nombre" +
                            " , m.nombre" +
                            " , v.nroFactura";


                return DBHelper.getDBHelper().consultaSQL(query);
            }
            else if (reporte == 2)
            {
                string query = "SELECT" +
                    " tm.descripcion" +
                    " FROM Ventas v" +
                    " INNER JOIN DetalleVentas d ON d.idVenta = v.idVenta" +
                    " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                    " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                    " INNER JOIN Medicamentos m ON d.idMedicamento = m.idMedicamento" +
                    " INNER JOIN TiposMedicamento tm ON m.tipoMedicamento = tm.idTipo" +
                    " WHERE v.fechaFactura BETWEEN CONVERT(DATE,'" + fechaDesde + "',105)" +
                    " AND CONVERT(DATE,'" + fechaHasta + "',105)";
                    
                if (!(indexFarm == -1))
                {
                    query = query + " AND v.idFarmacia = " + indexFarm;
                }

                if (!(indexLocalidad == -1))
                {
                    query = query + " AND b.idLocalidad = " + indexLocalidad;
                }

                return DBHelper.getDBHelper().consultaSQL(query);
            }
            else if (reporte == 3)
            {
                string query = "SELECT f.nombre" +
                    " FROM Ventas v" +
                    " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                    " WHERE v.fechaFactura BETWEEN CONVERT(DATE,'" + fechaDesde + "',105)" +
                    " AND CONVERT(DATE,'" + fechaHasta + "',105)";

                return DBHelper.getDBHelper().consultaSQL(query);
            }

             return null;
           
        }
    }
}
