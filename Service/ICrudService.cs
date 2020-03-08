using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface ICrudService<T>
    {
        bool Save(T entity);
        bool Update(T entity);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
