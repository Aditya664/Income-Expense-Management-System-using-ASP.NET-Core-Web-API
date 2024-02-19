namespace INCOMEEXPENSE.Web.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
