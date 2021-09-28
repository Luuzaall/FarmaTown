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

        private void frmFarmacias_Load(object sender, EventArgs e)
        {
            //this.deshabilitarBotones();
            DataTable tablaFarmacias = oFarmacia.recuperarTodos();
            if (tablaFarmacias.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvFarmacias, tablaFarmacias);
            }
            else
            {
                this.dgvFarmacias.Columns.Clear();

            }
        }
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
                    //string borrado;
                    //bool valorBorrado = (bool) table.Rows[i]["borrado"];
                    //Console.WriteLine(valorBorrado);

                    //if (valorBorrado == "True")
                    //    borrado = "Si";
                    //else
                    //    borrado = "No";

                    dgv.Rows.Add(table.Rows[i]["idFarmacia"],
                                    table.Rows[i]["nomFarmacia"],
                                    table.Rows[i]["calle"],
                                    table.Rows[i]["numero"],
                                    table.Rows[i]["nomBarrio"]
                                    //,borrado
                                    ) ;
                }
                dgv.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textbSucursal.TextName = "";
            this.TextbCalle.TextName = "";
            this.textbNumero.TextName = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable resultadoFarmacias;
            string sucursal = this.textbSucursal.TextName;
            string calle = this.TextbCalle.TextName;
            string numero = this.textbNumero.TextName;

            if (validarDatos())
            {
                resultadoFarmacias = oFarmacia.recuperarCParam(sucursal, calle, numero, "", "");
                this.cargarGrilla(this.dgvFarmacias, resultadoFarmacias);
            }
        }

        private bool validarDatos()
        {
            string sucursal = this.textbSucursal.TextName;
            string calle = this.TextbCalle.TextName;
            string numero = this.textbNumero.TextName;
            if (string.IsNullOrEmpty(sucursal)
                && string.IsNullOrEmpty(calle)
                && string.IsNullOrEmpty(numero)
                )
            {
                MessageBox.Show("Debe ingresar al menos uno de los datos",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.textbSucursal.Focus();
                this.TextbCalle.Focus();
                this.textbNumero.Focus();
                return false;
            }
            return true;
        }

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            ABMFar.ShowDialog();
            this.actualizar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            int id = (int)this.dgvFarmacias.CurrentRow.Cells[0].Value;
            oFarmacia = this.oFarmacia.traerFarmacia(id);
            ABMFar.seleccionarFarmacia(frmABMFarmacias.FormMode.update, oFarmacia);
            ABMFar.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ABMFar = new frmABMFarmacias();
            int id = (int)this.dgvFarmacias.CurrentRow.Cells[0].Value;
            oFarmacia = this.oFarmacia.traerFarmacia(id);
            ABMFar.seleccionarFarmacia(frmABMFarmacias.FormMode.delete, oFarmacia);
            ABMFar.ShowDialog();
            this.actualizar();
        }
        private void textbNumero_KeyDown(object sender, KeyEventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}