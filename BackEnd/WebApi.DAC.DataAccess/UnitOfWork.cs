namespace WebApi.DAC.DataAccess
{
    using WebApi.Domain.DataContext.WebApi;
    using WebApi.Domain.Interfaces.DAC;

    public class UnitOfWork : IUnitOfWork
    {
        private WebApiDataContext _dbContext;
        private BaseRepository<Customers> _customers;

        public UnitOfWork(WebApiDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Customers> Customers
        {
            get
            {
                return _customers ??
                    (_customers = new BaseRepository<Customers>(_dbContext));
            }
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
