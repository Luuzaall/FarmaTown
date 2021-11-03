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
    public partial class frmReporteVentasxFarmacia : Form
    {
        Venta oVenta;

        public frmReporteVentasxFarmacia()
        {
            InitializeComponent();
            oVenta = new Venta();

        }

        private void frmReporteVentasxFarmacia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.Farmacias' Puede moverla o quitarla según sea necesario.
            this.farmaciasTableAdapter.Fill(this.dataSetGeneral.Farmacias);
            this.rpvVentaxFarmacia.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (this.fechaDesdePicker.Value > this.fechaHastaPicker.Value)
            {
                MessageBox.Show("Fechas inválidas!", "Información"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int oFarm = -1;
            int oLoc = -1;

            Object tabla = oVenta.obtenerDatosReporte(this.fechaDesdePicker.Value, this.fechaHastaPicker.Value, oFarm, oLoc, 3);
            ReportDataSource rprtDTSource = new ReportDataSource("Farmacia", tabla);

            rpvVentaxFarmacia.LocalReport.DataSources.Clear();
            rpvVentaxFarmacia.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvVentaxFarmacia.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
