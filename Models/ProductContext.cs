using System.Data.Entity;

namespace e_business_movies.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Movies")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}