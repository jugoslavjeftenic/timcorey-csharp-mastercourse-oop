namespace T16_01_01_StaticClasses
{
    public static class RequestData
    {
        public static string GetAString(string message)
        {
            string? output;

            Console.Write($"{message} ");
            while (string.IsNullOrWhiteSpace(output = Console.ReadLine()))
            {
                Console.WriteLine("That was not a valid name. Please try again.");
                Console.Write($"{message} ");
            }

            return output;
        }

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
    }
}
