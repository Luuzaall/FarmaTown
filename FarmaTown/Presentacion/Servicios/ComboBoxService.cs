using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Servicios
{
    class ComboBoxService
    {
        public static void cargarCombo(ComboBox cbo, Object source, string display, string value)
        {
            /* 
             * Método reutilizable para cargar combo en
             * el formulario que lo necesite.
             */
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
