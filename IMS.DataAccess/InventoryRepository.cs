using IMS.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using MIS.CoreBusiness;

namespace IMS.DataAccess
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IDbContextFactory<IMSContext> _context;
        public InventoryRepository(IDbContextFactory<IMSContext> context)
        {
            _context = context;
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            // We are not using Scoped/Transient in Program.cs, we will destroy dbcontext instance based on ou need.
            using var db = _context.CreateDbContext();
            db.Inventories?.Add(inventory);
            await db.SaveChangesAsync();
        }

        public async Task DeleteInventoryByIdAsync(int invId)
        {
            using var db = _context.CreateDbContext();
            var inventory = db.Inventories?.Find(invId);
            if (inventory is null) return;
            db.Inventories?.Remove(inventory);
            await db.SaveChangesAsync();
        }

        public async Task EditInventoryAsync(Inventory inventory)
        {
            using var db = _context.CreateDbContext();
            var inv = await db.Inventories.FindAsync(inventory.InventoryId);
            if (inv is not null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Quantity = inventory.Quantity;
                inv.Price = inventory.Price;

                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            using var db = _context.CreateDbContext();

            return await db.Inventories.Where(i => i.InventoryName.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();

        }

        public async Task<Inventory?> GetInventoryByIdAsync(int invId)
        {
            using var db = _context.CreateDbContext();
            var inv = await db.Inventories.FindAsync(invId);
            return inv;
        }
    }
}
