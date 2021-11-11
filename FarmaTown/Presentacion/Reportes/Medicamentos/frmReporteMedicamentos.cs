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

namespace FarmaTown.Presentacion.Reportes.Medicamentos
{
    public partial class frmReporteMedicamentos : Form
    {
        Medicamento oMedicamento;
        TipoMedicamento oTipoMed;
        public frmReporteMedicamentos()
        {
            oMedicamento = new Medicamento();
            oTipoMed = new TipoMedicamento();
            InitializeComponent();
        }

        private void frmReporteMedicamentos_Load(object sender, EventArgs e)
        {
            this.rpvMedicamentos.RefreshReport();

            ComboBoxService.cargarCombo(this.cboTipoMed, oTipoMed.recuperarSoloUsadosMedicamentos()
                , "Descripcion", "IdTipo");
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int indexTipoMed = this.cboTipoMed.SelectedIndex;
            string idTipoMed;
            string nomTipo = "No Filtrado";
            int cantidadMinima = -1;
            int cantidadMaxima = -1;
            string cantMinStr = "No Filtrado";
            string cantMaxStr = "No Filtrado";

            if (indexTipoMed == -1)
                idTipoMed = "-1";
            else
            {
                idTipoMed = this.cboTipoMed.SelectedValue.ToString();
                nomTipo = this.cboTipoMed.Text;
            }

            if (!(this.txtbCantMin.Text == ""))
            {
                cantidadMinima = int.Parse(this.txtbCantMin.Text);
                cantMinStr = cantidadMinima.ToString();
            }
            if (!(this.txtbCantMax.Text == ""))
            {
                cantidadMaxima = int.Parse(this.txtbCantMax.Text);
                cantMaxStr = cantidadMaxima.ToString();
            }
            if (this.validarCampos(cantidadMinima, cantidadMaxima))
            {
                this.rpvMedicamentos.LocalReport.DataSources.Clear();
                Object tabla = oMedicamento.obtenerDatosReporte(cantidadMinima, cantidadMaxima, idTipoMed);
                ReportDataSource rprtDTSource = new ReportDataSource("DSMedicamentos", tabla);

                //Crea las variables para los parámetros que recibirá 
                // el reporte.
                var paramCantMin = new ReportParameter("cantidadMinima", cantMinStr);
                var paramCantMax = new ReportParameter("cantidadMaxima", cantMaxStr);
                var paramTipoMed = new ReportParameter("tipoMedicamento", nomTipo);

                var parametros = new List<ReportParameter>();
                parametros.Add(paramCantMin);
                parametros.Add(paramCantMax);
                parametros.Add(paramTipoMed);

                rpvMedicamentos.LocalReport.DataSources.Add(rprtDTSource);
                this.rpvMedicamentos.LocalReport.SetParameters(parametros);
                rpvMedicamentos.RefreshReport();
            }
            
        }

        private bool validarCampos(int cantidadMinima, int cantidadMaxima)
        {
            if (cantidadMaxima != -1 && cantidadMinima != -1)
            {
                if (cantidadMinima > cantidadMaxima)
                {
                    MessageBox.Show("¡El stock máximo debe ser mayor al mínimo!", "Información"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbCantMin.Text = "";
            this.txtbCantMax.Text = "";
            this.cboTipoMed.SelectedIndex = -1;
        }

        private void txtbStocks_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noLetras(e);
            TextBoxService.enter(this.btnGenerar, e);
        }
    }
}
