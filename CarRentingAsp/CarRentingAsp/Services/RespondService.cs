using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class RespondService : BaseService
    {
        public RespondService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Respond> GetRespond()
        {
            return repositoryWrapper.RespondRepository.FindAll().ToList();
        }

        public List<Respond> GetRespondByCondition(Expression<Func<Respond, bool>> expression)
        {
            return repositoryWrapper.RespondRepository.FindByCondition(expression).ToList();
        }

        public void AddRespond(Respond respond)
        {
            repositoryWrapper.RespondRepository.Create(respond);
        }

        public void UpdateRespond(Respond respond)
        {
            repositoryWrapper.RespondRepository.Update(respond);
        }

        public void DeleteRespond(Respond respond)
        {
            repositoryWrapper.RespondRepository.Delete(respond);
        }
    }
}