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

namespace FarmaTown.Presentacion
{
    public partial class frmUsuarios : Form
    {
        private Rol oRol;
        private frmABMUsuario frmABMUs;
        private Usuario oUsuario;

        public frmUsuarios()
        {
            oRol = new Rol();
            oUsuario = new Usuario();
            InitializeComponent();
        }

        // MÉTODOS RESPUESTA A EVENTOS

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de preparar los combos, grillas y 
             * botones del formulario.
             */
            ComboBoxService.cargarCombo(cboRoles, oRol.recuperarTodos(), "nombre", "idRol");
            this.deshabilitarBotones();
            List<Usuario> listaUsuarios = oUsuario.recuperarTodos();
            if (listaUsuarios.Count > 0)
            {
                this.cargarGrilla(this.dgvUsuarios, listaUsuarios);
            }
            else
            {
                this.dgvUsuarios.Columns.Clear();
                this.dgvUsuarios.Rows.Add("No se encontraron Usuarios...");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Permite al usuario limpiar sus selecciones si desea.
             */
            this.txtbNombre.Text = "";
            this.cboRoles.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario
             */
            List<Usuario> resultadosUsuarios = new List<Usuario>();
            int idRol = -1;

            string usuario = this.txtbNombre.Text;

            if (this.validarDatos())
            {

                if (!(this.cboRoles.SelectedIndex == -1))
                {
                    idRol = (int) this.cboRoles.SelectedValue;
                }
                else
                {
                    idRol = -1;

                }
                resultadosUsuarios = this.oUsuario.recurperarUsuarioCParametros(usuario, idRol);
                this.cargarGrilla(this.dgvUsuarios, resultadosUsuarios);
            }
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

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
        }

        private void cboRoles_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
        }

        //--------------------------------------------------------------------------------------------
        // MÉTODOS FUNCIONALES


        private void cargarGrilla(DataGridView dgv, List<Usuario> lista)
        {
            /*
             * Carga la grilla con los datos necesarios
             */
            dgv.Rows.Clear();
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    //string borrado;
                    //bool valorBorrado = (bool) table.Rows[i]["borrado"];
                    //Console.WriteLine(valorBorrado);

                    //if (valorBorrado == "True")
                    //    borrado = "Si";
                    //else
                    //    borrado = "No";

                    dgv.Rows.Add(lista[i].IdUsuario.ToString(),
                               lista[i].Nombre.ToString(),
                               lista[i].Rol.Nombre.ToString(),
                               lista[i].Empleado.Nombre.ToString());
                }
                dgv.ClearSelection();
            }
        }

        private bool validarDatos()
        {
            string nomUs = this.txtbNombre.Text;
            if (string.IsNullOrEmpty(nomUs)
                && this.cboRoles.SelectedIndex == -1)
            {
                this.actualizar();
                return false;
            }
            return true;
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
