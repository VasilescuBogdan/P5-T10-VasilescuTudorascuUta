using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
