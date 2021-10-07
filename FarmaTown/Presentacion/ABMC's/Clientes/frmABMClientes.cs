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
    public partial class frmABMClientes : Form
    {
        private FormMode formMode = FormMode.insert;
        private Cliente oCliente;
        TipoDocumento oTipoDoc;

        public frmABMClientes()
        {
            oTipoDoc = new TipoDocumento();
            oCliente = new Cliente();
            InitializeComponent();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
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
        private void cboTipoDoc_SelectionChangeCommited(object sender, EventArgs e)
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
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
            this.txtbApellido.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbPasaporteLetras.Text = "";
            this.txtbPasaporteNro.Text = "";
            this.txtbCalle.Text = "";
            this.txtbNumero.Text = "";

            this.cboTipoDoc.SelectedIndex = -1;

            this.deshabilitarTextBox();
        }

        private bool validarCampos()
        {
            string nombre = this.txtbNombre.Text; 
            string apellido = this.txtbApellido.Text;
            string calle = this.txtbCalle.Text;
            int numero = Convert.ToInt32(this.txtbNumero.Text);
            //string barrio = this.

            string nroDoc = this.txtbNroDoc.Text;
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;

            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (nombre.Length <= 2)
            {
                MessageBox.Show("Debe ingresar un nombre válido",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
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
            else if (this.dgvBarrios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir una farmacia",
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
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (!this.existeEmpleado())
                            {

                                var oEmpleado = new Empleado();
                                oEmpleado = this.cargarDatos(oEmpleado);

                                if (oEmpleado.crearEmpleado(oEmpleado))
                                {
                                    MessageBox.Show("Empleado agregado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar el empleado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este empleado ya está registrado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (this.validarCampos())
                        {
                            oEmpleado = this.cargarDatos(oEmpleado);

                            if (oEmpleado.actualizarEmpleado(oEmpleado))
                            {
                                MessageBox.Show("Empleado actualizado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el empleado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el empleado seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oEmpleado.cambiarEstado(oEmpleado, false))
                            {
                                MessageBox.Show("Empleado Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

    }
}
