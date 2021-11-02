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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dtpFechaDesde.Value;
            DateTime fechaHasta = this.dtpFechaHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("Fechas inválidas!", "Información"
                           ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int indexFarm = this.cboFarmacias.SelectedIndex;
                int indexLocalidad = this.cboLocalidades.SelectedIndex;


                this.rpvVentas.LocalReport.DataSources.Clear();
                Object tabla = oVenta.obtenerDatosReporte(fechaDesde, fechaHasta
                    , indexFarm, indexLocalidad, 1);
                ReportDataSource rprtDTSource = new ReportDataSource("DSVentas", tabla);

                this.rpvVentas.LocalReport.DataSources.Add(rprtDTSource);
                this.rpvVentas.RefreshReport();
            }
            

        }
    }
}
