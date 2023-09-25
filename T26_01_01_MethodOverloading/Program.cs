namespace T26_01_01_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Tim", "Corey");
            person.GenerateEmail(true, "gmail.com");

            Console.WriteLine(person.Email);
        }
    }
}