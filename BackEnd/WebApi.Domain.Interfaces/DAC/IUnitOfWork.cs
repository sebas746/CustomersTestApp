namespace WebApi.Domain.Interfaces.DAC
{   
    using WebApi.Domain.DataContext.WebApi;
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        void Commit();
    }
}
