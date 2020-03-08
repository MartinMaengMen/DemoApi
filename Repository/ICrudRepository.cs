using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ICrudRepository<T>
    {
        bool Save(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
