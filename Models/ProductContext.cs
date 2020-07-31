using System.Data.Entity;

namespace ProductsProject.Models
{
    public class ProductContext : DbContext
    {
        public  DbSet<Products> Products { get; set; }
    }
}