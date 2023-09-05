
using T24_03_02_HomeworkInheritanceMiniProject.Interfaces;

namespace T24_03_02_HomeworkInheritanceMiniProject.Models
{
    internal class MonitorModel : InventoryItemModel, ILoanPart, IInventoryItem
    {
        public string? MonitorBrand { get; set; }
        public float MonitorDiagonal { get; set; }

        public void LoanPart()
        {
            if (QuantityInStock > 0)
            {
                QuantityInStock--;
                Console.WriteLine($"Loaner {MonitorBrand} monitor has been provided.");
            }
            else
            {
                Console.WriteLine("There is not enough parts in inventory.");
            }
        }

        public void ReturnPart()
        {
            QuantityInStock++;
            Console.WriteLine($"Loaner {MonitorBrand} monitor has been returned.");
        }
    }
}
