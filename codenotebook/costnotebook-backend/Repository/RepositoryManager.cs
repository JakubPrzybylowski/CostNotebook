using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly CostNotebookDbContext _context;
        private ITransactionRepository _transactionRepository;
        private IAccountRepository _accountRepository;
        private IUserRepository _userRepository;

        public RepositoryManager(CostNotebookDbContext context)
        {
            _context = context;
        }

        public ITransactionRepository Transaction
        {
            get
            {
                if (_transactionRepository == null)
                    _transactionRepository = new TransactionRepository(_context);

                return _transactionRepository;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new AccountRepository(_context);

                return _accountRepository;
            }
        }
        public IUserRepository User 
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);

                return _userRepository;
            }
}
public void Save() => _context.SaveChanges();
    }
}

