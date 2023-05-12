using LotusShop.Domain.Entities;
using System.Data.Entity;

namespace LotusShop.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
