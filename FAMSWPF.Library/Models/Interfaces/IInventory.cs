namespace FAMSWPF.Library.Models.Interfaces
{
    public interface IInventory
    {
        int ItemId { get; set; }
        string ItemCode { get; set; }
        string Description { get; set; }
        string Manufacturer { get; set; }
        decimal MinLevelUnits { get; set; }
        string QuantityUnit { get; set; }
        string Title { get; set; }
        decimal UnitSize { get; set; }
    }
}