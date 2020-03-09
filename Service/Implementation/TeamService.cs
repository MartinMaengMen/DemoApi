using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;
namespace Service.Implementation
{
    public class TeamService : ITeamService
    {
        private ITeamRepository teamRepository;
        public TeamService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }
        public IEnumerable<Team> GetAll()
        {
            return teamRepository.GetAll();
        }

        public Team GetById(int id)
        {
            return teamRepository.GetById(id);
        }

        public bool Save(Team entity)
        {
            return teamRepository.Save(entity);
        }

        public bool Update(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
