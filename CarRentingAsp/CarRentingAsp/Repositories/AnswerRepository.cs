using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public AnswerRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
