using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL.Classes
{
    public class AuthRepository : IAuthRepository
    {
        DBContext context;
        public AuthRepository(DBContext context)
        {
            this.context = context;
        }
        public void Create(Authorizations obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Authorizations> GetAll()
        {
            return context.Authorizations.ToList();
        }

        public Authorizations GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Authorizations obj)
        {
            throw new NotImplementedException();
        }
    }
}
