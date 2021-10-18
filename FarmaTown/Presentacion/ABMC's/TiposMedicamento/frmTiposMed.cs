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

namespace FarmaTown.Presentacion.ABMC_s.TiposMedicamento
{
    public partial class frmTiposMed : Form
    {
        TipoMedicamento oTipoMed;
        frmABMTiposMed oFrmABMTipoMed;
        public frmTiposMed()
        {
            InitializeComponent();
            oTipoMed = new TipoMedicamento();
            oFrmABMTipoMed = new frmABMTiposMed();
        }
        //MÉTODOS A RESPUESTA A EVENTOS

        private void txtbDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
            TextBoxService.noDigitos(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbDescripcion.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string descripcion = this.txtbDescripcion.Text;

            if (string.IsNullOrEmpty(descripcion)
                || descripcion == " ")
            {
                this.actualizar();
            }
            else
            {
                List<TipoMedicamento> listaTipoMed = new List<TipoMedicamento>();
                listaTipoMed = this.oTipoMed.recuperarCParam(descripcion);
                this.cargarGrilla(this.dgvTiposMed, listaTipoMed);
            }
        }

        private void dgvTiposMed_CellClick(object sender, DataGridViewCellEventArgs e)
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
            oFrmABMTipoMed = new frmABMTiposMed();
            oFrmABMTipoMed.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oFrmABMTipoMed = new frmABMTiposMed();
            int idTipoMed = int.Parse(this.dgvTiposMed.CurrentRow.Cells[0].Value.ToString());
            oTipoMed = this.oTipoMed.traerTipoMed(idTipoMed);
            oFrmABMTipoMed.seleccionarTipoMed(frmABMTiposMed.FormMode.update, oTipoMed);
            oFrmABMTipoMed.ShowDialog();
            this.actualizar(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oFrmABMTipoMed = new frmABMTiposMed();
            int idTipoMed = int.Parse(this.dgvTiposMed.CurrentRow.Cells[0].Value.ToString());
            oTipoMed = this.oTipoMed.traerTipoMed(idTipoMed);
            oFrmABMTipoMed.seleccionarTipoMed(frmABMTiposMed.FormMode.delete, oTipoMed);
            oFrmABMTipoMed.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------
        //MÉTODOS FUNCIONALES

        private void frmTiposMed_Load(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void actualizar()
        {
            this.cargarGrilla(dgvTiposMed, oTipoMed.recuperarTodos(false));
            this.deshabilitarBotones();
        }

        private void deshabilitarBotones()
        {
            /*
             * Deshabilita los botones cambiándoles el color
             */
            this.btnEditar.Enabled = false;
            this.btnEditar.BackColor = Color.Gray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.BackColor = Color.Gray;
            this.lblAviso.Visible = true;
        }

        private void cargarGrilla(DataGridView dgv, List<TipoMedicamento> lista)
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
                    dgv.Rows.Add(lista[i].IdTipo.ToString()
                        , lista[i].Descripcion.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }
    }
}
