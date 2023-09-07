namespace T25_03_01_MethodOverriding
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start.");
        }

        internal abstract void SetClock();
    }
}