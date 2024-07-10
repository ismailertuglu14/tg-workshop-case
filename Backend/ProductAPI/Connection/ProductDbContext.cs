using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace CategoryAPI.Connection
{
    public class ProductDbContext : DbContext
	{
		public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, 
                        Title = "Iphone 14 Pro Max", Price= 40.000m, 
                        CategoryId = 1, CategoryTitle = "Elektronik",
                        CoverPath= "https://cdn.akakce.com/z/apple/iphone-14-pro-max.jpg",
                        StarRate =4,Status = ProductAPI.Models.ProductStatus.ACTIVE
                    },

         
                     new Product()
                     {
                         Id = 2,
                         Title = "Galaxy M32",
                         Price = 32.000m,
                         CategoryId = 1,
                         CategoryTitle = "Elektronik",
                         CoverPath = "https://cdn.akakce.com/z/samsung/samsung-galaxy-m32.jpg",
                         StarRate = 4,
                            
                         Status = ProductAPI.Models.ProductStatus.ACTIVE
                     },
                      new Product()
                      {
                           Id = 3,
                           Title = "Xspedd X-evo Erkek\nYazlık Motosiklet Mont Siyah",
                           Price = 4.500m,
                           CategoryId = 2,
                           CategoryTitle = "Giyim",
                           CoverPath = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg",
                           StarRate = 4,
                           Status = ProductAPI.Models.ProductStatus.ACTIVE
                      }

                );

            modelBuilder.Entity<Images>().HasData(
                    new Images() { Id = 1, Path = "https://cdn.akakce.com/z/apple/iphone-14-pro-max.jpg", ProductId = 1, Order = 1 },
                    new Images() { Id = 2, Path = "https://cdn.akakce.com/z/apple/iphone-14-pro-max-256-gb-altin.jpg", ProductId = 1, Order = 2 },
                    new Images() { Id = 3, Path = "https://cdn.akakce.com/z/samsung/samsung-galaxy-m32.jpg", ProductId = 2, Order = 1 },
                    new Images() { Id = 4, Path = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg", ProductId = 3, Order = 1 },
                    new Images() { Id = 5, Path = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/e3bfef4e-7126-3e1d-8977-8106adbd1879/1_org_zoom.jpg", ProductId = 3, Order = 2 }
             );
        }


    }
}

