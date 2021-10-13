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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion
{
    public partial class frmVentas : Form
    {
        // Atributos
        private TipoFactura oTipoFact;
        private Cliente oCliente;
        private Medicamento oMedicamento;
        private ObraSocial oObraSocial;
        private BindingList<DetalleVenta> listaDetalle;
        private Usuario oUsuario;


        public frmVentas(Usuario usuario)
        {
            InitializeComponent();
            this.dgvDetalle.AutoGenerateColumns = false;
            oTipoFact = new TipoFactura();
            oCliente = new Cliente();
            oObraSocial = new ObraSocial();
            listaDetalle = new BindingList<DetalleVenta>();
            oUsuario = usuario;
        }

        private void inicializarDetalle()
        {
            this.txtbNomMedicamento.Text = "";
            this.txtbPrecio.Text = 0.ToString("C", new CultureInfo("es-AR"));
            this.txtbCantMedicamento.Text = "";
            this.txtbImporte.Text = 0.ToString("C", new CultureInfo("es-AR"));
            this.txtbDescuentoOS.Text = 0.ToString("N2");

            this.cambiarEstadoBoton(this.btnAgregar, false);
            this.cambiarEstadoBoton(this.btnEliminar, false);
            this.lblAvisoStock.Visible = false;
        }

        private void inicializarFormulario()
        {
            this.cboTipoFactura.SelectedIndex = -1;
            this.txtbNroFactura.Text = "";
            this.txtNomCliente.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbTipoDoc.Text = "";
            this.cboObrasSociales.Enabled = true;
            this.cboObrasSociales.SelectedValue = 10;

            this.inicializarDetalle();

            // Limpia el DataGridView.
            this.listaDetalle.Clear();
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
            var importeTotal = listaDetalle.Sum(p => p.Importe);
            txtbImporteTotal.Text = importeTotal.ToString("C", new CultureInfo("es-AR"));
        }

        private bool validarInput()
        {
            int selectedIndexTipoFact = this.cboTipoFactura.SelectedIndex;

            if (selectedIndexTipoFact == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de factura",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.cboTipoFactura.Focus();
            }
            else if (oCliente.Nombre is null)
            {
                MessageBox.Show("Debe seleccionar un cliente",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.btnBuscCliente.Focus();
            }
            else if (listaDetalle.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un medicamento " +
                    "al detalle",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.btnBuscMedicamento.Focus();
            }
            else
            {
                return true;
            }
            return false;
            
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

                if (this.cboTipoFactura.SelectedIndex != -1
                     && listaDetalle.Count != 0)
                    this.cambiarEstadoBoton(this.btnGuardar, true);
            }
            else
            {
                oCliente.Nombre = null;
            }
            this.cambiarEstadoBoton(this.btnEliminar, false);
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

                this.txtbCantMedicamento.Text = "";
                this.txtbCantMedicamento.Enabled = true;
                this.lblAvisoStock.Visible = false;
            }
            this.cambiarEstadoBoton(this.btnEliminar, false);

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

            if (validarInput())
            {
                try
                {
                    var venta = new Venta
                    {
                        FechaFactura = this.dtpFechaActual.Value,
                        Cliente = oCliente,
                        TipoFactura = (TipoFactura)this.cboTipoFactura.SelectedItem,
                        Detalles = listaDetalle,
                        Empleado = oUsuario.Empleado,
                        Farmacia = oUsuario.Empleado.Farmacia,
                    };
                    venta.crearVenta(venta);

                    foreach (var item in listaDetalle)
                    {
                        Medicamento med = item.Medicamento;
                        med.CantidadStock = med.CantidadStock - item.Cantidad;
                        med.actualizarMedicamento(med);
                    }

                    MessageBox.Show(string.Concat("La factura ", venta.NroFactura, " se generó correctamente.")
                            , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtbNroFactura.Text = venta.NroFactura.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error al registrar la venta! " + ex.Message + ex.StackTrace
                        , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.cambiarEstadoBoton(this.btnGuardar, false);
            }

        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            /*
             * Limpia todo el formulario 
             * para una nueva factura.
             */
            this.inicializarFormulario();
            this.txtbImporteTotal.Text = 0.ToString("C", new CultureInfo("es-AR"));
            this.cambiarEstadoBoton(this.btnGuardar, false);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            this.inicializarFormulario();

            ComboBoxService.cargarCombo(this.cboTipoFactura, oTipoFact.recuperarTodos()
                , "Nombre", "IdTipoFactura");
            ComboBoxService.cargarCombo(this.cboObrasSociales, oObraSocial.recuperarTodos(false)
                , "Nombre", "IdOS");
            this.cboObrasSociales.SelectedValue = 10;

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
                  && !(textPrec == 0.ToString("N2"))
                  && !(textCant == "0")
                    )
            {
                int cant = int.Parse(textCant);
                bool pasaStock = (cant > oMedicamento.CantidadStock);

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
            else
            {
                this.cambiarEstadoBoton(this.btnAgregar, false);
                this.txtbImporte.Text = 0.ToString("N2");
            }
                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse( this.txtbCantMedicamento.Text.ToString() );

            Double descuento = 0;
            if (oObraSocial.Nombre != null)
                descuento = Double.Parse(this.txtbDescuentoOS.Text);

            DetalleVenta detalle = new DetalleVenta()
            {
                Medicamento = oMedicamento,
                Cantidad = cantidad,
                PrecioUnitario = oMedicamento.PrecioLista,
                Reintegro = descuento,
                ObraSocial = (ObraSocial)this.cboObrasSociales.SelectedItem,
            };


            bool yaEsta = false;
            int idMedNuevo = detalle.Medicamento.IdMedicamento;
            for (int fila = 0; fila < this.dgvDetalle.Rows.Count; fila++)
            {
                DetalleVenta detalleViejo = (DetalleVenta)this.dgvDetalle.Rows[fila].DataBoundItem;
                //int idMedicamento = (int)typeof(Medicamento).GetProperty("IdMedicamento").GetValue(detalle);
                if (idMedNuevo == detalleViejo.Medicamento.IdMedicamento)
                {
                    detalleViejo.Cantidad += detalle.Cantidad;
                    yaEsta = true;
                    this.dgvDetalle.Refresh();
                    break;
                }
            }

            if(!yaEsta)
                listaDetalle.Add(detalle);

            this.calcularTotales();

            this.inicializarDetalle();

            if (oCliente.Nombre != null
                   &&  this.cboTipoFactura.SelectedIndex != -1)
                this.cambiarEstadoBoton(this.btnGuardar, true);

            this.cambiarEstadoBoton(this.btnEliminar, false);
            this.cboObrasSociales.Enabled = false;
            
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cambiarEstadoBoton(this.btnEliminar, true);
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            /*
             * Quita el detalle seleccionado del DataGridView.
             */
            if (listaDetalle != null)
            {
                var detalleVenta = (DetalleVenta)this.dgvDetalle.CurrentRow.DataBoundItem;
                listaDetalle.Remove(detalleVenta);
                listaDetalle.IndexOf(detalleVenta);
                this.calcularTotales();
                if (listaDetalle.Count == 0)
                {
                    this.cboObrasSociales.Enabled = true;
                    this.cambiarEstadoBoton(this.btnGuardar, false);
                }
            }

            if (listaDetalle.Count == 0)
                this.cambiarEstadoBoton(this.btnAgregar, false);
            this.cambiarEstadoBoton(this.btnEliminar, false);
        }

        private void btnRehacerDetalle_Click_1(object sender, EventArgs e)
        {
            /*
             * Ante el botón de rehacer detalle,
             * vacía todo lo ingresado.
             */
            this.inicializarDetalle();
        }

        private void txtbDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noLetras(e);
            TextBoxService.enter(this.btnGuardar, e);
        }

        private void txtbDescuento_KeyUp(object sender, KeyEventArgs e)
        {
            this.calcularTotales();
        }

        private void cboTipoFactura_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (oCliente.Nombre != null
                && listaDetalle.Count != 0)
                this.cambiarEstadoBoton(this.btnGuardar, true);
        }
    }
}
