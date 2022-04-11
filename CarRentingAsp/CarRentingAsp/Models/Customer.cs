
namespace CarRentingAsp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? Birth_Date { get; set; }
        public string? Driver_License { get; set; }
        public ICollection<Contact>? Contacts { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Rents>? Rentss { get; set; }
    }
}
