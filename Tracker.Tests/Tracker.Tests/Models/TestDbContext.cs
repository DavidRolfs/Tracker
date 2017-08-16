using Microsoft.EntityFrameworkCore;
using Tracker.Models;

namespace Tracker.Test.Models
{
    public class TestDbContext : ApplicationDbContext
    {
        public override DbSet<Associate> Associates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SalesTrackerTest;integrated security = True");
        }
    }
}
