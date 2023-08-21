namespace T16_01_02_HomeworkStaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console application with a
            // static class that handles calculations.

            double x = RequestData.GetADouble("            Please enter your first number:");
            double y = RequestData.GetADouble("           Please enter your second number:");
            string op = RequestData.GetOperator("Please enter arithmetic operator (+,-,*,/):");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The result is: {CalculateData.ArithmeticOperation(op, x, y)}.");
        }
    }
}