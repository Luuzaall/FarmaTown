using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Servicios
{
    class TextBoxService
    {
        public static void enter(Button btn, KeyEventArgs e)
        {
            /*
             * Su objetivo es darle la funcionalidad
             * al textbox de, al recibir una tecla
             * del tipo enter, presionar el botón
             * indicado en este método.
             * 
             * Se utiliza en métodos de respuesta a eventos 
             * del tipo KeyDown.
             */
            if (e.KeyCode == Keys.Enter)
            {
                btn.PerformClick();
            }
        }

        public static void noDigitos(KeyEventArgs e)
        {
            /*
             * Su objetivo es darle la funcionalidad
             * al textbox de, al recibir una tecla
             * del tipo dígito, no tomarlo válido.
             * 
             * Se utiliza en métodos de respuesta a eventos 
             * del tipo KeyDown.
             */
            Console.WriteLine(e.KeyCode);
            if (char.IsDigit((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;
            }
        }

        public static void noLetras(KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if  ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                (e.KeyCode < Keys.NumPad1 || e.KeyCode > Keys.NumPad9) &&
                !(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back))
            {
                e.SuppressKeyPress = true;
            }
        }

        public static void verClave(TextBox txtb, Button btn)
        {
            bool estabaActivo = cambiarColorBtnClave(btn);
            if (estabaActivo)
            {
                txtb.PasswordChar = '*';
            }
            else
            {
                txtb.PasswordChar = '\0';
            }
        }

        private static bool cambiarColorBtnClave(Button btn)
        {
            var colorActual = btn.BackColor;
            if (colorActual == Color.Green)
            {
                btn.BackColor = Color.FromArgb(116, 201, 79);
                return true;
            }
            else
            {
                btn.BackColor = Color.Green;
                return false;
            }
        }
    }
}
