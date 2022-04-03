using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Create(T obj);

        void Update(T obj);

        void Delete(int id);
    }
}
