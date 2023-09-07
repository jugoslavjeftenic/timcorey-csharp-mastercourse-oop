namespace T25_03_01_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = "Tim",
                LastName = "Corey",
                Email = "tim@iamtimcorey.com"
            };

            Console.WriteLine(person);
        }
    }
}