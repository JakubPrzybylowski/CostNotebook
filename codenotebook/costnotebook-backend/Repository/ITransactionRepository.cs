
using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public interface ITransactionRepository : IRepositoryBase<Transaction>
    {
        List<double> GetTotalPositiveAmountTransactionsForMonths();
        List<double> GetTotalNegativeAmountTransactionsForMonths();
    }
}
