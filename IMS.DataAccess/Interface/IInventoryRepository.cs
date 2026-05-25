using MIS.CoreBusiness;

namespace IMS.DataAccess.Interface
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task EditInventoryAsync(Inventory inventory);
        Task<Inventory> GetInventoryByIdAsync(int invId);

        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string? name = null);
    }
}