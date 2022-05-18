using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class BookingService : BaseService
    {
        public BookingService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Booking> GetBooking()
        {
            return repositoryWrapper.BookingRepository.FindAll().ToList();
        }

        public List<Booking> GetBookingByCondition(Expression<Func<Booking, bool>> expression)
        {
            return repositoryWrapper.BookingRepository.FindByCondition(expression).ToList();
        }

        public void AddBooking(Booking booking)
        {
            repositoryWrapper.BookingRepository.Create(booking);
        }

        public void UpdateBooking(Booking booking)
        {
            repositoryWrapper.BookingRepository.Update(booking);
        }

        public void DeleteBooking(Booking booking)
        {
            repositoryWrapper.BookingRepository.Delete(booking);
        }
    }
}
