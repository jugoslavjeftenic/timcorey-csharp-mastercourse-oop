
using T24_03_02_HomeworkInheritanceMiniProject.Interfaces;

namespace T24_03_02_HomeworkInheritanceMiniProject.Models
{
    internal class StorageDeviceModel : InventoryItemModel, ISparePart, IInventoryItem
    {
        public string? StorageType { get; set; }
        public int StorageCapacity { get; set; }

        public void ReplacePart()
        {
            if (QuantityInStock > 0)
            {
                QuantityInStock--;
                Console.WriteLine($"Storage device {StorageType} with capacity of {StorageCapacity}GB has been replaced.");
            }
            else
            {
                Console.WriteLine("There is not enough parts in inventory.");
            }
        }
    }
}
