namespace CarRentingAsp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? Message { get; set; }
        public int CustomerId { get; set; }
        public  Customer ?Customer { get; set; }
        public  ICollection<Respond> ?Responds { get; set; }

    }
}
