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

namespace FarmaTown.Presentacion.Farmacias
{
    public partial class frmFarmacias : Form
    {

        private Farmacia oFarmacia;
        private frmABMFarmacias ABMFar;

        public frmFarmacias()
        {
            oFarmacia = new Farmacia();
            InitializeComponent();
        }

        /*
         * Carga la grilla con farmacias de la base de datos
         * una vez ejecutado el formulario
         */
        private void frmFarmacias_Load(object sender, EventArgs e)
        {
            //this.deshabilitarBotones();
            List<Farmacia> listaFarmacias = oFarmacia.recuperarTodos();
            if (listaFarmacias.Count > 0)
            {
                this.cargarGrilla(this.dgvFarmacias, listaFarmacias);
            }
            else
            {
                this.dgvFarmacias.Columns.Clear();

            }
        }

        private void cargarGrilla(DataGridView dgv, List<Farmacia> lista)
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
                    dgv.Rows.Add(lista[i].IdFarmacia.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].Calle.ToString()
                        , lista[i].Numero.ToString()
                        , lista[i].Barrio.Nombre.ToString()
                        );
                }
                dgv.ClearSelection();
            }
        }

        /*
         * Borra el contenido de los textBox del formulario 
         * y los deja vacios
         */

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textbSucursal.Text = "";
            this.TextbCalle.Text = "";
            this.textbNumero.Text = "";
        }

        /*
         * Respuesta a boton consultar
         * consulta a la base de datos las farmacias
         * con los parametros ingresados por el usuario
         * y carga la grilla con estos
         */
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Farmacia> resultadoFarmacias;
            string sucursal = this.textbSucursal.Text;
            string calle = this.TextbCalle.Text;
            string numero = this.textbNumero.Text;

            resultadoFarmacias = oFarmacia.recuperarCParam(sucursal, calle, numero, "", "");
            this.cargarGrilla(this.dgvFarmacias, resultadoFarmacias);
            
        }

        /*
         * Respuesta a una seleccion de celda de la grilla
         * habilita los botones de ABM para la farmacia seleccionada
         */

        private void dgvFarmacias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEditar.BackColor = Color.FromArgb(116, 201, 79);
            this.btnEliminar.Enabled = true;
            this.btnEliminar.BackColor = Color.FromArgb(116, 201, 79);
            this.lblAviso.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        /*
         * Recarga la grilla con todas las farmacias
         * de la base de datos
         */

        private void actualizar()
        {
            this.cargarGrilla(this.dgvFarmacias, this.oFarmacia.recuperarTodos());
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

        /*
         * Respuesta al boton agregar
         * crea una instancia del formulario de abm
         * y lo ejecuta en su modo insert
         */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            ABMFar.ShowDialog();
            this.actualizar();
        }

        /*
         * Respuesta al boton editar
         * crea una instancia del formulario de abm
         * y lo ejecuta en su modo update
         */
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            int id = Convert.ToInt32(this.dgvFarmacias.CurrentRow.Cells[0].Value.ToString());
            oFarmacia = this.oFarmacia.traerFarmacia(id);
            ABMFar.seleccionarFarmacia(frmABMFarmacias.FormMode.update, oFarmacia);
            ABMFar.ShowDialog();
            this.actualizar();
        }

        /*
         * Respuesta al boton eliminar
         * crea una instancia del formulario de abm
         * y lo ejecuta en su modo delete
         * trae de la base de datos la farmacia seleccionada
         */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            int id = Convert.ToInt32(this.dgvFarmacias.CurrentRow.Cells[0].Value.ToString());
            oFarmacia = this.oFarmacia.traerFarmacia(id);
            ABMFar.seleccionarFarmacia(frmABMFarmacias.FormMode.delete, oFarmacia);
            ABMFar.ShowDialog();
            this.actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbSucursal_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
            TextBoxService.noDigitos(e);
        }

        private void TextbCalle_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
            TextBoxService.noDigitos(e);
        }

        private void textbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
        }
    }
}