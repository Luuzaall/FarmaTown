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
        List<List<String>> listaOSXM;

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
            this.cboObrasSociales.SelectedIndex = -1;

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
            frmMedicamentos oFrmMed = new frmMedicamentos(FormMode.selection);
            DialogResult resultado = oFrmMed.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                oMedicamento = oFrmMed.recuperarSeleccion();
                oFrmMed.Dispose();
                this.txtbNomMedicamento.Text = oMedicamento.Nombre;
                this.txtbPrecio.Text = oMedicamento.PrecioLista.ToString();
                this.cambiarEstadoBoton(this.btnAgregar, true);

                if (oObraSocial.Nombre != null)
                {
                    double descuento = 0;
                    List<List<Object>> lista = oObraSocial.listaDescuentos;
                    int cantDescuentos = lista.Count;
                    for (int fila = 0; fila < cantDescuentos; fila++)
                    {
                        int idLista = (int) typeof(Medicamento).GetProperty("IdMedicamento").GetValue(lista[0][0]);
                        if ( idLista == oMedicamento.IdMedicamento)
                        {
                            descuento = (double) lista[fila][1] ;
                            break;
                        }
                    }

                    this.txtbDescuentoOS.Text = descuento.ToString();
                }
            }

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
            //        FechaFactura = this.dtpFechaActual.Value,
            //        Cliente = oCliente,
            //        TipoFactura = (TipoFactura)this.cboTipoFactura.SelectedItem,
            //        Detalles = listaFacturaDetalle,
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

        private void txtbCantMedicamento_KeyUp(object sender, KeyEventArgs e)
        {
            string textCant = this.txtbCantMedicamento.Text;
            string textPrec = this.txtbPrecio.Text;
           
            
            if ( !(string.IsNullOrEmpty(textCant)
                    || textCant == " ")
                  && !( textPrec == 0.ToString("N2") )
                    )
            {
                int cant = int.Parse(textCant);
                bool pasaStock = (cant > oMedicamento.Cantidad);

                // Modifica el estado del botón según si pasa el stock
                // registrado y visualiza el mensaje  de aviso si corresponde.
                this.cambiarEstadoBoton(this.btnAgregar, !pasaStock);
                this.lblAvisoStock.Visible = pasaStock;

                Double precioUnit = Double.Parse(textPrec);
                Double importeMed;
                if (oObraSocial.Nombre != null)
                {
                    Double descuento;
                    descuento = Double.Parse(this.txtbDescuentoOS.Text.ToString());
                    importeMed = (cant * (precioUnit - (precioUnit * descuento) ) );
                }
                else
                {
                    importeMed = cant * precioUnit;
                }
                this.txtbImporte.Text = importeMed.ToString("N2");
            }
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

            //listaDetalle.Add(detalle);

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

        private void cboObrasSociales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oObraSocial = (ObraSocial)this.cboObrasSociales.SelectedItem;

            if (oMedicamento != null)
            {
                double descuento = 0;
                List<List<Object>> lista = oObraSocial.listaDescuentos;
                int cantDescuentos = lista.Count;
                for (int fila = 0; fila < cantDescuentos; fila++)
                {
                    int idLista = (int)typeof(Medicamento).GetProperty("IdMedicamento").GetValue(lista[fila][0]);
                    if (idLista == oMedicamento.IdMedicamento)
                    {
                        descuento = (double)lista[fila][1];
                        break;
                    }
                }
                this.txtbDescuentoOS.Text = descuento.ToString();

                string txtCant = this.txtbCantMedicamento.Text;
                if ( !(string.IsNullOrEmpty(txtCant)
                        || txtCant == " ")
                    )
                {
                    Double cant = Double.Parse(txtCant);
                    Double precioUnit = Double.Parse(this.txtbPrecio.Text);
                    this.txtbImporte.Text = (cant * (precioUnit - (precioUnit * descuento))).ToString("N2");
                }

            }

        }


    }
}
