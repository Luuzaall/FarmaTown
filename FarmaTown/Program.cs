using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaTown.Datos;
using FarmaTown.Presentacion.Empleados;
using FarmaTown.Presentacion.Localidades;
using FarmaTown.Presentacion.ObrasSociales;

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
            //Application.Run(new frmEmpleados(null)); 
            //Application.Run(new frmLocalidades());
            //Application.Run(new frmABMLocalidades());
            Application.Run(new frmOOSS());
            Application.Run(new frmABMOS());

        }
    }
}
