namespace T25_03_01_MethodOverriding
{
    public class Corolla : Car
    {
        internal override void SetClock()
        {
            Console.WriteLine("Fiddle with the Corolla clock.");
        }
    }
}