using Common.modelsVM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
   public interface IUsersService
    {
        List<UsersVM> GetList();
        UsersVM GetById(int id);
        void DeleteUser(int id);
        void AddUser(UsersVM c);
        void AddUsers(IEnumerable<UsersVM> c);

        UsersVM GetUserByEmail(string Email);
        UsersVM GetUserByEmailAndPassword(string Email, string password);
    }
}
