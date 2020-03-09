using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Context;
using System.Linq;
namespace Repository.Implementation
{
    public class TeamRepository : ITeamRepository
    {
        private ApplicationDbContext context;
        public TeamRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetAll()
        {
            var result = new List<Team>();
            try
            {
                result = context.Teams.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public Team GetById(int id)
        {
            var team = new Team();
            try
            {
                team = context.Teams.Single(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
            return team;
        }

        public bool Save(Team entity)
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

        public bool Update(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
