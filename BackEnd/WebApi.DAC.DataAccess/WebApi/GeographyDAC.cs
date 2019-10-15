using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.DAC;
using WebApi.Domain.Interfaces.Geography;

namespace WebApi.DAC.DataAccess.WebApi
{
    public class GeographyDAC : IGeographyDAC
    {
        private IUnitOfWork repo;
        public GeographyDAC(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public IEnumerable<City> GetStateCities(int stateId)
        {
            return repo.Cities.Get(c => c.State.StateId.Equals(stateId)).ToList();
        }

        public IEnumerable<State> GetCountryStates(int countryId)
        {
            return repo.States.Get(s => s.Country.CountryId.Equals(countryId)).ToList();
        }

        public IEnumerable<Country> GetCountries()
        {
            return repo.Countries.Get().ToList();
        }
    }
}
