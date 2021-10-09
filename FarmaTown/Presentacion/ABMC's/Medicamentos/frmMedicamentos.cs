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

namespace FarmaTown.Presentacion.ABMC_s.Medicamentos
{


    public partial class frmMedicamentos : Form
    {
        TipoMedicamento oTipoMedicamento;
        Medicamento oMedicamento;
        private bool mostrarConBorrados = false;
        private frmABMMedicamentos frmABMMed;

        public frmMedicamentos()
        {
            oMedicamento = new Medicamento();
            oTipoMedicamento = new TipoMedicamento();
            InitializeComponent();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de preparar los combos, grillas y 
             * botones del formulario.
             */
            ComboBoxService.cargarCombo(this.cboTipos, oTipoMedicamento.recuperarTodos(), "descripcion", "idTipo");
            this.deshabilitarBotones();

            DataTable tablaMedicamentos = oMedicamento.recuperarTodos(mostrarConBorrados);
            if (tablaMedicamentos.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvMedicamentos, tablaMedicamentos);
            }
            else
            {
                this.dgvMedicamentos.Columns.Clear();
                this.dgvMedicamentos.Rows.Add("No se encontraron Medicamentos...");
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

                    dgv.Rows.Add(table.Rows[i]["idMedicamento"],
                                    table.Rows[i]["nombreMedicamento"],
                                    table.Rows[i]["descripcionMed"],
                                    table.Rows[i]["nombreTipoMed"],
                                    table.Rows[i]["precioLista"],
                                    table.Rows[i]["cantidad"]
                                    //,borrado
                                    );
                }
                dgv.ClearSelection();
            }
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

        private void cbBorrados_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarConBorrados)
            {
                this.mostrarConBorrados = false;
                this.dgvMedicamentos.Columns["borrado"].Visible = false;
                this.actualizar();
            }
            else
            {
                this.mostrarConBorrados = true;
                this.dgvMedicamentos.Columns["borrado"].Visible = true;
                this.actualizar();
            }

        }

        public Medicamento recuperarSeleccion()
        {
            string nombreMed = this.dgvMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
            return oMedicamento.traerMedicamento(nombreMed);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbMedicamento.TextName = "";
            this.cboTipos.SelectedIndex = -1;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            /*
             * Verifica la correcta selección
             * para el formulario
             */
            DataTable resultadoEmpleados;
            int idTipo = -1;

            string medicamento = this.txtbMedicamento.TextName;

            if (this.validarDatos())
            {

                if (!(this.cboTipos.SelectedIndex == -1))
                {
                    idTipo = (int)this.cboTipos.SelectedValue;
                }
                else
                {
                    idTipo = -1;

                }
                resultadoEmpleados = this.oMedicamento.recurperarMedicamentoCParametros(medicamento, idTipo, mostrarConBorrados);
                this.cargarGrilla(this.dgvMedicamentos, resultadoEmpleados);
            }
        }

        private bool validarDatos()
        {
            string nomMed = this.txtbMedicamento.Name;
            if (string.IsNullOrEmpty(nomMed)
                && this.cboTipos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Medicamento o un tipo\npara poder realizar la busqueda ",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.txtbMedicamento.Focus();
                this.cboTipos.Focus();
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMMed = new frmABMMedicamentos();
            string nomMed = (string)this.dgvMedicamentos.CurrentRow.Cells[1].Value;
            oMedicamento = this.oMedicamento.traerMedicamento(nomMed);
            frmABMMed.seleccionarMedicamento(frmABMMedicamentos.FormMode.insert, oMedicamento);
            frmABMMed.ShowDialog();
            this.actualizar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMMed = new frmABMMedicamentos();
            string nomMed = (string)this.dgvMedicamentos.CurrentRow.Cells[1].Value;
            oMedicamento = this.oMedicamento.traerMedicamento(nomMed);
            frmABMMed.seleccionarMedicamento(frmABMMedicamentos.FormMode.update, oMedicamento);
            frmABMMed.ShowDialog();
            this.actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMMed = new frmABMMedicamentos();
            string nomMed = (string)this.dgvMedicamentos.CurrentRow.Cells[1].Value;
            oMedicamento = this.oMedicamento.traerMedicamento(nomMed);
            frmABMMed.seleccionarMedicamento(frmABMMedicamentos.FormMode.delete, oMedicamento);
            frmABMMed.ShowDialog();
            this.actualizar();
        }

        private void actualizar()
        {
            this.cargarGrilla(dgvMedicamentos, oMedicamento.recuperarTodos(mostrarConBorrados));
            this.deshabilitarBotones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEditar.BackColor = Color.FromArgb(116, 201, 79);
            this.btnEliminar.Enabled = true;
            this.btnEliminar.BackColor = Color.FromArgb(116, 201, 79);
            this.lblAviso.Visible = false;

        }
       
    }
}
