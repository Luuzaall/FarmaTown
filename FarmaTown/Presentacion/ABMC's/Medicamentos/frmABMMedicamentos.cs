using System;
using FarmaTown.Logica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaTown.Presentacion.Servicios;

namespace FarmaTown.Presentacion.ABMC_s.Medicamentos
{
    public partial class frmABMMedicamentos : Form
    {
        private FormMode formMode = FormMode.insert;
        private Medicamento oMedicamento;
        private TipoMedicamento oTipoMedicamento;
        public enum FormMode
        {
            /*
             * Se crea una clase del tipo enum
             * que permita determinar el comportamiento
             * variable del formulario según su aplicación.
             */
            insert,
            update,
            delete
        }


        public frmABMMedicamentos()
        {
            InitializeComponent();
            oMedicamento = new Medicamento();
            oTipoMedicamento = new TipoMedicamento();

        }

        private void frmABMMedicamentos_Load(object sender, EventArgs e)
        {

            /*
             * Carga del formulario, dependiendo de la razón de la cual 
             * fue llamado, definido en el switch de los distintos
             * FormMode.
             */
            ComboBoxService.cargarCombo(this.cboTipoMedicamento, oTipoMedicamento.recuperarTodos(), "descripcion", "idTipo");

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Medicamento - FarmaTown";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Medicamento - FarmaTown";
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbDescripcion.Enabled = true;
                        this.cboTipoMedicamento.Enabled = true;
                        this.txtbPrecio.Enabled = true;
                        this.txtbCantidad.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Borrar Medicamento - FarmaTown";
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbDescripcion.Enabled = true;
                        this.cboTipoMedicamento.Enabled = true;
                        this.txtbPrecio.Enabled = true;
                        this.txtbCantidad.Enabled = true;
                        this.btnLimpiar.Enabled = false;
                        break;
                    }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Permite que el usuario limpie todos los campos
             */
            this.limpiarDatos();
        }

        private void limpiarDatos()
        {
            /*
             * Limpia los textbox y
             * los combos para un nuevo ingreso
             * de los mismos
             */
            this.txtbNombre.Text = "";
            this.txtbDescripcion.Text = "";
            this.cboTipoMedicamento.SelectedIndex = -1;
            this.txtbPrecio.Text = "";
            this.txtbCantidad.Text = "";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
            * El comportamiento del botón depende de lo determinado
            * por el formMode
            */

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            if (existeMedicamento() == false)
                            {
                                var oMedicamento = new Medicamento();
                                oMedicamento.Nombre = this.txtbNombre.Text;
                                oMedicamento.Descripcion = this.txtbDescripcion.Text;
                                oMedicamento.TipoMedicamento = new TipoMedicamento();
                                oMedicamento.TipoMedicamento.IdTipo = (int)cboTipoMedicamento.SelectedValue;

                                if (oMedicamento.crearMedicamento(oMedicamento))
                                {
                                    MessageBox.Show("Medicamento añadido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                            else
                                MessageBox.Show("Este nombre de medicamento ya esta utilizado Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }
                    
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oMedicamento.Nombre = this.txtbNombre.Text;
                            oMedicamento.Descripcion = this.txtbDescripcion.Text;
                            oMedicamento.TipoMedicamento = new TipoMedicamento();
                            oMedicamento.TipoMedicamento.IdTipo = (int)cboTipoMedicamento.SelectedValue;
                            oMedicamento.PrecioLista = float.Parse(this.txtbPrecio.Text);
                            oMedicamento.Cantidad = int.Parse(this.txtbCantidad.Text);

                            if (oMedicamento.actualizarMedicamento(oMedicamento))
                            {
                                MessageBox.Show("Medicamento actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Medicamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break; 
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el medicamento?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {
                            MessageBox.Show("Medicamento Deshabilitado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                            if (oMedicamento.cambiarEstadoMedicamento(oMedicamento, false))
                            {
                                MessageBox.Show("Medicamento Borrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el medicamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break; 
                    }
                default:
                    break;
            }


        }

        internal void seleccionarMedicamento (FormMode _formMode, Medicamento medicamentoSelected)
        { 
            /*
              * Se obtiene el medicamento seleccionado
              * y el modo de apertura del formABMMedicamentos
              */
            formMode = _formMode;
            oMedicamento = medicamentoSelected;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            string nom = this.txtbNombre.Text;
            string desc = this.txtbDescripcion.Text;
            int indexTipo = this.cboTipoMedicamento.SelectedIndex;
            float precio = float.Parse(this.txtbPrecio.Text);
            int cantidad = int.Parse(this.txtbCantidad.Text);




            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }

            else if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Debe ingresar una descripcion",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbDescripcion.Focus();
            }
            else if (precio < 0)
            {
                MessageBox.Show("Debe ingresar un precio adecuado",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbPrecio.Focus();
            }
            else if (cantidad < 0)
            {
                MessageBox.Show("Debe ingresar una cantidad adecuada",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbCantidad.Focus();
            }
            else if (indexTipo == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de Medicamento",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

            }


            else
            {
                return true;
            }
            //Cuando no llegó al último else, entró a 
            // alguno anterior...
            return false;
        }

        private bool existeMedicamento()
        {
            /*
             * Determina si ya existe un Medicamento
             * con el mismo nombre, retornando FALSE
             * si no existe y TRUE si existe.
             */
            string nomMed = this.txtbNombre.Text;
            Medicamento medEncontrado = this.oMedicamento.traerMedicamento(nomMed);
            if (medEncontrado is null)
            {
                return false;
            }
            return true;
        }

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box y combos
            * según el Medicamento seleccionado.
            */
            this.txtbNombre.Text = this.oMedicamento.Nombre;
            this.txtbDescripcion.Text = this.oMedicamento.Descripcion;
            this.cboTipoMedicamento.SelectedValue = this.oMedicamento.TipoMedicamento.IdTipo;
            this.txtbPrecio.Text = this.oMedicamento.PrecioLista.ToString();
            this.txtbCantidad.Text = this.oMedicamento.Cantidad.ToString();
        }












    }

}
