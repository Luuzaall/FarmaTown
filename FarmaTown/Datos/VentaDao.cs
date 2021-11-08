using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class VentaDao
    {
        DetalleVentaDao oDetalle;
        FarmaciaDao oFarmaciaDao;
        ClienteDao oClienteDao;
        EmpleadoDao oEmpleadoDao;
        TipoFacturaDao oTipoFacturaDao;
        MedioPagoDao oMedioPagoDao;
        ObraSocialDao oObraSocialDao;
        EstadoDao oEstadoDao;

        public VentaDao()
        {
            oDetalle = new DetalleVentaDao();
            oFarmaciaDao = new FarmaciaDao();
            oClienteDao = new ClienteDao();
            oEmpleadoDao = new EmpleadoDao();
            oTipoFacturaDao = new TipoFacturaDao();
            oMedioPagoDao = new MedioPagoDao();
            oObraSocialDao = new ObraSocialDao();
            oEstadoDao = new EstadoDao();
        }

        public List<Venta> recuperarTodos()
        {
            string query =" SELECT v.idVenta" +
                    " , f.nombre as nomFarmacia" +
                    " , f.idFarmacia" +
                    " , v.nroFactura" +
                    " , c.idCliente " +
                    ", v.fechaFactura" +
                    ", e.idEmpleado " +
                    ", t.idTipoFactura " +
                    ", m.idMedioPago " +
                    ", b.idBarrio " +
                    ", v.idOS " +
                    ", v.idEstado" +
                    " FROM Ventas v" +
                    " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                    " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                    " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                    " INNER JOIN Clientes c ON v.idCliente = c.idCliente" +
                    " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                    " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                    " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                    " WHERE v.borrado = 0; ";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
               
        }

        internal List<Venta> recuperarVentasConParam(string idFarm, string idLocalidad
            , string idEmpleado, string idObraSocial, string fechaDesde
            , string fechaHasta)
        {
            string query = "SELECT v.idVenta" +
                    " , f.nombre as nomFarmacia" +
                    " , f.idFarmacia" +
                    " , v.nroFactura" +
                    " , c.idCliente " +
                    ", v.fechaFactura" +
                    ", e.idEmpleado " +
                    ", t.idTipoFactura " +
                    ", m.idMedioPago " +
                    ", b.idBarrio " +
                    ", v.idOS" +
                    ", v.idEstado" +
                    " FROM Ventas v" +
                    " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                    " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                    " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                    " INNER JOIN Clientes c ON v.idCliente = c.idCliente" +
                    " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                    " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                    " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                    " WHERE v.borrado = 0 " +
                    " AND v.fechaFactura BETWEEN CONVERT(DATE, '" + fechaDesde + "', 105)" +
                    " AND CONVERT(DATE,'" + fechaHasta + "',105)";
            if (idFarm != "-1")
                query += " AND f.idFarmacia = " + idFarm;
            if (idLocalidad != "-1")
                query += " AND l.idLocalidad = " + idLocalidad;
            if (idEmpleado != "-1")
                query += " AND e.idEmpleado = " + idEmpleado;
            if (idObraSocial != "-1")
                query += " AND v.idOS = " + idObraSocial;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);

        }

        internal bool cancelada(Venta oVenta)
        {
            DBHelper helper = DBHelper.getDBHelper();
            try
            {
                helper.open();
                helper.beginTransaction();

                string modifyQuery = " UPDATE Ventas" +
                    " SET idEstado = @idEstado" +
                    " WHERE idVenta = " + oVenta.IdVenta;

                var paramNroFact = new Dictionary<string, object>();
                paramNroFact.Add("idEstado", 2);

                helper.ejecutarSQLCONPARAMETROS(modifyQuery, paramNroFact);

                foreach (var itemVenta in oVenta.Detalles)
                {
                    string modifyQueryDetalle = " UPDATE DetalleVentas" +
                    " SET idEstado = @idEstado" +
                    " WHERE idVenta = " + oVenta.IdVenta;

                    var paramDetalle = new Dictionary<string, object>();
                    
                    paramDetalle.Add("idEstado", 2);

                    helper.ejecutarSQLCONPARAMETROS(modifyQueryDetalle, paramDetalle);
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

        internal Venta traer(string nroVenta)
        {
            string query = "SELECT v.idVenta" +
                   " , f.nombre as nomFarmacia" +
                   " , f.idFarmacia" +
                   " , v.nroFactura" +
                   " , c.idCliente " +
                   ", v.fechaFactura" +
                   ", e.idEmpleado " +
                   ", t.idTipoFactura " +
                   ", m.idMedioPago " +
                   ", b.idBarrio " +
                   ", v.idOS" +
                   ", v.idEstado" +
                   " FROM Ventas v" +
                   " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                   " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                   " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                   " INNER JOIN Clientes c ON v.idCliente = c.idCliente" +
                   " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                   " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                   " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                   " WHERE v.borrado = 0 " +
                   " AND v.idVenta = " + nroVenta;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return objectMapping(tabla.Rows[0]);
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
                                                        "           ,@borrado)               ");

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

        public Object obtenerDatosReporte(DateTime fechaDesde, DateTime fechaHasta
                , String idFarm, String idLocalidad, string idEmpleado
            , string idObraSocial)
        {
            string query = 
                "SELECT v.idVenta" +
                ", v.nroFactura" +
                ", f.nombre as farmacia" +
                ", CONVERT(varchar(10), v.fechaFactura, 103) as fecha" +
                ", e.nombre as empleado" +
                ", t.nombre as tipoFactura" +
                ", m.nombre as medioPago" +
                ", o.nombre as obraSocial" +
                ", l.nombre as localidad" +
                ", tp.descripcion as tipoMedicamento" +
                ", v.idEstado " +
                ", ROUND(SUM(precio), 2) as 'Total'" +
                " FROM Ventas v" +
                " INNER JOIN DetalleVentas d ON d.idVenta = v.idVenta" +
                " INNER JOIN ObrasSociales o ON v.idOS = o.idOS" +
                " INNER JOIN Farmacias f ON v.idFarmacia = f.idFarmacia" +
                " INNER JOIN Barrios b ON f.idBarrio = b.idBarrio" +
                " INNER JOIN Localidades l ON b.idLocalidad = l.idLocalidad" +
                " INNER JOIN Empleados e ON v.idEmpleado = e.idEmpleado" +
                " INNER JOIN TiposFactura t ON v.idTipoFactura = t.idTipoFactura" +
                " INNER JOIN MediosPago m ON v.idMedioPago = m.idMedioPago" +
                " INNER JOIN Medicamentos med ON d.idMedicamento = med.idMedicamento" +
                " INNER JOIN TiposMedicamento tp ON med.tipoMedicamento = tp.idTipo" +
                " WHERE v.fechaFactura BETWEEN CONVERT(DATE,'" + fechaDesde + "',105)" +
                    " AND CONVERT(DATE,'" + fechaHasta + "',105)";

            if (idFarm != "-1")
                query += " AND f.idFarmacia = " + idFarm;
            if (idLocalidad != "-1")
                query += " AND l.idLocalidad = " + idLocalidad;
            if (idEmpleado != "-1")
                query += " AND e.idEmpleado = " + idEmpleado;
            if (idObraSocial != "-1")
                query += " AND o.idOS = " + idObraSocial;
            query += " GROUP BY v.idVenta" +
                        " , f.nombre" +
                        " , v.fechaFactura" +
                        " , e.nombre" +
                        " , t.nombre" +
                        " , m.nombre" +
                        " , v.nroFactura" +
                        ", o.nombre" +
                        ", l.nombre" +
                        ", tp.descripcion";


            return DBHelper.getDBHelper().consultaSQL(query);
        }

        private List<Venta> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
             */
            List<Venta> lista = new List<Venta>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }
        private Venta objectMapping(DataRow row)
        {
            int idFarmacia = Convert.ToInt32(row["idFarmacia"].ToString());
            int idCliente = Convert.ToInt32(row["idCliente"].ToString());
            int idEmpleado = Convert.ToInt32(row["idEmpleado"].ToString());
            int idTipoFactura = Convert.ToInt32(row["idTipoFactura"].ToString());
            int idMedioPago = Convert.ToInt32(row["idMedioPago"].ToString());
            int idOS = Convert.ToInt32(row["idOS"].ToString());
            int idEstado = Convert.ToInt32(row["idEstado"].ToString());

            int idVenta = Convert.ToInt32(row["idVenta"].ToString());
            List<DetalleVenta> listaDetalles = oDetalle.recuperarTodos(idVenta);

            

            Venta oVenta = new Venta
            {
                IdVenta = Convert.ToInt32(row["idVenta"].ToString()),
                Detalles = listaDetalles,
                Farmacia = this.oFarmaciaDao.traerFarmacia(idFarmacia),
                NroFactura = row["nroFactura"].ToString(),
                Cliente = this.oClienteDao.traer(idCliente),
                ObraSocial = this.oObraSocialDao.traer(idOS),
                FechaFactura = Convert.ToDateTime(row["fechaFactura"].ToString()),
                Empleado = this.oEmpleadoDao.traerEmpleado(idEmpleado),
                TipoFactura = this.oTipoFacturaDao.traer(idTipoFactura),
                MedioPago = this.oMedioPagoDao.traer(idMedioPago),
                EstadoActual = oEstadoDao.traer(idEstado),
            };
            return oVenta;
        }
    }
}
