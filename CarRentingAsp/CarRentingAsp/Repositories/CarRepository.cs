using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
