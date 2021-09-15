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

namespace FarmaTown.Presentacion
{
    public partial class frmABMUsuario : Form
    {
        //Atributos
        private FormMode formMode = FormMode.insert;
        private Usuario oUsuario;
        private Rol oRol;
        private Empleado oEmpleado;
        public frmABMUsuario()
        {
            /*
            * Inicializa el formulario con los
            * objetos que necesitará en su trabajo
            */
            InitializeComponent();
            oUsuario = new Usuario();
            oRol = new Rol();
            oEmpleado = new Empleado();
        }

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

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            /*
             * Carga del formulario, dependiendo de la razón de la cual 
             * fue llamado, definido en el switch de los distintos
             * FormMode.
             */

            //Llenar combo
            this.cargarCombo(this.cboRol, oRol.recuperarTodos(), "nombre", "idRol");

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        DataTable tablaEmpleados = oEmpleado.recuperarTodos();
                        this.limpiarDatos();
                        if (tablaEmpleados.Rows.Count > 0)
                        {
                            this.cargarGrilla(this.dgvEmpleados, tablaEmpleados);
                            this.dgvEmpleados.ClearSelection();
                        }
                        else
                            this.dgvEmpleados.Rows.Add("No se encontraron empleados...");
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        DataTable tablaEmpleados = oEmpleado.recuperarTodos();
                        if (tablaEmpleados.Rows.Count > 0)
                        {
                            this.cargarGrilla(this.dgvEmpleados, tablaEmpleados);
                            this.dgvEmpleados.ClearSelection();
                        }
                        else
                            this.dgvEmpleados.Rows.Add("No se encontraron empleados...");
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbClave.Enabled = true;
                        this.txtbClaveRep.Enabled = true;
                        this.cboRol.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        //MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        //txtNombre.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtPassword.Enabled = false;
                        //cboPerfil.Enabled = false;
                        //txtConfirmarPass.Enabled = false;
                        break;
                    }
            }
        }

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box y combos
            * según el usuario seleccionado.
            */
            this.txtbNombre.TextName = this.oUsuario.Nombre;
            this.txtbClave.TextName = 
                this.txtbClaveRep.TextName = this.oUsuario.Clave;
            this.cboRol.SelectedValue = this.oUsuario.Rol.IdRol;
            int cantFilasDvg = this.dgvEmpleados.RowCount;
            for(int i = 0; i < cantFilasDvg; i++)
            {

            }
        }
        private void limpiarDatos()
        {
            /*
             * Limpia los textbox y
             * los combos para un nuevo ingreso
             * de los mismos
             */
            this.txtbNombre.TextName = "";
            this.txtbClave.TextName = "";
            this.txtbClaveRep.TextName = "";
            this.cboRol.SelectedIndex = -1;
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
                            if (this.existeUsuario() == false)
                            {
                                var oUsuario = new Usuario();
                                oUsuario.Nombre = this.txtbNombre.TextName;
                                oUsuario.Clave = this.txtbClave.TextName;
                                oUsuario.Rol = new Rol();
                                oUsuario.Rol.IdRol = (int)this.cboRol.SelectedValue;
                                oUsuario.Empleado = new Empleado();
                                oUsuario.Empleado.IdEmpleado = (int)this.dgvEmpleados.CurrentRow.Cells[0].Value;

                                if (oUsuario.crearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Nombre de usuario encontrado! Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break; 
                    }
                case FormMode.update:
                    {
                        //if (ValidarCampos())
                        //{
                        //    oUsuarioSelected.NombreUsuario = txtNombre.Text;
                        //    oUsuarioSelected.Password = txtPassword.Text;
                        //    oUsuarioSelected.Email = txtEmail.Text;
                        //    oUsuarioSelected.Perfil = new Perfil();
                        //    oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                        //    if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                        //    {
                        //        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        this.Dispose();
                        //    }
                        //    else
                        //        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        break;
                    }
                case FormMode.delete:
                    {
                        //if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        //{

                        //    if (oUsuarioService.ModificarEstadoUsuario(oUsuarioSelected))
                        //    {
                        //        MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        this.Close();
                        //    }
                        //    else
                        //        MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}

                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool existeUsuario()
        {
            /*
             * Determina si ya existe un usuario
             * con el mismo nombre, retornando FALSE
             * si no existe y TRUE si existe.
             */
            string nomUs = this.txtbNombre.TextName;
            Usuario usEncontrado = this.oUsuario.traerUsuario(nomUs);
            if ( usEncontrado is null)
            {
                return false;
            }
            return true;
        }

        private bool validarCampos()
        {
            string nom = this.txtbNombre.TextName;
            string clave = this.txtbClave.TextName;
            string claveRep = this.txtbClaveRep.TextName;
            int indexRol = this.cboRol.SelectedIndex;

            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (nom.Count() < 3)
            {
                MessageBox.Show("Debe ingresar un nombre válido, mínimo 3 carácteres",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar una clave",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbClave.Focus();
            }
            
            else if (clave.Count() < 4)
            {
                MessageBox.Show("La clave mínimo 4 carácteres",
                   "Validación de Datos", MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
                this.txtbClave.Focus();
            }
            else if (string.IsNullOrEmpty(claveRep))
            {
                MessageBox.Show("Debe repetir la clave",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbClaveRep.Focus();
            }
            else if (indexRol == -1)
            {
                MessageBox.Show("Debe seleccionar un Rol",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.cboRol.Focus();
            }
            else if (clave != claveRep)
            {
                MessageBox.Show("La clave repetida debe coincidir con la primera!",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbClaveRep.Focus();
            }
            else if (this.dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir un empleado",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.dgvEmpleados.Focus();
            }
            else
            {
                return true;
            }
            //Cuando no llegó al último else, entró a 
            // alguno anterior...
            return false;
        }

        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgv.Rows.Add(table.Rows[i]["idEmpleado"],
                                table.Rows[i]["nomEmpleado"],
                                table.Rows[i]["nroDoc"],
                                table.Rows[i]["nomTipoDoc"],
                                table.Rows[i]["nomFarmacia"]); ;
            }
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void seleccionarUsuario(FormMode _formMode, Usuario usuarioSelected)
        {
            /*
             * Se obtiene el usuario seleccionado
             * y el modo de apertura del formABMUsuarios
             */
            formMode = _formMode;
            oUsuario = usuarioSelected;
        }
    }
}
