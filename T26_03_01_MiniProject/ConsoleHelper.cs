﻿namespace T26_03_01_MiniProject
{
    internal static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string? output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax)
                {
                    isInValidRange = (output >= minValue && output <= maxValue);
                }
            }

            return output;
        }
    }
}
