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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMUs = new frmABMUsuario();
            string nomUsuario = (string)this.dgvUsuarios.CurrentRow.Cells[1].Value;
            oUsuario = this.oUsuario.traerUsuario(nomUsuario);
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.delete, oUsuario);
            frmABMUs.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMUs = new frmABMUsuario();
            string nomUsuario = (string)this.dgvUsuarios.CurrentRow.Cells[1].Value;
            oUsuario = this.oUsuario.traerUsuario(nomUsuario);
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.update, oUsuario);
            frmABMUs.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMUs = new frmABMUsuario();
            frmABMUs.ShowDialog();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de cargar los combos
             */
            this.cargarCombo(cboRoles, oRol.recuperarTodos(), "nombre", "idRol");

            DataTable tablaUsuarios = oUsuario.recuperarTodos();
            if (tablaUsuarios.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvUsuarios, tablaUsuarios);
            }
            else
                this.dgvUsuarios.Rows.Add("No se encontraron Usuarios...");
        }
        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
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
                this.dgvUsuarios.ClearSelection();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
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
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
             * Le da oportunidad al usuario al actualizar
             * si quiere ver algún cambio reciente.
             */
            this.cargarGrilla(dgvUsuarios, oUsuario.recuperarTodos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Permite al usuario limpiar sus selecciones si desea.
             */
            this.txtbNombre.TextName = "";
            this.cboRoles.SelectedIndex = -1;
        }
    }
}
