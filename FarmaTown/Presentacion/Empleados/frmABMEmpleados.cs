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

namespace FarmaTown.Presentacion.Empleados
{
    public partial class frmABMEmpleados : Form
    {
        //Atributos
        private FormMode formMode = FormMode.insert;
        TipoDocumento oTipoDoc;
        Farmacia oFarmacia;

        public frmABMEmpleados()
        {
            InitializeComponent();
            oTipoDoc = new TipoDocumento();
            oFarmacia = new Farmacia();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        //MÉTODOS DE RESPUESTA A EVENTOS


        private void frmABMEmpleados_Load(object sender, EventArgs e)
        {
            //Carga los combos
            this.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(), "nombre", "idTipo");
            DataTable tablaFarmacias = oFarmacia.recuperarTodos();

            if (tablaFarmacias.Rows.Count > 0)
            {
                this.cargarGrilla(this.dgvFarmacias, tablaFarmacias);
                this.dgvFarmacias.ClearSelection();
            }
            else
                this.dgvFarmacias.Rows.Add("No se encontraron empleados...");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*
             * Limpia los textbox y combobox
             * cuando el usuario haga click en el botón Limpiar.
             */
            this.txtbNombre.TextName = "";
            this.txtbNroDoc.TextName = "";
            this.cboTipoDoc.SelectedIndex = -1;
        }

        //MÉTODOS FUNCIONALES


        private void cargarCombo(ComboBox cbo, Object source, string display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarGrilla(DataGridView dgv, DataTable table)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgv.Rows.Add(table.Rows[i]["idFarmacia"],
                                table.Rows[i]["nomFarmacia"],
                                table.Rows[i]["calle"],
                                table.Rows[i]["numero"],
                                table.Rows[i]["nomBarrio"],
                                table.Rows[i]["nomLocalidad"]); 
            }
        }

    }
}
