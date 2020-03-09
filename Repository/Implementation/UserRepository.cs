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
            catch(Exception)
            {
                throw;
            }
            return result;
        }

        public User GetById(int id)
        {
            var result = new User();
            try
            {
                result = context.Users.Single(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(User entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
#pragma warning disable CA1031 // No capture tipos de excepción generales.
            catch (Exception)
#pragma warning restore CA1031 // No capture tipos de excepción generales.
            {
                return false;
            }
            return true;
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
