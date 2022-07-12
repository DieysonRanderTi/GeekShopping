using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Camiseta Branca",
                Price = 28.99M,
                Description = "Camiseta Dragon Ball Z Masculina 100% Algodão.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "Camisetas"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta Preta",
                Price = 38.99M,
                Description = "Camiseta Occupy Mars Feminina 100% Algodão.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg",
                CategoryName = "Camisetas"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta Preta",
                Price = 38.99M,
                Description = "Camiseta No Internet Masculina 100% Algodão.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg",
                CategoryName = "Camisetas"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "capacete Dart Vader",
                Price = 238.99M,
                Description = "Capacete Dart Vader Produto Original e Licenciado.",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg",
                CategoryName = "Acessórios Nerd"
            });
        }
    }
}
