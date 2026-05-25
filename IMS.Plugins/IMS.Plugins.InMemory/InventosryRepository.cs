using MIS.CoreBusiness;
using MIS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventosryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventosryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory {InventoryId=1, InventoryName="Bike Seat", Quantity=10, Price=200},
                new Inventory {InventoryId=2, InventoryName="Bike Body", Quantity=10, Price=1500},
                new Inventory {InventoryId=3, InventoryName="Bike Wheels", Quantity=20, Price=800},
                new Inventory {InventoryId=4, InventoryName="Bike Pedels", Quantity=20, Price=100},
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
