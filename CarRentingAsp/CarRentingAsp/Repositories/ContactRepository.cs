using CarRentingAsp.Models;
using CarRentingAsp.Repositories.Interfaces;

namespace CarRentingAsp.Repositories.Interfaces
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(CarRentingContext carRentingContext)
            : base(carRentingContext)
        {
        }
    }
}
