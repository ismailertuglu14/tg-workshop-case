using ProductAPI.Entities;

namespace ProductAPI.Service
{
    public interface IProductService
    {
        Task<Product?> GetProductById(int id);
        Task<List<Product>?> GetProducts(string? category);
    }
}
