using Microsoft.EntityFrameworkCore;
using task.Model;

namespace task.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions):base(dbContextOptions) { }

        public DbSet<InvoiceDetails> invoiceDetails { get; set; }
        public DbSet<Unit> units { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }

    }
}
