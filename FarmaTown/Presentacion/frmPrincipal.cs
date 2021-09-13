using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaTown.Logica;

namespace FarmaTown.Presentacion
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        private bool estaLogeado = false;
        private Rol oRolLogueado;
        private Usuario oUsuarioLogueado;

        public frmPrincipal()
        {
            oUsuarioLogueado = new Usuario();
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
            if (frmLog.nomUsuario is null)
            {
                this.Close();
            }
            else
            {
                Sesion oSesion = new Sesion();
                //Persistencia de la Sesión.
                oUsuarioLogueado = oUsuarioLogueado.traerUsuario(frmLog.nomUsuario);
                oRolLogueado = oUsuarioLogueado.Rol;
                oSesion.Usuario = oUsuarioLogueado;
                oSesion.FechaInicio = DateTime.Now;

                
                estaLogeado = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsu = new frmUsuarios();
            frmUsu.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
