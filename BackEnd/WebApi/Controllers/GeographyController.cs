using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.Geography;

namespace WebApi.Controllers
{
    public class GeographyController : ApiController
    {
        private IGeographyService geographyService;

        public GeographyController(IGeographyService geographyService)
        {
            this.geographyService = geographyService;
        }

        [HttpGet]
        [Route("api/Geography/GetStateCities/")]
        public IEnumerable<City> GetStateCities(int stateId)
        {
            return geographyService.GetStateCities(stateId);
        }

        [HttpGet]
        [Route("api/Geography/GetCountryStates/")]
        public IEnumerable<State> GetCountryStates(int countryId)
        {
            return geographyService.GetCountryStates(countryId);
        }

        [HttpGet]
        [Route("api/Geography/GetCountries/")]
        public IEnumerable<Country> GetCountries()
        {
            return geographyService.GetCountries();
        }
    }
}
