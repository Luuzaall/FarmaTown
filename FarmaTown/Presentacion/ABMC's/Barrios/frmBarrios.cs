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
    public partial class frmBarrios : Form
    {
        Barrio oBarrio;
        frmABMBarrios oFrmABMBarrios;
        public frmBarrios()
        {
            oBarrio = new Barrio();
            InitializeComponent();
        }

        //MÉTODOS FUNCIONALES

        private void frmBarrios_Load(object sender, EventArgs e)
        {
            /*
             * Carga los barrios a la grilla.
             */
            this.actualizar();
        }

        private void actualizar()
        {
            this.cargarGrilla(dgvBarrios, oBarrio.recuperarTodos());
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

        private void cargarGrilla(DataGridView dgv, List<Barrio> lista)
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
                    dgv.Rows.Add(lista[i].IdBarrio.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].Localidad.Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }


        //MÉTODOS A RESPUESTA A EVENTOS

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.noDigitos(e);
            TextBoxService.enter(this.btnConsultar, e);
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
                List<Barrio> listaBarrio = new List<Barrio>();
                listaBarrio = this.oBarrio.recuperarCParam(nombre);
                this.cargarGrilla(this.dgvBarrios, listaBarrio);
            }

        }

        private void dgvBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
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
            oFrmABMBarrios = new frmABMBarrios();
            oFrmABMBarrios.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oFrmABMBarrios = new frmABMBarrios();
            int idBarrio = int.Parse(this.dgvBarrios.CurrentRow.Cells[0].Value.ToString());
            oBarrio = this.oBarrio.traerBarrio(idBarrio);
            oFrmABMBarrios.seleccionarBarrio(frmABMBarrios.FormMode.update, oBarrio);
            oFrmABMBarrios.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oFrmABMBarrios = new frmABMBarrios();
            int idBarrio = int.Parse(this.dgvBarrios.CurrentRow.Cells[0].Value.ToString());
            oBarrio = this.oBarrio.traerBarrio(idBarrio);
            oFrmABMBarrios.seleccionarBarrio(frmABMBarrios.FormMode.delete, oBarrio);
            oFrmABMBarrios.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
