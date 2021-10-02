﻿using FarmaTown.Logica;
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

        public void seleccionarBarrio(FormMode _formMode, Barrio barrioSelected)
        {
            formMode = _formMode;
            oBarrio = barrioSelected;
        }

        private bool validarCampos()
        {
            string nombre = this.txtbNombre.Text;
            //Nueva:
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
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Barrio - FarmaTown";
                        this.cargarGrilla(dgvLocalidades, oLocalidad.recuperarTodos(true));
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Barrio - FarmaTown";
                        this.txtbNombre.Text = oBarrio.Nombre;
                        this.cargarGrilla(dgvLocalidades, oLocalidad.recuperarTodos(true));
                        this.seleccionarFila(this.dgvLocalidades, oLocalidad.IdLocalidad);
                        this.dgvLocalidades.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Barrio - FarmaTown";
                        this.txtbNombre.Text = oBarrio.Nombre;
                        this.cargarGrilla(dgvLocalidades, oLocalidad.recuperarTodos(false));
                        this.cargarFila(this.dgvLocalidades);
                        this.dgvLocalidades.Enabled = false;
                        this.txtbNombre.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        break;

                    }
            }
        }


        //NUEVO DESDE ACA

        private void cargarFila(DataGridView dgv)
        {
            //Borra todo lo que no esta seleccionado de la dgv
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
                int idFila = Convert.ToInt32(dgv.Rows[i].Cells[0].Value.ToString());
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }
        private void cargarGrilla(DataGridView dgv, List<Localidad> lista)
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
                    dgv.Rows.Add(lista[i].IdLocalidad.ToString()
                        , lista[i].Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }
        // HASTA ACA
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                                //oNuevoBarrio.Nombre = nombre;
                                //nueva, vieja la de arriba
                                oNuevoBarrio.Nombre = this.txtbNombre.Text;
                                oNuevoBarrio.IdBarrio = Convert.ToInt32(this.dgvLocalidades.SelectedRows[0].Cells[0].Value);
                                //Nueva:
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
                            //¿que hace la linea que sige??
                            //oBarrio.IdBarrio = Convert.ToInt32( this.dgvLocalidades.SelectedRows[0].Cells[0].Value.ToString() );
                            oBarrio.Localidad = new Localidad();
                            //Nueva:
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

                            if (oBarrio.cambiarEstado(oBarrio, false))
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
    }
}