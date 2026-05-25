using MIS.CoreBusiness;

namespace IMS.DataAccess.Interface
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string? name = null);
    }
}