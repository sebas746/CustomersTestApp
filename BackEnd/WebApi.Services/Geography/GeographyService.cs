using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.Geography;

namespace WebApi.Services.Geography
{
    public class GeographyService : IGeographyService
    {
        private IGeographyDAC geographyDAC;
        public GeographyService(IGeographyDAC geographyDAC)
        {
            this.geographyDAC = geographyDAC;
        }

        public IEnumerable<City> GetStateCities(int stateId)
        {
            return geographyDAC.GetStateCities(stateId);
        }

        public IEnumerable<State> GetCountryStates(int countryId)
        {
            return geographyDAC.GetCountryStates(countryId);
        }

        public IEnumerable<Country> GetCountries()
        {
            return geographyDAC.GetCountries();
        }
    }
}
