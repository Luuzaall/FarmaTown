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
    public partial class frmABMUsuarios : Form
    {
        private Rol oRol;
        private frmABMUsuario frmABMUs = new frmABMUsuario();
        private Usuario oUsuario;
        public frmABMUsuarios()
        {
            oRol = new Rol();
            oUsuario = new Usuario();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.delete, oUsuario);
            frmABMUs.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMUs.seleccionarUsuario(frmABMUsuario.FormMode.update, oUsuario);
            frmABMUs.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMUs.ShowDialog();
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de cargar los combos
             */
            this.cargarCombo(cboRoles, oRol.recuperarTodos(), "nombre", "idRol");

            DataTable tablaUsuarios = oUsuario.recuperarTodos();
            if (tablaUsuarios.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvUsuarios, tablaUsuarios);
                this.dgvUsuarios.ClearSelection();
            }
            else
                this.dgvUsuarios.Rows.Add("No se encontraron Usuarios...");
        }
        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgv.Rows.Add(table.Rows[i]["idUsuario"],
                                table.Rows[i]["nomUsuario"],
                                table.Rows[i]["nomRol"],
                                table.Rows[i]["nomEmpleado"]); ;
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
            string idRol = this.cboRoles.SelectedValue.ToString();
            
            if (string.IsNullOrEmpty(usuario)
                & this.cboRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un usuario o un Rol",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.txtbNombre.Focus();
                this.cboRoles.Focus();
                this.cargarGrilla(this.dgvUsuarios, this.oUsuario.recuperarTodos());
            }

            DataTable resultadosUsuarios = this.oUsuario.recurperarUsuarioCParametros(usuario, idRol);
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
    }
}
