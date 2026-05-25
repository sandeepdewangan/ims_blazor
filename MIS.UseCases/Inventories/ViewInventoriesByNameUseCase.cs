using MIS.CoreBusiness;
using MIS.UseCases.Inventories.Interface;
using MIS.UseCases.PluginInterfaces;

namespace MIS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        public IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }


        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }

    }
}
