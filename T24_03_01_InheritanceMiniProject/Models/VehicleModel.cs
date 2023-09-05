using T24_03_01_InheritanceMiniProject.Interfaces;

namespace T24_03_01_InheritanceMiniProject.Models
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRenatable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The vehicle has been returned.");
        }
    }
}