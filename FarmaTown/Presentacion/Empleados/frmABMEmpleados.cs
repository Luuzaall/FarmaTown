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
            oEmpleado = new Empleado();
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
                        this.cargarDatos();
                        break;
                    }

                case FormMode.delete:
                    {
                        this.cargarDatos();
                        this.Text = "FarmaTown - Deshabilitar Usuario";
                        this.cargarFila(this.dgvFarmacias);
                        this.txtbNombre.Enabled = false;
                        this.txtbNroDoc.Enabled = false;
                        this.cboTipoDoc.Enabled = false;
                        this.btnLimpiarEmpleado.Enabled = false;
                        this.gbFiltrosFarm.Enabled = false;
                        this.btnRegFarmacia.Enabled = false;

                        break;
                    }
            }
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            /*
             * Limpia los textbox y combobox
             * cuando el usuario haga click en el botón Limpiar.
             */
            this.txtbNombre.Text = "";
            this.txtbNroDoc.Text = "";
            this.txtbPasaporteLetras.Text = "";
            this.txtbPasaporteNro.Text = "";

            this.cboTipoDoc.SelectedIndex = -1;

            this.deshabilitarTextBox(this.txtbNroDoc);
            this.deshabilitarTextBox(this.txtbPasaporteLetras);
            this.deshabilitarTextBox(this.txtbPasaporteNro);
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
                            if (this.existeEmpleado() == false)
                            {

                                var oEmpleado = new Empleado();
                                oEmpleado = this.cargarDatos(oEmpleado);

                                if (oEmpleado.crearEmpleado(oEmpleado))
                                {
                                    MessageBox.Show("Usuario agregado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Este empleado esta en uso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (this.validarCampos())
                        {
                            oEmpleado.Nombre = txtbNombre.Text;
                            oEmpleado.NroDoc = txtbNroDoc.Text;
                            oEmpleado.TipoDoc = new TipoDocumento();
                            oEmpleado.TipoDoc.IdTipo = (int)this.cboTipoDoc.SelectedValue;
                            oEmpleado.Farmacia = new Farmacia();
                            oEmpleado.Farmacia.IdFarmacia = (int)this.dgvFarmacias.SelectedRows[0].Cells[0].Value;
                            ;

                            if (oEmpleado.actualizarEmpleado(oEmpleado))
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
                        if (decision == DialogResult.OK)
                        {

                            if (oEmpleado.cambiarEstadoEmpleado(oEmpleado, false))
                            {
                                MessageBox.Show("Usuario Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnConsultarFarm_Click(object sender, EventArgs e)
        {
            string nomFarmacia = this.txtbNomFarm.TextName;
            string calle = this.txtbNomCalle.TextName;
            string barrio = this.txtbBarrio.TextName;
            string localidad = this.txtbLocalidad.TextName;

            if (string.IsNullOrEmpty(nomFarmacia)
                & string.IsNullOrEmpty(calle)
                & string.IsNullOrEmpty(barrio)
                & string.IsNullOrEmpty(localidad))
            {
                MessageBox.Show("No ingresó ningún dato",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }

            DataTable resultadosFarm = this.oFarmacia.recuperarCParam(nomFarmacia, calle, barrio, localidad);
            this.cargarGrilla(this.dgvFarmacias, resultadosFarm);

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void btnLimpiarFarmacias_Click(object sender, EventArgs e)
        {
            this.txtbNomFarm.TextName = "";
            this.txtbNomCalle.TextName = "";
            this.txtbBarrio.TextName = "";
            this.txtbLocalidad.TextName = "";
        }

        private void cboTipoDoc_DropDownClosed(object sender, EventArgs e)
        {
            int indiceSelecc = (int)this.cboTipoDoc.SelectedIndex;
            if (indiceSelecc != -1)
            {
                int valorSelecc = (int)this.cboTipoDoc.SelectedValue;
                if (valorSelecc == 1 
                    || valorSelecc == 3)
                {
                    this.deshabilitarTextBox(this.txtbPasaporteLetras);
                    this.deshabilitarTextBox(this.txtbPasaporteNro);
                    this.txtbPasaporteLetras.Text = "";
                    this.txtbPasaporteNro.Text = "";

                    this.txtbNroDoc.Visible = true;
                    this.txtbNroDoc.Enabled = true;
                    this.lblAvisoNroDoc.Text = "Debe tener 8 dígitos.";
                }
                else if (valorSelecc == 2)
                {
                    this.deshabilitarTextBox(this.txtbNroDoc);
                    this.txtbNroDoc.Text = "";

                    this.txtbPasaporteLetras.Visible = true;
                    this.txtbPasaporteLetras.Enabled = true;
                    this.txtbPasaporteNro.Visible = true;
                    this.txtbPasaporteNro.Enabled = true;
                    this.lblAvisoNroDoc.Text = "Deben ser 3 letras y 6 números.";

                }
            }

        }

        private void txtbNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada no sea dígito.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbPasaporteLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que no pase de tres letras.
            int cantLetras = this.txtbPasaporteLetras.Text.Length;
            if (cantLetras >= 3)
            {
                e.Handled = true;
            }
        }
        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        //---------------------------------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box y combos
            * según el usuario seleccionado.
            */
            this.txtbNombre.Text = this.oEmpleado.Nombre;
            this.txtbNroDoc.Text = this.oEmpleado.NroDoc.ToString();
            this.txtbNomFarm.TextName = this.oEmpleado.Farmacia.Nombre;
            this.txtbNomCalle.TextName = this.oEmpleado.Farmacia.Calle;
            this.txtbBarrio.TextName = this.oEmpleado.Farmacia.Barrio.Nombre;
            this.txtbLocalidad.TextName = this.oEmpleado.Farmacia.Barrio.Localidad.Nombre;

            this.cboTipoDoc.SelectedValue = this.oEmpleado.TipoDoc.IdTipo;

            int idFarmacia = oEmpleado.Farmacia.IdFarmacia;
            this.seleccionarFila(this.dgvFarmacias, idFarmacia);

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
                int idFila = (int)dgv.Rows[i].Cells[0].Value;
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
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
            dgv.ClearSelection();
        }

        private bool validarCampos()
        { 
            string nombre = this.txtbNombre.Text;
            string nroDoc = this.txtbNroDoc.Text;
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (string.IsNullOrEmpty(nroDoc))
            {

                MessageBox.Show("Debe ingresar un numero de documento",
                "Validación de Datos", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                this.cboTipoDoc.Focus();
            }
            else if (indexCboTipoDoc == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de documento",
                "Validación de Datos", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
                this.txtbNroDoc.Focus();
            }
            else if ((nroDoc.Length < 8 || nroDoc.Length > 8) 
                        & ((int)this.cboTipoDoc.SelectedValue) == 1)
            { 
                MessageBox.Show("Debe ingresar un número de documento válido!",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                this.txtbNroDoc.Focus();
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

        private bool existeEmpleado()
        {
            string nombre = this.txtbNombre.Text;
            string nroDoc = this.txtbNroDoc.Text;
            
            int idFarmacia = (int) this.dgvFarmacias.SelectedRows[0].Cells[0].Value;
            int indexCboTipoDoc = this.cboTipoDoc.SelectedIndex;
            int idTipoDoc;

            if (indexCboTipoDoc == -1)
                idTipoDoc = -1;
            else
                idTipoDoc = (int) this.cboTipoDoc.SelectedValue;

            return oEmpleado.existeEmpleado(nombre, nroDoc, idTipoDoc, idFarmacia);
        }

        internal void seleccionarEmpleado(FormMode _formMode, Empleado empleadoSelected)
        {
            formMode = _formMode;
            oEmpleado = empleadoSelected;
        }

        private Empleado cargarDatos(Empleado oEmpleado)
        {
            string nroDoc = this.txtbNroDoc.Text;

            oEmpleado.Nombre = this.txtbNombre.Text;
            oEmpleado.TipoDoc = new TipoDocumento();
            int idTipo = oEmpleado.TipoDoc.IdTipo = (int)this.cboTipoDoc.SelectedValue;
            if (idTipo == 2)
            {
                string letrasPasap = this.txtbPasaporteLetras.Text;
                string nroPasap = this.txtbPasaporteNro.Text;
                oEmpleado.NroDoc = letrasPasap + nroPasap;
            }
            else
                oEmpleado.NroDoc = nroDoc;



            oEmpleado.Farmacia = new Farmacia();
            oEmpleado.Farmacia.IdFarmacia = (int)this.dgvFarmacias.CurrentRow.Cells[0].Value;

            return oEmpleado;
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

        private void actualizar()
        {
            this.cargarGrilla(dgvFarmacias, oFarmacia.recuperarTodos());
        }

        private void deshabilitarTextBox(TextBox txtb)
        {
            txtb.Enabled = false;
            txtb.Visible = false;

        }
    }
}
