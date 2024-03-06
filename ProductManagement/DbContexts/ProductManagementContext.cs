using ProductManagement.Entity;
using Microsoft.EntityFrameworkCore;


namespace ProductManagement.DbContexts

{
    public class ProductManagementContext : DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Soğan Kuru Dökme Kg", Price = 9.90, IsDeleted = false, FileId = 1 },
                new Product { Id = 2, Name = "Hatay Arsuz Limonu Kg", Price = 17.95, IsDeleted = false, FileId = 2 },
                new Product { Id = 3, Name = "Muz Yerli Kg", Price = 51.90, IsDeleted = false, FileId = 3 },
                new Product { Id = 4, Name = "Portakal Sıkma File Kg", Price = 16.90, IsDeleted = false, FileId = 4 },
                new Product { Id = 5, Name = "Maydonoz Adet", Price = 15.95, IsDeleted = false, FileId = 5 },
                new Product { Id = 6, Name = "Hıyar Badem Paket Kg", Price = 44.95, IsDeleted = false, FileId = 6 },
                new Product { Id = 7, Name = "Mandalina Murcot", Price = 39.95, IsDeleted = false, FileId = 7 },
                new Product { Id = 8, Name = "Domates Kokteyl Kg", Price = 69.95, IsDeleted = false, FileId = 8 },
                new Product { Id = 9, Name = "Elma Starking Kg", Price = 34.90, IsDeleted = false, FileId = 9 },
                new Product { Id = 10, Name = "Kabak Sakız Kg", Price = 34.95, IsDeleted = false, FileId = 10 },
                new Product { Id = 11, Name = "Domates Salkım Kg", Price = 49.95, IsDeleted = false, FileId = 11 }
             );
        }
    }
}
