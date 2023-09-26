namespace T26_03_01_MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel
            {
                FirstName = "What is your first name: ".RequestString(),
                LastName = "What is your last name: ".RequestString(),
                Age = "What is your age: ".RequestInt(0, 120)
            };
        }
    }
}