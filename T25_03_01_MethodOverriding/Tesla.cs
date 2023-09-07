namespace T25_03_01_MethodOverriding
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destination.");
        }

        internal override void SetClock()
        {
            Console.WriteLine("It sets itself.");
        }
    }
}