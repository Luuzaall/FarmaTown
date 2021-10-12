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
        private SqlTransaction dbTransaction;
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

        public void BeginTransaction()
        {
            if (cnn.State == ConnectionState.Open)
                dbTransaction = cnn.BeginTransaction();
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
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

        public int EjecutarSQLCONPARAMETROS(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = cnn;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }


                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = cnn;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

    }
}
