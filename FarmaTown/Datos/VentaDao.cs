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
                                ", borrado)" +
                            " VALUES" +
                                "( @idFarmacia" +
                                ", @nroFact" +
                                ", @idCliente" +
                                ", @fechaFact" +
                                ", @idEmpleado" +
                                ", @tipoFact" +
                                ", @borrado)";

                var parametros = new Dictionary<string, object>();
                parametros.Add("idFarmacia", nuevaVenta.Farmacia.IdFarmacia);
                parametros.Add("nroFact", nuevaVenta.IdVenta);
                parametros.Add("idCliente", nuevaVenta.Cliente.IdCliente);
                parametros.Add("fechaFact", nuevaVenta.FechaFactura);
                parametros.Add("idEmpleado", nuevaVenta.Empleado.IdEmpleado);
                parametros.Add("tipoFact", nuevaVenta.TipoFactura.IdTipofactura);
                parametros.Add("borrado", 0);
                helper.ejecutarSQLCONPARAMETROS(query, parametros);

                var newId = helper.consultaSQLScalar(" SELECT @@IDENTITY");
                nuevaVenta.IdVenta = Convert.ToInt32(newId);

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

                string idVenta = nuevaVenta.IdVenta.ToString();
                string idFarma = nuevaVenta.Farmacia.IdFarmacia.ToString();

                int diferencia = 6 - idVenta.Length;
                int nroFact = int.Parse(idFarma + string.Concat(Enumerable.Repeat("0", diferencia)) + idVenta);

                string modifyQuery = " UPDATE Ventas" +
                    " SET nroFactura = " + nroFact +
                    " WHERE idVenta = " + int.Parse(idVenta);

                helper.ejecutarSQL(modifyQuery);



            }
            return true;

        }
    }
}
