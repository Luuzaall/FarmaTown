using FarmaTown.Logica;
using FarmaTown.Presentacion.ABMC_s.Clientes;
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

namespace FarmaTown.Presentacion
{
    public partial class frmVentas : Form
    {
        // Atributos
        TipoFactura oTipoFact;
        Cliente oCliente;
        public frmVentas()
        {
            InitializeComponent();
            oTipoFact = new TipoFactura();
            oCliente = new Cliente();
        }

        //MÉTODOS DE RESPUESTA A EVENTOS

        private void btnBuscCliente_Click(object sender, EventArgs e)
        {
            /*
             * Debe ejecutar el form de consulta a clientes
             * Y pasar por parámtetro el elegido.
             */
            frmClientes oFrmClientes = new frmClientes(FormMode.selection);
            DialogResult resultado = oFrmClientes.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                oCliente = oFrmClientes.recuperarSeleccion();
                this.txtNomCliente.Text = oCliente.Nombre;
                this.txtbNroDoc.Text = oCliente.NroDoc;
                this.txtbTipoDoc.Text = oCliente.TipoDoc.Nombre;
            }
        }

        private void btnBuscMedicamento_Click(object sender, EventArgs e)
        {
            /*
             * Debe ejecutar el form de consulta medicamentos
             * Y pasar por parámtetro el elegido.
             */
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*
            * Cierra el formulario con el botón de salir
            */
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            * Guarda la información ingresada de la factura,
            * generando el id de la factura.
            */

        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            /*
             * Limpia todo el formulario 
             * para una nueva factura
             */
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            ComboBoxService.cargarCombo(this.cboTipoFactura, oTipoFact.recuperarTodos()
                , "Nombre", "IdTipoFactura");
        }
    }
}
