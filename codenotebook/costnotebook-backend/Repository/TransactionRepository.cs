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
        public List<double> GetTransactionsByCatergory()
        {
            var transactions = RepositoryContext.Transactions.ToList();

            double[] countCategoryTransactions = new double[16];

            foreach(Transaction transaction in transactions)
            {
                var category = transaction.Category;

                switch (category)
                {
                    case CategoryTransaction.FoodAndHouseholdChemistry:
                        countCategoryTransactions[0] += 1;
                        break;
                    case CategoryTransaction.Crossings:
                        countCategoryTransactions[1] += 1;
                        break;
                    case CategoryTransaction.Influences:
                        countCategoryTransactions[2] += 1;
                        break;
                    case CategoryTransaction.AccessoriesAndEquipment:
                        countCategoryTransactions[3] += 1;
                        break;
                    case CategoryTransaction.EatingOut:
                        countCategoryTransactions[4] += 1;
                        break;
                    case CategoryTransaction.Uncategorized:
                        countCategoryTransactions[5] += 1;
                        break;
                    case CategoryTransaction.OutingsAndEvents:
                        countCategoryTransactions[6] += 1;
                        break;
                    case CategoryTransaction.Current:
                        countCategoryTransactions[7] += 1;
                        break;
                    case CategoryTransaction.GiftsAndSupport:
                        countCategoryTransactions[8] += 1;
                        break;
                    case CategoryTransaction.Renumeration:
                        countCategoryTransactions[9] += 1;
                        break;
                    case CategoryTransaction.RegularSaving:
                        countCategoryTransactions[10] += 1;
                        break;
                    case CategoryTransaction.Flue:
                        countCategoryTransactions[11] += 1;
                        break;
                    case CategoryTransaction.RenovationAndGarden:
                        countCategoryTransactions[12] += 1;
                        break;
                    case CategoryTransaction.MultimediaBooksAndPress:
                        countCategoryTransactions[13] += 1;
                        break;
                    case CategoryTransaction.ClothingAndFootwear:
                        countCategoryTransactions[14] += 1;
                        break;
                    case CategoryTransaction.TvInternetTelephone:
                        countCategoryTransactions[15] += 1;
                        break;
                } 
            }
            return countCategoryTransactions.ToList();
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
