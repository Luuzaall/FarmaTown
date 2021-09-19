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

namespace FarmaTown.Presentacion.Empleados
{
    public partial class frmABMEmpleados : Form
    {
        //Atributos
        private FormMode formMode = FormMode.insert;
        private Empleado oEmpleado;
        TipoDocumento oTipoDoc;
        Farmacia oFarmacia;

        public frmABMEmpleados()
        {
            InitializeComponent();
            oTipoDoc = new TipoDocumento();
            oFarmacia = new Farmacia();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        //MÉTODOS DE RESPUESTA A EVENTOS


        private void frmABMEmpleados_Load(object sender, EventArgs e)
        {
            //Carga los combos
            this.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(), "nombre", "idTipo");
            DataTable tablaFarmacias = oFarmacia.recuperarTodos();

            if (tablaFarmacias.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvFarmacias, tablaFarmacias);
                this.dgvFarmacias.ClearSelection();
            }
            else
                this.dgvFarmacias.Rows.Add("No se encontraron farmacias...");

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "FarmaTown - Nuevo Empleado";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "FarmaTown - Actualizar Empleado";
                        //this.cargarDatos();
                        //this.txtbNombre.Enabled = true;
                        //this.txtbClave.Enabled = true;
                        //this.txtbClaveRep.Enabled = true;
                        //this.cboRol.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        //this.cargarDatos();
                        //this.Text = "FarmaTown - Habilitar/Deshabilitar Usuario";
                        //this.cargarFila();
                        //this.txtbNombre.Enabled = false;
                        //this.txtbClave.Enabled = false;
                        //this.txtbClaveRep.Enabled = false;
                        //this.cboRol.Enabled = false;
                        //this.btnLimpiar.Enabled = false;
                        //this.btnRegEmpleado.Enabled = false;
                        break;
                    }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Limpia los textbox y combobox
             * cuando el usuario haga click en el botón Limpiar.
             */
            this.txtbNombre.TextName = "";
            this.txtbNroDoc.TextName = "";
            this.cboTipoDoc.SelectedIndex = -1;
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
                        if (this.validarCampos())
                        {
                            /*if (this.existeEmpleado() == false)
                            {
                        //        var oUsuario = new Usuario();
                        //        oUsuario.Nombre = this.txtbNombre.TextName;
                        //        oUsuario.Clave = this.txtbClave.TextName;
                        //        oUsuario.Rol = new Rol();
                        //        oUsuario.Rol.IdRol = (int)this.cboRol.SelectedValue;
                        //        oUsuario.Empleado = new Empleado();
                        //        oUsuario.Empleado.IdEmpleado = (int)this.dgvEmpleados.CurrentRow.Cells[0].Value;

                        //        if (oUsuario.crearUsuario(oUsuario))
                        //        {
                        //            MessageBox.Show("Usuario agregado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //            this.Close();
                        //        }
                            }
                            else
                                MessageBox.Show("Este empleado esta en uso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        //if (this.validarCampos())
                        //{
                        //    oUsuario.Nombre = txtbNombre.TextName;
                        //    oUsuario.Clave = txtbClave.TextName;
                        //    oUsuario.Rol = new Rol();
                        //    oUsuario.Rol.IdRol = (int)cboRol.SelectedValue;
                        //    oUsuario.Empleado = new Empleado();
                        //    oUsuario.Empleado.IdEmpleado = (int)this.dgvEmpleados.SelectedRows[0].Cells["idEmpleado"].Value;
                        //    ;

                        //    if (oUsuario.actualizarUsuario(oUsuario))
                        //    {
                        //        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        this.Dispose();
                        //    }
                        //    else
                        //        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                        this.Text = "FarmaTown - Actualizar Empleado";
                        this.cargarDatos();
                     
                        this.txtbNombre.Enabled = true;
                        this.txtbNroDoc.Enabled = true;
                        this.txtbNomFarm.Enabled = true;
                        this.txtbNomCalle.Enabled = true;
                        this.txtbBarrio.Enabled = true;
                        this.txtbLocalidad.Enabled = true;


                        break;
                    }
                case FormMode.delete:
                    {
                        //var decision = MessageBox.Show("Seguro que desea deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        //if (decision == DialogResult.OK)
                        //{

                        //    if (oUsuario.cambiarEstadoUsuario(oUsuario))
                        //    {
                        //        MessageBox.Show("Usuario Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        this.Close();
                        //    }
                        //    else
                        //        MessageBox.Show("Error al deshabilitar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                        break;
                    }
            }
        }

        //MÉTODOS FUNCIONALES

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box y combos
            * según el usuario seleccionado.
            */
            this.txtbNombre.TextName = this.oEmpleado.Nombre;
            this.txtbNroDoc.TextName = this.oEmpleado.NroDoc.ToString();
            this.txtbNomFarm.TextName = this.oEmpleado.Farmacia.Nombre;
            this.txtbNomCalle.TextName = this.oEmpleado.Farmacia.Calle;
            this.txtbBarrio.TextName = this.oEmpleado.Farmacia.Barrio.Nombre;
            this.txtbLocalidad.TextName = this.oEmpleado.Farmacia.Barrio.Localidad.Nombre;



        }

        private void cargarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgv.Rows.Add(table.Rows[i]["idFarmacia"],
                                table.Rows[i]["nomFarmacia"],
                                table.Rows[i]["calle"],
                                table.Rows[i]["numero"],
                                table.Rows[i]["nomBarrio"],
                                table.Rows[i]["nomLocalidad"]); 
            }
        }

        private bool validarCampos()
        { 
            string nombre = this.txtbNombre.TextName;
            string nroDoc = this.txtbNroDoc.TextName;
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (this.dgvFarmacias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir una farmacia",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.dgvFarmacias.Focus();
            }
            else
            {
                return true;
            }
            //Cuando no llegó al último else, entró a 
            // alguno anterior...
            return false;
        }

        /*private bool existeEmpleado()
        {

        }*/

        internal void seleccionarEmpleado(FormMode update, Empleado empleadoSelected)
        {
            formMode = update;
            oEmpleado = empleadoSelected;

        }
    }
}
