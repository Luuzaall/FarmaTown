using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaTown.Datos;
using FarmaTown.Presentacion.Empleados;

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
            //Application.Run(new frmPrincipal());

            //Application.Run(new frmABMUsuario());
            //Application.Run(new frmUsuarios());
            Application.Run(new frmEmpleados());
            //Application.Run(new frmEmpleados());
        }
    }
}
