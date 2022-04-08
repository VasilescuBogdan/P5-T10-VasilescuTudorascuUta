namespace CarRentingAsp.Models
{
    public class Respond
    {
        public int RespondId { get; set; }
        public int ReviewId { get; set; }
        public int EmployerId { get; set; }
       

        public  Review ?Review { get; set; }
        public  Employer ?Employer { get; set; }
      

    }
}
