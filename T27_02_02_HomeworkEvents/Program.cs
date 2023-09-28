
namespace T27_02_02_HomeworkEvents
{
    // Create an event in a class and then consume that class.
    // Attach a listener to the event and have it write to the console.

    internal class Program
    {
        static void Main()
        {
            CarModel car = new("Peugeot", "208");
            car.CarDashboard += Car_CarDashboard;
            car.StartEngine();
            Thread.Sleep(1000);
            car.StopEngine();
        }

        private static void Car_CarDashboard(object? sender, string e)
        {
            Console.WriteLine(e);
        }
    }
}