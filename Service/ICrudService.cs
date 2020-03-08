using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface ICrudService<T>
    {
        bool Save(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
