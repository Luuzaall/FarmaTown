using FarmaTown.Datos;
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
    public partial class frmListadoMedicamentos : Form
    {
        Medicamento oMedicamento;
        public frmListadoMedicamentos()
        {
            InitializeComponent();
            oMedicamento = new Medicamento();
        }

        private void frmListadoMedicamentos_Load(object sender, EventArgs e)
        {
            //ACA SINO
            this.rpvMedicamentos.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidadMinima = -1;
            int cantidadMaxima = -1 ;

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
                //LA PRIMER LINEA ESTA MAS ARRIBA TMB COMENTADA, BORRAR ALGUNA
                //esta línea de código carga datos en la tabla 'dataSetGeneral.Medicamentos'.
                this.medicamentosTableAdapter.Fill(this.dataSetGeneral.Medicamentos);
                Object tabla = oMedicamento.obtenerDatosReporte(cantidadMinima, cantidadMaxima);
                ReportDataSource rprtDTSource = new ReportDataSource("DSMedicamentos", tabla);

                rpvMedicamentos.LocalReport.DataSources.Clear();
                rpvMedicamentos.LocalReport.DataSources.Add(rprtDTSource);
                rpvMedicamentos.LocalReport.Refresh();
            }
        }
    }
}
