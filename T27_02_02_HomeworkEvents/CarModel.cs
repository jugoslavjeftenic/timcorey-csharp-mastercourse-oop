
namespace T27_02_02_HomeworkEvents
{
    public class CarModel
    {
        public event EventHandler<string>? CarDashboard;

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public bool IsRunning { get; set; } = false;

        public CarModel(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void StartEngine()
        {
            IsRunning = true;
            CarDashboard?.Invoke(this, $"{Brand} {Model} engine is on.");
        }

        public void StopEngine()
        {
            IsRunning = false;
            CarDashboard?.Invoke(this, $"{Brand} {Model} engine is off.");
        }
    }
}