using System.ComponentModel.DataAnnotations;

namespace MIS.CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal than 0.")]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Price must be greater or equal than 0.")]
        public double Price { get; set; }

        // Many to Many
        public List<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();

        // Helper function to add product inventories
        public void AddInventory(Inventory inventory)
        {
            if (!this.ProductInventories.Any(x => x.Inventory is not null && x.Inventory.InventoryName.Equals(inventory.InventoryName)))
            {
                this.ProductInventories.Add(
                        new ProductInventory
                        {
                            InventoryId = inventory.InventoryId,
                            ProductId = this.ProductId,
                            Inventory = inventory,
                            Product = this,
                        }
                    );
            }
        }

        public void RemoveInventory(ProductInventory prodInv)
        {
            this.ProductInventories.Remove(prodInv);
        }
    }
}
