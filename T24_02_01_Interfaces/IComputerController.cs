namespace T24_02_01_Interfaces
{
    public interface IComputerController : IDisposable
    {
        void Connect();
        void CurrentKeyPressed();
    }
}