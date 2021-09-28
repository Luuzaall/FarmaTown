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
            oTipoDoc = new TipoDocumento();
            oFarmacia = new Farmacia();
            oEmpleado = new Empleado();
            InitializeComponent();
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
            this.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(false), "nombre", "idTipo");
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
                        this.Text = "Nuevo Empleado - FarmaTown";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Empleado - FarmaTown";
                        this.cargarDatos();
                        break;
                    }

                case FormMode.delete:
                    {
                        this.lblAviso.Visible = false;
                        this.cargarDatos();
                        this.Text = "Deshabilitar Empleado - FarmaTown";
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

            this.deshabilitarTextBox();
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
                            if (! this.existeEmpleado())
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

        private void txtbNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbNroDoc.Text.Length;
                if (cant >= 8)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsDigit((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtbPasaporteNro_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbPasaporteNro.Text.Length;
                if (cant >= 6)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsDigit((char)e.KeyCode)
                    || char.IsPunctuation((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtbPasaporteLetras_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Back))
            {
                int cant = this.txtbPasaporteLetras.Text.Length;
                if (cant >= 3)
                {
                    e.SuppressKeyPress = true;
                }
                else if (!char.IsLetter((char)e.KeyCode))
                {
                    e.SuppressKeyPress = true;
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

        //---------------------------------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box y combos
            * según el usuario seleccionado.
            */
            this.txtbNombre.Text = this.oEmpleado.Nombre;
            this.txtbNomFarm.TextName = this.oEmpleado.Farmacia.Nombre;
            this.txtbNomCalle.TextName = this.oEmpleado.Farmacia.Calle;
            this.txtbBarrio.TextName = this.oEmpleado.Farmacia.Barrio.Nombre;
            this.txtbLocalidad.TextName = this.oEmpleado.Farmacia.Barrio.Localidad.Nombre;

            int idTipoDoc = this.oEmpleado.TipoDoc.IdTipo;
            this.cboTipoDoc.SelectedValue = idTipoDoc;
            if (idTipoDoc == 2)
            {
                this.txtbPasaporteLetras.Visible = true;
                this.txtbPasaporteLetras.Enabled = true;
                this.txtbPasaporteNro.Visible = true;
                this.txtbPasaporteNro.Enabled = true;

                this.txtbPasaporteLetras.Text = this.oEmpleado.NroDoc.ToString().Substring(0, 3);
                this.txtbPasaporteNro.Text = this.oEmpleado.NroDoc.ToString().Substring(3);
            }
            else
            {
                this.txtbNroDoc.Enabled = true;
                this.txtbNroDoc.Visible = true;
                this.txtbNroDoc.Text = this.oEmpleado.NroDoc.ToString(); ;
            }

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

            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                MessageBox.Show("Debe ingresar un nombre",
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
            else if ( (int)this.cboTipoDoc.SelectedValue == 2
                && ( string.IsNullOrEmpty(this.txtbPasaporteLetras.Text)
                     || string.IsNullOrEmpty(this.txtbPasaporteNro.Text)) )
            {
                MessageBox.Show("Debe completar el número de pasaporte!",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                 this.txtbPasaporteLetras.Focus();
                 this.txtbPasaporteNro.Focus();
            }
            else if ((int)this.cboTipoDoc.SelectedValue == 1
                && string.IsNullOrEmpty(nroDoc) )
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
                string letrasPasap = this.txtbPasaporteLetras.Text.ToUpper();
                string nroPasap = this.txtbPasaporteNro.Text;
                oEmpleado.NroDoc = letrasPasap + nroPasap;
            }
            else
                oEmpleado.NroDoc = nroDoc;

            oEmpleado.Farmacia = new Farmacia();
            oEmpleado.Farmacia.IdFarmacia = (int)this.dgvFarmacias.SelectedRows[0].Cells[0].Value;

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
    }
}
