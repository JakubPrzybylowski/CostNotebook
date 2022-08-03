using costnotebook_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend
{
    public class DataSeeder
    {
        private readonly CostNotebookDbContext _dbContext;

        public DataSeeder(CostNotebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                //sprawadzamy czy dane są aktualne
                var pendingMigrations = _dbContext.Database.GetPendingMigrations();
                if (pendingMigrations != null && pendingMigrations.Any())
                {
                    _dbContext.Database.Migrate();
                }

                if (!_dbContext.Tests.Any())
                {
                    var tests = GetTests();
                    _dbContext.Tests.AddRange(tests);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Test> GetTests()
        {
            var tests = new List<Test>();
            var rd = new Random();
            int rand_num = rd.Next(100, 200);
            for (int i = 0; i < 10; i++)
            {
                tests.Add(new Test { Name = $"Test{rand_num}" });
            }

            return tests;
        }
    }
}
