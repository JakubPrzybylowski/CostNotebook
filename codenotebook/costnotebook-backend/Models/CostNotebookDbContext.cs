using costnotebook_backend.Models.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Models
{
    public class CostNotebookDbContext : DbContext
    {
        public CostNotebookDbContext(DbContextOptions<CostNotebookDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
