using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Classes
{
   public interface IUsersRepository: IRepository<Users>
    {
        Users GetUserByEmail(string Email);
        Users GetUserByEmailAndPassword(string Email, string password);
    }
}
