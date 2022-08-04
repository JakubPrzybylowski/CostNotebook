using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Models.Seeders;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        //Department
        modelBuilder.Entity<Test>()
            .HasData(
               new Test { Id = 1, Name = "HR" },
               new Test { Id = 2, Name = "Admin" },
               new Test { Id = 3, Name = "Development" },
               new Test { Id = 4, Name = "Test" }
        );
    }
}
