using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmaTown.Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());

            //Usuario us = new Usuario();
            //Application.Run(new frmVentas(us.traerUsuario("Nao")));
            //Usuario us = new Usuario();
            //Application.Run(new frmConsultaVentas(us.traerUsuario("maru")));

            //Usuario us = new Usuario();
            //Application.Run(new frmConsultaVentas(us.traerUsuario("Nao")));
            
            //Reportes

            //Application.Run(new frmReporteTMedicamentosxVenta());
            //Application.Run(new frmReporteVentasxFarmacia());
            //Application.Run(new frmReporteClientes());

            //Application.Run(new frmClientes(FormMode.management));
            //Application.Run(new frmABMClientes());

        }
    }
}
