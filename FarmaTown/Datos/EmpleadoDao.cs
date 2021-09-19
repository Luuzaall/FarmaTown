﻿using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class EmpleadoDao
    {
        public DataTable recuperarTodos()
        {
            string query = "SELECT e.idEmpleado" +
                ", e.nroDoc" +
                ", t.nombre as nomTipoDoc" +
                ", f.nombre as nomFarmacia" +
                ", e.nombre as nomEmpleado" +
                " FROM Empleados e" +
                " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia" +
                " INNER JOIN TiposDocumento t ON e.tipoDoc = t.idTipo" +
                " WHERE e.borrado = 0;";

            return DBHelper.getDBHelper().consultaSQL(query);
        }
        private Empleado objectMappingEmpleado(DataRow row)
        {

            Empleado oEmpleado = new Empleado
            {
                IdEmpleado = Convert.ToInt32(row["idEmpleado"].ToString()),
                NroDoc = Convert.ToInt32(row["nroDoc"].ToString()),
                TipoDoc = new TipoDocumento()
                {
                    IdTipo = Convert.ToInt32(row["idTipo"].ToString()),
                    //Nombre = row["nombre"].ToString(),
                },
                Farmacia = new Farmacia()
                {
                    IdFarmacia = Convert.ToInt32(row["idFarmacia"].ToString()),
                    //Nombre = row["nombre"].ToString(),
                },

            };

            return oEmpleado;
        }

            internal Empleado traerEmpleado(string idEmpleado)
        {
            string query = "SELECT * FROM Empleados e "+
                    " INNER JOIN TiposDocumento td ON e.idTipoDoc = td.idTipo " +
                    " INNER JOIN Farmacias f ON e.idFarmacia = f.idFarmacia " +
                    " WHERE idEmpleado = "+ idEmpleado +" AND borrado = 0;";

            DataTable tablaEmpleados = DBHelper.getDBHelper().consultaSQL(query);

            return this.objectMappingEmpleado(tablaEmpleados.Rows[0]);
        }
    }
}
