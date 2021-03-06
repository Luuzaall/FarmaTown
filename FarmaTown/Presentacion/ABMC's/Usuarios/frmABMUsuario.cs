using FarmaTown.Logica;
using FarmaTown.Presentacion.Empleados;
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
            ComboBoxService.cargarCombo(this.cboRol, oRol.recuperarTodos(), "nombre", "idRol");
            this.mostrarEmpleados();
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario - FarmaTown";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario - FarmaTown";
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbClave.Enabled = true;
                        this.txtbClaveRep.Enabled = true;
                        this.cboRol.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.cargarDatos();
                        this.Text = "Deshabilitar Usuario - FarmaTown";
                        this.cargarFila(this.dgvEmpleados);
                        this.txtbNombre.Enabled = false;
                        this.txtbClave.Enabled = false;
                        this.txtbClaveRep.Enabled = false;
                        this.cboRol.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        this.btnRegEmpleado.Enabled = false;
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
            this.txtbNombre.Text = this.oUsuario.Nombre;
            this.txtbClave.Text =
                this.txtbClaveRep.Text = this.oUsuario.Clave;
            this.cboRol.SelectedValue = this.oUsuario.Rol.IdRol;

            this.seleccionarFila(this.dgvEmpleados, oUsuario.Empleado.IdEmpleado);
        }

        private void cargarFila(DataGridView dgv)
        {
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                bool estaSelecc = dgv.Rows[i].Selected;
                if (!estaSelecc)
                {
                    dgv.Rows.RemoveAt(i);
                    i = i - 1;
                }
                cantFilasdgv = dgv.RowCount;
            }
        }
        private void seleccionarFila(DataGridView dgv, int id)
        {
            /*
             * Busca en el DataGridView la fila correspondiente
             * al dato que corresponde al id guardado en la base
             * de datos para seleccionarlo para el usuario.
             */
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                int idFila = int.Parse(dgv.Rows[i].Cells[0].Value.ToString() );
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
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
                                oUsuario.Nombre = this.txtbNombre.Text;
                                oUsuario.Clave = this.txtbClave.Text;
                                oUsuario.Rol = new Rol();
                                oUsuario.Rol.IdRol = (int)this.cboRol.SelectedValue;
                                oUsuario.Empleado = new Empleado();
                                oUsuario.Empleado.IdEmpleado = int.Parse( this.dgvEmpleados.CurrentRow.Cells[0].Value.ToString() );

                                if (oUsuario.crearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario agregado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Este nombre de usuario esta en uso! Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break; 
                    }
                case FormMode.update:
                    {
                        if (this.validarCampos())
                        {
                            oUsuario.Nombre = txtbNombre.Text;
                            oUsuario.Clave = txtbClave.Text;
                            oUsuario.Rol = new Rol();
                            oUsuario.Rol.IdRol = (int)cboRol.SelectedValue;
                            oUsuario.Empleado = new Empleado();
                            oUsuario.Empleado.IdEmpleado = int.Parse(this.dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString() );
;

                            if (oUsuario.actualizarUsuario(oUsuario))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if ( decision == DialogResult.OK)
                        {

                            if (oUsuario.cambiarEstadoUsuario(oUsuario))
                            {
                                MessageBox.Show("Usuario Deshabilitado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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
            string nomUs = this.txtbNombre.Text;
            Usuario usEncontrado = this.oUsuario.traerUsuario(nomUs);
            if ( usEncontrado is null)
            {
                return false;
            }
            return true;
        }

        private bool validarCampos()
        {
            string nom = this.txtbNombre.Text;
            string clave = this.txtbClave.Text;
            string claveRep = this.txtbClaveRep.Text;
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

        private void cargarGrilla(DataGridView dgv, List<Empleado> lista)
        {
            /*
             * Carga la grilla con los datos necesarios
             */
            dgv.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    dgv.Rows.Add(lista[i].IdEmpleado.ToString(),
                                lista[i].Nombre.ToString(),
                                lista[i].NroDoc.ToString(),
                                lista[i].TipoDoc.Nombre.ToString(),
                                lista[i].Farmacia.Nombre.ToString()); ;
                }
                dgv.ClearSelection();
            }
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
            this.txtbClave.Text = "";
            this.txtbClaveRep.Text = "";
            this.cboRol.SelectedIndex = -1;
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            TextBoxService.verClave(this.txtbClave, this.btnVerClave);
        }

        private void btnVerClaveRep_Click(object sender, EventArgs e)
        {
            TextBoxService.verClave(this.txtbClaveRep, this.btnVerClaveRep);
        }

        private void mostrarEmpleados()
        {
            List<Empleado> listaEmpleados = oEmpleado.recuperarTodos();

            if (listaEmpleados.Count > 0)
            {
                this.cargarGrilla(this.dgvEmpleados, listaEmpleados);
                this.dgvEmpleados.ClearSelection();
            }
            else
                this.dgvEmpleados.Rows.Add("No se encontraron empleados...");
        }

        private void btnRegEmpleado_Click(object sender, EventArgs e)
        {
            frmABMEmpleados frmABMEmpl = new frmABMEmpleados();
            frmABMEmpl.ShowDialog();

            this.mostrarEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarGrilla(this.dgvEmpleados, oEmpleado.recuperarTodos());
        }

        private void txtbEnter_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
        }
    }
}
