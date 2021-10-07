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
    public partial class frmClientes : Form
    {
        Cliente oCliente;
        TipoDocumento oTipoDoc;
        Barrio oBarrio;
        public frmClientes()
        {
            oCliente = new Cliente();
            oTipoDoc = new TipoDocumento();
            oBarrio = new Barrio();
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ComboBoxService.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(false)
                , "nombre", "idTipo");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario y filtra
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
            }

        }

        private bool validarCampos()
        {
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
            this.cargarGrilla(dgvClientes, oCliente.recuperarTodos(false));
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
                                lista[i].Numero.ToString(),
                                lista[i].Barrio.Nombre.ToString()); ;
                }
                dgv.ClearSelection();
            }
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noDigitos(e);
        }

        private void txtbApellido_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noDigitos(e);
        }

        private void txtbCalle_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noDigitos(e);
        }

        private void cboTipoDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
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

        private void deshabilitarTextBox()
        {
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
             * lo vea
            // */
            //this.btnEditar.Enabled = false;
            //this.btnEditar.BackColor = Color.Gray;
            //this.btnEliminar.Enabled = false;
            //this.btnEliminar.BackColor = Color.Gray;
            //this.lblAviso.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

    }
}
