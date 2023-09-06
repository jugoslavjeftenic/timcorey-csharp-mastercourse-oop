namespace T25_02_02_HomeworkAbstractClasses
{
    // Create an Abstract Class that has an Interface applied to it.
    // When instantiating the child class, store it using the interface type.

    internal class Program
    {
        static void Main(string[] args)
        {
            Technician technician = new Technician();

            technician.ReplaceMemory();
            technician.ReplaceSSD();
        }
    }
}