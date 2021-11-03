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
    public partial class frmReporteTMedicamentosxVenta : Form
    {
        Venta oVenta;
        Farmacia oFarmacia;
        Localidad oLocalidad;

        public frmReporteTMedicamentosxVenta()
        {
            InitializeComponent();
            oVenta = new Venta();
            oFarmacia = new Farmacia();
            oLocalidad = new Localidad();
        }

        private void frmReporteTMedicamentosxVenta_Load(object sender, EventArgs e)
        {
            ComboBoxService.cargarCombo(this.cboFarmacias, oFarmacia.recuperarTodos(), "Nombre", "IdFarmacia");
            ComboBoxService.cargarCombo(this.cboLocalidades, oLocalidad.recuperarTodos(false), "Nombre", "IdLocalidad");
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.TiposMedicamento' Puede moverla o quitarla según sea necesario.
            this.tiposMedicamentoTableAdapter.Fill(this.dataSetGeneral.TiposMedicamento);
            this.rpvMedicamentosxVenta.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (this.fechaDesdePicker.Value > this.fechaHastaPicker.Value)
            {
                MessageBox.Show("Fechas inválidas!", "Información"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int oFarm = -1;
            int oLoc = -1;
            if (this.cboFarmacias.SelectedIndex != -1)
            {
                Farmacia farm = (Farmacia)this.cboFarmacias.SelectedItem;
                oFarm = farm.IdFarmacia;
            }
            if (this.cboLocalidades.SelectedIndex != -1)
            {
                Localidad loc = (Localidad)this.cboLocalidades.SelectedItem;
                oLoc = loc.IdLocalidad;
            }



            Object tabla = oVenta.obtenerDatosReporte(this.fechaDesdePicker.Value, this.fechaHastaPicker.Value, oFarm, oLoc, 2);
            ReportDataSource rprtDTSource = new ReportDataSource("TipoMedicamento", tabla);

            rpvMedicamentosxVenta.LocalReport.DataSources.Clear();
            rpvMedicamentosxVenta.LocalReport.DataSources.Add(rprtDTSource);
            this.rpvMedicamentosxVenta.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
