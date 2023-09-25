namespace T26_02_02_HomeworkExtensionMethods
{
    // Create the following chain using extension methods:
    // person.SetDefaultAge().PrintInfo();

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Bob", "Smith");
            person.SetDefaultAge().PrintInfo();
        }
    }
}