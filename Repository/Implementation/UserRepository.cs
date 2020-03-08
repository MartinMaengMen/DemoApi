using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Context;
using System.Linq;
namespace Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext context;
        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
        {
            var result = new List<User>();
            try
            {
                result = context.Users.ToList();
            }
            catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
