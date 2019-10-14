namespace WebApi.Domain.Interfaces.DAC
{   
    using WebApi.Domain.DataContext.WebApi;
    public interface IUnitOfWork
    {
        IRepository<Customers> Customers { get; }
        void Commit();
    }
}
