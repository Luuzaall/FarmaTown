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

namespace FarmaTown.Presentacion.Reportes.Medicamentos
{
    public partial class frmReporteMedicamentos : Form
    {
        Medicamento oMedicamento;
        public frmReporteMedicamentos()
        {
            oMedicamento = new Medicamento();
            InitializeComponent();
        }

        private void frmReporteMedicamentos_Load(object sender, EventArgs e)
        {
            this.rpvMedicamentos.RefreshReport();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidadMinima = -1;
            int cantidadMaxima = -1;

            if (!(this.txtbCantMin.Text == ""))
            {
                cantidadMinima = int.Parse(this.txtbCantMin.Text);
            }
            if (!(this.txtbCantMax.Text == ""))
            {
                cantidadMaxima = int.Parse(this.txtbCantMax.Text);
            }


            if (cantidadMinima > cantidadMaxima)
            {
                MessageBox.Show("El stock máximo debe ser mayor al mínimo!", "Información"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.rpvMedicamentos.LocalReport.DataSources.Clear();
                Object tabla = oMedicamento.obtenerDatosReporte(cantidadMinima, cantidadMaxima);
                ReportDataSource rprtDTSource = new ReportDataSource("DSMedicamentos", tabla);

                rpvMedicamentos.LocalReport.DataSources.Add(rprtDTSource);
                rpvMedicamentos.RefreshReport();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbCantMin.Text = "";
            this.txtbCantMax.Text = "";
        }
    }
}
