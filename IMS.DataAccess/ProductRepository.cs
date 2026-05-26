using IMS.DataAccess.Interface;
using MIS.CoreBusiness;

namespace IMS.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product {ProductId=1, ProductName="Bike", Quantity=10, Price=200},
                new Product {ProductId=2, ProductName="Car", Quantity=10, Price=1500},
                new Product {ProductId=3, ProductName="Bus", Quantity=20, Price=800}
            };
        }

        public Task AddProductAsync(Product product)
        {
            if (_products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            var maxId = _products.Max(x => x.ProductId);
            product.ProductId = maxId + 1;
            _products.Add(product);

            return Task.CompletedTask;
        }

        public Task DeleteProductByIdAsync(int invId)
        {
            var inv = _products.FirstOrDefault(i => i.ProductId == invId);
            if (inv is not null)
            {
                _products.Remove(inv);
            }
            return Task.CompletedTask;
        }

        public Task EditProductAsync(Product product)
        {
            if (_products.Any(x => x.ProductId != product.ProductId && x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase))) return Task.CompletedTask;
            var invToUpdate = _products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (invToUpdate is not null)
            {
                invToUpdate.ProductName = product.ProductName;
                invToUpdate.Quantity = product.Quantity;
                invToUpdate.Price = product.Price;
            }
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string? name = null)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_products);

            return _products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Product?> GetProductByIdAsync(int invId)
        {
            return await Task.FromResult(_products.FirstOrDefault(x => x.ProductId == invId));
        }
    }
}
