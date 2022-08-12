using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace costnotebook_backend.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions(bool trackChanges);
    }
}
