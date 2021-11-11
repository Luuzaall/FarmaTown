using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class SesionDao
    {
        public int persistirSesionInicio(Sesion oSesion)
        {
            /*
             * Permite persistir la sesión en el momento
             * en que inicia sesión.
             */
            string query = "INSERT INTO Sesiones(idUsuario," +
                             "fechaInicio, fechaFin, borrado)" +
                              " VALUES" +
                             " (" + oSesion.Usuario.IdUsuario +
                             ", CONVERT(DATETIME, '" + oSesion.FechaInicio + "', 103)" +
                             ", null" +
                             ", 0)";
            
            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            return afectadas;
        } 

        public int persistirSesionFinal(Sesion oSesion)
        {
            /*
             * Guarda la fecha fin de la sesión
             * cuando la cierra.
             */
            string query = "UPDATE Sesiones" +
                " SET fechaFin = CONVERT(DATETIME, '" + oSesion.FechaFin + "', 103)" +
                " WHERE fechaInicio = CONVERT(DATETIME, '" + oSesion.FechaInicio + "', 103)";

            int afectadas = DBHelper.getDBHelper().ejecutarSQL(query);
            return afectadas;
        }
    }
}
