using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.Service;

namespace WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        private ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return customerService.GetCustomer();
        }

        // GET api/values/5
        [HttpGet]
        public Customer GetCustomers(int id)
        {
            return customerService.GetCustomer(id);
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]Customer customer)
        {
            var result = customerService.CreateCustomer(customer);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
