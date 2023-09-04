namespace T24_02_01_Interfaces
{
    public class BatteryPoweredGameController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}