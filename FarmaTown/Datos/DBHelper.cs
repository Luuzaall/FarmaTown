﻿using FarmaTown.Logica;
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

        public Usuario obtenerUsuarioPorNom(string nomUs)
        {
            /*
            * Permite obtener el usuario por su nombre
            */
            string query = "SELECT u.idUsuario" + 
                " , u.idEmpleado" + 
                " , u.nombre as NombreUsuario" + 
                " , u.clave " + 
                " , r.idRol" +
                " , r.idRol " + 
                " , r.nombre as NombreRol " +
                " FROM Usuarios u" + " INNER JOIN Roles r ON u.idRol = r.idRol" + 
                " WHERE u.nombre = '" + nomUs + "'" +
                " AND u.borrado = 0;";

            DataTable tablaUs = instance.consultaSQL(query);
            if (tablaUs.Rows.Count > 0)
            {
                return objectMappingUsuario(tablaUs.Rows[0]);
            }
            return null;
            
        }

        private DataTable consultaSQL(string strSql)
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

        private Usuario objectMappingUsuario(DataRow row)
        {
            /*
             * A partir del registro de un usuario,
             * tranforma esa información en un 
             * objeto del tipo Usuario
             */
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["idUsuario"].ToString()),
                Nombre = row["NombreUsuario"].ToString(),
                Clave = row["clave"].ToString(),
                Rol = new Rol()
                {
                    IdRol = Convert.ToInt32(row["idRol"].ToString()),
                    Nombre = row["NombreRol"].ToString(),
                }
            };

            return oUsuario;
        }
    }
}
