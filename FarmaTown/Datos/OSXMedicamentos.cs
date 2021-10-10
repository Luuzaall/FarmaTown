using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    public class OSXMedicamentosDao
    {
        MedicamentoDao oMedicamentoDao;

        public OSXMedicamentosDao()
        {
            oMedicamentoDao = new MedicamentoDao();
        }

        public List<List<Object>> recuperarTodos(int idOS)
        {
            string query = "SELECT ox.descuento" +
                ", m.nombre as NombreMedicamento" +
                ", m.idMedicamento" +
                ", m.descripcion as descripcionMed" +
                ", m.tipoMedicamento as idTipoMed " +
                ", m.precioLista" +
                ", m.cantidad" +
                ", tm.descripcion as nombreTipoMEd " +
                " FROM OSXMedicamentos ox " +
                " INNER JOIN ObrasSociales o ON ox.idOS = o.idOS " +
                " INNER JOIN Medicamentos m ON ox.idMedicamento = m.idMedicamento" +
                " INNER JOIN TiposMedicamento tm ON m.tipoMedicamento = tm.idTipo" +
                " WHERE ox.borrado = 0" +
                " AND o.borrado = 0" +
                " AND m.borrado = 0" +
                " AND o.idOS = " + idOS;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);

        }
        private List<List<Object>> listMapping(DataTable tabla)
        {
            List<List<Object>> listasDescuentos = new List<List<Object>>();
            int cantFilas = tabla.Rows.Count;
            for (int fila = 0; fila < cantFilas; fila++)
            {
                listasDescuentos.Add(this.objectMapping(tabla.Rows[fila]));
            }
            return listasDescuentos;
        }

        private List<Object> objectMapping(DataRow row)
        {
            List<Object> listaOSXMed = new List<Object>();
            Medicamento oMedicamento = oMedicamentoDao.objectMapping(row);
            listaOSXMed.Add(oMedicamento);
            listaOSXMed.Add( Double.Parse( row["descuento"].ToString() ) ) ;
            return listaOSXMed;
        }

    }

    




}
