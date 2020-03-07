using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Repository
{
    public interface IUserRepository:ICrudRepository<User>
    {
    }
}
