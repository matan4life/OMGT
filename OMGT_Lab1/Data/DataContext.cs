using Microsoft.EntityFrameworkCore;
using OMGT_Lab1.Models;

namespace OMGT_Lab1.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Alternative> Alternatives { get; set; }
        public DbSet<Criterion> Criteria { get; set; }
        public DbSet<LPR> LPR { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Vector> Vectors { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OM_GT;Trusted_Connection=True;");
        }
    }
}
