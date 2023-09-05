
using T24_03_02_HomeworkInheritanceMiniProject.Interfaces;

namespace T24_03_02_HomeworkInheritanceMiniProject.Models
{
    internal class LaptopModel : InventoryItemModel, ILoanPart, IInventoryItem
    {
        public string? LaptopBrand { get; set; }
        public string? LaptopProcesor { get; set; }
        public int MemoryCapacity { get; set; }

        public void LoanPart()
        {
            if (QuantityInStock > 0)
            {
                QuantityInStock--;
                Console.WriteLine($"Loaner {LaptopBrand} laptop has been provided.");
            }
            else
            {
                Console.WriteLine("There is not enough parts in inventory.");
            }
        }

        public void ReturnPart()
        {
            QuantityInStock++;
            Console.WriteLine($"Loaner {LaptopBrand} laptop has been returned.");
        }
    }
}
