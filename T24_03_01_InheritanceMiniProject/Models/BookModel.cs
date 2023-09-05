using T24_03_01_InheritanceMiniProject.Interfaces;

namespace T24_03_01_InheritanceMiniProject.Models
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased.");
        }
    }
}