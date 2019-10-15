namespace WebApi.Domain.Interfaces.DAC
{   
    using WebApi.Domain.DataContext.WebApi;
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        IRepository<City> Cities { get; }
        IRepository<State> States { get; }
        IRepository<Country> Countries { get; }       
        void Commit();
    }
}
