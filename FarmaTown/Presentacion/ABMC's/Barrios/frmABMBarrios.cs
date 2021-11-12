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

namespace FarmaTown.Presentacion.Localidades
{
    public partial class frmABMBarrios : Form
    {
        private FormMode formMode = FormMode.insert;
        Barrio oBarrio;
        Localidad oLocalidad;

        public frmABMBarrios()
        {
            InitializeComponent();
            oBarrio = new Barrio();
            oLocalidad = new Localidad();

        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        //-----------------------------------------------------------------------------------
        //MÉTODOS FUNCIONALES

        //Permite recibir el barrio que se seleccionóen la ventana anterior.
        public void seleccionarBarrio(FormMode _formMode, Barrio barrioSelected)
        {
            formMode = _formMode;
            oBarrio = barrioSelected;
        }

        //Verifica que todos los datos sean válidos para el registro del barrio.
        private bool validarCampos()
        {
            string nombre = this.txtbNombre.Text;
            oLocalidad.IdLocalidad = Convert.ToInt32(this.dgvLocalidades.CurrentRow.Cells[0].Value.ToString());
            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                MessageBox.Show("Debe ingresar un nombre",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.txtbNombre.Focus();
                return false;
            }
            else if 
                (this.dgvLocalidades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una localidad",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        //Devuelve el barrio ya existente
        private bool existeBarrio(string nombre)
        {
            Barrio resultado = this.oBarrio.traerBarrio(nombre);
            if (resultado is null)
            {
                return false;
            }
            else
                return true;
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void frmABMBarrios_Load(object sender, EventArgs e)
        {
            this.cargarGrilla(dgvLocalidades, oLocalidad.recuperarTodos());
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Barrio - FarmaTown";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Barrio - FarmaTown";
                        this.cargarDatos(oBarrio);
                        this.seleccionarFila(this.dgvLocalidades, oBarrio.Localidad.IdLocalidad);
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Barrio - FarmaTown";
                        this.cargarDatos(oBarrio);
                        this.cargarFila(this.dgvLocalidades);

                        this.dgvLocalidades.Enabled = false;
                        this.txtbNombre.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        break;
                    }
            }
        }

        private void cargarDatos(Barrio oBarrio)
        {
            this.txtbNombre.Text = oBarrio.Nombre;
        }

        //Borra todo lo que no esta seleccionado del DataGridView
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

        //Busca en el DataGridView la fila correspondiente al dato que corresponde al id guardado en la base
        //de datos para seleccionarlo para el usuario.
        private void seleccionarFila(DataGridView dgv, int id)
        {
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                int idFila = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }

        //Carga la grilla con los datos necesarios pasados por lista.
        private void cargarGrilla(DataGridView dgv, List<Localidad> lista)
        {
            dgv.Rows.Clear();
            if (lista != null)
            {
                int cantObjs = lista.Count;
                for (int i = 0; i < cantObjs; i++)
                {
                    dgv.Rows.Add(lista[i].IdLocalidad.ToString()
                        , lista[i].Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }

        //Limpia el textbox cuando el usuario haga click en el botón Limpiar.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //El comportamiento del botón depende de lo determinado por el formMode
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtbNombre.Text;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (!this.existeBarrio(nombre))
                            {
                                Barrio oNuevoBarrio = new Barrio();
                                oNuevoBarrio.Nombre = this.txtbNombre.Text;
                                oNuevoBarrio.IdBarrio = Convert.ToInt32(this.dgvLocalidades.SelectedRows[0].Cells[0].Value);
                                oNuevoBarrio.Localidad = new Localidad();
                                oNuevoBarrio.Localidad.IdLocalidad = Convert.ToInt32(this.dgvLocalidades.CurrentRow.Cells[0].Value.ToString());

                                bool resultInsert = oNuevoBarrio.crearBarrio(oNuevoBarrio);
                                if (resultInsert)
                                {
                                    MessageBox.Show("Barrio agregado!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al insertar el Barrio!", "Información"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Este Barrio ya está registrado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oBarrio.Nombre = this.txtbNombre.Text;
                            oBarrio.Localidad = new Localidad();
                            oBarrio.Localidad.IdLocalidad = Convert.ToInt32(this.dgvLocalidades.SelectedRows[0].Cells[0].Value);

                            bool resultActualiz = this.oBarrio.actualizar(oBarrio);
                            if (resultActualiz)
                            {
                                MessageBox.Show("Barrio actualizado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Barrio!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el Barrio seleccionado?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oBarrio.cambiarEstado(oBarrio))
                            {
                                MessageBox.Show("Barrio Deshabilitado!", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al deshabilitar el Barrio", "Información"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnAceptar, e);
        }
    }
}