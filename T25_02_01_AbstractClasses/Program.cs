namespace T25_02_01_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryItem book = new Book();
            book.ProductName = "Some book";

            Car car = new Car();
            car.NumberOfWheels = 6;
        }
    }

    public abstract class Vehicle
    {
        public string? VIN { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}