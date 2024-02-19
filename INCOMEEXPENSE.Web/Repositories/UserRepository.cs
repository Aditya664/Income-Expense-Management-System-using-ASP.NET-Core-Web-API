using INCOMEEXPENSE.Web.Contexts;
using INCOMEEXPENSE.Web.Interfaces;
using INCOMEEXPENSE.Web.Model;

namespace INCOMEEXPENSE.Web.Repositories
{
    public class UserRepository : RepositoryBase<Register>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
