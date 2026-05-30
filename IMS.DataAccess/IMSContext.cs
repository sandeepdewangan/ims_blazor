using Microsoft.EntityFrameworkCore;
using MIS.CoreBusiness;

namespace IMS.DataAccess
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions<IMSContext> options) : base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Establish Relationship
            // Many to Many relationship
            modelBuilder.Entity<ProductInventory>().HasKey(pi => new { pi.ProductId, pi.InventoryId });
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductInventories)
                .HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductInventory>()
                .HasOne(pi => pi.Inventory)
                .WithMany(p => p.ProductInventories)
                .HasForeignKey(pi => pi.InventoryId);

            // Seeding data
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Bike", Quantity = 10, Price = 200 },
                new Product { ProductId = 2, ProductName = "Car", Quantity = 10, Price = 1500 },
                new Product { ProductId = 3, ProductName = "Bus", Quantity = 20, Price = 800 }
             );

            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 200 },
                new Inventory { InventoryId = 2, InventoryName = "Bike Body", Quantity = 10, Price = 1500 },
                new Inventory { InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 20, Price = 800 },
                new Inventory { InventoryId = 4, InventoryName = "Bike Pedels", Quantity = 20, Price = 100 }
             );

            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { ProductId = 1, InventoryId = 1, InventoryQuantity = 1 },
                new ProductInventory { ProductId = 1, InventoryId = 2, InventoryQuantity = 1 }
             );
        }
    }
}
