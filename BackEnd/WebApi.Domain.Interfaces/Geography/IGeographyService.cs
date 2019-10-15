using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.DataContext.WebApi;

namespace WebApi.Domain.Interfaces.Geography
{
    public interface IGeographyService
    {
        IEnumerable<City> GetStateCities(int stateId);
        IEnumerable<State> GetCountryStates(int countryId);
        IEnumerable<Country> GetCountries();
    }
}
