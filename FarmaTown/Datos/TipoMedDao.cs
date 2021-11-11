using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class TipoMedDao
    {
        public List<TipoMedicamento> recuperarTodos()
        {
            /*
             * Recupera todos los medicamentos sin 
             * parámetros.
             */
            string query = "SELECT *" +
                " FROM TiposMedicamento" +
                " WHERE borrado = 0" +
                " ORDER BY descripcion";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }
        public List<TipoMedicamento> recuperarCParam(string descripcion)
        {
            /*
             * Recuper todos los medicamentos que 
             * cumplan con el parámetro ingresado.
             */
            string query = "SELECT idTipo" +
                ", descripcion" +
                ", borrado" +
                " FROM TiposMedicamento" +
                " WHERE descripcion LIKE '%" + descripcion + "%' " +
                " AND borrado = 0" +
                " ORDER BY descripcion";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            return listMapping(tabla);
        }

        public TipoMedicamento traer(int idTipo)
        {
            /*
             * Recuepera un tipo medicamento
             * correspondiente con el id recibido
             * por el parámetro.
             */
            string query = "SELECT *" +
                " FROM TiposMedicamento" +
                " WHERE borrado = 0" +
                " AND idTipo = " + idTipo;

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            DataRow fila = tabla.Rows[0];
            return this.objectMapping(fila);
        }

        public TipoMedicamento traer(string descripcion)
        {
            /*
             * Recupera el tipo de medicamento
             * que corresponda a la descripción 
             * recibida por parámetro.
             */
            string query = "SELECT *" +
                " FROM TiposMedicamento" +
                " WHERE borrado = 0" +
                " AND descripcion = '" + descripcion + "'";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            if (tabla.Rows.Count != 0)
            {
                DataRow fila = tabla.Rows[0];
                return this.objectMapping(fila);
            }
            else
                return null;
        }

        public int crear(TipoMedicamento nuevoTipoMed)
        {
            /*
             * Persiste el tipo de medicamento recibido
             * por parámetro.
             */
            string query = "INSERT INTO TiposMedicamento" +
                "(descripcion, borrado)" +
                " VALUES" +
                "('" + nuevoTipoMed.Descripcion + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(TipoMedicamento oTipoMed)
        {
            /*
             * Realiza los cambios de datos del tipo 
             * de medicamento a los datos nuevos.
             */
            string query = "UPDATE TiposMedicamento" +
                " SET descripcion = '" + oTipoMed.Descripcion + "'" +
                " WHERE idTipo = " + oTipoMed.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(TipoMedicamento oTipoMed)
        {
            /*
             * Realiza la baja lógica del tipo 
             * de medicamento.
             */
            string query = "UPDATE TiposMedicamento" +
                " SET borrado = 1" +
                " WHERE idTipo = " + oTipoMed.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        private List<TipoMedicamento> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de TipoMedicamento
             */
            List<TipoMedicamento> lista = new List<TipoMedicamento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                lista.Add(this.objectMapping(fila));
            }

            return lista;
        }

        public TipoMedicamento objectMapping(DataRow row)
        {
            /*
             * Toma los datos de la fila y los guarda
             * en una instancia de la clase.
             */
            int idTipo = Convert.ToInt32(row["idTipo"].ToString());
            TipoMedicamento oTipoMed = new TipoMedicamento
            {
                IdTipo = idTipo,
                Descripcion = row["descripcion"].ToString(),
            };

            return oTipoMed;
        }
    }
}
