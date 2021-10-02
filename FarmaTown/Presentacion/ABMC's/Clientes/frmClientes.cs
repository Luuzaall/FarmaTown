using FarmaTown.Logica;
using FarmaTown.Presentacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.ABMC_s.Clientes
{
    public partial class frmClientes : Form
    {
        Cliente oCliente;
        TipoDocumento oTipoDoc;
        Barrio oBarrio;
        public frmClientes()
        {
            oCliente = new Cliente();
            oTipoDoc = new TipoDocumento();
            oBarrio = new Barrio();
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ComboBoxService.cargarCombo(this.cboTipoDoc, oTipoDoc.recuperarTodos(false)
                , "nombre", "idTipo");
            ComboBoxService.cargarCombo(this.cboBarrio, oBarrio.recuperarTodos(false)
                , "nombre", "idBarrio");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica la correcta selección
             * para el formulario y filtra
             */
            if (this.validarCampos())
            {
                List<Cliente> resultadosClientes = new List<Cliente>();
                string nom = this.txtbNombre.Text;
                string apellido = this.txtbApellido.Text;
                int idTipoDoc;
                string nroDoc = this.txtbNumDoc.Text;
                string calle = this.txtbCalle.Text;
                string numCalle = this.txtbNumCalle.Text;
                //int idCliente;
                //int idBarrio;
               

                if (this.cboTipoDoc.SelectedIndex == -1)
                {
                    idTipoDoc = -1;
                }
                else
                {
                    idTipoDoc = (int)this.cboTipoDoc.SelectedValue;
                    if (idTipoDoc == 2)
                    {

                        string letras = this.txtbNumDoc.Text;
                        string nros = this.txtbPasaporteNro.Text;
                        nroDoc = letras + nros;
                    }
                    else
                        nroDoc = this.txtbNumDoc.Text;
                }
                //falta pasarle idCliente
                resultadosClientes = this.oCliente.recuperarConParam(nom, apellido, nroDoc, idTipoDoc, calle, numCalle);
                //this.cargarGrilla(this.dgvClientes, resultadosClientes);
            }

        }
    }
}
