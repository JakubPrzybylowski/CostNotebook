using costnotebook_backend.Models;

namespace costnotebook_backend.Repository
{
    public interface IAccountRepository : IRepositoryBase<User>
    {
        public string GetJwt(User user);
    }
}
