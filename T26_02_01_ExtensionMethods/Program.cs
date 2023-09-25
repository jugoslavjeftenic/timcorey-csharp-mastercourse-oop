namespace T26_02_01_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Hello World".PrintToConsole();

            var room = new HotelRoomModel();
            room.TurnOnAir().SetTemperature(24).OpenShades();
            room.TurnOffAir().CloseShades();
        }
    }
}