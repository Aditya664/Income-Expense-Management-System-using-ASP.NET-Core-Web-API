using INCOMEEXPENSE.Web.Contexts;
using INCOMEEXPENSE.Web.Interfaces;
using INCOMEEXPENSE.Web.Model;

namespace INCOMEEXPENSE.Web.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
