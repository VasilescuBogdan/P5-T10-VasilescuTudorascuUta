﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class UserService : BaseService
    {
        public UserService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<User> GetUsers()
        {
            return repositoryWrapper.UserRepository.FindAll().ToList();
        }

        public List<User> GetUsersByCondition(Expression<Func<User, bool>> expression)
        {
            return repositoryWrapper.UserRepository.FindByCondition(expression).ToList();
        }

        public void AddUser(User user)
        {
            repositoryWrapper.UserRepository.Create(user);
        }

        public void UpdateUser(User user)
        {
            repositoryWrapper.UserRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            repositoryWrapper.UserRepository.Delete(user);
        }
    }
}
