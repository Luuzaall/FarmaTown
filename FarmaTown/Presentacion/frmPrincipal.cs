using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentación
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        private bool estaLogeado = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de abandonar la aplicación?",
                "SALIENDO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                if (!estaLogeado)
                {
                    this.cargarLogIn();
                }
            }
                
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.cargarLogIn();
        }

        private void cargarLogIn()
        {
            frmLogin frmLog = new frmLogin();
            frmLog.ShowDialog();
            if (frmLog.idUsuario == -1)
            {
                this.Close();
            }
            else
            {
                estaLogeado = true;
            }
        }
    }
}
