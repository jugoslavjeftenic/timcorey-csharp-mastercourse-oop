using T18_01_02_HomeworkClassLibrariesLibrary.Models;

namespace T18_01_02_HomeworkClassLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class library that holds a Person class.
            // Use that class in a Console application.

            PersonModel person = new();
            person.Name = "Popeye";

            Console.WriteLine(person.Name);
        }
    }
}