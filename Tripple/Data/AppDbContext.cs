using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tripple.Models;

namespace Tripple.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string connectionString) : base(connectionString)
        {

        }
        public IDbSet<DeliveryMan> DeliveryMan { get; set; }
        public IDbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeliveryMan>().ToTable("DeliveryMan");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
