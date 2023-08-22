using T17_02_02_PrintData;

namespace T17_02_02_HomeworkNamespaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create class file and change the namespace to be something different.
            // Call a method in that class.

            PersonModel person = new("Popeye");

            PrintData.PrintName(person.Name);
        }
    }
}