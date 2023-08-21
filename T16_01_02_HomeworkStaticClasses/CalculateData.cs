
namespace T16_01_02_HomeworkStaticClasses
{
    internal class CalculateData
    {
        public static double ArithmeticOperation(string operation, double x, double y)
        {
            return operation switch
            {
                "+" => Add(x, y),
                "-" => Subtract(x, y),
                "*" => Multiply(x, y),
                _ => Divide(x, y),
            };
        }

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static double Subtract(double x, double y)
        {
            return x - y;
        }

        private static double Multiply(double x, double y)
        {
            return x * y;
        }

        private static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
