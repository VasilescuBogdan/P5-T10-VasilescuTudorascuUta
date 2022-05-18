namespace CarRentingAsp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime? PickUp_Date { get; set; }

        public DateTime? DropOff_Date { get; set; }

        public float? PickUp_Time { get; set; }

        public float? DropOff_Time { get; set; }

        public string? PickUp_Location { get; set; }

        public string? DropOff_Location { get; set; }

        public string? Status { get; set; }

        public int? Amount { get; set; }


        public int CustomerId { get; set; }
        public int CarId { get; set; }

       
        public Car? Car { get; set; }


    }
}
