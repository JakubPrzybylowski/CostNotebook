using costnotebook_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly CostNotebookDbContext _context;

        public TransactionRepository(CostNotebookDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DbLoggerCategory.Database.Transaction> GetAllTransactions(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
