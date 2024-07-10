using ProductAPI.Repository;
using ProductAPI.Service;

namespace ProductAPI.Helpers
{
    /// <summary>
    /// This static class contains extension methods for registering services in the di container.
    /// </summary>
    public static class ServiceRegistrations
    {
        public static void AddServiceRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
