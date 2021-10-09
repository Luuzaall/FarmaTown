using FarmaTown.Logica;
using FarmaTown.Presentacion.ABMC_s;
using FarmaTown.Presentacion.ABMC_s.Clientes;
using FarmaTown.Presentacion.ABMC_s.Medicamentos;
using FarmaTown.Presentacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion
{
    public partial class frmVentas : Form
    {
        // Atributos
        TipoFactura oTipoFact;
        Cliente oCliente;
        Medicamento oMedicamento;
        ObraSocial oObraSocial;
        BindingList<DetalleVenta> listaDetalle;

        public frmVentas()
        {
            InitializeComponent();
            oTipoFact = new TipoFactura();
            oCliente = new Cliente();
            oObraSocial = new ObraSocial();

        }

        private void inicializarDetalle()
        {
            this.txtbNomMedicamento.Text = "";
            this.txtbPrecio.Text = 0.ToString("N2");
            this.txtbCantMedicamento.Text = "";
            this.txtbImporte.Text = 0.ToString("N2");

            this.cambiarEstadoBoton(this.btnAgregar, false);
            this.cambiarEstadoBoton(this.btnQuitar, false);
        }

        private void inicializarFormulario()
        {
            this.cboTipoFactura.SelectedIndex = -1;
            this.txtbNroFactura.Text = "";
            this.txtNomCliente.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbTipoDoc.Text = "";

            this.inicializarDetalle();

            // Limpia el DataGridView.
            this.dgvDetalle.DataSource = null;

        }

        private void cambiarEstadoBoton(Button btn, bool seHabilita)
        {
            btn.Enabled = seHabilita;
            if (seHabilita)
                btn.BackColor = Color.FromArgb(116, 201, 79);
            else
                btn.BackColor = Color.Gray;

        }

        private void calcularTotales()
        {
            //var subTotal = listaDetalle.Sum(p => p.Importe);
            //this.txtbSubtotal.Text = subTotal.ToString();

            //double descuento = 0;
            //double.TryParse(txtbDescuento.Text, out descuento);

            //var importeTotal = subtotal - subtotal * descuento / 100;
            //txtbImporteTotal.Text = importeTotal.ToString("C");
        }
            
        //MÉTODOS DE RESPUESTA A EVENTOS

        private void btnBuscCliente_Click(object sender, EventArgs e)
        {
            /*
             * Debe ejecutar el form de consulta a clientes
             * Y pasar por parámtetro el elegido.
             */
            frmClientes oFrmClientes = new frmClientes(FormMode.selection);
            DialogResult resultado = oFrmClientes.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                oCliente = oFrmClientes.recuperarSeleccion();
                this.txtNomCliente.Text = oCliente.Nombre;
                this.txtbNroDoc.Text = oCliente.NroDoc;
                this.txtbTipoDoc.Text = oCliente.TipoDoc.Nombre;
            }
        }

        private void btnBuscMedicamento_Click(object sender, EventArgs e)
        {
            /*
             * Debe ejecutar el form de consulta medicamentos
             * Y pasar por parámtetro el elegido.
             */
            //frmMedicamentos oFrmClientes = new frmMedicamentos(FormMode.selection);
            //DialogResult resultado = oFrmClientes.ShowDialog();
            //if (resultado != DialogResult.Cancel)
            //{
            //    oMedicamento = frmMedicamentos.recuperarSeleccion();
            //    this.txtNomCliente.Text = oMedicamento.Nombre;
            //    this.txtbNroDoc.Text = oMedicamento.NroDoc;
            //    this.txtbTipoDoc.Text = oMedicamento.TipoDoc.Nombre;
            //    this.cambiarEstadoBoton(this.btnAgregar, true);
            //}

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*
            * Cierra el formulario con el botón de salir
            */
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            * Guarda la información ingresada de la factura,
            * generando el id de la factura.
            */

            //try
            //{
            //    var venta = new Venta
            //    {
            //        Fecha = dtpFecha.Value,
            //        Cliente = (Cliente)cboCliente.SelectedItem,
            //        TipoFactura = (TipoFactura)cboTipoFact.SelectedItem,
            //        FacturaDetalle = listaFacturaDetalle,
            //        SubTotal = double.Parse(txtSubtotal.Text),
            //        Descuento = double.Parse(txtDescuento.Text)
            //    };

            //    if (facturaService.ValidarDatos(factura))
            //    {
            //        facturaService.Crear(factura);

            //        MessageBox.Show(string.Concat("La factura nro: ", factura.IdFactura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        InicializarFormulario();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //this.cambiarEstadoBoton(this.btnGuardar, false);

    }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            /*
             * Limpia todo el formulario 
             * para una nueva factura.
             */
            this.inicializarFormulario();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            this.inicializarFormulario();

            ComboBoxService.cargarCombo(this.cboTipoFactura, oTipoFact.recuperarTodos()
                , "Nombre", "IdTipoFactura");
            ComboBoxService.cargarCombo(this.cboObrasSociales, oObraSocial.recuperarTodos(false)
                , "Nombre", "IdOS");

            this.dgvDetalle.DataSource = listaDetalle;
        }

        private void txtbCantMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noLetras(e);
            TextBoxService.enter(this.btnAgregar, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse( this.txtbCantMedicamento.Text.ToString() );
            DetalleVenta detalle = new DetalleVenta()
            {
                Medicamento = oMedicamento,
                Cantidad = cantidad,
                PrecioUnitario = oMedicamento.PrecioLista,
                //Reintegro = 
                ObraSocial = (ObraSocial)this.cboObrasSociales.SelectedItem,
            };

            listaDetalle.Add(detalle);

            this.calcularTotales();

            this.inicializarDetalle();

            this.cambiarEstadoBoton(this.btnGuardar, true);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            /*
             * Quita el detalle seleccionado del DataGridView.
             */
            if (listaDetalle != null) 
            {
                var detalleVenta = (DetalleVenta)this.dgvDetalle.CurrentRow.DataBoundItem;
                listaDetalle.Remove(detalleVenta);
            }

            if (listaDetalle.Count == 0)
                this.cambiarEstadoBoton(this.btnAgregar, false);
        }

        private void btnRehacerDetalle_Click(object sender, EventArgs e)
        {
            /*
             * Ante el botón de rehacer detalle,
             * vacía todo lo ingresado.
             */
            this.inicializarDetalle();

            this.cambiarEstadoBoton(this.btnAgregar, false);
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cambiarEstadoBoton(this.btnQuitar, true);

        }

        private void dgvDetalle_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.cambiarEstadoBoton(this.btnQuitar, false);
        }
    }
}
