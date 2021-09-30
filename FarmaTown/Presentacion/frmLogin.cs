using FarmaTown.Logica;
using FarmaTown.Presentacion.Servicios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FarmaTown
{
    public partial class frmLogin : Form
    {

        //Atributos
        private Usuario oUsuario;
        public string nomUsuario;

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
            string usuario = this.txtbUsuario.Text;
            string clave = this.txtbClave.Text;

            if (this.validarDatos())
            {
                this.nomUsuario = this.oUsuario.validarUsuario(usuario, clave);

                if (!(this.nomUsuario is null))
                {
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

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            TextBoxService.verClave(this.txtbClave, this.btnVerClave);
        }

        private bool validarDatos()
        {
            string usuario = this.txtbUsuario.Text;
            string clave = this.txtbClave.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe ingresar un usuario",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtbUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar una clave",
                    "Validación de Datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtbClave.Focus();
            }
            else
                return true;

            return false;
        }

    }
}
