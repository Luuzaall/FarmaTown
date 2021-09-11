using System;
using System.Data;
using System.Windows.Forms;

namespace FarmaTown
{
    public partial class frmLogin : Form
    {

        //Atributos

        public frmLogin()
        //Constructor
        {
            InitializeComponent();
        }

        private bool validarCredenciales(string usuario, string clave)
        {
            //DataTable usuarios = dbhelper.consultarTabla("Usuarios");

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe ingresar un usuario",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(clave)) 
            {
                MessageBox.Show("Debe ingresar una clave",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtClave.Focus();
                return;
            }

            this.MiUsuario.Nombre = usuario;
            this.MiUsuario.Password = clave;

            this.MiUsuario.Id_usuario = this.MiUsuario.validarUsuario(usuario, clave);
           
            if (this.MiUsuario.Id_usuario != 0)
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
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
            */
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void txtClave_Enter(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
            */
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
