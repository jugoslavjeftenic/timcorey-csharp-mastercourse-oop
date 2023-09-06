namespace T25_02_02_HomeworkAbstractClasses
{
    public class Technician : ReplaceComputerPart
    {
        public override void ReplaceMemory()
        {
            Console.WriteLine("Momory is replaced.");
        }

        public override void ReplaceSSD()
        {
            Console.WriteLine("SSD is replaced.");
        }
    }
}