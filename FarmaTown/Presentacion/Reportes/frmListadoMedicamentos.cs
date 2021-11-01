using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Reportes
{
    public partial class frmListadoMedicamentos : Form
    {
        public frmListadoMedicamentos()
        {
            InitializeComponent();
        }

        private void frmListadoMedicamentos_Load(object sender, EventArgs e)
        {

            this.rpvMedicamentos.RefreshReport();
        }
    }
}
