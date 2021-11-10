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

namespace FarmaTown.Presentacion.Reportes.Empleados
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

        private void frmReporteEmpleados_Load(object sender, EventArgs e)
        {
            this.rpvEmpleados.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nom = this.txtbNombre.Text;

            this.rpvEmpleados.LocalReport.DataSources.Clear();
            Object tabla = oEmpleado.obtenerDatosReporte(nom);
            ReportDataSource rprtDTSource = new ReportDataSource("DSEmpleados", tabla);

            this.rpvEmpleados.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvEmpleados.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }
    }
}
