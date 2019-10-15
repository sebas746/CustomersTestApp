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
        private IUnitOfWork repo;

        public CustomerService(IUnitOfWork unitOfWork)
        {   
            this.repo = unitOfWork;
        }

        public IEnumerable<Customer> GetCustomer()
        {
            try
            {
                return repo.Customers.Get();
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
                return repo.Customers.Get(c => c.CustomerId.Equals(id)).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int CreateCustomer(Customer customer)
        {
            try
            {
                customer.AvailableCredit = customer.CreditLimit;
                repo.Customers.Insert(customer);
                repo.Commit();
                return 1;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

    }
}
