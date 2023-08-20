namespace T16_01_01_StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateData.myAge = 52;

            UserMessages.ApplicationStartMessage(RequestData.GetAString("What is your first name?"));

            double x = RequestData.GetADouble(" Please enter your first number:");
            double y = RequestData.GetADouble("Please enter your second number:");
            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}.");
        }
    }
}
