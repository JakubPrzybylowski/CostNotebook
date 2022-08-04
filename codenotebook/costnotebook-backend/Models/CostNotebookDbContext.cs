using costnotebook_backend.Models.Seeders;
using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Models
{
    public class CostNotebookDbContext : DbContext
    {
        public CostNotebookDbContext(DbContextOptions<CostNotebookDbContext> options) : base(options)
        {

        }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
