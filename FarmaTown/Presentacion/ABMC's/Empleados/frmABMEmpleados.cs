using FarmaTown.Logica;
using FarmaTown.Presentacion.Farmacias;
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
            ComboBoxService.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(false), "nombre", "idTipo");
            List<Farmacia> listaFarmacias = oFarmacia.recuperarTodos();

            if (listaFarmacias.Count > 0)
            {
                this.cargarGrilla(this.dgvFarmacias, listaFarmacias);
            }
            else
            {
                this.dgvFarmacias.Columns.Clear();

            }

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
                        this.cargarDatos();
                        this.Text = "Deshabilitar Empleado - FarmaTown";
                        this.cargarFila(this.dgvFarmacias);

                        this.lblAviso.Visible = false;
                        this.txtbNombre.Enabled = false;
                        this.txtbNroDoc.Enabled = false;
                        this.cboTipoDoc.Enabled = false;
                        this.btnLimpiarEmpleado.Enabled = false;

                        this.gbFarmacias.Enabled = false;

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
            string nomFarmacia = this.txtbNomFarm.Text;
            string calle = this.txtbNomCalle.Text;
            string barrio = this.txtbBarrio.Text;
            string localidad = this.txtbLocalidad.Text;

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

            List<Farmacia> resultadosFarm = this.oFarmacia.recuperarCParam(nomFarmacia, calle,"", barrio, localidad);
            this.cargarGrilla(this.dgvFarmacias, resultadosFarm);

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void btnLimpiarFarmacias_Click(object sender, EventArgs e)
        {
            this.txtbNomFarm.Text = "";
            this.txtbNomCalle.Text = "";
            this.txtbBarrio.Text = "";
            this.txtbLocalidad.Text = "";
        }

        private void cboTipoDoc_SelectionChangeCommited(object sender, EventArgs e)
        {
            /*
             *Permite actualizar el aviso de lo que
             *debe ingresar para el textbox correspondiente
            * al número de documento.

            *
            *Además, pone a la vista los textbox
             *correctos para el tipo de documento
            * que se haya elegido
            */

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

        private void btnRegFarmacia_Click(object sender, EventArgs e)
        {
            frmABMFarmacias farmacias = new frmABMFarmacias();
            farmacias.ShowDialog();

            this.actualizar();
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
            TextBoxService.enter(this.btnAceptar, e);
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
            TextBoxService.enter(this.btnAceptar, e);
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
            TextBoxService.enter(this.btnAceptar, e);
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnAceptar);
        }

        private void txtbNomFarm_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnConsultarFarm);
        }

        private void txtbBarrio_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnConsultarFarm);
        }

        private void txtbNomCalle_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnConsultarFarm);
        }

        private void txtbLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnConsultarFarm);
        }

        private void dgvFarmacias_KeyDown(object sender, KeyEventArgs e)
        {
            this.verificarIngresoLetra(e, this.btnAceptar);
        }

        private void verificarIngresoLetra(KeyEventArgs e, Button btn)
        {
            TextBoxService.enter(btn, e);
            TextBoxService.noDigitos(e);
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
            this.txtbNomFarm.Text = this.oEmpleado.Farmacia.Nombre;
            this.txtbNomCalle.Text = this.oEmpleado.Farmacia.Calle;
            this.txtbBarrio.Text = this.oEmpleado.Farmacia.Barrio.Nombre;
            this.txtbLocalidad.Text = this.oEmpleado.Farmacia.Barrio.Localidad.Nombre;

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
                int idFila = int.Parse(dgv.Rows[i].Cells[0].Value.ToString() );
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void cargarGrilla(DataGridView dgv, List<Farmacia> lista)
        {
            /*
                * Carga la grilla con los datos necesarios
                * pasado por lista.
                */
            dgv.Rows.Clear();
            if (lista != null)
            {
                int cantObjs = lista.Count;
                for (int i = 0; i < cantObjs; i++)
                {
                    dgv.Rows.Add(lista[i].IdFarmacia.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].Calle.ToString()
                        , lista[i].Numero.ToString()
                        , lista[i].Barrio.Nombre.ToString()
                        , lista[i].Barrio.Localidad.Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
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
            else if(nombre.Length <= 2)
            {
                MessageBox.Show("Debe ingresar un nombre válido",
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
                     || string.IsNullOrEmpty(this.txtbPasaporteNro.Text)
                     || this.txtbPasaporteLetras.Text.Length < 3
                     || this.txtbPasaporteNro.Text.Length < 6) ) 
            {
                MessageBox.Show("Debe completar el número de pasaporte!",
                       "Validación de Datos", MessageBoxButtons.OK
                       , MessageBoxIcon.Information);
                 this.txtbPasaporteLetras.Focus();
                 this.txtbPasaporteNro.Focus();
            }
            else if ((int)this.cboTipoDoc.SelectedValue == 1
                && (string.IsNullOrEmpty(nroDoc)
                    || nroDoc.Length <8) )
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
            
            int idFarmacia =  int.Parse( this.dgvFarmacias.SelectedRows[0].Cells[0].Value.ToString() );
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
            oEmpleado.Farmacia.IdFarmacia = int.Parse( this.dgvFarmacias.SelectedRows[0].Cells[0].Value.ToString() );

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
