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

namespace FarmaTown.Presentacion.Reportes.ObrasSociales
{
    public partial class frmReporteObrasSociales : Form
    {
        ObraSocial oObraSocial;

        public frmReporteObrasSociales()
        {
            oObraSocial = new ObraSocial();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rpvOS.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.rpvOS.LocalReport.DataSources.Clear();
            Object tabla = oObraSocial.obtenerDatosReporte();
            ReportDataSource rprtDTSource = new ReportDataSource("DSObrasSociales", tabla);
            this.rpvOS.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvOS.RefreshReport();

        }

        private void rpvOS_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.rpvOS.RefreshReport();
        }
    }
}
