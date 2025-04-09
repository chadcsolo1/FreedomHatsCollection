using FreedomHatsCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace FreedomHatsCollection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Order> Orders => Set<Order>();

        public DbSet<OrderDetails> OrderDetails => Set<OrderDetails>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();


    }
}
