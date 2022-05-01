using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.Classes
{
    public class RolesRepository : IRolesRepository
    {
        DBContext context;
        public RolesRepository(DBContext context)
        {
            this.context = context;
        }
        public void Create(Roles obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Roles> GetAll()
        {
            throw new NotImplementedException();
        }

        public Roles GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Roles obj)
        {
            throw new NotImplementedException();
        }
      
        public List<Roles> GetUserRolesInCommunity(int userid, int comid)
         {
            //Roles r= r.Joinings
            return (from j in context.Joinings where (j.Userid == userid && j.Communityid==comid) select (j.Role)).ToList();
        }
        public List<Roles> GetRolesPerUserAndCommunity()
        {
            //Roles r= r.Joinings
            return (from j in context.Joinings select (j.Role)).ToList();
        }
    }
}
