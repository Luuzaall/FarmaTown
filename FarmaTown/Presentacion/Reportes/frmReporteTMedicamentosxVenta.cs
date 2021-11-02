using FarmaTown.Logica;
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
    public partial class frmReporteTMedicamentosxVenta : Form
    {
        Venta oVenta;
        public frmReporteTMedicamentosxVenta()
        {
            InitializeComponent();
            oVenta = new Venta();
        }

        private void frmReporteTMedicamentosxVenta_Load(object sender, EventArgs e)
        {

            this.rpvMedicamentosxVenta.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            Object tabla = oVenta.obtenerDatosReporte(this.fechaDesdePicker.Value, this.fechaHastaPicker.Value, this.cboFarmacias.SelectedIndex, this.cboLocalidades.SelectedIndex, 2);
            ReportDataSource rprtDTSource = new ReportDataSource("DSTMedicamento", tabla);

            rpvMedicamentosxVenta.LocalReport.DataSources.Clear();
            rpvMedicamentosxVenta.LocalReport.DataSources.Add(rprtDTSource);
            rpvMedicamentosxVenta.LocalReport.Refresh();
        }
    }
}
