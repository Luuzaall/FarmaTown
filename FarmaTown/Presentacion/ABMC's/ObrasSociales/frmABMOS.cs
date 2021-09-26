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

namespace FarmaTown.Presentacion.ObrasSociales
{
    public partial class frmABMOS : Form
    {
        private FormMode formMode = FormMode.insert;
        ObraSocial oOS;
        public frmABMOS()
        {
            InitializeComponent();
            oOS = new ObraSocial();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        //-----------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        public void seleccionarOS(FormMode _formMode, ObraSocial obraSocialSelected)
        {
            formMode = _formMode;
            oOS = obraSocialSelected;
        }

        private bool validarCampos()
        {
            string nombre = this.txtbNombre.Text;
            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
                return false;
            }
            return true;
        }

        private bool existeOS(string nombre)
        {
            ObraSocial resultado = this.oOS.traerOS(nombre);
            if (resultado is null)
            {
                return false;
            }
            else
                return true;
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void frmABMOS_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Obra Social - FarmaTown";
                            break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Obra Social - FarmaTown";
                        this.txtbNombre.Text = oOS.Nombre;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Obra Social - FarmaTown";
                        this.txtbNombre.Text = oOS.Nombre;
                        this.txtbNombre.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        break;

                    }
            }
        }

        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtbNombre.Text;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (!this.existeOS(nombre))
                            {
                                ObraSocial oNuevaOS = new ObraSocial();
                                oNuevaOS.Nombre = nombre;

                                bool resultInsert = oNuevaOS.crearOS(oNuevaOS);
                                if (resultInsert)
                                {
                                    MessageBox.Show("Obra Social agregada!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar la obra social!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este obra social ya está registrada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oOS.Nombre = this.txtbNombre.Text;

                            bool resultActualiz = this.oOS.actualizar(oOS);
                            if (resultActualiz)
                            {
                                MessageBox.Show("Obra social actualizada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la obra social!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar la obra social seleccionada?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oOS.cambiarEstado(oOS, false))
                            {
                                MessageBox.Show("Obra social Deshabilitada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar la obra social", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

    }
}
