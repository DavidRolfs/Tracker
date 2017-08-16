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
        public ApplicationDbContext() { }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
