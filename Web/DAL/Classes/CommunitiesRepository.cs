using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CommunitiesRepository : ICommunitiesRepository
    {
        DBContext context;
        public CommunitiesRepository(DBContext context)
        {
            this.context = context;
        }

        public void Create(Communities obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Communities> GetAll()
        {
            //List<Communities> GetAll = new List<Communities>();
            //GetAll.Add(new Communities() { Communityid = 909 });
            //return GetAll;
            return context.Communities.ToList();
        }

        public Communities GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Communities obj)
        {
            throw new NotImplementedException();
        }
        public List<Communities> GetUserCommunities(int id)
        {
            //List<Communities> communities = new List<Communities>();
            ////var f= context.Communities.Where(c=>c.)
            //var list = (context.Joinings.Where(j => j.Userid == id).Include(j => j.Community)).ToList();
            //foreach (var item in list)
            //{
            //    communities.Add(item.Community);
            //}
            return (from j in context.Joinings where (j.Userid == id) select (j.Community)).ToList();
         }

        public Communities GetCommunityById(int id)
        {
            return context.Communities.Find(id);
        }
    }
}
