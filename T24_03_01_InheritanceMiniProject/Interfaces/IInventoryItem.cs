namespace T24_03_01_InheritanceMiniProject.Interfaces
{
    public interface IInventoryItem
    {
        public string? ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
}