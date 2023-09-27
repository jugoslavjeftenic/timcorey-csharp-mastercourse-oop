namespace T27_01_02_HomeworkGenerics
{
    // Create a generic method that takes in an item and calls the ToString() method and
    // prints that value to the Console.

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintToConsole(99.99f);
        }

        private static void PrintToConsole<T>(T item)
        {
            Console.WriteLine(item?.ToString());
        }
    }
}