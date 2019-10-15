using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.DataContext.WebApi;

namespace WebApi.Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomer();
    }
}
