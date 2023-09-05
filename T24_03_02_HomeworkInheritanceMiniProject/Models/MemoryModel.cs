
using T24_03_02_HomeworkInheritanceMiniProject.Interfaces;

namespace T24_03_02_HomeworkInheritanceMiniProject.Models
{
    internal class MemoryModel : InventoryItemModel, ISparePart, IInventoryItem
    {
        public string? MemoryType { get; set; }
        public int MemoryCapacity { get; set; }

        public void ReplacePart()
        {
            if (QuantityInStock > 0)
            {
                QuantityInStock--;
                Console.WriteLine($"Memory {MemoryType} with capacity of {MemoryCapacity}GB has been replaced.");
            }
            else
            {
                Console.WriteLine("There is not enough parts in inventory.");
            }
        }
    }
}
