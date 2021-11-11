using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class DetalleVentaDao
    {
        MedicamentoDao oMedicamentoDao;
        EstadoDao oEstadoDao;

        public DetalleVentaDao()
        {
            oMedicamentoDao = new MedicamentoDao();
            oEstadoDao = new EstadoDao();
        }
        public List<DetalleVenta> recuperarTodos(int idVenta)
        {
            string query = "SELECT d.idVenta" +
                " , m.nombre as nomMedicamento" +
                " , m.idMedicamento" +
                " , d.cantidad" +
                " , d.precio" +
                " , d.idEstado" +
                " FROM DetalleVentas d" +
                " INNER JOIN Medicamentos m ON d.idMedicamento = m.idMedicamento" +
                " WHERE d.idVenta = " + idVenta +
                " AND d.borrado = 0";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);

        }

        private List<DetalleVenta> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<DetalleVenta> lista = new List<DetalleVenta>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        private DetalleVenta objectMapping(DataRow row)
        {
            string nomMedicamento = row["nomMedicamento"].ToString();
            DetalleVenta oDetalleVenta = new DetalleVenta
            {
                Medicamento = this.oMedicamentoDao.obtenerMedicamentoPorNom(nomMedicamento),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                PrecioUnitario = Convert.ToDouble(row["precio"].ToString()),
                EstadoActual = this.oEstadoDao.traer(Convert.ToInt32(row["idEstado"])),
            };
            return oDetalleVenta;
        }

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
                                ", idOS" +
                                ", idEstado" +
                                ", borrado)" +
                            " VALUES" +
                                "( @idFarmacia" +
                                ", @nroFactura" +
                                ", @idCliente" +
                                ", @fechaFact" +
                                ", @idEmpleado" +
                                ", @tipoFact" +
                                ", @idTipoPago" +
                                ", @idOS" +
                                ", @idEstado" +
                                ", @borrado)";

                var parametros = new Dictionary<string, object>();
                parametros.Add("idFarmacia", nuevaVenta.Farmacia.IdFarmacia);
                parametros.Add("nroFactura", 0);
                parametros.Add("idCliente", nuevaVenta.Cliente.IdCliente);
                parametros.Add("fechaFact", nuevaVenta.FechaFactura);
                parametros.Add("idEmpleado", nuevaVenta.Empleado.IdEmpleado);
                parametros.Add("tipoFact", nuevaVenta.TipoFactura.IdTipofactura);
                parametros.Add("idTipoPago", nuevaVenta.MedioPago.idMedioPago);
                parametros.Add("idOS", nuevaVenta.ObraSocial.IdOS);
                parametros.Add("idEstado", 1);
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

                nuevaVenta.NroFactura = Convert.ToString(nroFact);

                foreach (var itemVenta in nuevaVenta.Detalles)
                {
                    string queryDetalle = string.Concat(" INSERT INTO [dbo].[DetalleVentas]   ",
                                                        "           ([idVenta]              ",
                                                        "           ,[idMedicamento]        ",
                                                        "           ,[cantidad]             ",
                                                        "           ,[precio]               ",
                                                        "           ,[reintegro]             ",
                                                        "           ,[borrado] )             ",
                                                        "     VALUES                        ",
                                                        "           (@idVenta               ",
                                                        "           ,@idMedicamento         ",
                                                        "           ,@cantidad              ",
                                                        "           ,@precio                ",
                                                        "           ,@reintegro             ",
                                                        "           ,@borrado)              ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("idVenta", nuevaVenta.IdVenta);
                    paramDetalle.Add("idMedicamento", itemVenta.Medicamento.IdMedicamento);
                    paramDetalle.Add("cantidad", itemVenta.Cantidad);
                    paramDetalle.Add("precio", itemVenta.PrecioUnitario);
                    paramDetalle.Add("reintegro", itemVenta.Reintegro);
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
    }
}
