namespace CarRentingAsp.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }

        public int? Model_Year { get; set; }
        public int? Mileage { get; set; }

        public int? Registration_Number { get; set; }

        public string? Status  { get; set; }

        public int? Price_Hour  { get; set; }

        public int? Price_Day { get; set; }

        public int? Price_Month { get; set; }

        public int? Fee_Per_Hour { get; set; }
        public string? Fuel { get; set; }

        public string? Transmission { get; set; }

        public string? Traction { get; set; }
        public int? Lenght { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Trunk { get; set; }
        public string? Engine { get; set; }
        public string? Displacement { get; set; }
        public string? Fuel_System { get; set; }
        public int? Horsepower { get; set; }
        public int? Torque { get; set; }
        public float? Consumption_Urban { get; set; }
        public float? Consumption_Extra_Urban { get; set; }
        public float? Consumption_Combine { get; set; }
        public float? Acceleration { get; set; }
        public int? Max_Speed { get; set; }
        public string? Imagine_Name { get; set; }
        public int Car_CategoryId  { get; set; }
       

        public  Car_Category ?Car_Category { get; set; }
        

        public  ICollection<Rents>? Rentss { get; set; }
        
    }
}
