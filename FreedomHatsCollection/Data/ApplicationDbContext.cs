using FreedomHatsCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace FreedomHatsCollection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Product> Products
        {
            get;
            set;
        }


    }
}
