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
        public frmABMUsuario()
        {
            InitializeComponent();
            oUsuario = new Usuario();
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
