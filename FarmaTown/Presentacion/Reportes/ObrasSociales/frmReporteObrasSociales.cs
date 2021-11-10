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

namespace FarmaTown.Presentacion.Reportes.ObrasSociales
{
    public partial class frmReporteObrasSociales : Form
    {
        ObraSocial oObraSocial;
        Medicamento oMedicamento;

        public frmReporteObrasSociales()
        {
            oObraSocial = new ObraSocial();
            oMedicamento = new Medicamento();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rpvOS.RefreshReport();
            ComboBoxService.cargarCombo(this.cboObrasSociales, oObraSocial.recuperarTodos()
    , "Nombre", "IdOS");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.rpvOS.LocalReport.DataSources.Clear();
            Object tabla = oObraSocial.obtenerDatosReporte(this.cboObrasSociales.Text);
            ReportDataSource rprtDTSource = new ReportDataSource("DSObrasSociales", tabla);
            this.rpvOS.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvOS.RefreshReport();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cboObrasSociales.SelectedIndex = -1;
        }
    }
}
