using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Service
{
    public interface IUserService:ICrudService<User>
    {
        User Authenticate(string username, string password);
    }
}
