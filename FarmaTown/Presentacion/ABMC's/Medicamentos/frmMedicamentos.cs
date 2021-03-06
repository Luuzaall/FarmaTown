using FarmaTown.Logica;
using FarmaTown.Presentacion.ABMC_s.Clientes;
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
        private frmABMMedicamentos frmABMMed;
        FormMode modo;
        Usuario usuarioLogueado;

        public frmMedicamentos(FormMode _modo, Usuario _usuarioLogueado)
        {
            InitializeComponent();
            oMedicamento = new Medicamento();
            oTipoMedicamento = new TipoMedicamento();
            modo = _modo;
            usuarioLogueado = _usuarioLogueado;

        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de preparar los combos, grillas y 
             * botones del formulario.
             */
            ComboBoxService.cargarCombo(this.cboTipos, oTipoMedicamento.recuperarTodos(), "descripcion", "idTipo");
            this.deshabilitarBotones();
            List<Medicamento> listaMedicamentos = oMedicamento.recuperarTodos();
            if (listaMedicamentos.Count > 0)
            {
                this.cargarGrilla(this.dgvMedicamentos, listaMedicamentos);
            }
            else
            {
                this.dgvMedicamentos.Columns.Clear();
                this.dgvMedicamentos.Rows.Add("No se encontraron Medicamentos...");
            }
            if (modo == FormMode.selection)
            {
                this.btnSeleccionar.Visible = true;
                if (usuarioLogueado.esVendedor())
                {
                    this.btnAgregar.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnEditar.Visible = false;
                }
            }
                
        }

        private void cargarGrilla(DataGridView dgv, List<Medicamento> lista)
        {

            /*
             * Carga la grilla con los datos necesarios
             */
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
                    dgv.Rows.Add(lista[i].IdMedicamento.ToString()
                        , lista[i].Nombre.ToString()
                        , lista[i].TipoMedicamento.Descripcion.ToString()
                        , lista[i].PrecioLista.ToString()
                        , lista[i].CantidadStock.ToString()
                        , lista[i].Descripcion.ToString()
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

            if (modo == FormMode.selection)
            {
                this.btnSeleccionar.Enabled = false;
                this.btnSeleccionar.BackColor = Color.Gray;

            }
        }

        public Medicamento recuperarSeleccion()
        {
            string nombreMed = this.dgvMedicamentos.SelectedRows[0].Cells[1].Value.ToString();
            return oMedicamento.traerMedicamento(nombreMed);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtbMedicamento.Text = "";
            this.cboTipos.SelectedIndex = -1;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario
             */
            List<Medicamento> resultadoMedicamentos;
            int idTipo = -1;

            string medicamento = this.txtbMedicamento.Text;

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
                resultadoMedicamentos = oMedicamento.recurperarMedicamentoCParametros(medicamento
                    , idTipo);
                this.cargarGrilla(this.dgvMedicamentos, resultadoMedicamentos);
            }

            this.deshabilitarBotones();
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMMed = new frmABMMedicamentos();
            string nomMed = (string)this.dgvMedicamentos.CurrentRow.Cells[1].Value;
            oMedicamento = this.oMedicamento.traerMedicamento(nomMed);
            frmABMMed.seleccionarMedicamento(frmABMMedicamentos.FormMode.delete, oMedicamento);
            frmABMMed.ShowDialog();
        }

        private void actualizar()
        {
            this.cargarGrilla(dgvMedicamentos, oMedicamento.recuperarTodos());
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
            
            if (modo == FormMode.selection)
            {
                this.btnSeleccionar.Enabled = true;
                this.btnSeleccionar.BackColor = Color.FromArgb(116, 201, 79);
            }

        }

        private void txtbEnter_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxService.enter(this.btnConsultar, e);
        }

    }
}
