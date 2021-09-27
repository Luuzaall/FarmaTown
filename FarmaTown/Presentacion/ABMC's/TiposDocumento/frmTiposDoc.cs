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

namespace FarmaTown.Presentacion.ABMC_s.TiposDocumento
{
    public partial class frmTiposDoc : Form
    {
        TipoDocumento oTipoDoc;
        frmABMTiposDoc oFrmABMTipoDoc;
        public frmTiposDoc()
        {
            InitializeComponent();
            oTipoDoc = new TipoDocumento();
            oFrmABMTipoDoc = new frmABMTiposDoc();
        }

        //MÉTODOS A RESPUESTA A EVENTOS

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnConsultar.PerformClick();

            }
            else if (char.IsDigit((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = "";
            this.txtbPalabraClave.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtbNombre.Text;
            string pClave = this.txtbPalabraClave.Text;

            if ( (string.IsNullOrEmpty(nombre)
                    || nombre == " " ) 
                && ( string.IsNullOrEmpty(pClave)
                    || pClave == " ") )
            {
                this.actualizar();
            }
            else
            {
                List<TipoDocumento> listaTD = new List<TipoDocumento>();
                listaTD = this.oTipoDoc.recuperarCParam(nombre, pClave);
                this.cargarGrilla(this.dgvTiposDoc, listaTD);
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
            oFrmABMTipoDoc = new frmABMTiposDoc();
            oFrmABMTipoDoc.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oFrmABMTipoDoc = new frmABMTiposDoc();
            int idTipoDoc = int.Parse(this.dgvTiposDoc.CurrentRow.Cells[0].Value.ToString());
            oTipoDoc = this.oTipoDoc.traerTipoDOc(idTipoDoc);
            oFrmABMTipoDoc.seleccionarOS(frmABMTiposDoc.FormMode.update, oObraSocial);
            oFrmABMTipoDoc.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oFrmABMTipoDoc = new frmABMTiposDoc();
            //int idOS = int.Parse(this.dgvTiposDoc.CurrentRow.Cells[0].Value.ToString());
            //oTipoDoc = this.oTipoDoc.traerOS(idOS);
            //oFrmABMTipoDoc.seleccionarOS(frmABMTiposDoc.FormMode.delete, oObraSocial);
            oFrmABMTipoDoc.ShowDialog();
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
            //this.cargarGrilla(dgvTiposDoc, oTipoDoc.recuperarTodos(false));
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

        private void cargarGrilla(DataGridView dgv, List<TipoDocumento> lista)
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
                        , lista[i].Nombre.ToString()
                        , lista[i].Descripcion.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }
    }
}
