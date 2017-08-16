using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SalesTracker;integrated security=True");
        }
        public ApplicationDbContext() { }
        public virtual DbSet<Associate> Associates { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
