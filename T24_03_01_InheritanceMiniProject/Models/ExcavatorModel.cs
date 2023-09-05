using T24_03_01_InheritanceMiniProject.Interfaces;

namespace T24_03_01_InheritanceMiniProject.Models
{
    public class ExcavatorModel : InventoryItemModel, IRenatable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The excavator has been returned.");
        }
    }
}