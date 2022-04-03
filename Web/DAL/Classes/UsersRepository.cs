using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Classes
{
    public class UsersRepository : IUsersRepository
    {
        DBContext context;
        public UsersRepository(DBContext context)
        {
            this.context = context;
        }

        public void Create(Users obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Users GetById(int id)
        {
            return context.Users.Find(id);
        }
        public Users GetUserByEmail(string Email)
        {
            return context.Users.Where(u => u.Email.Trim() == Email).FirstOrDefault();
        }
        public Users GetUserByEmailAndPassword(string Email, string password)
        {
            return context.Users.Where(u => u.Email.Trim() == Email && u.Userpassword.Trim() == password).FirstOrDefault();
        }

        public void Update(Users obj)
        {
            if (GetById(obj.Userid) != null)
                context.Users.Update(obj);


        }
    }
}
