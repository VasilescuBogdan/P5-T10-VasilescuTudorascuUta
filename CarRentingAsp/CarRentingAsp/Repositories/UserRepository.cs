using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        { }
    }
}
