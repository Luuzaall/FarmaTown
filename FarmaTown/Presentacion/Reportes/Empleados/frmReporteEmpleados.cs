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
            ComboBoxService.cargarCombo(this.cboFarmacias, oFarmacia.recuperarTodos()
                , "Nombre", "IdFarmacia");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nomEmpleado = this.txtbNombre.Text;
            int indexFarmacia = this.cboFarmacias.SelectedIndex;
            string idFarmacia;
            string nomFarmacia = "No Filtrado";

            if (indexFarmacia == -1)
            {
                idFarmacia = "-1";
            }
            else
            {
                idFarmacia = this.cboFarmacias.SelectedValue.ToString();
                nomFarmacia = this.cboFarmacias.Text;
            }

            this.rpvEmpleados.LocalReport.DataSources.Clear();
            Object tabla = oEmpleado.obtenerDatosReporte(nomEmpleado, idFarmacia);
            ReportDataSource rprtDTSource = new ReportDataSource("DSEmpleados", tabla);


            //Crea las variables para los parámetros que recibirá 
            // el reporte.
            var paramFarmacia = new ReportParameter("farmacia", nomFarmacia);
            var paramNomEmpleado = new ReportParameter("nomEmpleado", nomEmpleado);

            var parametros = new List<ReportParameter>();
            parametros.Add(paramFarmacia);
            parametros.Add(paramNomEmpleado);

            this.rpvEmpleados.RefreshReport();

            this.rpvEmpleados.LocalReport.DataSources.Add(rprtDTSource);
            //Le pasa los parámetros del formulario útiles 
            //Para agregarlo en el reporte.
            this.rpvEmpleados.LocalReport.SetParameters(parametros);

            this.rpvEmpleados.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }
    }
}
