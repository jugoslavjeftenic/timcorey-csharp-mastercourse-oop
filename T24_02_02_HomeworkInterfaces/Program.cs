namespace T24_02_02_HomeworkInterfaces
{
    // Create an IRun interface and apply it ti a Person class and an Animal class.
    // Store both types in a List<IRun> object.

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runners = new List<IRun>();

            runners.Add(new Person());
            runners.Add(new Animal());

            foreach (var runner in runners)
            {
                runner.Run();

                if (runner is Person person)
                {
                    person.Walk();
                }
            }
        }
    }
}