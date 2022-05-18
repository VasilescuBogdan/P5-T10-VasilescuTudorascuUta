namespace CarRentingAsp.Models
{
    public class Car_Category
    {
        public string Car_CategoryId { get; set; }


        public int? Seats { get; set; }

        public string? Luggage { get; set; }

      

        public  ICollection<Car>? Cars { get; set; }
    }
}
