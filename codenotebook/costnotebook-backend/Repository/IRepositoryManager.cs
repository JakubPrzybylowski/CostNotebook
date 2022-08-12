

using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public interface IRepositoryManager
    {
        IRepositoryBase<Transaction> Transaction { get; }
        void Save();
    }
}
