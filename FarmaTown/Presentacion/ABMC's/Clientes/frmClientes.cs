using FarmaTown.Logica;
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

namespace FarmaTown.Presentacion.ABMC_s.Clientes
{
    public enum FormMode
    {
        selection,
        management
    }

    public partial class frmClientes : Form
    {
        private Cliente oCliente;
        private TipoDocumento oTipoDoc;
        private FormMode modo;
        
        public frmClientes(FormMode _modo)
        {
            InitializeComponent();
            oCliente = new Cliente();
            oTipoDoc = new TipoDocumento();
            modo = _modo;
        }

        // MÉTODOS DE RESPUESTA A EVENTOS
        private void frmClientes_Load(object sender, EventArgs e)
        {
            /*
             * Carga los combos y, dependiendo del tipo de fomrulario, 
             * ubica visible el botón de seleccionar, como no.
             */
            ComboBoxService.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos()
                , "nombre", "idTipo");

           if (modo == FormMode.selection)
                //Caso de que sea abierto desde la ventana de ventas...
                this.btnSeleccionar.Visible = true;
            else
                this.btnSeleccionar.Visible = false;
        }

        private void txtbNoDigitos_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * Verifica que no ingrese dígitos y
             * que si apreta enter, es como
             * hacer click en el botón
             * de consulta.
             */
            TextBoxService.noDigitos(e);
            TextBoxService.enter(this.btnConsultar, e);
        }


        private void cboTipoDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
             * Permite actualizar el aviso de lo que
             * debe ingresar para el textbox correspondiente
             * al número de documento.
             * 
             * Además, pone a la vista los textbox
             * correspondientes para el tipo de documento
             * que se haya elegido
             */

            int indiceSelecc = (int)this.cboTipoDoc.SelectedIndex;
            if (indiceSelecc != -1)
            {
                int valorSelecc = (int)this.cboTipoDoc.SelectedValue;
                if (valorSelecc == 1
                    || valorSelecc == 3)
                {
                    this.deshabilitarTextBox();
                    this.txtbPasaporteLetras.Text = "";
                    this.txtbPasaporteNro.Text = "";

                    this.txtbNroDoc.Text = "";
                    this.txtbNroDoc.Visible = true;
                    this.txtbNroDoc.Enabled = true;

                    this.lblAvisoNroDoc.Text = "Debe tener 8 números.";
                }
                else if (valorSelecc == 2)
                {
                    this.deshabilitarTextBox();
                    this.txtbNroDoc.Text = "";

                    this.txtbPasaporteLetras.Visible = true;
                    this.txtbPasaporteLetras.Enabled = true;
                    this.txtbPasaporteLetras.Enabled = true;
                    this.txtbPasaporteNro.Visible = true;
                    this.txtbPasaporteNro.Enabled = true;
                    this.lblAvisoNroDoc.Text = "Deben ser 3 letras y 6 números.";

                }
                else
                {
                    this.deshabilitarTextBox();
                    this.txtbNroDoc.Visible = true;
                    this.txtbNroDoc.Enabled = true;
                    this.lblAvisoNroDoc.Text = "";
                }
            }

        }

        private void txtbNoLetras_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * No permite el ingreso de letras 
             * para el textbox que se le haya aplicado
             * esta respuesta de evento.
             * 
             * Además, al apretar enter simula el click en 
             * el botón consultar.
             */
            TextBoxService.noLetras(e);
            TextBoxService.enter(this.btnConsultar, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Limpia todos los textbox del 
             * formulario
             */
            this.txtbNombre.Text = "";
            this.txtbApellido.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbPasaporteLetras.Text = "";
            this.txtbPasaporteNro.Text = "";
            this.cboTipoDoc.SelectedIndex = -1;
            this.lblAvisoNroDoc.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Luego de validar los campos, toma los
             * datos de los textbox y se los envía a
             * la instancia de cliente para que recupere
             * los clientes que corresponden a los filtros
             * aplicados.
             * 
             * Deshabilita botones de editar y eliminar,
             * ya que se deselecciona el cliente.
             */
            if (this.validarCampos())
            {
                List<Cliente> resultadosClientes = new List<Cliente>();
                string nombre = this.txtbNombre.Text;
                string apellido = this.txtbApellido.Text;
                int idTipoDoc;
                string nroDoc = this.txtbNroDoc.Text;


                if (this.cboTipoDoc.SelectedIndex == -1)
                {
                    idTipoDoc = -1;
                }
                else
                {
                    idTipoDoc = (int)this.cboTipoDoc.SelectedValue;
                    if (idTipoDoc == 2)
                    {

                        string letras = this.txtbPasaporteLetras.Text;
                        string nros = this.txtbPasaporteNro.Text;
                        nroDoc = letras + nros;
                    }
                    else
                        nroDoc = this.txtbNroDoc.Text;
                }

                resultadosClientes = this.oCliente.recuperarConParam(nombre, apellido, nroDoc
                    , idTipoDoc);
                this.cargarGrilla(this.dgvClientes, resultadosClientes);
                this.deshabilitarBotones();
            }

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Habilita los botones para poder ser seleccionados,
             * proyenedo una invitación visual
             */
            this.btnEditar.Enabled = true;
            this.btnEditar.BackColor = Color.FromArgb(116, 201, 79);
            this.btnEliminar.Enabled = true;
            this.btnEliminar.BackColor = Color.FromArgb(116, 201, 79);
            this.lblAviso.Visible = false;

            if (modo == FormMode.selection)
            {
                this.btnSeleccionar.Enabled = true;
                this.btnSeleccionar.BackColor = Color.FromArgb(116, 201, 79);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
             * AL hacer click, vuelve a cargar todos los clientes.
             */
            this.cargarGrilla(this.dgvClientes, oCliente.recuperarTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*
             * Instancia la ventana para la creación de un nuevo cliente
             *  y la muestra.
             */
            frmABMClientes oFrmABMClientes = new frmABMClientes();
            oFrmABMClientes.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
             * Instancia la ventana con el modo de edición y le pasa
             * el cliente a modificar para que se muestre.
             */
            int idClienteSelecc = int.Parse(this.dgvClientes.CurrentRow.Cells[0].Value.ToString());
            Cliente clienteSelecc = oCliente.traerCliente(idClienteSelecc);
            frmABMClientes oFrmABMClientes = new frmABMClientes();

            oFrmABMClientes.seleccionarCliente(FormModeABM.update, clienteSelecc);
            oFrmABMClientes.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*
             * Instancia la ventana de clientes en modo deshabilitación
             *  y le pasa el cliente seleccionado para que lo muestre.
             */
            int idClienteSelecc = int.Parse(this.dgvClientes.CurrentRow.Cells[0].Value.ToString());
            Cliente clienteSelecc = oCliente.traerCliente(idClienteSelecc);
            frmABMClientes oFrmABMClientes = new frmABMClientes();

            oFrmABMClientes.seleccionarCliente(FormModeABM.delete, clienteSelecc);
            oFrmABMClientes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*
             * Cierra la ventana.
             */
            this.Close();
        }

        // -----------------------------------------------------------------------------
        // MÉTODOS FUNCIONALES

        private bool validarCampos()
        {
            /*
             * Valida que si todos los cambios están vacíos, 
             * igual actualice.
             */
            string nombre = this.txtbNombre.Text;
            string apellido = this.txtbApellido.Text;
            string nroDoc = this.txtbNroDoc.Text;
            string nroPasaporte = this.txtbPasaporteNro.Text;
            string letrasPasaporte = this.txtbPasaporteLetras.Text;

            if (string.IsNullOrEmpty(nombre)
                & string.IsNullOrEmpty(nroDoc)
                & string.IsNullOrEmpty(nroPasaporte)
                & string.IsNullOrEmpty(letrasPasaporte)
                & string.IsNullOrEmpty(apellido)
                & this.cboTipoDoc.SelectedIndex == -1)
            {
                this.actualizar();
                return false;
            }
            else
                return true;

        }

        private void actualizar()
        {
            /*
             * Recupera todos los clientes sin parámetros,
             * los carga en la grilla y deshabilita los botones
             * de edición y eliminación.
             */
            this.cargarGrilla(dgvClientes, oCliente.recuperarTodos());
            this.deshabilitarBotones();
        }

        private void cargarGrilla(DataGridView dgv, List<Cliente> lista)
        {
            /*
             * Carga la grilla con los datos necesarios
             */
            dgv.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    dgv.Rows.Add(lista[i].IdCliente.ToString(),
                                lista[i].Nombre.ToString(),
                                lista[i].Apellido.ToString(),
                                lista[i].NroDoc.ToString(),
                                lista[i].TipoDoc.Nombre.ToString(),
                                lista[i].Calle.ToString(),
                                lista[i].NroCalle.ToString(),
                                lista[i].Barrio.Nombre.ToString()); ;
                }
                dgv.ClearSelection();
            }
        }

        private void deshabilitarTextBox()
        {
            /*
             * Para la eliminación, deshabilita los
             * textbox de ingreso de número de documento.
             */
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Visible = false;

            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteLetras.Visible = false;
            this.txtbPasaporteNro.Visible = false;
            this.lblAvisoNroDoc.Text = "";
        }

        private void deshabilitarBotones()
        {
            /*
             * Deshabilita los botones cambiándoles
             * el color para que el usuario visualmente
             * lo distinga.
             */
            this.btnEditar.Enabled = false;
            this.btnEditar.BackColor = Color.Gray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.BackColor = Color.Gray;
            this.lblAviso.Visible = true;

            if (modo == FormMode.selection)
            {
                this.btnSeleccionar.Enabled = false;
                this.btnSeleccionar.BackColor = Color.Gray;
            }
        }

        public Cliente recuperarSeleccion()
        {
            /*
             * Recupara el cliente que el usuario
             * seleccionó en la grilla.
             */
            int idCliente = int.Parse( this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
            return oCliente.traerCliente(idCliente);
        }
    }
}
