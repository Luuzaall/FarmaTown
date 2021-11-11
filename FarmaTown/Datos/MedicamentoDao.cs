﻿using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class MedicamentoDao
    {
        

        public Medicamento obtenerMedicamentoPorNom(string medicamento)
        {
            /*
            * Permite obtener el medicamento por su nombre
            */
            string query = "SELECT m.idMedicamento," +
                " m.nombre as nombreMedicamento," +
                " m.descripcion as descripcionMed," +
                " t.idTipo as idTipoMed,"+
                " t.descripcion as nombreTipoMed,"+
                " m.precioLista,"+
                " m.cantidad"+
                " FROM Medicamentos m" +
                " INNER JOIN TiposMedicamento t ON t.idTipo = m.tipoMedicamento" +
                " WHERE m.nombre = '" + medicamento + "'" +
                " ORDER BY m.nombre;";

            DataTable tablaMedicamentos = DBHelper.getDBHelper().consultaSQL(query);
            if (tablaMedicamentos.Rows.Count > 0)
            {
                return objectMapping(tablaMedicamentos.Rows[0]);
            }
            return null;
        }

        public List<Medicamento> recuperarTodos()
        {
            string query = "SELECT m.idMedicamento" +
                    ", m.nombre as nombreMedicamento" +
                    ", m.descripcion as descripcionMed" +
                    ", t.idTipo as idTipoMed" +
                    ", t.descripcion as nombreTipoMed" +
                    ", m.precioLista" +
                    ", m.cantidad" +
                    " FROM Medicamentos m" +
                    " INNER JOIN TiposMedicamento t ON t.idTipo = m.tipoMedicamento" +
                    " WHERE m.borrado = 0" +
                    " ORDER BY m.nombre";

            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Medicamento> listaMed = new List<Medicamento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaMed.Add(this.objectMapping(fila));
            }

            return listaMed;
        }

        public List<Medicamento> consultarMedicamentoCParam(string nom, int idTipo)
        {
            string query = "SELECT m.idMedicamento" +
                ", m.nombre as nombreMedicamento" +
                ", m.descripcion as descripcionMed" +
                ", t.idTipo as idTipoMed" +
                ", t.descripcion as nombreTipoMed" +
                ", m.precioLista" +
                ", m.cantidad" +
                ", m.borrado" +
                " FROM Medicamentos m " +
                " INNER JOIN TiposMedicamento t ON t.idTipo = m.TipoMedicamento" +
                " WHERE m.borrado = 0";

            if (!(string.IsNullOrEmpty(nom)))
            {
                query = query + " AND m.nombre LIKE '%" + nom + "%'";
            }
            if (!(idTipo == -1))
            {
                query = query + " AND m.TipoMedicamento = " + idTipo;
            }

            query += " ORDER BY m.nombre";
            DataTable tabla = DBHelper.getDBHelper().consultaSQL(query);

            List<Medicamento> listaMedicamento = new List<Medicamento>();
            int cantFilas = tabla.Rows.Count;

            for (int i = 0; i < cantFilas; i++)
            {
                DataRow fila = tabla.Rows[i];
                listaMedicamento.Add(this.objectMapping(fila));
            }

            return listaMedicamento;

        }

        internal bool actualizar(Medicamento oMedicamento)
        {
            /*
             * Actualiza los datos del Medicamento obtenido
             * en la base de datos, con los nuevos cambios.
             */

            string query = "UPDATE Medicamentos " +
                " SET nombre = '" + oMedicamento.Nombre + "'" +
                " , descripcion = '" + oMedicamento.Descripcion + "'" +
                " , tipoMedicamento = " + oMedicamento.TipoMedicamento.IdTipo +
                " , precioLista = " + oMedicamento.PrecioLista.ToString(CultureInfo.InvariantCulture) +
                " , cantidad = " + oMedicamento.CantidadStock +
                " WHERE idMedicamento = " + oMedicamento.IdMedicamento;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas > 0)
            {
                return true;
            }
            return false;
        }

        internal bool cambiarEstado(Medicamento oMedicamento, bool habilitado)
        {
            string query = "UPDATE Medicamentos" +
                 " SET borrado = ";

            if (habilitado)
                query = query + "0";
            else
                query = query + "1";

            query = query + " WHERE idMedicamento = " + oMedicamento.IdMedicamento;

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas > 0)
            {
                return true;
            }
            return false;
        }

        internal bool insertar(Medicamento oMedicamento)
        {
            /*
             * Inserta el medicamento nuevo en la base de datos.
             * Su resultado se retornará en booleano.
             * - TRUE si se insertó exitosamente
             * - FALSE si no se logró insertar.
             */
            string query = "INSERT INTO Medicamentos" +
                "(descripcion" +
                ", nombre" +
                ", tipoMedicamento" +
                ", precioLista" +
                ", cantidad" +
                ", borrado)" +
                " VALUES" +
                "( '" + oMedicamento.Descripcion + "'" +
                ", '" + oMedicamento.Nombre + "'" +
                ", '" + oMedicamento.TipoMedicamento.IdTipo + "'" +
                ", '" + oMedicamento.PrecioLista + "'" +
                ", '" + oMedicamento.CantidadStock + "'" +
                ", 0)";


            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            if (afectadas == 0)
            {
                return false;
            }
            else return true;

        }

        public Medicamento objectMapping(DataRow row)
        {
            /*
             * A partir del registro de un medicamento,
             * tranforma esa información en un 
             * objeto del tipo Medicamento
             */
            Medicamento oMedicamento = new Medicamento
            {
                IdMedicamento = Convert.ToInt32(row["idMedicamento"].ToString()),
                Descripcion = row["descripcionMed"].ToString(),
                Nombre = row["NombreMedicamento"].ToString(),

                TipoMedicamento = new TipoMedicamento()
                {
                    IdTipo = Convert.ToInt32(row["idTipoMed"].ToString()),
                    Descripcion = row["nombreTipoMEd"].ToString(),
                },
                PrecioLista = float.Parse(row["precioLista"].ToString()),
                CantidadStock = Convert.ToInt32(row["cantidad"].ToString()),

            };


            return oMedicamento;
        }

        public Object obtenerDatosReporte(int cantidadMinima, int cantidadMaxima, string idTipo)
        {
            string query = "SELECT m.idMedicamento" +
                    ", m.nombre as nombre" +
                    ", m.cantidad as cantidad" +
                    ", tm.descripcion as tipoMedicamento" +
                    ", m.precioLista as precioLista" +
                    " FROM Medicamentos m" +
                    " INNER JOIN TiposMedicamento tm ON m.tipoMedicamento = tm.idTipo" +
                    " WHERE m.borrado = 0";

            if (idTipo != "-1")
                query += " AND tm.idTipo = " + idTipo;
            if (cantidadMinima != -1)
                query += " AND m.cantidad > " + cantidadMinima;
            if (cantidadMaxima != -1)
                query += " AND m.cantidad < " + cantidadMaxima;

            query = query + " ORDER BY m.nombre";

         return DBHelper.getDBHelper().consultaSQL(query);
        }
    }
}
