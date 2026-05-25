using MIS.CoreBusiness;

namespace MIS.UseCases.Inventories.Interface
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}