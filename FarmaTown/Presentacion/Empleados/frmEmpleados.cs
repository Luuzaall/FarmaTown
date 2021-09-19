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

namespace FarmaTown.Presentacion.Empleados
{
    public partial class frmEmpleados : Form
    {
        Empleado oEmpleado;
        TipoDocumento oTipoDoc;
        frmABMEmpleados frmABMEmpl;
        public frmEmpleados()
        {
            oEmpleado = new Empleado();
            oTipoDoc = new TipoDocumento();
            InitializeComponent();
        }

        //MÉTODOS A RESPUESTA DE EVENTOS


        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.deshabilitarBotones();
            this.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos()
                , "nombre", "idTipo");
            DataTable tablaUsuarios = oEmpleado.recuperarTodos();
            if (tablaUsuarios.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvEmpleados, tablaUsuarios);
            }
            else
                this.dgvEmpleados.Rows.Add("No se encontraron Usuarios...");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario y filtra
             */
            if (this.validarCampos())
            {
                DataTable resultadosEmpleados;
                int idTipoDoc;
                string nomEmpl = this.txtbNombre.Text;
                string nroDoc = this.txtbNroDoc.Text;
                string nomFarm = this.txtbFarmacia.TextName;
                
                if (this.cboTipoDoc.SelectedIndex == -1)
                {
                    idTipoDoc = -1;
                }
                else
                {
                    idTipoDoc = (int) this.cboTipoDoc.SelectedValue;
                }

                resultadosEmpleados = this.oEmpleado.recuperarEmpleadoCParametros(nomEmpl, nroDoc, idTipoDoc, nomFarm);
                this.cargarGrilla(this.dgvEmpleados, resultadosEmpleados);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Permite al usuario limpiar sus selecciones si desea.
             */
            this.txtbNombre.TextName = "";
            this.txtbNroDoc.Text = "";
            this.txtbFarmacia.TextName = "";
            this.cboTipoDoc.SelectedIndex = -1;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Habilita los botones para poder ser seleccionados,
             * proyenedo una invitación visual
             */
            this.btnEditar.Enabled = true;
            this.btnEditar.BackColor = Color.FromArgb(116, 201, 79);
            this.btnEliminar.Enabled = true;
            this.btnEliminar.BackColor = Color.FromArgb(116, 201, 79);
            this.lblAviso.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
             * Le da oportunidad al usuario al actualizar
             * si quiere ver algún cambio reciente.
             */
            this.actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMEmpl = new frmABMEmpleados();
            frmABMEmpl.ShowDialog();
            this.actualizar();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMEmpl = new frmABMEmpleados();
            int idEmpleado = (int) this.dgvEmpleados.CurrentRow.Cells[0].Value;
            oEmpleado = this.oEmpleado.traerEmpleado(idEmpleado);
            frmABMEmpl.seleccionarEmpleado(frmABMEmpleados.FormMode.delete, oEmpleado);
            frmABMEmpl.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //MÉTODOS FUNCIONALES

        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
            /*
             * Carga la grilla con los datos necesarios
             */
            dgv.Rows.Clear();
            if (table != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgv.Rows.Add(table.Rows[i]["idEmpleado"],
                                table.Rows[i]["nomEmpleado"],
                                table.Rows[i]["nroDoc"],
                                table.Rows[i]["nomTipoDoc"],
                                table.Rows[i]["nomFarmacia"]);
                }
                dgv.ClearSelection();
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

        private bool validarCampos()
        {
            string nom = this.txtbNombre.TextName;
            string nroDoc = this.txtbNroDoc.Text;
            string nomFarmacia = this.txtbFarmacia.TextName;
            bool tieneLetrasNroDoc = nroDoc.Any(x => !char.IsLetter(x));

            if (string.IsNullOrEmpty(nom)
                & string.IsNullOrEmpty(nroDoc)
                & string.IsNullOrEmpty(nomFarmacia)
                & this.cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar algún dato!",
                    "Validación de Datos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return false;
            }
            return true;

        }


        private void actualizar()
        {
            this.cargarGrilla(dgvEmpleados, oEmpleado.recuperarTodos());
            this.deshabilitarBotones();
        }

        private void deshabilitarBotones()
        {
            /*
             * Deshabilita los botones cambiándoles
             * el color para que el usuario visualmente
             * lo vea
             */
            this.btnEditar.Enabled = false;
            this.btnEditar.BackColor = Color.Gray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.BackColor = Color.Gray;
            this.lblAviso.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMEmpl = new frmABMEmpleados();
            int idEmpleado = (int) this.dgvEmpleados.CurrentRow.Cells[0].Value;
            oEmpleado = this.oEmpleado.traerEmpleado(idEmpleado);
            frmABMEmpl.seleccionarEmpleado(frmABMEmpleados.FormMode.update, oEmpleado);
            frmABMEmpl.ShowDialog();
            this.actualizar();

        }

        private void txtbNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada no sea dígito.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
