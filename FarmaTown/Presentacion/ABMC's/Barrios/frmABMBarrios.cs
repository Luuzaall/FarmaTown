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

        public frmABMBarrios()
        {
            InitializeComponent();
            oBarrio = new Barrio();

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
            int localidad = (int)this.dgvLocalidades.SelectedRows[0].Cells[0].Value;
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
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Barrio - FarmaTown";
                        this.txtbNombre.Text = oBarrio.Nombre;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Barrio - FarmaTown";
                        this.txtbNombre.Text = oBarrio.Nombre;
                        this.txtbNombre.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        break;

                    }
            }
        }


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
                                oNuevoBarrio.Nombre = nombre;
                                oNuevoBarrio.IdBarrio = (int)this.dgvLocalidades.SelectedRows[0].Cells[0].Value;

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
                            oBarrio.IdBarrio = (int)this.dgvLocalidades.SelectedRows[0].Cells[0].Value;

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
                        var decision = MessageBox.Show("Seguro que desea deshabilitar el Barrio seleccionada?"
                            , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (decision == DialogResult.OK)
                        {

                            if (oBarrio.cambiarEstado(oBarrio, false))
                            {
                                MessageBox.Show("Barrio Deshabilitada!", "Información"
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