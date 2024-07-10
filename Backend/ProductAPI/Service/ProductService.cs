using ProductAPI.Entities;
using ProductAPI.Repository;

namespace ProductAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task<List<Product>?> GetProducts(string? category)
        {

            return await _productRepository.GetProducts(category);
        }
    }
}
