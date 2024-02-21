namespace INCOMEEXPENSE.Web.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ICategoryRepository Category { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
