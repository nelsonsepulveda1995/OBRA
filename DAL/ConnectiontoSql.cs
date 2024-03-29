﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        static readonly string key = "Front.Properties.Settings.ObraDB";
        SqlConnection objConexion;

        /* -------------------- private void Conectar() ------------ 
         * Este metodo como indica su nombre... me permite conectarme con la 
         * base de datos (en este caso, SqlServer) 
         */
        private void Conectar()
        {
            objConexion = new SqlConnection(ConfigurationManager.ConnectionStrings[key].ConnectionString);
            objConexion.Open();
        }
        /* -------------------- private void Desconectar() ------------ 
         * Este metodo como indica su nombre... me permite desconectarme de la
         * base de datos (en este caso, SqlServer)
         * 
         */
        private void Desconectar()
        {
            objConexion.Close();
            objConexion.Dispose();
        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure, SqlParameter[] pParametrosSql = null)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();
            //Me conecto...
            Conectar();

            try
            {
                using (objComando)
                {
                    objComando.CommandText = pNombreStoreProcedure;
                    objComando.CommandType = CommandType.StoredProcedure;
                    objComando.Connection = this.objConexion;

                    if (pParametrosSql != null)
                    {
                        //Lleno los SqlParameters a la lista de parametros
                        objComando.Parameters.AddRange(pParametrosSql);
                    }
                }

                //Instancio un adaptador con el parametro SqlCommand
                using (var objAdaptador = new SqlDataAdapter(objComando))
                {
                    //Lleno la tabla, el objeto unaTabla con el adaptador
                    objAdaptador.Fill(unaTabla);
                }

            }
            catch (Exception)
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;
                throw;
            }
            finally
            {
                //Pase lo que pase me desconecto
                this.Desconectar();
            }
            return unaTabla;
        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure, SqlParameter pParametrosSql = null)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            using (var objComando = new SqlCommand())
            {

                //Me conecto...
                this.Conectar();

                try
                {
                    objComando.CommandText = pNombreStoreProcedure;
                    objComando.CommandType = CommandType.StoredProcedure;
                    objComando.Connection = this.objConexion;

                    if (pParametrosSql != null)
                    {
                        //Lleno los SqlParameters a la lista de parametros
                        objComando.Parameters.Add(pParametrosSql);
                    }

                    //Instancio un adaptador con el parametro SqlCommand
                    using (var objAdaptador = new SqlDataAdapter(objComando))
                    {
                        //Lleno la tabla, el objeto unaTabla con el adaptador
                        objAdaptador.Fill(unaTabla);
                    }

                }
                catch (Exception)
                {
                    //Como hay error... por el motivo que sea asigno el resultado a null
                    unaTabla = null;
                    throw;
                }
                finally
                {
                    //Pase lo que pase me desconecto
                    this.Desconectar();
                }
            }
            return unaTabla;
        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                objComando.CommandText = pNombreStoreProcedure;
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Connection = this.objConexion;

                //Instancio un adaptador con el parametro SqlCommand
                var objAdaptador = new SqlDataAdapter(objComando);
                
                    //Lleno la tabla, el objeto unaTabla con el adaptador
                    objAdaptador.Fill(unaTabla);
                
            }
            catch (Exception)
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;
                throw;
            }
            finally
            {
                //Pase lo que pase me desconecto
                this.Desconectar();
            }
            return unaTabla;
        }

        public DataTable LeerPorComando(string pComando)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                //Parametrizo el objeto SqlCommand con sus valores respectivos
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;
                objComando.CommandText = pComando;

                //Instancio un adaptador con el parametro SqlCommand
                var objAdaptador = new SqlDataAdapter(objComando);
                   //Lleno la tabla, el objeto unaTabla con el adaptador
                    objAdaptador.Fill(unaTabla);
                
            }
            catch
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;
                throw;
            }
            finally
            {
                //Siempre, por más que salga bien o mal el llenado, me desconecto
                this.Desconectar();
            }
            return unaTabla;
        }

        public int EscribirPorComando(string pTexto)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            using (var objComando = new SqlCommand())
            {

                //Me conecto...
                this.Conectar();

                try
                {
                    objComando.CommandText = pTexto;
                    objComando.CommandType = CommandType.Text;
                    objComando.Connection = this.objConexion;

                    //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                    filasAfectadas = objComando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    filasAfectadas = -1;
                    throw;
                }
                finally
                {
                    //Me desconecto
                    this.Desconectar();
                }
            }

            return filasAfectadas;
        }

        public int EscribirPorStoreProcedure(string pTexto, SqlParameter[] pParametrosSql)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();
            
                //Me conecto...
                this.Conectar();

                try
                {
                    objComando.CommandText = pTexto;
                    objComando.CommandType = CommandType.StoredProcedure;
                    objComando.Connection = this.objConexion;

                    if (pParametrosSql.Length > 0)
                    {
                        objComando.Parameters.AddRange(pParametrosSql);
                        //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                        filasAfectadas = objComando.ExecuteNonQuery();
                    }
                    else
                    {
                        //retorno -1 porque la lista de parametros Sql tiene 0 ítems...
                        filasAfectadas = -1;
                    }
                }
                catch (Exception)
                {
                    filasAfectadas = -1;
                    throw;
                }
                finally
                {
                    //Me desconecto
                    this.Desconectar();
                }
            
            return filasAfectadas;
        }

        #region Parametros
        public SqlParameter CrearParametro(string pNombre, string pValor)
        {

            SqlParameter objParametro = new SqlParameter
            {
                ParameterName = pNombre,
                Value = pValor,
                DbType = DbType.String
            };

            return objParametro;
        }

        public SqlParameter CrearParametro(string pNombre, double pValor)
        {

            SqlParameter objParametro = new SqlParameter
            {
                ParameterName = pNombre,
                Value = pValor,
                DbType = DbType.Double
            };

            return objParametro;
        }

        public SqlParameter CrearParametro(string pNombre, DateTime pValor)
        {

            SqlParameter objParametro = new SqlParameter
            {
                ParameterName = pNombre,
                Value = pValor,
                DbType = DbType.DateTime
            };

            return objParametro;
        }

        public SqlParameter CrearParametro(string pNombre, int pValor)
        {

            SqlParameter objParametro = new SqlParameter
            {
                ParameterName = pNombre,
                Value = pValor,
                DbType = DbType.Int32
            };

            return objParametro;
        }

        public SqlParameter CrearParametro(string pNombre, Boolean pValor)
        {

            SqlParameter objParametro = new SqlParameter
            {
                ParameterName = pNombre,
                Value = pValor,
                DbType = DbType.Boolean
            };

            return objParametro;
        }
        #endregion
    }
}