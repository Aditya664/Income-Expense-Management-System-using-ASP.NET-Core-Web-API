using INCOMEEXPENSE.Web.Model;
using Microsoft.EntityFrameworkCore;

namespace INCOMEEXPENSE.Web.Contexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<Register> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
