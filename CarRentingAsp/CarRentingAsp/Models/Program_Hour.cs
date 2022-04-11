namespace CarRentingAsp.Models
{
    public class Program_Hour
    {
        public int Program_HourId { get; set; }
        public string? Working_Hour { get; set; }
        
        public  ICollection<Employer>? Employers { get; set; }

    }
}
