using MIS.CoreBusiness;

namespace IMS.DataAccess.Interface
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
        Task EditProductAsync(Product product);
        Task<Product?> GetProductByIdAsync(int invId);

        Task DeleteProductByIdAsync(int invId);

        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    }
}