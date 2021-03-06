using FarmaTown.Logica;
using FarmaTown.Presentacion.Localidades;
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
    public enum FormModeABM
    {
        insert,
        update,
        delete
    }

    public partial class frmABMClientes : Form
    {
        private FormModeABM formMode = FormModeABM.insert;
        private Cliente oCliente;
        TipoDocumento oTipoDoc;
        private Barrio oBarrio;

        public frmABMClientes()
        {
            InitializeComponent();
            oTipoDoc = new TipoDocumento();
            oCliente = new Cliente();
            oBarrio = new Barrio();
        }
        
        // Métodos funcionales.
        internal void seleccionarCliente(FormModeABM _formMode, Cliente clienteSelected)
        {
            /*
             * Permite recibir el cliente que se seleccionó
             * en la ventana anterior.
             */
            formMode = _formMode;
            oCliente = clienteSelected;
        }

        private void deshabilitarTextBox()
        {
            /*
             * Deshabilita todos los textbox en caso
             * de ser iniciado como deshabilitación.
             */
            this.txtbNroDoc.Enabled = false;
            this.txtbNroDoc.Visible = false;

            this.txtbPasaporteLetras.Enabled = false;
            this.txtbPasaporteNro.Enabled = false;
            this.txtbPasaporteLetras.Visible = false;
            this.txtbPasaporteNro.Visible = false;
            this.lblAvisoNroDoc.Text = "";
        }
        private void cboTipoDoc_SelectionChangeCommited(object sender, EventArgs e)
        {
            /*
             *Permite actualizar el aviso de lo que
             * debe ingresar para el textbox correspondiente
             * al número de documento.

             *
             * Además, pone a la vista los textbox
             * correctos para el tipo de documento
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
                    this.lblAvisoNroDoc.Text = "Debe tener 8 dígitos.";
                }
                else if (valorSelecc == 2)
                {
                    this.deshabilitarTextBox();
                    this.txtbNroDoc.Text = "";

                    this.txtbPasaporteLetras.Visible = true;
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

        private bool validarCampos()
        {
            /*
             * Verifica que todos los datos sean válidos
             * para el registro del cliente.
             */
            string nombre = this.txtbNombre.Text; 
            string apellido = this.txtbApellido.Text;
            string nroDoc = this.txtbNroDoc.Text;
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;
            string calle = this.txtbCalle.Text;
            string numeroCalle = this.txtbNroCalle.Text;

            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (string.IsNullOrEmpty(apellido)
                || apellido == " ")
            {
                MessageBox.Show("Debe ingresar un apellido",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbApellido.Focus();
            }
            else if (indexCboTipoDoc == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de documento",
                "Validación de Datos", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                this.txtbNroDoc.Focus();
            }
            else if ((int)this.cboTipoDoc.SelectedValue == 2
                && (string.IsNullOrEmpty(this.txtbPasaporteLetras.Text)
                     || string.IsNullOrEmpty(this.txtbPasaporteNro.Text)
                     || this.txtbPasaporteLetras.Text.Length < 3
                     || this.txtbPasaporteNro.Text.Length < 6))
            {
                MessageBox.Show("Debe completar el número de pasaporte!",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                this.txtbPasaporteLetras.Focus();
                this.txtbPasaporteNro.Focus();
            }
            else if ((int)this.cboTipoDoc.SelectedValue == 1
                && (string.IsNullOrEmpty(nroDoc)
                    || nroDoc.Length < 8))
            {
                MessageBox.Show("Debe ingresar un número de documento válido!",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                this.txtbNroDoc.Focus();
            }
            else if (string.IsNullOrEmpty(calle)
                || calle == " ")
            {
                MessageBox.Show("Debe ingresar una calle",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbCalle.Focus();
            }
            else if (string.IsNullOrEmpty(numeroCalle))
            {
                MessageBox.Show("Debe ingresar un numero de calle",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNroCalle.Focus();
            }
            else if (this.dgvBarrios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir un Barrio",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.dgvBarrios.Focus();
            }
            else
            {
                return true;
            }
            //Cuando no llegó al último else, entró a 
            // alguno anterior...
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
             * Ejecuta la tarea para la cual la ventana fue iniciada
             */
            switch (formMode)
            {
                case FormModeABM.insert:
                    {
                        if (this.validarCampos())
                        {
                            /*
                             * Valida los datos, verifica que no exista el cliente
                             * y lo persiste, indicándole al cliente si se pudo
                             * agregar o no.
                             */
                            if (!this.existeCliente())
                            {

                                var oCliente = new Cliente();
                                oCliente = this.cargarDatos(oCliente);

                                if (oCliente.crear(oCliente))
                                {
                                    MessageBox.Show("Cliente agregado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar el cliente!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este Cliente ya está registrado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormModeABM.update:
                    {
                        /*
                         * Valida los datos y persiste los cambios
                         * , indicándole al cliente si se lograron
                         * guardar los cambios o no.
                         */
                        if (this.validarCampos())
                        {
                            oCliente = this.cargarDatos(oCliente);

                            if (oCliente.actualizar(oCliente))
                            {
                                MessageBox.Show("Cliente actualizado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Cliente!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormModeABM.delete:
                    {
                        /*
                         * Pregunta de confirmación y realiza la deshabilitación,
                         * avisándole al cliente el resultado.
                         */
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el Cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oCliente.cambiarEstado(oCliente))
                            {
                                MessageBox.Show("Cliente Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void frmABMClientes_Load(object sender, EventArgs e)
        {
            ComboBoxService.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(), "nombre", "idTipo");
            List<Barrio> listaBarrios = oBarrio.recuperarTodos();

            if (listaBarrios.Count > 0)
            {
                this.cargarGrilla(this.dgvBarrios, listaBarrios);
            }
            else
            {
                this.dgvBarrios.Columns.Clear();
            }

            switch (formMode)
            {
                case (FormModeABM.insert):
                    {
                        this.Text = "Nuevo Cliente - FarmaTown";
                        this.txtbNombre.Focus();
                        break;
                    }

                case (FormModeABM.update):
                    {
                        this.Text = "Modificar Cliente - FarmaTown";
                        this.cargarGrilla(this.dgvBarrios, oBarrio.recuperarTodos());
                        this.cargarCampos();
                        break;
                    }
                case (FormModeABM.delete):
                    {
                        this.Text = "Deshabilitar Cliente - FarmaTown";
                        this.cargarGrilla(this.dgvBarrios, oBarrio.recuperarTodos());
                        this.cargarCampos();
                        GrillaService.cargarFila(this.dgvBarrios);

                        this.gbClientes.Enabled = false;
                        this.gbUbicacion.Enabled = false;
                        this.txtbNombre.Enabled = false;
                        this.txtbApellido.Enabled = false;
                        this.txtbNroDoc.Enabled = false;
                        this.cboTipoDoc.Enabled = false;
                        this.txtbCalle.Enabled = false;
                        this.txtbNroCalle.Enabled = false;

                        break;
                    }
            }

        }

        private bool existeCliente()
        {
            string nombre = this.txtbNombre.Text;
            string nroDoc = this.txtbNroDoc.Text;

            int idBarrio = int.Parse(this.dgvBarrios.SelectedRows[0].Cells[0].Value.ToString());
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;
            int idTipoDoc;

            if (indexCboTipoDoc == -1)
                idTipoDoc = -1;
            else
                idTipoDoc = (int)this.cboTipoDoc.SelectedValue;

            return oCliente.existeCliente(nombre, nroDoc
                , idTipoDoc, idBarrio);
        }
        //private bool existeCliente()
        //{
        //    int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;
        //    int idTipoDoc;
        //    string nroDoc;

        //    if (indexCboTipoDoc == -1)
        //    {
        //        idTipoDoc = -1;
        //        nroDoc = "";
        //    }
                
        //    else
        //    {
        //        idTipoDoc = (int)this.cboTipoDoc.SelectedValue;
        //        if (indexCboTipoDoc == 1
        //            || indexCboTipoDoc == 3
        //            || indexCboTipoDoc == 4)
        //        {
        //            nroDoc = this.txtbNroDoc.Text;
                    
        //        }
        //        else if (indexCboTipoDoc == 2)
        //        {
        //            nroDoc = this.txtbPasaporteLetras.Text
        //                + this.txtbPasaporteNro.Text;
        //        } 
        //        else
        //        {
        //            nroDoc = "";
        //        }

        //    }
        //    return oCliente.existe(idTipoDoc, nroDoc);
        //}

        public void cargarGrilla(DataGridView dgv, List<Barrio> lista)
        {
            /*
                * Carga la grilla con los datos necesarios
                * pasado por lista.
                */
            dgv.Rows.Clear();
            if (lista != null)
            {
                int cantObjs = lista.Count;
                for (int i = 0; i < cantObjs; i++)
                {
                    dgv.Rows.Add(lista[i].IdBarrio.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].Localidad.Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }
        private Cliente cargarDatos(Cliente oCliente)
        {
            oCliente.Nombre = this.txtbNombre.Text;
            oCliente.Apellido = this.txtbApellido.Text;
            oCliente.Calle = this.txtbCalle.Text;
            oCliente.NroCalle = int.Parse(this.txtbNroCalle.Text);
            oCliente.Barrio = new Barrio()
            {
                IdBarrio = int.Parse(this.dgvBarrios.SelectedRows[0].Cells[0].Value.ToString())
            };    

            oCliente.TipoDoc = (TipoDocumento) this.cboTipoDoc.SelectedItem;
            int idTipoDoc = (int)this.cboTipoDoc.SelectedValue;

            if (idTipoDoc == 1
                   || idTipoDoc == 3
                   || idTipoDoc == 4)
            {
                oCliente.NroDoc = this.txtbNroDoc.Text;

            }
            else if (idTipoDoc == 2)
            {
                    oCliente.NroDoc = (this.txtbPasaporteLetras.Text.ToUpper()
                        + this.txtbPasaporteNro.Text);
            }

            return oCliente;
        }

        public void cargarCampos()
        {
            this.txtbNombre.Text = this.oCliente.Nombre;
            this.txtbApellido.Text = this.oCliente.Apellido;
            this.txtbCalle.Text = this.oCliente.Calle;
            this.txtbNroCalle.Text = this.oCliente.NroCalle.ToString();
            this.txtbBarrio.Text = this.oCliente.Barrio.Nombre;
            int idTipoDoc = this.oCliente.TipoDoc.IdTipo;
            this.cboTipoDoc.SelectedValue = idTipoDoc;
            if (idTipoDoc == 2)
            {
                this.txtbPasaporteLetras.Visible = true;
                this.txtbPasaporteLetras.Enabled = true;
                this.txtbPasaporteNro.Visible = true;
                this.txtbPasaporteNro.Enabled = true;

                this.txtbPasaporteLetras.Text = this.oCliente.NroDoc.ToString().Substring(0, 3);
                this.txtbPasaporteNro.Text = this.oCliente.NroDoc.ToString().Substring(3);
            }
            else
            {
                this.txtbNroDoc.Enabled = true;
                this.txtbNroDoc.Visible = true;
                this.txtbNroDoc.Text = this.oCliente.NroDoc.ToString(); ;
            }

            int idBarrio = oCliente.Barrio.IdBarrio;
            GrillaService.seleccionarFila(this.dgvBarrios, idBarrio);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void actualizar()
        {
            this.cargarGrilla(this.dgvBarrios, oBarrio.recuperarTodos());
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
            this.txtbApellido.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbPasaporteLetras.Text = "";
            this.txtbPasaporteNro.Text = "";

            this.cboTipoDoc.SelectedIndex = -1;
            this.deshabilitarTextBox();
        }

        private void btnLimpiarUbicacion_Click(object sender, EventArgs e)
        {
            this.txtbBarrio.Text = "";
            this.txtbLocalidad.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLimpiarCalleyNum_Click(object sender, EventArgs e)
        {
            this.txtbCalle.Text = "";
            this.txtbNroCalle.Text = "";
        }

        private void btnConsultarUbicacion_Click(object sender, EventArgs e)
        {
            string barrio = this.txtbBarrio.Text;
            string localidad = this.txtbLocalidad.Text;

            if (string.IsNullOrEmpty(barrio)
                & string.IsNullOrEmpty(localidad))
            {
                MessageBox.Show("No ingresó ningún dato",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbBarrio.Focus();
            }

            List<Barrio> resultadosBarrios = this.oBarrio.recuperarCParamOtro(barrio, localidad);
            this.cargarGrilla(this.dgvBarrios, resultadosBarrios);
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            frmABMBarrios barrios = new frmABMBarrios();
            barrios.ShowDialog();

            this.actualizar();
        }
        private void txtbNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbNroDoc.Text.Length;
                if (cant >= 8)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsDigit((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
            }
            TextBoxService.enter(this.btnAceptar, e);
        }

        private void txtbPasaporteNro_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbPasaporteNro.Text.Length;
                if (cant >= 6)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsDigit((char)e.KeyCode)
                    || char.IsPunctuation((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
            }
            TextBoxService.enter(this.btnAceptar, e);
        }

        private void txtbPasaporteLetras_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbPasaporteLetras.Text.Length;
                if (cant >= 3)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsLetter((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
            }
            TextBoxService.enter(this.btnAceptar, e);
        }
        private void txtbNoDigitos_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noDigitos(e);
            TextBoxService.enter(this.btnAceptar, e);
        }
        private void txtbNoLetras_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noLetras(e);
            TextBoxService.enter(this.btnAceptar, e);
        }
    }
}
