using T24_03_01_InheritanceMiniProject.Interfaces;

namespace T24_03_01_InheritanceMiniProject.Models
{
    public class InventoryItemModel : IInventoryItem
    {
        public string? ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
}