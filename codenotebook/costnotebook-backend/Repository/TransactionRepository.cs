using costnotebook_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace costnotebook_backend.Repository
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(CostNotebookDbContext context) : base(context)
        { }
    }
}
