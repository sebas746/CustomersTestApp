using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.DataContext.WebApi;
using WebApi.Domain.Interfaces.DAC;
using WebApi.Domain.Interfaces.Service;

namespace WebApi.Services.WebApi
{
    public class CustomerService : ICustomerService
    {
        private IUnitOfWork unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {   
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetCustomer()
        {
            try
            {
                return unitOfWork.Customers.Get();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Customer GetCustomer(int id)
        {
            try
            {
                return unitOfWork.Customers.Get(c => c.CustomerId.Equals(id)).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        
    }
}
