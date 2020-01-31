using dotnet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Persistence.Contexts {
    public class AppDbContext : DbContext {
        private const string FYV = "Fruits and Vegetables";
        private const string DAIRY = "Dairy";
        private const string CATEGORIES = "Categories";
        private const string PRODUCTS = "Products";

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {   }

         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Category>().ToTable(CATEGORIES);
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = FYV }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = DAIRY }
            );

            builder.Entity<Product>().ToTable(PRODUCTS);
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();
        }
    }
}