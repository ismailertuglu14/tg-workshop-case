using CategoryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CategoryAPI.Connection
{
	public class CategoryDbContext : DbContext
	{
		public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
        {
		}

		public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                    new Category() { Id = 1, DisplayTitle = "Elektronik", Path = "elektronik"},
                    new Category() { Id = 2, DisplayTitle = "Giyim", Path = "giyim" },
                    new Category() { Id = 3, DisplayTitle = "Ev Eşyaları", Path = "ev-esyalari" }
                );
        }


    }
}

