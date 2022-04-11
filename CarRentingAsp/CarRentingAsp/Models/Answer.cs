namespace CarRentingAsp.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        
        public int ContactId { get; set; }
        public int EmployerId { get; set; }

       
        public  Employer? Employer { get; set; }
        public  Contact? Contact { get; set; }

    }
}
