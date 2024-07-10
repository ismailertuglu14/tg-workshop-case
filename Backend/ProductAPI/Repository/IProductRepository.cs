using ProductAPI.Entities;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<Product?> GetProductById(int id);
        Task<List<Product>?> GetProducts(string? name);
    }
}
