using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    public class CustomerDA
    {
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> ourCustomers = new List<Customer>();

            ourCustomers.Add(new Customer("Bob", "Smith", "me@you.com", "402-111-1111", Convert.ToDateTime("11/11/11"), "8800 O Street"));
            ourCustomers.Add(new Customer("Fred", "Flintstone", "fred@you.com", "402-222-1111", Convert.ToDateTime("12/5/21"), "12 Bedrock Street"));
            ourCustomers.Add(new Customer("Barney", "Rubble", "Barney@you.com", "402-333-1111", Convert.ToDateTime("2/29/12"), "14 Bedrock Street"));
            ourCustomers.Add(new Customer("George", "Jetson", "George@you.com", "402-444-1111", Convert.ToDateTime("11/11/11"), "231 Skyway Drive"));


            return ourCustomers;
        }
    }
}
