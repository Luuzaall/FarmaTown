using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Empleados
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnEditar_EnabledChanged(object sender, EventArgs e)
        {
            if (this.btnEditar.Enabled == false)
            {
                this.btnEditar.BackColor = Color.Gray;
            }
        }
    }
}
