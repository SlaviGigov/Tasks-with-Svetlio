

namespace GameOfPocketsMVC.DataAccess
{
    using GameOfPocketsMVC.DataInvestors;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Investor>()
                .HasNoKey()
                .ToView("InvestorViewModel");
        }
        public DbSet<Investor> Investors { get; set; }

    }
}
