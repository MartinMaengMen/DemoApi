﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Repository;
namespace Service.Implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
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
