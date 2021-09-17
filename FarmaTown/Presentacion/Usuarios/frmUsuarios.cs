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
    public partial class frmUsuarios : Form
    {
        private Rol oRol;
        private frmABMUsuario frmABMUs;
        private Usuario oUsuario;
        public frmUsuarios()
        {
            InitializeComponent();
            oRol = new Rol();
            oUsuario = new Usuario();
        }

        // MÉTODOS RESPUESTA A EVENTOS

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de preparar los combos, grillas y 
             * botones del formulario.
             */
            this.cargarCombo(cboRoles, oRol.recuperarTodos(), "nombre", "idRol");
            this.deshabilitarBotones();
            DataTable tablaUsuarios = oUsuario.recuperarTodos();
            if (tablaUsuarios.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvUsuarios, tablaUsuarios);
            }
            else
                this.dgvUsuarios.Rows.Add("No se encontraron Usuarios...");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Permite al usuario limpiar sus selecciones si desea.
             */
            this.txtbNombre.TextName = "";
            this.cboRoles.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario
             */
            string usuario = this.txtbNombre.TextName;
            DataTable resultadosUsuarios = null;

            if (string.IsNullOrEmpty(usuario)
                && this.cboRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un usuario o un Rol",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.txtbNombre.Focus();
                this.cboRoles.Focus();
                resultadosUsuarios = oUsuario.recuperarTodos();
            }
            else if (!(this.cboRoles.SelectedIndex == -1))
            {
                string idRol = this.cboRoles.SelectedValue.ToString();
                resultadosUsuarios = this.oUsuario.recurperarUsuarioCParametros(usuario, idRol);
            }
            else
            {
                resultadosUsuarios = this.oUsuario.recurperarUsuarioCParametros(usuario, "-1");

            }
            this.cargarGrilla(this.dgvUsuarios, resultadosUsuarios);

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
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
            frmABMUs = new frmABMUsuario();
            frmABMUs.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMUs = new frmABMUsuario();
            string nomUsuario = (string)this.dgvUsuarios.CurrentRow.Cells[1].Value;
            oUsuario = this.oUsuario.traerUsuario(nomUsuario);
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.update, oUsuario);
            frmABMUs.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMUs = new frmABMUsuario();
            string nomUsuario = (string)this.dgvUsuarios.CurrentRow.Cells[1].Value;
            oUsuario = this.oUsuario.traerUsuario(nomUsuario);
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.delete, oUsuario);
            frmABMUs.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MÉTODOS FUNCIONALES


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
                    dgv.Rows.Add(table.Rows[i]["idUsuario"],
                                    table.Rows[i]["nomUsuario"],
                                    table.Rows[i]["nomRol"],
                                    table.Rows[i]["nomEmpleado"]); ;
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


        private void actualizar()
        {
            this.cargarGrilla(dgvUsuarios, oUsuario.recuperarTodos());
            this.deshabilitarBotones();
        }

    }
}
