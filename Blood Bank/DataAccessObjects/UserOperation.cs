using Blood_Bank.DataAccess;
using Blood_Bank.Entities;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Blood_Bank.DataAccessObjects
{
    /// <summary>
    /// User Data Access Object Implementations
    /// 
    /// Written By: Abtahi
    /// </summary>
    internal class UserOperation : IUserOperation
    {
        AccessDB accessDB = new AccessDB();

        /// <summary>
        /// Inserts a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int InsertUser(UserEntity user)
        {
            string procName = "INSERT_USER";
            string param0 = "U_FIRSTNAME";
            string param1 = "U_LASTNAME";
            string param2 = "U_PASSWORD";
            string param3 = "U_BLOOD_GROUP";
            string param4 = "U_GENDER";
            string param5 = "U_DOB";
            string param6 = "U_EMAIL";
            string param7 = "U_CONTACT_NO";
            string param8 = "U_ADDRESS";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.FirstName;
            command.Parameters.Add(param1, OracleDbType.Varchar2).Value = user.LastName;
            command.Parameters.Add(param2, OracleDbType.Varchar2).Value = user.Password;
            command.Parameters.Add(param3, OracleDbType.Varchar2).Value = user.BloodGroup;
            command.Parameters.Add(param4, OracleDbType.Varchar2).Value = user.Gender;
            command.Parameters.Add(param5, OracleDbType.Varchar2).Value = user.Dob;
            command.Parameters.Add(param6, OracleDbType.Varchar2).Value = user.Email;
            command.Parameters.Add(param7, OracleDbType.Int32).Value = user.ContactNo;
            command.Parameters.Add(param8, OracleDbType.Varchar2).Value = user.Address;

            return accessDB.ExecuteNonQuery(command);
        }

        /// <summary>
        /// Updates a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UpdateUser(UserEntity user)
        {
            string procName = "UPDATE_USER";
            string param0 = "U_NAME";
            string param1 = "U_EMAIL";
            string param2 = "U_PASSWORD";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.FirstName;
            command.Parameters.Add(param1, OracleDbType.Varchar2).Value = user.Email;
            command.Parameters.Add(param2, OracleDbType.Varchar2).Value = user.Password;

            return accessDB.ExecuteNonQuery(command);
        }

        /// <summary>
        /// Deletes a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int DeleteUser(UserEntity user)
        {
            string procName = "DELETE_USER";
            string param0 = "U_EMAIL";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.Email;

            return accessDB.ExecuteNonQuery(command);
        }

        /// <summary>
        /// Validates User Credential
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable ValidateUser(UserEntity user)
        {
            string procName = "VALIDATE_USER";
            string param0 = "U_EMAIL";
            string param1 = "U_PASSWORD";
            string param2 = "U_RECORDSET";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.Email;
            command.Parameters.Add(param1, OracleDbType.Varchar2).Value = user.Password;
            command.Parameters.Add(param2, OracleDbType.RefCursor, ParameterDirection.Output);

            return accessDB.ExecuteReader(command);
        }

        /// <summary>
        /// Lists all User
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUsers()
        {
            string procName = "SELECT_USER";
            string param0 = "U_RECORDSET";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.RefCursor, ParameterDirection.Output);

            return accessDB.ExecuteReader(command);
        }

        /// <summary>
        /// Search User by Email
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable SearchUserByEmail(UserEntity user)
        {
            string procName = "SEARCH_USER_BY_EMAIL";
            string param0 = "U_EMAIL";
            string param1 = "U_RECORDSET";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.Email;
            command.Parameters.Add(param1, OracleDbType.RefCursor, ParameterDirection.Output);

            return accessDB.ExecuteReader(command);
        }

        /// <summary>
        /// Search User by Blood Group
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable SearchUsersByBloodGroup(UserEntity user)
        {
            string procName = "SEARCH_USER_BY_BLOOD_GROUP";
            string param0 = "U_BLOOD_GROUP";
            string param1 = "U_RECORDSET";

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.Add(param0, OracleDbType.Varchar2).Value = user.BloodGroup;
            command.Parameters.Add(param1, OracleDbType.RefCursor, ParameterDirection.Output);

            return accessDB.ExecuteReader(command);
        }
    }
}
