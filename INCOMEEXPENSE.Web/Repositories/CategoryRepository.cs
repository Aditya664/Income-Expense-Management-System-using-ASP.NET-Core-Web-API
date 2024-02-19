using INCOMEEXPENSE.Web.Contexts;
using INCOMEEXPENSE.Web.Interfaces;
using INCOMEEXPENSE.Web.Model;

namespace INCOMEEXPENSE.Web.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
