using incomeexpense.Contexts;
using incomeexpense.Interfaces;
using incomeexpense.Models;

namespace incomeexpense.Repositories
{
    public class UserRepository : RepositoryBase<Register>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
