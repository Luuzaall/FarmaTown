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
    public partial class frmABMFarmacias : Form
    {
        private FormMode formMode = FormMode.insert;
        private Farmacia oFarmacia;
        private Barrio oBarrio;

        public frmABMFarmacias()
        {
            oFarmacia = new Farmacia();
            oBarrio = new Barrio();
            InitializeComponent();

        }

        public enum FormMode
        {
            /*
             * Se crea una clase del tipo enum
             * que permita determinar el comportamiento
             * variable del formulario según su aplicación.
             */
            insert,
            update,
            delete
        }

        public void seleccionarFarmacia(FormMode _formMode, Farmacia farmaciaSelected)
        {
            /*
             * Se obtiene el usuario seleccionado
             * y el modo de apertura del formABMUsuarios
             */
            formMode = _formMode;
            oFarmacia = farmaciaSelected;
        }

        private void frmABMFarmacias_Load(object sender, EventArgs e)
        {
            this.mostrarBarrios();
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Farmacia - FarmaTown";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Farmacia - FarmaTown";
                        this.cargarDatos();
                        this.txtbNombre.Enabled = true;
                        this.txtbCalle.Enabled = true;
                        this.txtbNumero.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.cargarDatos();
                        this.Text = "Deshabilitar Farmacia - FarmaTown";
                        this.cargarFila(this.dgvBarrios);
                        this.txtbNombre.Enabled = false;
                        this.txtbCalle.Enabled = false;
                        this.txtbNumero.Enabled = false;
                        this.btnLimpiar.Enabled = false;
                        this.btnRegBarrio.Enabled = false;
                        break;
                    }
            }
        }

        private void cargarDatos()
        {
            /*
            * Carga los datos en los text box
            * según la farmacia seleccionada.
            */
            this.txtbNombre.TextName = this.oFarmacia.Nombre;
            this.txtbCalle.TextName = this.oFarmacia.Calle;
            this.txtbNumero.TextName = this.oFarmacia.Numero.ToString();

            this.seleccionarFila(this.dgvBarrios, oFarmacia.Barrio.IdBarrio);
        }

        private void cargarFila(DataGridView dgv)
        {
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                bool estaSelecc = dgv.Rows[i].Selected;
                if (!estaSelecc)
                {
                    dgv.Rows.RemoveAt(i);
                    i = i - 1;
                }
                cantFilasdgv = dgv.RowCount;
            }
        }

        private void seleccionarFila(DataGridView dgv, int id)
        {
            /*
             * Busca en el DataGridView la fila correspondiente
             * al dato que corresponde al id guardado en la base
             * de datos para seleccionarlo para la farmacia.
             */
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                int idFila = (int)dgv.Rows[i].Cells[0].Value;
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void mostrarBarrios()
        {
            DataTable tablaBarrios = oBarrio.recuperarTodos();

            if (tablaBarrios.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvBarrios, tablaBarrios);
                this.dgvBarrios.ClearSelection();
            }
            else
                this.dgvBarrios.Rows.Add("No se encontraron empleados...");
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

                    dgv.Rows.Add(table.Rows[i]["idBarrio"],
                                    table.Rows[i]["nomBarrio"],
                                    table.Rows[i]["nomLocalidad"]
                                    //,borrado
                                    );
                }
                dgv.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void limpiarDatos()
        {
            this.txtbNombre.TextName = "";
            this.txtbCalle.TextName = "";
            this.txtbNumero.TextName = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                /*case.FormMode.insert:
                    {
                        if (this.validarCampos())
                        {
                            if (this.existeFarmacia() == false)
                            {
                                var oFarmacia = new Farmacia();
                                oFarmacia.Nombre = this.txtbNombre.TextName;
                                oFarmacia.Calle = this.txtbCalle.TextName;
                                oFarmacia.Numero = Convert.ToInt32(this.txtbNumero.TextName);
                                oFarmacia.Barrio = new Barrio();
                                oFarmacia.Barrio.IdBarrio = (int)this.dgvBarrios.CurrentRow.Cells[0].Value;

                                if (oFarmacia.crearFarmacia(oFarmacia))
                                {
                                    MessageBox.Show("Farmacia agregada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("La farmacia que intenta ingresar ya esta en el sistema!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }*/

            }
        }

        /*private bool existeFarmacia()
        {
            
        }*/

        private void btnRegBarrio_Click(object sender, EventArgs e)
        {

        }
    }
}
