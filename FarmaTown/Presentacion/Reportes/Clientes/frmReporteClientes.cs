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

namespace FarmaTown.Presentacion.Reportes.Clientes
{
    public partial class frmReporteClientes : Form
    {
        Cliente oCliente;
        Barrio oBarrio;
        Localidad oLocalidad;
        public frmReporteClientes()
        {
            InitializeComponent();
            oCliente = new Cliente();
            oBarrio = new Barrio();
            oLocalidad = new Localidad();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            this.rpvClientes.RefreshReport();

            ComboBoxService.cargarCombo(this.cboBarrios, oBarrio.recuperarTodos(false)
                , "Nombre", "IdBarrio");
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos()
                , "Nombre", "IdLocalidad");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Inicializa los filtros del generador
             * del Reporte.
             */
            this.cboBarrios.SelectedIndex = -1;
            this.cboLocalidades.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int indexBarrio = this.cboBarrios.SelectedIndex;
            int indexLocalidad = this.cboLocalidades.SelectedIndex;
            string idBarrio;
            string idLocalidad;

            if (indexBarrio == -1)
                idBarrio = "-1";
            else
                idBarrio = this.cboBarrios.SelectedValue.ToString();

            if (indexLocalidad == -1)
                idLocalidad = "-1";
            else
                idLocalidad = this.cboLocalidades.SelectedValue.ToString();



            this.rpvClientes.LocalReport.DataSources.Clear();
            Object tabla = oCliente.obtenerDatosReporte(idBarrio, idLocalidad);
            ReportDataSource rprtDTSource = new ReportDataSource("DSClientes", tabla);

            this.rpvClientes.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvClientes.RefreshReport();
        }
    }
}
