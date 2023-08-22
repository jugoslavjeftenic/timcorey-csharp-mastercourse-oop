namespace T17_01_01_PropertyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new("Corey")
            {
                FirstName = "Tim",
                //LastName = "Corey",
                Age = 30,
                SSN = "123-45-6789"
            };

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);
        }
    }
}