
namespace T16_01_02_HomeworkStaticClasses
{
    public static class RequestData
    {
        public static double GetADouble(string message)
        {
            double output;

            Console.Write($"{message} ");
            while (double.TryParse(Console.ReadLine(), out output) == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.Write($"{message} ");
            }

            return output;
        }

        public static string GetOperator(string message)
        {
            string? output;

            Console.Write($"{message} ");
            do
            {
                output = Console.ReadLine();
                if (output == "+" || output == "-" || output == "*" || output == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid arithmetic operator.");
                    Console.Write($"{message} ");
                }

            } while (true);

            return output;
        }
    }
}
