
namespace CarRentingAsp.Models
{
    public class Billing
    {
       
    
        public int BillingId { get; set; }

        public string? Status { get; set; }
        public int? Amount  { get; set; }
        public int BookingId { get; set; }

        public  Booking ?Booking { get; set; }
    }
}
