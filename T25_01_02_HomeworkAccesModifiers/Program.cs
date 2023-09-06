using T25_01_02_HomeworkAccesModifiersLibrary;

namespace T25_01_02_HomeworkAccesModifiers
{
    // Create a Class Library and a Console application.
    // Create a public class with members that have diferent modifiers.
    // Try each out.

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetAge(50);
        }
    }
}