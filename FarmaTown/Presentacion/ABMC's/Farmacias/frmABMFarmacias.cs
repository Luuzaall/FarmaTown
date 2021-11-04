using FarmaTown.Logica;
using FarmaTown.Presentacion.Localidades;
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

namespace FarmaTown.Presentacion.Farmacias
{
    public partial class frmABMFarmacias : Form
    {
        private FormMode formMode = FormMode.insert;
        private Farmacia oFarmacia;
        private Barrio oBarrio;

        public frmABMFarmacias()
        {
            oFarmacia = new Farmacia();
            oBarrio = new Barrio();
            InitializeComponent();

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

        public void seleccionarFarmacia(FormMode _formMode, Farmacia farmaciaSelected)
        {
            /*
             * Se obtiene el usuario seleccionado
             * y el modo de apertura del formABMUsuarios
             */
            formMode = _formMode;
            oFarmacia = farmaciaSelected;
        }

        private void frmABMFarmacias_Load(object sender, EventArgs e)
        {
            this.mostrarBarrios();
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Farmacia - FarmaTown";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Farmacia - FarmaTown";
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbCalle.Enabled = true;
                        this.txtbNumero.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.cargarDatos();
                        this.Text = "Deshabilitar Farmacia - FarmaTown";
                        this.cargarFila(this.dgvBarrios);
                        this.txtbNombre.Enabled = false;
                        this.txtbCalle.Enabled = false;
                        this.txtbNumero.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        this.btnRegBarrio.Enabled = false;
                        break;
                    }
            }
        }

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box
            * según la farmacia seleccionada.
            */
            this.txtbNombre.Text = this.oFarmacia.Nombre;
            this.txtbCalle.Text = this.oFarmacia.Calle;
            this.txtbNumero.Text = this.oFarmacia.Numero.ToString();

            this.seleccionarFila(this.dgvBarrios, oFarmacia.Barrio.IdBarrio);
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
             * de datos para seleccionarlo para la farmacia.
             */
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                int idFila = Convert.ToInt32(dgv.Rows[i].Cells[0].Value.ToString());
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void mostrarBarrios()
        {
            List<Barrio> tablaBarrios = oBarrio.recuperarTodos();

            
            this.cargarGrilla(this.dgvBarrios, tablaBarrios);
            
        }

        private void cargarGrilla(DataGridView dgv, List<Barrio> lista)
        {
            /*
                * Carga la grilla con los datos necesarios
                */
            dgv.Rows.Clear();
            if (lista != null)
            {
                int cantObjs = lista.Count;
                for (int i = 0; i < cantObjs; i++)
                {
                    dgv.Rows.Add(lista[i].IdBarrio.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].Localidad.Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void limpiarDatos()
        {
            this.txtbNombre.Text = "";
            this.txtbCalle.Text = "";
            this.txtbNumero.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (this.existeFarmacia() == false)
                            {
                                var oFarmacia = new Farmacia();
                                oFarmacia.Nombre = this.txtbNombre.Text;
                                oFarmacia.Calle = this.txtbCalle.Text;
                                oFarmacia.Numero = Convert.ToInt32(this.txtbNumero.Text);
                                oFarmacia.Barrio = new Barrio();
                                oFarmacia.Barrio.IdBarrio = Convert.ToInt32(this.dgvBarrios.CurrentRow.Cells[0].Value.ToString());

                                if (oFarmacia.crearFarmacia(oFarmacia))
                                {
                                    MessageBox.Show("Farmacia agregada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("La farmacia que intenta ingresar ya esta en el sistema!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (this.validarCampos())
                        {
                            oFarmacia.Nombre = txtbNombre.Text;
                            oFarmacia.Calle = txtbCalle.Text;
                            oFarmacia.Numero = Convert.ToInt32(txtbNumero.Text);
                            oFarmacia.Barrio = new Barrio();
                            oFarmacia.Barrio.IdBarrio = Convert.ToInt32(this.dgvBarrios.SelectedRows[0].Cells[0].Value);
                            ;

                            if (oFarmacia.actualizarFarmacia(oFarmacia))
                            {
                                MessageBox.Show("Farmacia actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la farmacia!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar la farmacia seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oFarmacia.cambiarEstadoFarmacia(oFarmacia, false))
                            {
                                MessageBox.Show("Farmacia Deshabilitada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar la farmacia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

            }
        }

        private bool existeFarmacia()
        {
            string nom = this.txtbNombre.Text;
            string calle = this.txtbCalle.Text;
            string num = this.txtbNumero.Text;
            List<Farmacia> farma = this.oFarmacia.recuperarCParam(this.txtbNombre.Text, this.txtbCalle.Text, this.txtbNumero.Text, this.dgvBarrios.CurrentRow.Cells[1].Value.ToString(), this.dgvBarrios.CurrentRow.Cells[2].Value.ToString());
            if (farma.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarCampos()
        {
            string nom = this.txtbNombre.Text;
            string calle = this.txtbCalle.Text;
            string num = this.txtbNumero.Text;

            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
            }
            else if (string.IsNullOrEmpty(calle))
            {
                MessageBox.Show("Debe ingresar un nombre de calle",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbCalle.Focus();
            }
            else if (string.IsNullOrEmpty(num))
            {
                MessageBox.Show("Debe ingresar un numero de direccion",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNumero.Focus();
            }
            else if (this.dgvBarrios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe elegir un barrio",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.dgvBarrios.Focus();
            }
            else
            {
                return true;
            }
            //Cuando no llegó al último else, entró a 
            // alguno anterior...
            return false;
        }

        private void btnRegBarrio_Click(object sender, EventArgs e)
        {
            frmABMBarrios barrios = new frmABMBarrios();
            barrios.ShowDialog();
            this.mostrarBarrios();
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
            TextBoxService.noDigitos(e);
        }

        private void txtbCalle_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
            TextBoxService.noDigitos(e);
        }

        private void txtbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
        }
    }
}
