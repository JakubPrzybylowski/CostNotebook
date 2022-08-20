

using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public interface IRepositoryManager
    {
        ITransactionRepository Transaction { get; }
        IAccountRepository Account { get; }
        IUserRepository User { get; }
        void Save();
    }
}
