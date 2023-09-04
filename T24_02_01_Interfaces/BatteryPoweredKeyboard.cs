namespace T24_02_01_Interfaces
{
    public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}