using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Classes
{
    public class JoiningsRepository : IJoiningsRepository
    {
        DBContext context;
        public JoiningsRepository(DBContext context)
        {
            this.context = context;
        }
        public void Create(Joinings obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }
         public void Create(IEnumerable<Joinings> objs)
        {
            foreach (var ob in objs)
            {
                context.Add(ob);
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Joinings> GetAll()
        {
            return context.Joinings.ToList();
        }

        public Joinings GetById(int id)
        {
            return context.Joinings.Find(id);
        }

        public void Update(Joinings obj)
        {
            if (GetById((int)obj.Userid) != null)
                context.Joinings.Update(obj);
        }
    }
}
