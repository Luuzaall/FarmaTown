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

namespace FarmaTown.Presentacion.Localidades
{
    public partial class frmABMLocalidades : Form
    {
        private FormMode formMode = FormMode.insert;
        Localidad oLocalidad;
        public frmABMLocalidades()
        {
            InitializeComponent();
            oLocalidad = new Localidad();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        //-----------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        public void seleccionarLocalidad(FormMode _formMode, Localidad localidadSelected)
        {
            formMode = _formMode;
            oLocalidad = localidadSelected;
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

        private bool existeLocalidad(string nombre)
        {
            Localidad resultado = this.oLocalidad.traerLocalidad(nombre);
            if (resultado is null)
            {
                return false;
            }
            else
                return true;
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void frmABMLocalidades_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Localidad - FarmaTown";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Localidad - FarmaTown";
                        this.txtbNombre.Text = oLocalidad.Nombre;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Localidad - FarmaTown";
                        this.txtbNombre.Text = oLocalidad.Nombre;
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
                            if (!this.existeLocalidad(nombre))
                            {
                                Localidad oNuevaLocalidad = new Localidad();
                                oNuevaLocalidad.Nombre = nombre;

                                bool resultInsert = oLocalidad.crearLocalidad(oNuevaLocalidad);
                                if (resultInsert)
                                {
                                    MessageBox.Show("Localidad agregada!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar la Localidad!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Esta Localidad ya está registrada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oLocalidad.Nombre = this.txtbNombre.Text;

                            bool resultActualiz = this.oLocalidad.actualizar(oLocalidad);
                            if (resultActualiz)
                            {
                                MessageBox.Show("Localidad actualizada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la Localidad!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar la Localidad seleccionada?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oLocalidad.cambiarEstado(oLocalidad, false))
                            {
                                MessageBox.Show("Localidad Deshabilitada!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar la Localidad", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }
    }
}
