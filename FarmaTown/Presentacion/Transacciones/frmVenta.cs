using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Transacciones
{
    public partial class frmVenta : Form
    {
        private FormMode formMode = FormMode.details;
        private Venta oVenta;
        public enum FormMode
        {
            delete,
            details
        }
        public frmVenta()
        {
            InitializeComponent();
            oVenta = new Venta();
        }

        public void seleccionarVenta(FormMode _formMode, Venta ventaSelecc)
        {
            this.formMode = _formMode;
            this.oVenta = ventaSelecc;
        }

        private void cargarDatos(Venta oVenta)
        {
            this.lblEmpleado.Text = oVenta.Empleado.Nombre;
            this.lblFarmacia.Text = oVenta.Farmacia.Nombre;
            this.lblLocalidad.Text = oVenta.Farmacia.Barrio.Localidad.Nombre;
            this.lblTipoFactura.Text = oVenta.TipoFactura.Nombre;
            this.lblNroFactura.Text = oVenta.NroFactura;
            this.lblFecha.Text = oVenta.FechaFactura.ToString();
            this.lblNombreCliente.Text = oVenta.Cliente.Nombre;
            this.lblNroDoc.Text = oVenta.Cliente.NroDoc;
            this.lblTipoDoc.Text = oVenta.Cliente.TipoDoc.Nombre;
            this.lblNombreOS.Text = oVenta.ObraSocial.Nombre;
            this.lblMedioPago.Text = oVenta.MedioPago.Nombre;
            List<double> totales = oVenta.obtenerTotales();
            this.lblImporteTotalSDesc.Text = totales[0].ToString();
            this.lblImporteTotalCliente.Text = totales[1].ToString();
            this.lblEstado.Text = oVenta.EstadoActual.Nombre;

            this.cargarGrilla(this.dgvDetalle, oVenta.Detalles);
        }

        private void cargarGrilla(DataGridView dgv, IList<DetalleVenta> lista)
        {
            dgv.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    dgv.Rows.Add(lista[i].Medicamento.IdMedicamento.ToString(),
                                lista[i].Medicamento.Nombre.ToString(),
                                lista[i].Cantidad.ToString(),
                                lista[i].PrecioUnitarioShort.ToString(),
                                lista[i].Reintegro.ToString(),
                                lista[i].Importe.ToString());
                }
                dgv.ClearSelection();
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.cargarDatos(oVenta);
            
            switch (this.formMode)
            {
                case FormMode.delete:
                    {
                        this.Text = "Baja de Venta - FarmaTown";
                        this.lblTitulo.Text = "Baja de Venta";
                        break;
                    }

                case FormMode.details:
                    {
                        this.Text = "Consulta Detalle de Ventas - FarmaTown";
                        this.lblTitulo.Text = "Consulta de Venta";
                        break;
                    }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.formMode)
            {
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea cancelar la venta seleccionada?"
                              , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            oVenta.cancelada(oVenta);
                            MessageBox.Show("Venta Deshabilitada!", "Información"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        break;
                    }

                case FormMode.details:
                    {
                        this.Close();
                        break;
                    }
            }
        }
    }
}
