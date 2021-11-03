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
    public partial class frmReporteEmpleados : Form
    {
        Farmacia oFarmacia;
        Empleado oEmpleado;
        public frmReporteEmpleados()
        {
            InitializeComponent();
            oFarmacia = new Farmacia();
            oEmpleado = new Empleado();
        }

        

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nom = this.txtbNombre.Text;

            this.rptEmpleados.LocalReport.DataSources.Clear();
            Object tabla = oEmpleado.obtenerDatosReporte(nom);
            ReportDataSource rprtDTSource = new ReportDataSource("DSEmpleados", tabla);

            this.rptEmpleados.LocalReport.DataSources.Add(rprtDTSource);
            this.rptEmpleados.RefreshReport();
        }

        private void frmReporteEmpleados_Load(object sender, EventArgs e)
        {
            this.rptEmpleados.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
