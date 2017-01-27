using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace Blood_Bank.DataAccess
{
    /// <summary>
    /// Common DB Interaction Logics
    /// 
    /// Written By: Abtahi
    /// </summary>
    public class AccessDB
    {
        const string CONNECTION_STRING = "User Id=root;Password=password;" + "Data Source=localhost:1521/XE;Pooling=false;";

        public OracleConnection connection = new OracleConnection(CONNECTION_STRING);

        public AccessDB()
        {

        }

        /// <summary>
        /// Opens a DB connection
        /// </summary>
        /// <returns>SqlConnection object</returns>
        public OracleConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        /// <summary>
        /// Opens a DB connection
        /// </summary>
        /// <returns>SqlConnection object</returns>
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Executes non query commands for insert, update, delete
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Number of rows affected</returns>
        public int ExecuteNonQuery(OracleCommand command)
        {
            command.Connection = this.GetConnection();

            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return rowsAffected;
        }

        /// <summary>
        /// Retrives single value from the DB
        /// </summary>
        /// <param name="command"></param>
        /// <returns>First column of the first row</returns>
        public object ExeceuteScalar(OracleCommand command)
        {
            command.Connection = this.GetConnection();

            object obj = 0;
            try
            {
                obj = command.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }

            return obj;
        }

        /// <summary>
        /// Executes sql command and builds a data table
        /// </summary>
        /// <param name="command"></param>
        /// <returns>DataTable consisting retrived data</returns>
        public DataTable ExecuteReader(OracleCommand command)
        {
            command.Connection = this.GetConnection();

            OracleDataReader oracleDataReader;
            DataTable dataTable = new DataTable();
            try
            {
                oracleDataReader = command.ExecuteReader();

                if (oracleDataReader.HasRows)
                {
                    dataTable.Load(oracleDataReader);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dataTable;
        }

        /// <summary>
        /// Executes sql command and builds a reader
        /// </summary>
        /// <param name="command"></param>
        /// <returns>SqlDataReader Object</returns>
        public OracleDataReader ExecuteDataReader(OracleCommand command)
        {
            command.Connection = this.GetConnection();

            OracleDataReader oracleDataReader;
            try
            {
                oracleDataReader = command.ExecuteReader();
                oracleDataReader.Read();
            }
            catch (Exception)
            {
                throw;
            }

            //connection.Close();
            return oracleDataReader;
        }
    }
}
