using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    { 
        public TransactionRepository(CostNotebookDbContext context) : base(context)
        {
        }

        public List<double> GetTotalPositiveAmountTransactionsForMonths()
        {
            var positiveTransactions = RepositoryContext.Transactions.Where(x => x.Amount > 0).ToList();
            return GetTotalAmountTransactionsForMonths(positiveTransactions).ToList();
        }

        public List<double> GetTotalNegativeAmountTransactionsForMonths()
        {
            var negativeTransactions = RepositoryContext.Transactions.Where(x => x.Amount < 0).ToList();
            return GetTotalAmountTransactionsForMonths(negativeTransactions).Select(x => x * -1).ToList();
        }
        private static  List<double> GetTotalAmountTransactionsForMonths(List<Transaction> transactions)
        {
            double[] amountTransactions = new double[12];

            foreach (Transaction transaction in transactions)
            {
                var month = transaction.Date.Month;

                switch (month)
                {
                    case 1:
                        amountTransactions[0] += transaction.Amount;
                        break;
                    case 2:
                        amountTransactions[1] += transaction.Amount;
                        break;
                    case 3:
                        amountTransactions[2] += transaction.Amount;
                        break;
                    case 4:
                        amountTransactions[3] += transaction.Amount;
                        break;
                    case 5:
                        amountTransactions[4] += transaction.Amount;
                        break;
                    case 6:
                        amountTransactions[5] += transaction.Amount;
                        break;
                    case 7:
                        amountTransactions[6] += transaction.Amount;
                        break;
                    case 8:
                        amountTransactions[7] += transaction.Amount;
                        break;
                    case 9:
                        amountTransactions[8] += transaction.Amount;
                        break;
                    case 10:
                        amountTransactions[9] += transaction.Amount;
                        break;
                    case 11:
                        amountTransactions[10] += transaction.Amount;
                        break;
                    case 12:
                        amountTransactions[11] += transaction.Amount;
                        break;
                }
            }
            return amountTransactions.ToList();
        }
    }
}
