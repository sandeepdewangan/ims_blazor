using IMS.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using MIS.CoreBusiness;

namespace IMS.DataAccess
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbContextFactory<IMSContext> _context;
        public ProductRepository(IDbContextFactory<IMSContext> context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            using var db = _context.CreateDbContext();
            db.Products?.Add(product);
            await db.SaveChangesAsync();
        }

        public async Task DeleteProductByIdAsync(int prodId)
        {
            using var db = _context.CreateDbContext();
            var product = db.Products?.Find(prodId);
            if (product is null) return;
            db.Products?.Remove(product);
            await db.SaveChangesAsync();
        }

        public async Task EditProductAsync(Product product)
        {
            using var db = _context.CreateDbContext();
            var prod = await db.Products.FindAsync(product.ProductId);
            if (prod is not null)
            {
                prod.ProductName = product.ProductName;
                prod.Quantity = product.Quantity;
                prod.Price = product.Price;

                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            using var db = _context.CreateDbContext();

            return await db.Products.Where(i => i.ProductName.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int productId)
        {
            using var db = _context.CreateDbContext();
            var prod = await db.Products.FindAsync(productId);
            return prod;
        }
    }
}
