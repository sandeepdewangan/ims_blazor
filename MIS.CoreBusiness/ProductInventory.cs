using System.Text.Json.Serialization;

namespace MIS.CoreBusiness
{
    // Many to many relationship between product and inventory.
    public class ProductInventory
    {
        public int ProductId { get; set; }
        public int InventoryId { get; set; }
        public int InventoryQuantity { get; set; }

        // Navigation property
        [JsonIgnore]
        public Product? Product { get; set; }
        [JsonIgnore]
        public Inventory? Inventory { get; set; }
    }
}
