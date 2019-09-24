using HBSApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers(int accountId);

        Customer UpdateCustomer(Customer customer );

        Customer AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
    }

    public class CustomerService :  ICustomerService
    {
        private readonly HBSContext hbsContext;

        public CustomerService(HBSContext hbsContext)
        {
            this.hbsContext = hbsContext;
        }

        public List<Customer> GetCustomers(int accountId)
        {
            return hbsContext.Customer.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var entity = hbsContext.Customer.Update(customer);
            hbsContext.SaveChanges();
            return entity.Entity;
        }

        public Customer AddCustomer(Customer customer)
        {
            var entity = hbsContext.Customer.Add(customer);
            hbsContext.SaveChanges();
            return entity.Entity;
        }

        public void DeleteCustomer(Customer customer)
        {
            hbsContext.Customer.Remove(customer);
            hbsContext.SaveChanges();
        }
    }
}
