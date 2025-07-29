using BusinessLogic.Models;
using DataAccessLayer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("MasterSchema"); // 👈 Add this if your DB uses it
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());

            // --- Category Seed ---
            var categories = new List<Category>();
            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category
                {
                    id = i,
                    catName = $"Category {i}",
                    catOrder = i,
                    markedAsDeleted = false
                });
            }
            modelBuilder.Entity<Category>().HasData(categories);

            // --- Product Seed ---
            var products = new List<Product>();
            int productId = 1;

            for (int catId = 1; catId <= 10; catId++)
            {
                for (int i = 1; i <= 3; i++)
                {
                    products.Add(new Product
                    {
                        id = productId,
                        title = $"Product {productId}",
                        author = $"Author {productId}",
                        price = 10.5 * i + catId,
                        categoryId = catId,
                        description = null, // ✅ Add this if column exists
                        markedAsDeleted = false
                    });
                    productId++;
                }
            }
            modelBuilder.Entity<Product>().HasData(products);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
