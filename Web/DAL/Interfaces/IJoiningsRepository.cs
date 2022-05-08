using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
   public interface IJoiningsRepository:IRepository<Joinings>
    {
        public void Create(IEnumerable<Joinings> objs);
    }
}
