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

namespace FarmaTown.Presentacion.Reportes
{
    public partial class frmListadoVentas : Form
    {
        Venta oVenta;
        Farmacia oFarmacia;
        Localidad oLocalidad;
        public frmListadoVentas()
        {
            InitializeComponent();
            oVenta = new Venta();
            oFarmacia = new Farmacia();
            oLocalidad = new Localidad();
        }

        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            this.rpvVentas.RefreshReport();
            this.dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            this.dtpFechaHasta.Value = DateTime.Today;

            ComboBoxService.cargarCombo(this.cboFarmacias, oFarmacia.recuperarTodos()
                , "Nombre", "IdFarmacia");
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos(false)
                , "Nombre", "IdLocalidad");
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
                String idFarm;
                String idLocalidad;

                if (indexFarm == -1)
                    idFarm = "-1";
                else
                    idFarm = this.cboFarmacias.SelectedValue.ToString();

                if (indexLocalidad == -1)
                    idLocalidad = "-1";
                else
                    idLocalidad = this.cboLocalidades.SelectedValue.ToString();



                this.rpvVentas.LocalReport.DataSources.Clear();
                Object tabla = oVenta.obtenerDatosReporte(fechaDesde, fechaHasta
                    , idFarm, idLocalidad);
                ReportDataSource rprtDTSource = new ReportDataSource("DSVentas", tabla);

                this.rpvVentas.LocalReport.DataSources.Add(rprtDTSource);
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
        }

    }
}
