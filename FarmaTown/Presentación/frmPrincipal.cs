using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPBTS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            
            if (fl.MiUsuario.Id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
                this.lblBienv.Text += fl.MiUsuario.Nombre + "!";
            }

            fl.Dispose();
        }
    }
}
