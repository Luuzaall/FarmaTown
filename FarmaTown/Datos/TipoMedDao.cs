﻿using FarmaTown.Logica;
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
            string query = "SELECT *" +
                " FROM TiposMedicamento" +
                " WHERE borrado = 0" +
                " ORDER BY descripcion";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);
            return listMapping(tabla);
        }

        public List<TipoMedicamento> recuperarCParam(string descripcion)
        {
            string query = "SELECT idTipo" +
                ", descripcion" +
                ", borrado" +
                " FROM TiposMedicamento" +
                " WHERE descripcion LIKE '%" + descripcion + "%' " +
                " AND borrado = 0" +
                " ORDER BY descripcion";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<TipoMedicamento> listaTipoMed = new List<TipoMedicamento>();

            return listMapping(tabla);
        }

        public TipoMedicamento traer(int idTipo)
        {
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
            string query = "INSERT INTO TiposMedicamento" +
                "(descripcion, borrado)" +
                " VALUES" +
                "('" + nuevoTipoMed.Descripcion + "', 0)";

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int actualizar(TipoMedicamento oTipoMed)
        {
            string query = "UPDATE TiposMedicamento" +
                " SET descripcion = '" + oTipoMed.Descripcion + "'" +
                " WHERE idTipo = " + oTipoMed.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public int cambiarEstado(TipoMedicamento oTipoMed, bool seHabilita)
        {
            string query = "UPDATE TiposMedicamento" +
                " SET borrado = ";

            if (seHabilita)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idTipo = " + oTipoMed.IdTipo;

            return DBHelper.getDBHelper().ejecutarSQL(query);
        }

        public TipoMedicamento objectMapping(DataRow row)
        {
            int idTipo = Convert.ToInt32(row["idTipo"].ToString());
            TipoMedicamento oTipoMed = new TipoMedicamento
            {
                IdTipo = idTipo,
                Descripcion = row["descripcion"].ToString(),
            };

            return oTipoMed;
        }


        private List<TipoMedicamento> listMapping(DataTable tabla)
        {
            /*
             * Recibe una tabla con filas
             * y tranforma la información de cada
             * una de ellas en un objeto del 
             * tipo de Empleado
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
        public List<TipoMedicamento> recuperarSoloUsadosMedicamentos()
        {
            string query = "SELECT tm.descripcion" +
                " FROM Medicamentos m" +
                " INNER JOIN TiposMedicamento tm ON m.tipoMedicamento = tm.idTipo" +
                " GROUP BY tm.idTipo" +
                "	, tm.descripcion" +
                " ORDER BY tm.descripcion";

            DataTable tablaNoms = DBHelper.getDBHelper().consultaSQL(query);

            List<TipoMedicamento> tiposMedicamento = new List<TipoMedicamento>();

            for (int fila = 0; fila < tablaNoms.Rows.Count; fila++)
            {
                string nom = tablaNoms.Rows[fila]["descripcion"].ToString();
                tiposMedicamento.Add(this.traer(nom));
            }
            return tiposMedicamento;
        }
    }
}
