using FarmaTown.Logica;
using FarmaTown.Presentacion.Servicios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Reportes.Ventas
{
    public partial class frmReporteVentas : Form
    {
        Venta oVenta;
        Farmacia oFarmacia;
        Localidad oLocalidad;
        Empleado oEmpleado;
        ObraSocial oObraSocial;
        public frmReporteVentas()
        {
            InitializeComponent();
            oVenta = new Venta();
            oFarmacia = new Farmacia();
            oLocalidad = new Localidad();
            oEmpleado = new Empleado();
            oObraSocial = new ObraSocial();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            this.rpvVentas.RefreshReport();
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today.AddDays(1);

            ComboBoxService.cargarCombo(this.cboFarmacias, oFarmacia.recuperarTodos()
                , "Nombre", "IdFarmacia");
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos()
                , "Nombre", "IdLocalidad");
            ComboBoxService.cargarCombo(this.cboEmpleados, oEmpleado.recuperarTodos()
                , "Nombre", "IdEmpleado");
            ComboBoxService.cargarCombo(this.cboObrasSociales, oObraSocial.recuperarTodos()
                , "Nombre", "IdOS");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dtpFechaDesde.Value;
            DateTime fechaHasta = this.dtpFechaHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Fecha desde es mayor que la fecha hasta.", "Información"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int indexFarm = this.cboFarmacias.SelectedIndex;
                int indexLocalidad = this.cboLocalidades.SelectedIndex;
                int indexEmpleado = this.cboEmpleados.SelectedIndex;
                int indexObraSocial = this.cboObrasSociales.SelectedIndex;

                string idFarm;
                string idLocalidad;
                string idEmpleado;
                string idObraSocial;

                string nomFarmacia = "No filtrado";
                string nomLocalidad = "No filtrado";
                string nomEmpleado = "No filtrado";
                string nomObraSocial = "No filtrado";

                if (indexFarm == -1)
                    idFarm = "-1";
                else
                {
                    idFarm = this.cboFarmacias.SelectedValue.ToString();
                    nomFarmacia = this.cboFarmacias.Text;
                }

                if (indexLocalidad == -1)
                    idLocalidad = "-1";
                else
                {
                    idLocalidad = this.cboLocalidades.SelectedValue.ToString();
                    nomLocalidad = this.cboLocalidades.Text;
                }

                if (indexEmpleado == -1)
                    idEmpleado = "-1";
                else
                {
                    idEmpleado = this.cboEmpleados.SelectedValue.ToString();
                    nomEmpleado = this.cboEmpleados.Text;
                }

                if (indexObraSocial == -1)
                    idObraSocial = "-1";
                else
                {
                    idObraSocial = this.cboObrasSociales.SelectedValue.ToString();
                    nomObraSocial = this.cboObrasSociales.Text;
                }


                this.rpvVentas.LocalReport.DataSources.Clear();
                Object tabla = oVenta.obtenerDatosReporte(fechaDesde, fechaHasta
                    , idFarm, idLocalidad, 1, idEmpleado, idObraSocial);
                ReportDataSource rprtDTSource = new ReportDataSource("DSVentas", tabla);

                //Crea las variables para los parámetros que recibirá 
                // el reporte.
                var paramFechaDesde = new ReportParameter("fechaDesde", fechaDesde.ToString("dd/MM/yyyy"));
                var paramFechaHasta = new ReportParameter("fechaHasta", fechaHasta.ToString("dd/MM/yyyy"));
                var paramLocalidad = new ReportParameter("localidad", nomLocalidad);
                var paramFarmacia = new ReportParameter("farmacia", nomFarmacia);
                var paramEmpleado = new ReportParameter("empleado", nomEmpleado);
                var paramObraSocial = new ReportParameter("obraSocial", nomObraSocial);

                var parametros = new List<ReportParameter>();
                parametros.Add(paramFechaDesde);
                parametros.Add(paramFechaHasta);
                parametros.Add(paramFarmacia);
                parametros.Add(paramLocalidad);
                parametros.Add(paramEmpleado);
                parametros.Add(paramObraSocial);

                this.rpvVentas.LocalReport.DataSources.Add(rprtDTSource);

                //Le pasa los parámetros del formulario útiles 
                //Para agregarlo en el reporte.
                this.rpvVentas.LocalReport.SetParameters(parametros);
                this.rpvVentas.RefreshReport();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Inicializa los filtros del generador
             * del Reporte.
             */
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cboFarmacias.SelectedIndex = -1;
            this.cboLocalidades.SelectedIndex = -1;
            this.cboEmpleados.SelectedIndex = -1;
            this.cboObrasSociales.SelectedIndex = -1;
        }
    }
}
