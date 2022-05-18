using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class AnswerService : BaseService
    {
        public AnswerService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Answer> GetAnswer()
        {
            return repositoryWrapper.AnswerRepository.FindAll().ToList();
        }

        public List<Answer> GetAnswerByCondition(Expression<Func<Answer, bool>> expression)
        {
            return repositoryWrapper.AnswerRepository.FindByCondition(expression).ToList();
        }

        public void AddAnswer(Answer answer)
        {
            repositoryWrapper.AnswerRepository.Create(answer);
        }

        public void UpdateAnswer(Answer answer)
        {
            repositoryWrapper.AnswerRepository.Update(answer);
        }

        public void DeleteAnswer(Answer answer)
        {
            repositoryWrapper.AnswerRepository.Delete(answer);
        }
    }
}
