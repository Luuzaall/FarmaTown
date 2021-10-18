using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaTown.Datos;
using FarmaTown.Logica;
using FarmaTown.Presentacion.ABMC_s.Clientes;
using FarmaTown.Presentacion.ABMC_s.Medicamentos;
using FarmaTown.Presentacion.ABMC_s.TiposMedicamento;
using FarmaTown.Presentacion.Empleados;
using FarmaTown.Presentacion.Farmacias;
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
            //Application.Run(new frmFarmacias());
            //Application.Run(new frmUsuarios());
            //Application.Run(new frmABMEmpleados()); 

            //Application.Run(new frmBarrios());
            //Application.Run(new frmABMBarrios());
            //Application.Run(new frmLocalidades());

            //Application.Run(new frmABMLocalidades());
            //Application.Run(new frmABMMedicamentos());
            //Application.Run(new frmMedicamentos(FormMode.management));

            //Application.Run(new frmOOSS());
            //Application.Run(new frmTiposDoc());

            Application.Run(new frmTiposMed());


            //Usuario us = new Usuario();
            //Application.Run(new frmVentas(us.traerUsuario("maru")));




            //Application.Run(new frmClientes(FormMode.management));
            //Application.Run(new frmABMClientes());

        }
    }
}
