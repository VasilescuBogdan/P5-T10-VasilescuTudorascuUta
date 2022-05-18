using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class Car_CategoryRepository : RepositoryBase<Car_Category>, ICar_CategoryRepository
    {
        public Car_CategoryRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
