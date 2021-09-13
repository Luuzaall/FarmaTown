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

namespace FarmaTown.Presentacion
{
    public partial class frmABMUsuario : Form
    {
        //Atributos
        private FormMode formMode = FormMode.insert;
        private readonly Usuario oUsuario;
        private Rol oRol;
        private Empleado oEmpleado;
        public frmABMUsuario()
        {
            InitializeComponent();
            oUsuario = new Usuario();
            oRol = new Rol();
            oEmpleado = new Empleado();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            //Llenar combo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }
            }
            this.cargarCombo(cboPerfil, oRol.recuperarTodos(), "nombre", "idRol");
            this.cargarGrilla(dgv, oEmpleado.recuperarTodos());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /*
             * Encargado de cargar los perfiles
             */

        }

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
            for (int i=0; i< table.Rows.Count; i++)
            {
                dgv.Rows.Add(table.Rows[i][""],
                                table.Rows[i][""],
                                table.Rows[i][""],
                                table.Rows[i][""]);
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtbCorreo_Load(object sender, EventArgs e)
        {

        }
    }
}
