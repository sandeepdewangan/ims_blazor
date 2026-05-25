using MIS.CoreBusiness;

namespace IMS.DataAccess.Interface
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string? name = null);
    }
}