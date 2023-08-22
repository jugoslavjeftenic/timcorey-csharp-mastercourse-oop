namespace T16_02_02_HomeworkInstantiatedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console application that has a Person class and Address clas.

            Address address = new()
            {
                Street = "1st street",
                StreetNumber = "66",
                City = "Sweethaven Village",
            };

            Person person = new()
            {
                FirstName = "Popeye",
                LastName = "Sailor Man",
                DOB = DateOnly.Parse("16/9/1929"),
                Address = address,
            };

            Console.WriteLine($"{person.FirstName} {person.LastName}");
            Console.WriteLine($"{person.DOB}");
            Console.WriteLine($"{person.Address.Street} {person.Address.StreetNumber} {person.Address.City}");
        }
    }
}