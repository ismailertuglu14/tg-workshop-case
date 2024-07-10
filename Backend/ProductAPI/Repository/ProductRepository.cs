using CategoryAPI.Connection;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Product?> GetProductById(int id)
        {
            try
            {
                Product? product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                return product;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<List<Product>?> GetProducts(string? category)
        {
            List<Product> products;
            try
            {
                if (category == null) products = await _context.Products.AsQueryable().AsNoTracking().Skip(0).Take(10).ToListAsync();
                else products = await _context.Products.AsQueryable().AsNoTracking().Where(p => p.CategoryTitle == category).Skip(0).Take(10).ToListAsync();
                return products;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
