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
            this.rpvMedicamentos.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            float precioMinimo = float.Parse(this.txtbPrecioMin.Text);
            float precioMaximo = float.Parse(this.txtbPrecioMax.Text);

            if (precioMinimo > precioMaximo)
            {
                MessageBox.Show("El monto máximo debe ser mayor al mínimo!", "Información"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.rpvMedicamentos.LocalReport.DataSources.Clear();
                Object tabla = oMedicamento.obtenerDatosReporte(precioMinimo, precioMaximo);
                ReportDataSource rprtDTSource = new ReportDataSource("DSMedicamentos", tabla);

                this.rpvMedicamentos.LocalReport.DataSources.Add(rprtDTSource);
                this.rpvMedicamentos.RefreshReport();
            }
        }
    }
}
