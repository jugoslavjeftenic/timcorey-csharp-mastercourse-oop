namespace T24_02_01_Interfaces
{
    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string? ConnectionType { get; set; }
    }
}