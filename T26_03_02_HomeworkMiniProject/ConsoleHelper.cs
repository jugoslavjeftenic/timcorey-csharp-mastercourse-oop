namespace T26_03_02_HomeworkMiniProject
{
    internal static class ConsoleHelper
    {
        public static string GetString(this string message)
        {
            string? output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int GetInt(this string message)
        {
            return message.GetInt();
        }

        public static int GetInt(this string message, int minRange, int maxRange)
        {
            return message.GetInt(true, minRange, maxRange);
        }

        private static int GetInt(this string message, bool useRange = false, int minRange = 0, int maxRange = 0)
        {
            int output = 0;
            bool isInt = false;

            while (isInt == false)
            {
                Console.Write(message);
                isInt = int.TryParse(Console.ReadLine(), out output);

                if (isInt && useRange)
                {
                    if (output >= minRange && output <= maxRange)
                    {
                        return output;
                    }
                    else
                    {
                        isInt = false;
                    }
                }
            }

            return output;
        }

        public static decimal GetDecimal(this string message)
        {
            decimal output = 0m;
            bool isDecimal = false;

            while (isDecimal == false)
            {
                Console.Write(message);
                isDecimal = decimal.TryParse(Console.ReadLine(), out output);
            }

            return output;
        }

        public static void PrintEmployeeData(this EmployeeModel employee)
        {
            Console.WriteLine();
            Console.WriteLine("Employee data:");
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            Console.WriteLine($"- weekly work hours: {employee.WeeklyWorkHours}");
            Console.WriteLine($"-       hourly wage: {employee.HourlyWage}");
            Console.WriteLine($"-        weekly pay: {employee.WeeklyWorkHours * employee.HourlyWage}");
        }
    }
}