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
    public partial class frmReporteClientes : Form
    {
        Localidad oLocalidad;
        Barrio oBarrio;
        Cliente oCliente;
        public frmReporteClientes()
        {
            InitializeComponent();
            oLocalidad = new Localidad();
            oBarrio = new Barrio();
            oCliente = new Cliente();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            //Carga los combos
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos(false)
                , "Nombre", "IdLocalidad");
            ComboBoxService.cargarCombo(this.cboBarrios, oBarrio.recuperarTodos(false)
                , "Nombre", "IdBarrio");

            this.rpvClientes.RefreshReport();
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
            //Obtiene el valor correspondiete al valor de los combos.
            //Si no eligió alguno de los parámetros, lo genera igual,
            //sin considerar el filtro que falta.
            int indexLocalidad = this.cboLocalidades.SelectedIndex;
            int indexBarrio = this.cboBarrios.SelectedIndex;
            string idLocalidad;
            string idBarrio;

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
