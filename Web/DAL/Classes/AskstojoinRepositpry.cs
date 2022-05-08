using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Classes
{
    public class AskstojoinRepository : IAskstojoinRepository
    {
        DBContext context;

        public AskstojoinRepository(DBContext context)
        {
            this.context = context;
        }

        public void Create(Askstojoin obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Askstojoin> GetAll()
        {
           return context.Askstojoin.ToList();
        }

        public Askstojoin GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Askstojoin obj)
        {
            context.Add(obj);
            context.SaveChanges();
        }
    }
}
