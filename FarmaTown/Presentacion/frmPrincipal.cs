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
using FarmaTown.Presentacion.ABMC_s.Clientes;
using FarmaTown.Presentacion.ABMC_s.Medicamentos;
using FarmaTown.Presentacion.ABMC_s.TiposDocumento;
using FarmaTown.Presentacion.Empleados;
using FarmaTown.Presentacion.Farmacias;
using FarmaTown.Presentacion.Localidades;
using FarmaTown.Presentacion.ObrasSociales;
using FarmaTown.Presentacion.Reportes;
using FarmaTown.Presentacion.Reportes.Clientes;
using FarmaTown.Presentacion.Reportes.Empleados;
using FarmaTown.Presentacion.Reportes.Medicamentos;
using FarmaTown.Presentacion.Reportes.ObrasSociales;
using FarmaTown.Presentacion.Reportes.Ventas;
using FarmaTown.Presentacion.Transacciones;

namespace FarmaTown.Presentacion
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        private bool estaLogeado = false;
        private Rol rolLogeado;
        private Usuario oUsuarioLogueado;
        private Sesion oSesion;

        Timer t = new Timer();

        public frmPrincipal()
        {
            oUsuarioLogueado = new Usuario();
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Métodos para el reloj en tiempo real.
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
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
                oSesion = new Sesion();
                //Persistencia de la Sesión.
                oUsuarioLogueado = oUsuarioLogueado.traerUsuario(frmLog.nomUsuario);
                oSesion.Usuario = oUsuarioLogueado;
                oSesion.FechaInicio = DateTime.Now;
                oSesion.persistirInicio();
                
                estaLogeado = true;

                rolLogeado = new Rol();
                rolLogeado.IdRol = oUsuarioLogueado.Rol.IdRol;
                rolLogeado.Nombre = oUsuarioLogueado.Rol.Nombre;

                this.lblNombre.Text = oUsuarioLogueado.Empleado.Nombre;
                this.lblNomRol.Text = rolLogeado.Nombre;

                if (rolLogeado.IdRol == 2)
                {
                    this.gestiónToolStripMenuItem.Visible = false;
                    this.reportesToolStripMenuItem.Visible = false;
                }
                else
                {
                    this.gestiónToolStripMenuItem.Visible = true;
                    this.reportesToolStripMenuItem.Visible = true;
                }
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de abandonar la aplicación?",
                "SALIENDO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                if (oSesion != null)
                {
                    this.cerrarSesion();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                if (!estaLogeado)
                {
                    this.cargarLogIn();
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblNombre.Text = "";
            this.lblNomRol.Text = "";
            this.estaLogeado = false;
            this.cerrarSesion();
            this.cargarLogIn();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesion()
        {
            oSesion.FechaFin = DateTime.Now;
            oSesion.persistirFinal();
        }

        //GESTION
        private void obrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOOSS frmOS = new frmOOSS();
            frmOS.ShowDialog();
        }

        private void farmaciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFarmacias frmFar = new frmFarmacias();
            frmFar.ShowDialog();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes oFrmClientes = new frmClientes(FormMode.management);
            oFrmClientes.ShowDialog();
        }
        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMedicamentos oFrmMedicamentos = new frmMedicamentos(FormMode.management, oUsuarioLogueado);
            oFrmMedicamentos.ShowDialog();
        }
        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleados.frmEmpleados frmEmp = new Empleados.frmEmpleados();
            frmEmp.ShowDialog();
        }
        private void tiposDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposDoc ofrmTiposDoc = new frmTiposDoc();
            ofrmTiposDoc.ShowDialog();
        }
        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsu = new frmUsuarios();
            frmUsu.ShowDialog();
        }
        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades oFrmLocalidades = new frmLocalidades();
            oFrmLocalidades.ShowDialog();
        }
        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrios oFrmBarrios = new frmBarrios();
            oFrmBarrios.ShowDialog();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            /*
             * Manejador del reloj
             */
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            this.lblReloj.Text = time;
        }

        //VENTAS
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaVenta ofrmVentas = new frmAltaVenta(oUsuarioLogueado);
            ofrmVentas.ShowDialog();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVentas oFrmConsultaVentas = new frmConsultaVentas(oUsuarioLogueado);
            oFrmConsultaVentas.ShowDialog();
        }

        //REPORTES

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEmpleados ofrmfrmReporteEmpleados = new frmReporteEmpleados();
            ofrmfrmReporteEmpleados.ShowDialog();
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteClientes oFrmReporteClientes = new frmReporteClientes();
            oFrmReporteClientes.ShowDialog();
        }
        private void obrasSocialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteObrasSociales ofrmReporteObrasSociales = new frmReporteObrasSociales();
            ofrmReporteObrasSociales.ShowDialog();
        }
        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteMedicamentos oFrmReporteMedicamentos = new frmReporteMedicamentos();
            oFrmReporteMedicamentos.ShowDialog();
        }

            //REPORTES VENTAS

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteVentas oFrmListadoVentas = new frmReporteVentas();
            oFrmListadoVentas.ShowDialog();
        }
    }
}
