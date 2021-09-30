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

namespace FarmaTown.Presentacion.ABMC_s.TiposDocumento
{
    public partial class frmABMTiposDoc : Form
    {
        private FormMode formMode = FormMode.insert;
        TipoDocumento oTipoDoc;
        public frmABMTiposDoc()
        {
            InitializeComponent();
            this.oTipoDoc = new TipoDocumento();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        //-----------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        public void seleccionarTipoDoc(FormMode _formMode, TipoDocumento tipoDocumentoSelected)
        {
            formMode = _formMode;
            oTipoDoc = tipoDocumentoSelected;
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

        private bool existeTipoDoc(string nombre)
        {
            TipoDocumento resultado = this.oTipoDoc.traerTipoDoc(nombre);
            if (resultado is null)
            {
                return false;
            }
            else
                return true;
        }

        private void cargarCampos()
        {
            this.txtbNombre.Text = oTipoDoc.Nombre;
            this.txtbDescrip.Text = oTipoDoc.Descripcion;
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void frmABMTiposDoc_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Tipo Documento - FarmaTown";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Tipo Documento - FarmaTown";
                        this.cargarCampos();
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Tipo Documento - FarmaTown";
                        this.cargarCampos();
                        this.lblAviso.Visible = false;
                        this.txtbNombre.Enabled = false;
                        this.txtbDescrip.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        break;
                    }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
            this.txtbDescrip.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtbNombre.Text;
            string descripcion = this.txtbDescrip.Text;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (!this.existeTipoDoc(nombre))
                            {
                                TipoDocumento oNuevoTipoDoc = new TipoDocumento();
                                oNuevoTipoDoc.Nombre = nombre;
                                oNuevoTipoDoc.Descripcion = descripcion;

                                bool resultInsert = oNuevoTipoDoc.crearNuevo(oNuevoTipoDoc);
                                if (resultInsert)
                                {
                                    MessageBox.Show("Tipo de Documento agregado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar el Tipo de Documento.", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este Tipo de Documento ya está registrado.", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oTipoDoc.Nombre = this.txtbNombre.Text;
                            oTipoDoc.Descripcion = this.txtbDescrip.Text;

                            bool resultActualiz = this.oTipoDoc.actualizar(oTipoDoc);
                            if (resultActualiz)
                            {
                                MessageBox.Show("Tipo de Documento actualizado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Tipo de Documento!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el Tipo de Documento seleccionado?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oTipoDoc.cambiarEstado(false, oTipoDoc))
                            {
                                MessageBox.Show("Tipo de Documento Deshabilitado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el Tipo de Documento", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
            TextBoxService.noDigitos(e);
        }

        private void txtbDescrip_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
        }
    }
}
