using DAL.Models;
using Microsoft.EntityFrameworkCore;
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
        public void Create(IEnumerable<Users> objs)
        {
            foreach (var u in objs)
            {
                context.Add(u);
            }
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
        public Users GetUserByEmail(string em)
        {
            return context.Users.Where(u => u.Email.Trim() == em).FirstOrDefault();
           //return context.Users.FromSqlInterpolated<Users>($"EXECUTE dbo.sp_getUserByEmail '{em}'").IgnoreQueryFilters().Include(c => c.Communities).AsEnumerable().LastOrDefault(); 
       
           // return  context.Users.FromSqlRaw<Users>($"EXECUTE select * from Users'{em}'").AsEnumerable().Include(c=>c.Communities).AsEnumerable().LastOrDefault();
           // return context.Users.FromSqlRaw($"EXECUTE dbo.sp_getUserByEmail '{em}'").AsEnumerable().LastOrDefault();
           // return h;
        }
        public Users GetUserByEmailAndPassword(string Email, string password)
        {
            return context.Users.FromSqlRaw<Users>($"EXECUTE dbo.sp_getUserByEmailAndPassword '{Email}', '{password}'").AsEnumerable().LastOrDefault();
            //return context.Users.Where(u => u.Email.Trim() == Email && u.Userpassword.Trim() == password).FirstOrDefault();
        }

        public void Update(Users obj)
        {
            
            if (GetById(obj.Userid) != null)
                context.Users.Update(obj);


        }
    }
}
