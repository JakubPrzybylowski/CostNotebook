using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(CostNotebookDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
