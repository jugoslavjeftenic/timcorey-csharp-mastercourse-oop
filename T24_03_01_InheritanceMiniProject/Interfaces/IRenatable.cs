namespace T24_03_01_InheritanceMiniProject.Interfaces
{
    public interface IRenatable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}