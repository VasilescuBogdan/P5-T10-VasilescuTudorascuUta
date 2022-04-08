namespace CarRentingAsp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int CustomerId { get; set; }

        public  ICollection<Answer> ?Answers { get; set; }

        public  Customer? Customer { get; set; }

    }
}
