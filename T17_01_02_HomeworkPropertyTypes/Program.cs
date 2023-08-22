
namespace T17_01_02_HomeworkPropertyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class that has properties for street address, city, state, and zip code.
            // Then add a FullAddress property that is read-only.

            AddressModel address = new()
            {
                Street = "1st Street",
                City = "Sweethaven Village",
                State = "Malta",
                Zip = "MLH 356",
            };

            Console.WriteLine(address.FullAddress);
        }
    }
}