using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    public class DBHelper
    {
        //Atributes
        private static DBHelper instance = null;
        private SqlConnection cnn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        //SqlCommand para DML

        private string stringConexion;

        public DBHelper()
        {
            /*
             * Establece el string de conexión
             */
            stringConexion = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a79a32_farmatown;User Id=db_a79a32_farmatown_admin;" +
                "Password=123123GGHHj";
        }


        public static DBHelper getDBHelper()
        {
            /*
             * Permite utilziar una instancia del DBHelper
             * , siendo el patrón Singleton
             */
            if (instance == null)
                instance = new DBHelper();
            return new DBHelper();
        }
        public string getStringConexion()
        {
            /*
            * Permite obtener el string de conexión
            */
            return stringConexion;
        }


        public bool persistirSesion(Sesion ses, bool esFinal)
        {
            string query = "";
            if (!esFinal)
            {
                query = "INSERT INTO Sesiones(idUsuario," +
                            "fechaInicio, fechaFin, borrado)" +
                            " VALUES" +
                             " (" + ses.Usuario.IdUsuario +
                             ", CONVERT(DATETIME, '" + ses.FechaInicio + "', 103), null, 0)";
            }
            else
            {
                query = "UPDATE Sesiones" +
                    " SET fechaFin = CONVERT(DATETIME, '" + ses.FechaFin + "', 103)" +
                    " WHERE fechaInicio = CONVERT(DATETIME, '" + ses.FechaInicio + "', 103)";
            }
            int resultado = this.ejecutarSQL(query);
            if (resultado==0)
            {
                return false;
            }
            return true;
        }

        public int ejecutarSQL(string strSql)
        {
            /*
             * Utilizada para realizar modificación de datos
             * , específicamente transacciones.
             */

            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = stringConexion;
                cnn.Open();

                //Starts the transaction
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                afectadas = cmd.ExecuteNonQuery();
                //Finishes the transaction
                t.Commit();

             } catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            } finally
            {
                this.closeConnection(cnn);
            }

            return afectadas;

        }


        public DataTable consultaSQL(string strSql)
        {
            /*
             * Sólo para consultas sin parámetros.
             */

            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = stringConexion;
                cnn.Open();
                
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            } catch (SqlException ex)
            {
                throw (ex);
            } finally
            {
                this.closeConnection(cnn);
            }
        }

        public DataTable consultarSQLConParametros(string sqlStr,
            Object[] prs)
        {
            DataTable tabla = new DataTable();
            string n_param;

            try
            {
                cnn.ConnectionString = stringConexion;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        //Si o si deben nombrarse param1, param2, etc!
                        n_param = "param"
                            + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            } catch (Exception ex)
            {
                throw (ex);
            } finally
            {
                this.closeConnection(cnn);
            }
        }

        private void closeConnection(SqlConnection cnn)
        {
            /*
             * Asegura la liberación de recursos!
             */

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public DataTable consultarTabla(string tabla)
        {
            return this.consultaSQL("SELECT * FROM " + tabla);
        }

    }
}
