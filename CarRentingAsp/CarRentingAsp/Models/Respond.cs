namespace CarRentingAsp.Models
{
    public class Respond
    {
        public int RespondId { get; set; }
        public string Message { get; set; }
        public int ReviewId { get; set; }
        public int EmployerId { get; set; }
       

        public  Review ?Review { get; set; }
        
      

    }
}
