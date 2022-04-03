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
            //לקבל את קוד המשתמש
            //לקבל את קודי הקהילות שחבר בהן בפועל
            List<Communities> communities = new List<Communities>();
            List<Joinings> joinings = new List<Joinings>();

            var list = (context.Joinings.Where(j => j.Userid == id).Include(j => j.Community)).ToList();
            foreach (var item in list)
            {
                communities.Add(item.Community);
            }
            return communities;

        }
    }
}
