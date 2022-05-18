namespace CarRentingAsp.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Message { get; set; }
        public int ContactId { get; set; }
        public int EmployerId { get; set; }

       
        
        public  Contact? Contact { get; set; }

    }
}
