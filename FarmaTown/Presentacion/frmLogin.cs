using FarmaTown.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace FarmaTown
{
    public partial class frmLogin : Form
    {

        //Atributos
        private Usuario oUsuario;
        public int idUsuario = -1;

        public frmLogin()
        {
        /*
        * Constructor
        */
            InitializeComponent();
            oUsuario = new Usuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
        /*
        * Permite que al haber hecho click en el botón ingresar, valide
        * la completitud de los datos ingresados y si son correctos para
        * el ingreso al sistema.
        */

            string usuario = this.txtbUsuario.TextName;
            string clave = this.txtbClave.TextName;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe ingresar un usuario",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtbUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(clave)) 
            {
                MessageBox.Show("Debe ingresar una clave",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtbClave.Focus();
                return;
            }

            this.idUsuario = this.oUsuario.validarUsuario(usuario, clave);
           
            if (this.idUsuario != -1)
            {
                MessageBox.Show("Login Ok", "Ingreso al Sistema"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtbUsuario.Text = "";
                this.txtbClave.Text = string.Empty;
                this.txtbUsuario.Focus();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        /*
        * Borón salir cierre el formulario.
        */
            this.Close();
        }

    

        private void txtClave_Enter(object sender, KeyPressEventArgs e)
        {
        /*
        * Al apretar enter en el campo clave, 
        * fuera como apretar Ingresar.
        */
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
