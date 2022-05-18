using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class RespondRepository : RepositoryBase<Respond>, IRespondRepository
    {
        public RespondRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
