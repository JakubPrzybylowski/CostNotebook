using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly CostNotebookDbContext _context;
        private IRepositoryBase<Transaction>? _transactionRepository;

        public RepositoryManager(CostNotebookDbContext context)
        {
            _context = context;
        }

        IRepositoryBase<Transaction> IRepositoryManager.Transaction
        {
            get
            {
                if (_transactionRepository == null)
                    _transactionRepository = new RepositoryBase<Transaction>(_context);

                return _transactionRepository;
            }
        }
        public void Save() => _context.SaveChanges();
    }
}

