using Blood_Bank.Entities;
using System.Data;

namespace Blood_Bank.DataAccessObjects
{
    /// <summary>
    /// User Data Access Object public Interface
    /// 
    /// Written By: Abtahi
    /// </summary>
    public interface IUserOperation
    {
        int InsertUser(UserEntity user);
        int UpdateUser(UserEntity user);
        int DeleteUser(UserEntity user);
        DataTable ValidateUser(UserEntity user);
        DataTable GetAllUsers();
        DataTable SearchUserByEmail(UserEntity user);
        DataTable SearchUsersByBloodGroup(UserEntity user);
    }
}
