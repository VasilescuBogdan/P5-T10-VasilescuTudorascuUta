namespace CarRentingAsp.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }

        public int? Amount { get; set; }
     

        public  ICollection<Employer> ?Employees { get; set; }
    }
}
