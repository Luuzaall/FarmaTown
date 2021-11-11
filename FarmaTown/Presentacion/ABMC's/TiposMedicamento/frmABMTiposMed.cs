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

namespace FarmaTown.Presentacion.ABMC_s.TiposMedicamento
{
    public partial class frmABMTiposMed : Form
    {
        private FormMode formMode = FormMode.insert;
        TipoMedicamento oTipoMed;
        public frmABMTiposMed()
        {
            InitializeComponent();
            oTipoMed = new TipoMedicamento();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        //-----------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        public void seleccionarTipoMed(FormMode _formMode, TipoMedicamento tipoMedicamentoSelected)
        {
            formMode = _formMode;
            oTipoMed = tipoMedicamentoSelected;
        }

        private bool validarCampos()
        {
            string descripcion = this.txtbDescripcion.Text;
            if (string.IsNullOrEmpty(descripcion)
                || descripcion == " ")
            {
                MessageBox.Show("Debe ingresar una descripcion",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbDescripcion.Focus();
                return false;
            }
            else if (descripcion.Length <= 2)
            {
                MessageBox.Show("Debe ingresar una descripción válida",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                this.txtbDescripcion.Focus();
                return false;

            }
            return true;
        }

        private bool existeTipoMed(string descripcion)
        {
            TipoMedicamento resultado = this.oTipoMed.traerTipoMed(descripcion);
            if (resultado is null)
            {
                return false;
            }
            else
                return true;
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void frmABMTiposMed_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Tipo de Medicamento - FarmaTown";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Tipo de Medicamento - FarmaTown";
                        this.txtbDescripcion.Text = oTipoMed.Descripcion;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Tipo de Medicamento - FarmaTown";
                        this.txtbDescripcion.Text = oTipoMed.Descripcion;
                        this.txtbDescripcion.Enabled = false;
                        this.lblAviso.Visible = false;
                        this.btnLimpiar.Enabled = false;
                        break;
                    }
            }
        }

        private void txtbDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
            TextBoxService.noDigitos(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbDescripcion.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string descripcion = this.txtbDescripcion.Text;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (!this.existeTipoMed(descripcion))
                            {
                                TipoMedicamento oNuevoTipoMed = new TipoMedicamento();
                                oNuevoTipoMed.Descripcion = descripcion;

                                bool resultInsert = oNuevoTipoMed.crearTipoMedicamento(oNuevoTipoMed);
                                if (resultInsert)
                                {
                                    MessageBox.Show("Tipo de medicamento agregado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar el tipo de medicamento!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este tipo de medicamento ya está registrado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oTipoMed.Descripcion = this.txtbDescripcion.Text;

                            bool resultActualiz = this.oTipoMed.actualizar(oTipoMed);
                            if (resultActualiz)
                            {
                                MessageBox.Show("Tipo de medicamento actualizado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el tipo de medicamento!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("¿Seguro que desea deshabilitar el tipo de medicamento seleccionado?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oTipoMed.cambiarEstado(oTipoMed))
                            {
                                MessageBox.Show("Tipo de medicamento Deshabilitado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el tipo de medicamento", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }
    }
}