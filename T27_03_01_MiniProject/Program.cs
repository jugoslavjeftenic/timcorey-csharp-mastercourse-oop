namespace T27_03_01_MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new()
            {
                new PersonModel{FirstName="Tim",LastName="Corey",Email="tim@iamtimcorey.com"},
                new PersonModel{FirstName="Sue",LastName="Storm",Email="sue@stormy.net"},
                new PersonModel{FirstName="John",LastName="Smith",Email="john45376@aol.com"},
                new PersonModel{FirstName="Bob",LastName="Darnit",Email="john45376@aol.com"},
            };

            List<CarModel> cars = new()
            {
                new CarModel{Manufacturer="Toyota",Model="Corolla"},
                new CarModel{Manufacturer="Toyota",Model="Highlander"},
                new CarModel{Manufacturer="Ford",Model="Mustang"},
            };

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\");

            DataAcces<PersonModel> peopleData = new();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;
            peopleData.SaveToCSV(people, $"{filePath}people.csv");

            DataAcces<CarModel> carData = new();
            carData.BadEntryFound += CarData_BadEntryFound;
            carData.SaveToCSV(cars, $"{filePath}cars.csv");
        }

        private static void PeopleData_BadEntryFound(object? sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName}");
        }

        private static void CarData_BadEntryFound(object? sender, CarModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model}");
        }
    }
}