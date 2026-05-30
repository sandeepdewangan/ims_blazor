namespace IMS.DataAccess.Interface
{
    public interface IInventoryReportRepository
    {
        Task<List<InventoriesModel>> Filter(string? inventoryName = null, DateTime? fromDate = null, DateTime? toDate = null, string? orderId = null);
    }
}