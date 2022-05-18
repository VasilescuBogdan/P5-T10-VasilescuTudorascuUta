using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
