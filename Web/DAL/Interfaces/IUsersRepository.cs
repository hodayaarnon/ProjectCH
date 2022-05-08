using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Classes
{
   public interface IUsersRepository: IRepository<Users>
    {
        void Create(IEnumerable<Users> objs);
        Users GetUserByEmail(string Email);
        Users GetUserByEmailAndPassword(string Email, string password);
    }
}
