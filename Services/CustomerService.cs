using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBSApi.Services
{
    public interface ICustomerService
    {
        string /*Customer[] */ GetCustomers(string accountId);

        string /*Customer */ UpdateCustomer(string accountId /* Customer customer */);

        string /*Customer */ AddCustomer(string accountId /* Customer customer */);

        bool DeleteCustomer(string accountId, int customerId);
    }

    public class CustomerService :  ICustomerService
    {
        public CustomerService()
        {

        }

        public string /*Customer[] */ GetCustomers(string accountId)
        {
            return "";
        }

        public string /*Customer */ UpdateCustomer(string accountId /* Customer customer */)
        {
            return "";
        }

        public string /*Customer */ AddCustomer(string accountId /* Customer customer */)
        {
            return "";
        }

        public bool DeleteCustomer(string accountId, int customerId)
        {
            return true;
        }
    }
}
