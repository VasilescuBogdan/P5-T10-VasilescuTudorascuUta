using Microsoft.EntityFrameworkCore;
namespace CarRentingAsp.Models
{
    public class CarRentingContext:DbContext
    {
        public CarRentingContext(DbContextOptions<CarRentingContext> options)
            : base(options) { }

        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Answer>? Answers { get; set; }
        public DbSet<Billing>? Billings { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Car>? Cars { get; set; }
        public DbSet<Car_Category>? Car_Categories { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Employer>? Employees { get; set; }
        public DbSet<Program_Hour>? Program_Hours { get; set; }
        public DbSet<Rents>? Rentss { get; set; }
        public DbSet<Respond>? Responds { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Salary>? Salaries { get; set; }


    }
}
