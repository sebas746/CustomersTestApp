using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.DAC;

namespace WebApi.DAC.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private WebApiDataContext _dbContext;
        private BaseRepository<Customer> _customers;
        private BaseRepository<City> _cities;
        private BaseRepository<State> _states;
        private BaseRepository<Country> _countries;
        private BaseRepository<Visit> _visits;

        public UnitOfWork(WebApiDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Customer> Customers
        {
            get
            {
                return _customers ??
                    (_customers = new BaseRepository<Customer>(_dbContext));
            }
        }

        public IRepository<City> Cities
        {
            get
            {
                return _cities ??
                    (_cities = new BaseRepository<City>(_dbContext));
            }
        }

        public IRepository<State> States
        {
            get
            {
                return _states ??
                    (_states = new BaseRepository<State>(_dbContext));
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                return _countries ??
                    (_countries = new BaseRepository<Country>(_dbContext));
            }
        }

        public IRepository<Visit> Visits
        {
            get
            {
                return _visits ??
                    (_visits = new BaseRepository<Visit>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
