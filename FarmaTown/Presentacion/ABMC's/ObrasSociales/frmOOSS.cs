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

namespace FarmaTown.Presentacion.ObrasSociales
{
    public partial class frmOOSS : Form
    {
        ObraSocial oObraSocial;
        frmABMOS oFrmABMOS;
        public frmOOSS()
        {
            InitializeComponent();
            oObraSocial = new ObraSocial();
        }

        //MÉTODOS A RESPUESTA A EVENTOS

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
            TextBoxService.noDigitos(e);
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
                List<ObraSocial> listaOS = new List<ObraSocial>();
                listaOS = this.oObraSocial.recuperarCParam(nombre);
                this.cargarGrilla(this.dgvObrasSociales, listaOS);
            }

        }

        private void dgvObrasSociales_CellClick(object sender, DataGridViewCellEventArgs e)
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
            oFrmABMOS = new frmABMOS();
            oFrmABMOS.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oFrmABMOS = new frmABMOS();
            int idOS = int.Parse(this.dgvObrasSociales.CurrentRow.Cells[0].Value.ToString());
            oObraSocial = this.oObraSocial.traerOS(idOS);
            oFrmABMOS.seleccionarOS(frmABMOS.FormMode.update, oObraSocial);
            oFrmABMOS.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oFrmABMOS = new frmABMOS();
            int idOS = int.Parse(this.dgvObrasSociales.CurrentRow.Cells[0].Value.ToString());
            oObraSocial = this.oObraSocial.traerOS(idOS);
            oFrmABMOS.seleccionarOS(frmABMOS.FormMode.delete, oObraSocial);
            oFrmABMOS.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------
        //MÉTODOS FUNCIONALES

        private void frmOOSS_Load(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void actualizar()
        {
            this.cargarGrilla(dgvObrasSociales, oObraSocial.recuperarTodos(false));
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

        private void cargarGrilla(DataGridView dgv, List<ObraSocial> lista)
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
                    dgv.Rows.Add(lista[i].IdOS.ToString()
                        , lista[i].Nombre.ToString()
                        ) ;
                }
                dgv.ClearSelection();
            }
        }


        

    }
}
