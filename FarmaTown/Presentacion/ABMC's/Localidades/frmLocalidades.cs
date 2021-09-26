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

namespace FarmaTown.Presentacion.Localidades
{
    public partial class frmLocalidades : Form
    {
        Localidad oLocalidad;
        frmABMLocalidades oFrmABMLocalidades;
        public frmLocalidades()
        {
            oLocalidad = new Localidad();
            InitializeComponent();
        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            this.actualizar();
        }
        private void actualizar()
        {
            this.cargarGrilla(dgvLocalidades, oLocalidad.recuperarTodos(false));
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


        //MÉTODOS A RESPUESTA A EVENTOS

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtbNombre.Text;

            if (string.IsNullOrEmpty(nombre)
                || nombre == " ")
            {
                this.actualizar();
            }
            else
            {
                List<Localidad> listaLocalidad = new List<Localidad>();
                listaLocalidad = this.oLocalidad.recuperarCParam(nombre);
                this.cargarGrilla(this.dgvLocalidades, listaLocalidad);
            }

        }

        private void dgvLocalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Habilita los botones para poder ser seleccionados,
             * proyenedo una invitación visual
             */
            this.btnEditar.Enabled = true;
            this.btnEditar.BackColor = Color.FromArgb(116, 201, 79);
            this.btnEliminar.Enabled = true;
            this.btnEliminar.BackColor = Color.FromArgb(116, 201, 79);
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
            oFrmABMLocalidades = new frmABMLocalidades();
            oFrmABMLocalidades.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oFrmABMLocalidades = new frmABMLocalidades();
            int idLocalidad = int.Parse(this.dgvLocalidades.CurrentRow.Cells[0].Value.ToString());
            oLocalidad = this.oLocalidad.traerLocalidad(idLocalidad);
            oFrmABMLocalidades.seleccionarLocalidad(frmABMLocalidades.FormMode.update, oLocalidad);
            oFrmABMLocalidades.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oFrmABMLocalidades = new frmABMLocalidades();
            int idLocalidad = int.Parse(this.dgvLocalidades.CurrentRow.Cells[0].Value.ToString());
            oLocalidad = this.oLocalidad.traerLocalidad(idLocalidad);
            oFrmABMLocalidades.seleccionarLocalidad(frmABMLocalidades.FormMode.delete, oLocalidad);
            oFrmABMLocalidades.ShowDialog();
            this.actualizar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
