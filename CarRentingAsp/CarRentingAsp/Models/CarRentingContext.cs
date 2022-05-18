using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CarRentingAsp.Models
{
    public class CarRentingContext:IdentityDbContext<IdentityUser>
    {
       
        

        public CarRentingContext(DbContextOptions<CarRentingContext> options)
            : base(options) { }

        
        public DbSet<Answer>? Answers { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Car>? Cars { get; set; }
        public DbSet<Car_Category>? Car_Categories { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Respond>? Responds { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
