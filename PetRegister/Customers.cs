using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    class Customers
    {
        List<Customer> ourCustomers = new List<Customer>();

        public List<Customer> GetAllCustomers()
        {
            ourCustomers = CustomerDA.GetAllCustomers();

            return ourCustomers;

        }
        public int AddCustomer(Customer aCust)
        {
            int numRows;
            numRows = CustomerDA.AddCustomer(aCust);

            return numRows;
        }

    }
}
