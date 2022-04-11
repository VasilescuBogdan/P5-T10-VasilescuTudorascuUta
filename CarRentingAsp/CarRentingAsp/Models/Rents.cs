namespace CarRentingAsp.Models
{
    public class Rents
    {
        public int RentsId { get; set; }

        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int BookingId { get; set; }

        public  Customer? Customer { get; set; }
        public  Car ?Car { get; set; }
        public  Booking ?Booking { get; set; }

    }
}
