using incomeexpense.Models;
using Microsoft.EntityFrameworkCore;

namespace incomeexpense.Contexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }
        public DbSet<Register> Users { get; set; }
    }
}
