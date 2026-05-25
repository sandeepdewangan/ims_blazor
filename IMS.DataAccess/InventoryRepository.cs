using IMS.DataAccess.Interface;
using MIS.CoreBusiness;

namespace IMS.DataAccess
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory {InventoryId=1, InventoryName="Bike Seat", Quantity=10, Price=200},
                new Inventory {InventoryId=2, InventoryName="Bike Body", Quantity=10, Price=1500},
                new Inventory {InventoryId=3, InventoryName="Bike Wheels", Quantity=20, Price=800},
                new Inventory {InventoryId=4, InventoryName="Bike Pedels", Quantity=20, Price=100},
            };
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            var maxId = _inventories.Max(x => x.InventoryId);
            inventory.InventoryId = maxId + 1;
            _inventories.Add(inventory);

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string? name = null)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
