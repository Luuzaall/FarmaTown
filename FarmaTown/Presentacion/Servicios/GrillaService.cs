using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTown.Presentacion.Servicios
{
    class GrillaService
    {
        //public static void cargarGrilla(DataGridView dgv, List<Object> listaObjs, List<string> listaColums)
        //{
        //    dgv.Rows.Clear();
        //    if (listaObjs != null)
        //    {
        //        int cantColum = dgv.Columns.Count;
        //        int cantObjs = listaObjs.Count;
        //        Array fila;
        //        for (int j = 0; j < cantColum; j++)
        //        {
        //            fila = fila, ;
        //        }
        //        for (int i = 0; i < cantObjs; i++)
        //        {

        //            //dgv.Rows.Add(lista[i].IdOS.ToString()
        //            //    , lista[i].Nombre.ToString()
        //            //    );
        //        }
        //        dgv.ClearSelection();
        //    }
        //}

        public static void seleccionarFila(DataGridView dgv, int id)
        {
            /*
             * Busca en el DataGridView la fila correspondiente
             * al dato que corresponde al id guardado en la base
             * de datos para seleccionarlo para el usuario.
             */
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                int idFila = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                if (idFila == id)
                {
                    dgv.Rows[i].Selected = true;
                    break;
                }
            }
        }

        public static void cargarFila(DataGridView dgv)
        {
            int cantFilasdgv = dgv.RowCount;

            for (int i = 0; i < cantFilasdgv; i++)
            {
                bool estaSelecc = dgv.Rows[i].Selected;
                if (!estaSelecc)
                {
                    dgv.Rows.RemoveAt(i);
                    i = i - 1;
                }
                cantFilasdgv = dgv.RowCount;
            }
        }
    }
}
