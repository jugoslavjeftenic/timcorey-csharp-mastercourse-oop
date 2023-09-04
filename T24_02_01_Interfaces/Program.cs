namespace T24_02_01_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)
            {
                controller.Connect();

                if (controller is GameController gc)
                {
                    gc.Dispose();
                }

                if (controller is IBatteryPowered powered)
                {
                    powered.BatteryLevel = 0;
                    controller.Connect();
                }
            }

            using (GameController gc = new())
            {

            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);
        }
    }
}