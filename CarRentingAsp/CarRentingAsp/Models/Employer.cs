namespace CarRentingAsp.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }

        public string? First_Name { get; set; }

        public string? Last_Name { get; set; }

        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public int Program_HourId { get; set; }
        public int SalaryId { get; set; }
    

        public virtual Program_Hour? Program_Hour { get; set; }

        public virtual Salary? Salary { get; set; }

        

        public  ICollection<Booking>? Bookings { get; set; }
        public  ICollection<Respond> ?Responds { get; set; }
        public  ICollection<Answer> ?Answers { get; set; }   

    }
}
